using Microsoft.EntityFrameworkCore;
using TravelExpertsData;


namespace TravelExpertsGUI
{
    public partial class frmMain : Form
    {
        private readonly List<int> _selectedIds = new List<int>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeDataGridColumns();
            LoadData();
            AddEventHandlersIdSelection();
        }

        public void LoadData()
        {
            using (var context = new TravelExpertsData.TravelExpertsContext())
            {
                context.Packages.Load();
                dgvPackages.DataSource = context.Packages.Local.ToBindingList();

                context.Products.Load();
                dgvProducts.DataSource = context.Products.Local.ToBindingList();

                context.Suppliers.Load();
                dgvSuppliers.DataSource = context.Suppliers.Local.ToBindingList();
            }

            ClearDvgSelections();
        }


        private void ClearDvgSelections()
        {
            // Clear selections
            dgvPackages.ClearSelection();
            dgvProducts.ClearSelection();
            dgvSuppliers.ClearSelection();
        }

        private void InitializeDataGridColumns()
        {
            using (var context = new TravelExpertsData.TravelExpertsContext())
            {
                InitializeDataGridView(dgvPackages, context.Packages.ToList(), "Products & Suppliers");

                InitializeDataGridView(dgvProducts, context.Products.ToList(), "Packages & Suppliers");

                InitializeDataGridView(dgvSuppliers, context.Suppliers.ToList(), "Packages & Products");
            }

            // Set SelectionMode and MultiSelect properties
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.MultiSelect = true;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = true;

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = true;

            // Clear selections
            dgvPackages.ClearSelection();
            dgvProducts.ClearSelection();
            dgvSuppliers.ClearSelection();
        }

