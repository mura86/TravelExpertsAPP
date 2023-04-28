using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO.Packaging;
using System.Text.RegularExpressions;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmPackages : Form
    {
        private int _packageId;

        private bool _isReadOnly;
        private bool _isAddMode;
        private bool _isModifyMode;
        bool packageModified;

        private bool _isOkButtonClicked = false;

        private readonly frmMain _mainForm;



        private List<(int ProductId, int SupplierId)> _tempAddedItems = new List<(int ProductId, int SupplierId)>();

        public frmPackages(int packageId, bool isReadOnly, bool isAddMode, bool isModifyMode, frmMain mainForm)
        {
            InitializeComponent();
            _packageId = packageId;
            _isReadOnly = isReadOnly;
            _isAddMode = isAddMode;
            _isModifyMode = isModifyMode;
            _mainForm = mainForm;

            // Handle the FormClosing event
            this.FormClosing += FrmPackages_FormClosing;
        }


        private void frmPackages_Load(object sender, EventArgs e)
        {
            frmModeAddModifyReadonly();
        }


        private void UpdateTreeView(int packageId)
        {
            treeViewPackages.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Products and Suppliers");

            using (var context = new TravelExpertsContext())
            {
                var packageProductSuppliers = context.PackagesProductsSuppliers.Where(pps => pps.PackageId == packageId).ToList();

                // Add the items from the _tempAddedItems list to the tree view
                foreach (var item in _tempAddedItems)
                {
                    var product = context.Products.FirstOrDefault(p => p.ProductId == item.ProductId);
                    var supplier = context.Suppliers.FirstOrDefault(s => s.SupplierId == item.SupplierId);

                    if (product != null && supplier != null)
                    {
                        // Check if the product node already exists
                        TreeNode productNode = rootNode.Nodes.Cast<TreeNode>().FirstOrDefault(node => node.Text.StartsWith($"(ID: {product.ProductId}) {product.ProdName}"));

                        // If the product node doesn't exist, create a new one
                        if (productNode == null)
                        {
                            productNode = new TreeNode($"(ID: {product.ProductId}) {product.ProdName} (Qty: 1)");
                            rootNode.Nodes.Add(productNode);
                        }
                        else
                        {
                            // Update the quantity in the product node's text
                            int currentQty = int.Parse(Regex.Match(productNode.Text, @"\(Qty:\s+(\d+)\)").Groups[1].Value);
                            productNode.Text = $"(ID: {product.ProductId}) {product.ProdName} (Qty: {currentQty + 1})";
                        }

                        // Add the supplier node under the product node
                        productNode.Nodes.Add($"(ID: {supplier.SupplierId}) {supplier.SupName}");
                    }
                }
            }

            treeViewPackages.Nodes.Add(rootNode);
            rootNode.Expand();
        }

        private void LoadPackageDetails()
        {
            using (var context = new TravelExpertsContext())
            {
                // Get the package details
                var package = context.Packages.SingleOrDefault(p => p.PackageId == _packageId);
                if (package != null)
                {

                    txtPackageID.Text = package.PackageId.ToString();
                    txtPackageName.Text = package.PkgName;
                    txtPackageStartDate.Text = package.PkgStartDate?.ToShortDateString();
                    txtPackageEndDate.Text = package.PkgEndDate?.ToShortDateString();
                    txtPackageDescription.Text = package.PkgDesc;
                    txtBasePrice.Text = package.PkgBasePrice.ToString();
                    txtAgencyComission.Text = package.PkgAgencyCommission.ToString();
                }

                // Load existing products and suppliers into the temp list
                var existingProductSuppliers = (from pps in context.PackagesProductsSuppliers
                                                join ps in context.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                                                where pps.PackageId == _packageId
                                                select new { ps.ProductId, ps.SupplierId }).ToList();

                _tempAddedItems = existingProductSuppliers.Select(x => ((int)x.ProductId, (int)x.SupplierId)).ToList();
            }
            UpdateProductSupplierControls();
        }


        private void frmModeAddModifyReadonly()
        {
            if (_isReadOnly)
            {
                //sets lbl to show ID to be autogenerated when added
                lblAutoGenerate.Visible = false;


                txtPackageName.Enabled = false;
                txtPackageStartDate.Enabled = false;
                txtPackageEndDate.Enabled = false;
                txtPackageDescription.Enabled = false;
                txtBasePrice.Enabled = false;
                txtAgencyComission.Enabled = false;

                cboPackageProduct.Enabled = false;
                cboPackageSupplier.Enabled = false;

                rdoAddPackage.Enabled = false;
                rdoRemovePackage.Enabled = false;
                lblAddOrRemovePackage.Enabled = false;
                lblProduct.Enabled = false;
                lblSupplier.Enabled = false;

                btnAdd.Visible = false;
                btnPackageDone.Visible = false;

                btnRemovePackage.Enabled = true;
                btnModifyPackage.Enabled = true;

                _isModifyMode = false;
                _isAddMode = false;


                RefreshAllFields();
            }
            else if (_isAddMode)
            {
                //sets lbl to show ID to be autogenerated when added
                lblAutoGenerate.Visible = true;

                // Enable other input fields as needed
                txtPackageName.Enabled = true;
                txtPackageStartDate.Enabled = true;
                txtPackageEndDate.Enabled = true;
                txtPackageDescription.Enabled = true;
                txtBasePrice.Enabled = true;
                txtAgencyComission.Enabled = true;
                cboPackageProduct.Enabled = true;
                cboPackageSupplier.Enabled = true;
                rdoAddPackage.Enabled = true;
                rdoRemovePackage.Enabled = true;
                lblAddOrRemovePackage.Enabled = true;
                lblProduct.Enabled = true;
                lblSupplier.Enabled = true;

                btnAdd.Visible = true;
                btnPackageDone.Visible = true;


                btnRemovePackage.Enabled = false;
                btnModifyPackage.Enabled = false;

                _isReadOnly = false;
                _isModifyMode = false;

                RefreshAllFields();
            }
            else if (_isModifyMode)
            {
                //sets lbl to show ID to be autogenerated when added
                lblAutoGenerate.Visible = false;


                txtPackageName.Enabled = true;
                txtPackageStartDate.Enabled = true;
                txtPackageEndDate.Enabled = true;
                txtPackageDescription.Enabled = true;
                txtBasePrice.Enabled = true;
                txtAgencyComission.Enabled = true;
                cboPackageProduct.Enabled = true;
                cboPackageSupplier.Enabled = true;
                rdoAddPackage.Enabled = true;
                rdoRemovePackage.Enabled = true;
                lblAddOrRemovePackage.Enabled = true;
                lblProduct.Enabled = true;
                lblSupplier.Enabled = true;

                btnAdd.Visible = true;
                btnPackageDone.Visible = true;

                btnRemovePackage.Enabled = false;
                btnModifyPackage.Enabled = false;

                _isReadOnly = false;
                _isAddMode = false;


                RefreshAllFields();
            }
        }

        private void btnModifyPackage_Click(object sender, EventArgs e)
        {
            if (_isReadOnly && !_isAddMode)
            {
                _isModifyMode = true;
                _isAddMode = false;
                _isReadOnly = false;
                frmModeAddModifyReadonly();
            }
        }

        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            // Show warning message before deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the current package? This action is irreversible.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                PackageDB.DeletePackage(_packageId);
                _mainForm.LoadData(); // Refresh the data grid views in frmMain
                this.Close(); // Close the current screen
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            this.Close(); //close the current screen
        }

        private void FrmPackages_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isReadOnly && (_isAddMode || _isModifyMode))
            {
                // If in Add mode or Modify mode, show a warning message
                DialogResult result = MessageBox.Show("Are you sure you want to exit? All changes will be lost.", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // If the user confirms to exit, allow the form to close
                    _mainForm.LoadData(); // Refresh the data grid views in frmMain
                }
                else
                {
                    // If the user chooses not to exit, cancel the form closing event
                    e.Cancel = true;
                }
            }
            else
            {
                _mainForm.LoadData(); // Refresh the data grid views in frmMain
            }
        }

        private List<Product> GetProductList()
        {
            using (var context = new TravelExpertsContext())
            {
                return context.Products.OrderBy(p => p.ProdName).ToList();
            }
        }

        private List<Supplier> GetSupplierList(int productId)
        {
            using (var context = new TravelExpertsContext())
            {
                if (productId == -1)
                {
                    return context.Suppliers.OrderBy(s => s.SupName).ToList();
                }
                else
                {
                    return context.ProductsSuppliers
                        .Where(ps => ps.ProductId == productId)
                        .Select(ps => ps.Supplier)
                        .OrderBy(s => s.SupName)
                        .ToList();
                }
            }
        }

        private void UpdateProductSupplierControls()
        {
            // Load the product list
            var productList = GetProductList();
            cboPackageProduct.DataSource = productList;
            cboPackageProduct.DisplayMember = "ProdName";
            cboPackageProduct.ValueMember = "ProductId";
            cboPackageProduct.SelectedIndex = -1;

            // Format the product combo box items
            cboPackageProduct.Format += (sender, e) =>
            {
                e.Value = $"(ID: {((Product)e.ListItem).ProductId}) {((Product)e.ListItem).ProdName}";
            };

            // Handle the product selection event
            cboPackageProduct.SelectedIndexChanged += (sender, e) =>
            {
                // Check if a product is selected
                if (cboPackageProduct.SelectedIndex != -1)
                {
                    // Load the supplier list for the selected product
                    var selectedProductId = (int)cboPackageProduct.SelectedValue;
                    var supplierList = GetSupplierList(selectedProductId);
                    cboPackageSupplier.DataSource = supplierList;
                    cboPackageSupplier.DisplayMember = "SupName";
                    cboPackageSupplier.ValueMember = "SupplierId";
                    cboPackageSupplier.SelectedIndex = -1;

                    // Format the supplier combo box items
                    cboPackageSupplier.Format += (sender, e) =>
                    {
                        e.Value = $"(ID: {((Supplier)e.ListItem).SupplierId}) {((Supplier)e.ListItem).SupName}";
                    };

                    // Enable the supplier combo box
                }
                else
                {
                    // Clear the supplier combo box
                    cboPackageSupplier.DataSource = null;
                    cboPackageSupplier.Items.Clear();
                }
            };
        }


        private void rdoAddPackage_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateProductSupplierControls();
        }

        private void RefreshAllFields()
        {
            // Set the DataSource property to null before modifying the Items collection
            cboPackageProduct.DataSource = null;
            cboPackageSupplier.DataSource = null;

            // Clear and reload all the controls
            cboPackageProduct.Items.Clear();
            cboPackageSupplier.Items.Clear();
            treeViewPackages.Nodes.Clear();

            // Reload package details, tree view, and product-supplier controls
            LoadPackageDetails();
            UpdateTreeView(_packageId);
            UpdateProductSupplierControls();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            int selectedProductId = GetSelectedProductId();
            int selectedSupplierId = GetSelectedSupplierId();

            if (selectedProductId == -1 || selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a product and a supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = string.Format("Are you sure you want to add the following item to the package?\n\nProduct: (ID: {0}) {1}\nSupplier: (ID: {2}) {3}",
                selectedProductId, cboPackageProduct.Text, selectedSupplierId, cboPackageSupplier.Text);

            DialogResult result = MessageBox.Show(message, "Add Item to Package", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddTempItem(selectedProductId, selectedSupplierId);

                // Refresh the product list and supplier list to not include the temporarily added item
                UpdateProductSupplierControls();

                // Update the tree view
                UpdateTreeView(_packageId);

                // Clear combo boxes
                cboPackageProduct.SelectedIndex = -1;
                cboPackageSupplier.SelectedIndex = -1;
            }

            // Refresh the combo boxes
            UpdateProductSupplierControls();
        }


        private void AddTempItem(int productId, int supplierId)
        {
            // Check if the product-supplier combination already exists in the _tempAddedItems list
            bool combinationExists = _tempAddedItems.Any(item => item.ProductId == productId && item.SupplierId == supplierId);

            if (!combinationExists)
            {
                //Activates the done (save) button
                _isOkButtonClicked = true;

                _tempAddedItems.Add((productId, supplierId));

                MessageBox.Show("Item added successfully.", "Add Item to Package", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("The selected product-supplier combination already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private int GetSelectedProductId()
        {
            if (cboPackageProduct.SelectedItem == null)
                return -1;

            var selectedProduct = (Product)cboPackageProduct.SelectedItem;
            return selectedProduct.ProductId;
        }

        private int GetSelectedSupplierId()
        {
            if (cboPackageSupplier.SelectedItem == null)
                return -1;

            var selectedSupplier = (Supplier)cboPackageSupplier.SelectedItem;
            return selectedSupplier.SupplierId;
        }
        private bool IsPackageModified(TravelExpertsData.Package originalPackage)
        {
            return
                originalPackage.PkgName != txtPackageName.Text ||
                originalPackage.PkgStartDate != DateTime.Parse(txtPackageStartDate.Text) ||
                originalPackage.PkgEndDate != DateTime.Parse(txtPackageEndDate.Text) ||
                originalPackage.PkgDesc != txtPackageDescription.Text ||
                originalPackage.PkgBasePrice != decimal.Parse(txtBasePrice.Text) ||
                originalPackage.PkgAgencyCommission != decimal.Parse(txtAgencyComission.Text);
        }

        private void btnPackageDone_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                TravelExpertsData.Package package;
                // Check if any required fields are empty
                if (string.IsNullOrWhiteSpace(txtPackageName.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageStartDate.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageEndDate.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtBasePrice.Text) ||
                    string.IsNullOrWhiteSpace(txtAgencyComission.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_isAddMode)
                {
                    // Create a new package
                    package = new TravelExpertsData.Package
                    {
                        PkgName = txtPackageName.Text,
                        PkgStartDate = DateTime.Parse(txtPackageStartDate.Text),
                        PkgEndDate = DateTime.Parse(txtPackageEndDate.Text),
                        PkgDesc = txtPackageDescription.Text,
                        PkgBasePrice = decimal.Parse(txtBasePrice.Text),
                        PkgAgencyCommission = decimal.Parse(txtAgencyComission.Text)
                    };

                    // Add the new package to the context
                    context.Packages.Add(package);

                    // Save the package to the database to generate a valid PackageId
                    context.SaveChanges();

                    // Update the packageId
                    _packageId = package.PackageId;
                }
                else
                {
                    // Find the existing package
                    package = context.Packages.Find(_packageId);
                    if (package != null)
                    {
                        // Update the package fields
                        package.PkgName = txtPackageName.Text;
                        package.PkgStartDate = DateTime.Parse(txtPackageStartDate.Text);
                        package.PkgEndDate = DateTime.Parse(txtPackageEndDate.Text);
                        package.PkgDesc = txtPackageDescription.Text;
                        package.PkgBasePrice = decimal.Parse(txtBasePrice.Text);
                        package.PkgAgencyCommission = decimal.Parse(txtAgencyComission.Text);
                    }
                }

                // Add or update PackagesProductsSuppliers entries
                foreach (var item in _tempAddedItems)
                {
                    var productSupplier = context.ProductsSuppliers.FirstOrDefault(ps => ps.ProductId == item.ProductId && ps.SupplierId == item.SupplierId);
                    if (productSupplier != null)
                    {
                        // Check if the combination already exists in the Packages_Products_Suppliers table
                        bool combinationExists = context.PackagesProductsSuppliers.Any(pps => pps.PackageId == _packageId && pps.ProductSupplierId == productSupplier.ProductSupplierId);

                        if (!combinationExists)
                        {
                            var packageProductSupplier = new PackagesProductsSupplier
                            {
                                PackageId = _packageId,
                                ProductSupplierId = productSupplier.ProductSupplierId
                            };
                            context.PackagesProductsSuppliers.Add(packageProductSupplier);
                        }
                    }
                }

                // Save changes and handle exceptions
                try
                {
                    context.SaveChanges();
                    if (_isAddMode)
                    {
                        MessageBox.Show("Package added successfully.", "Package Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else if (_isModifyMode)
                    {
                        if (_isOkButtonClicked || IsPackageModified(package))
                        {
                            MessageBox.Show("Package modified successfully.", "Package Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //Display message no Modification were made
                            MessageBox.Show("No modifications were made.", "Package Modification", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        }
                    }
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("An error occurred while saving the changes: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Reset the form state
                _isAddMode = false;
                _isReadOnly = true;
                _isModifyMode = false;

                // Refresh the form controls
                RefreshAllFields();
                frmModeAddModifyReadonly();
            }
        }
    }
}