        private void Dgv_VisibleChanged(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.Visible)
            {
                dgv.ClearSelection();
            }
        }

        private void InitializeDataGridView(DataGridView dgv, object dataSource, string buttonText)
        {
            dgvPackages.MultiSelect = false;
            dgvProducts.MultiSelect = false;
            dgvSuppliers.MultiSelect = false;

            dgv.DataSource = dataSource;
            dgv.ClearSelection();

            // Set the SelectionMode to FullRowSelect
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set the SortMode for each column to Automatic
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            if (!string.IsNullOrEmpty(buttonText))
            {
                DataGridViewButtonColumn buttonColumn = CreateNewButtonColumn(buttonText, $"{buttonText}ButtonColumn");
                dgv.Columns.Add(buttonColumn);
            }
        }

        private void AddEventHandlersIdSelection()
        {
            // Add event handlers for the CellClick event
            dgvPackages.CellClick += Dgv_CellClick;
            dgvProducts.CellClick += Dgv_CellClick;
            dgvSuppliers.CellClick += Dgv_CellClick;

            // Add event handlers for the VisibleChanged event
            dgvPackages.VisibleChanged += Dgv_VisibleChanged;
            dgvProducts.VisibleChanged += Dgv_VisibleChanged;
            dgvSuppliers.VisibleChanged += Dgv_VisibleChanged;
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks and button clicks

            var dgv = (DataGridView)sender;

            // Get all selected rows
            var selectedRows = dgv.SelectedRows;

            if (dgv.Name == "dgvPackages" && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (selectedRows.Count > 1)
                {
                    MessageBox.Show("Only one package can be modified at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int packageId = (int)selectedRows[0].Cells[GetColumnName(dgv, "PackageId")].Value;
                frmPackages packageForm = new frmPackages(packageId, true, false, false, this); // Pass 'this' as a reference
                packageForm.ShowDialog();
            }
        }

        private string GetColumnName(DataGridView dgv, string dataPropertyName)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.DataPropertyName == dataPropertyName)
                {
                    return column.Name;
                }
            }

            throw new ArgumentException($"Column with DataPropertyName '{dataPropertyName}' not found.");
        }
        private List<string> GetSelectedNames(DataGridView dgv)
        {
            List<string> names = new List<string>();

            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                string name;
                switch (dgv.Name)
                {
                    case "dgvPackages":
                        name = row.Cells[GetColumnName(dgv, "PkgName")].Value.ToString();
                        break;
                    case "dgvProducts":
                        name = row.Cells[GetColumnName(dgv, "ProdName")].Value.ToString();
                        break;
                    case "dgvSuppliers":
                        name = row.Cells[GetColumnName(dgv, "SupName")].Value.ToString();
                        break;
                    default:
                        throw new ArgumentException($"Unknown DataGridView: {dgv.Name}");
                }
                names.Add(name);
            }

            return names;
        }
        private DataGridViewButtonColumn CreateNewButtonColumn(string headerText, string columnName)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            buttonColumn.HeaderText = headerText;
            buttonColumn.Name = columnName;
            buttonColumn.Text = "View";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Width = 75;

            return buttonColumn;
        }
        private DataGridView GetActiveDataGridView()
        {
            var activeTab = tabControl1.SelectedTab;

            switch (activeTab.Name)
            {
                case "PackagesTab":
                    return dgvPackages;
                case "ProductsTab":
                    return dgvProducts;
                case "SuppliersTab":
                    return dgvSuppliers;
                default:
                    throw new InvalidOperationException("Unknown tab.");
            }
        }
        private List<int> GetSelectedIds()
        {
            var selectedIds = new List<int>();
            DataGridView dgv = GetActiveDataGridView();

            if (dgv == null) return selectedIds;

            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                string idPropertyName = string.Empty;

                switch (dgv.Name)
                {
                    case "dgvPackages":
                        idPropertyName = "PackageId";
                        break;
                    case "dgvProducts":
                        idPropertyName = "ProductId";
                        break;
                    case "dgvSuppliers":
                        idPropertyName = "SupplierId";
                        break;
                    default:
                        MessageBox.Show("Unknown DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                int id = (int)row.Cells[GetColumnName(dgv, idPropertyName)].Value;
                selectedIds.Add(id);
            }

            return selectedIds;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedIds = GetSelectedIds();

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Please select one or more rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedIds.Count > 10)
            {
                MessageBox.Show("It's not possible to delete more than 10 items at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridView dgv = GetActiveDataGridView();
            var selectedNames = GetSelectedNames(dgv);

            string namesText = string.Join(Environment.NewLine, selectedNames);
            int itemCount = selectedIds.Count;

            // Show warning message before deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the following {itemCount} item(s)? This action is irreversible.\n\n{namesText}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var activeTab = tabControl1.SelectedTab;

                switch (activeTab.Name)
                {
                    case "PackagesTab":
                        foreach (int id in selectedIds)
                        {
                            PackageDB.DeletePackage(id);
                        }
                        break;
                    case "ProductsTab":
                        foreach (int id in selectedIds)
                        {
                            ProductDB.DeleteProduct(id);
                            LoadData();
                        }
                        break;
                    case "SuppliersTab":
                        foreach (int id in selectedIds)
                        {
                            SupplierDB.DeleteSupplier(id);
                            LoadData();
                        }
                        break;
                    default:
                        MessageBox.Show("Unknown tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                LoadData(); // Refresh the data grid views
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Implement exit
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DataGridView activeDataGridView = GetActiveDataGridView();

            // Ensure the Packages tab is selected
            if (activeDataGridView == dgvPackages)
            {
                // Check if a row is selected
                if (dgvPackages.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No package selected. Please select a package to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure only one row is selected
                if (dgvPackages.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Only one package can be modified at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected package ID
                int packageId = Convert.ToInt32(dgvPackages.SelectedRows[0].Cells[GetColumnName(dgvPackages, "PackageId")].Value);
                // Create a new instance of the frmPackages form with all fields enabled (isReadOnly set to false)
                frmPackages modifyPackageForm = new frmPackages(packageId, false, false, true, this); // Pass 'this' as a reference

                // Show the form as a dialog
                DialogResult result = modifyPackageForm.ShowDialog();

            }
            else if (activeDataGridView != null && activeDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No item selected. Please select an item to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridView activeDataGridView = GetActiveDataGridView();

            // Ensure the Packages tab is selected
            if (activeDataGridView == dgvPackages)
            {
                // Create a new instance of the frmPackages form with all fields enabled (isReadOnly set to false) and isAddMode set to true
                frmPackages addPackageForm = new frmPackages(0,false,true,false,this);

                // Show the form as a dialog
                DialogResult result = addPackageForm.ShowDialog();
            }
            else if (activeDataGridView != null)
            {
                MessageBox.Show("Adding new items is only available for the Packages tab.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}