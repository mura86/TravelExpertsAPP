using TravelExpertsData;
using System.Linq;


namespace TravelExpertsGUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            PackagesTab = new TabPage();
            dgvPackages = new DataGridView();
            packageIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgStartDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgEndDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgDescDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgBasePriceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pkgAgencyCommissionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            packageBindingSource = new BindingSource(components);
            ProductsTab = new TabPage();
            dgvProducts = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prodNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            SuppliersTab = new TabPage();
            dgvSuppliers = new DataGridView();
            supplierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnRemove = new Button();
            btnModify = new Button();
            packageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgStartDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgEndDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgBasePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgAgencyCommissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            tabControl1.SuspendLayout();
            PackagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).BeginInit();
            ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PackagesTab);
            tabControl1.Controls.Add(ProductsTab);
            tabControl1.Controls.Add(SuppliersTab);
            tabControl1.Location = new Point(15, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1495, 447);
            tabControl1.TabIndex = 0;
            // 
            // PackagesTab
            // 
            PackagesTab.Controls.Add(dgvPackages);
            PackagesTab.Location = new Point(4, 28);
            PackagesTab.Margin = new Padding(4);
            PackagesTab.Name = "PackagesTab";
            PackagesTab.Padding = new Padding(4);
            PackagesTab.Size = new Size(1487, 415);
            PackagesTab.TabIndex = 0;
            PackagesTab.Tag = "PackagesTab";
            PackagesTab.Text = "Packages";
            PackagesTab.UseVisualStyleBackColor = true;
            // 
            // dgvPackages
            // 
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.AllowUserToDeleteRows = false;
            dgvPackages.AutoGenerateColumns = false;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Columns.AddRange(new DataGridViewColumn[] { packageIdDataGridViewTextBoxColumn1, pkgNameDataGridViewTextBoxColumn1, pkgStartDateDataGridViewTextBoxColumn1, pkgEndDateDataGridViewTextBoxColumn1, pkgDescDataGridViewTextBoxColumn1, pkgBasePriceDataGridViewTextBoxColumn1, pkgAgencyCommissionDataGridViewTextBoxColumn1 });
            dgvPackages.DataSource = packageBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPackages.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPackages.Dock = DockStyle.Fill;
            dgvPackages.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPackages.Location = new Point(4, 4);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.ReadOnly = true;
            dgvPackages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvPackages.RowTemplate.Height = 25;
            dgvPackages.Size = new Size(1479, 407);
            dgvPackages.TabIndex = 0;
            // 
            // packageIdDataGridViewTextBoxColumn1
            // 
            packageIdDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            packageIdDataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            packageIdDataGridViewTextBoxColumn1.HeaderText = "Package ID";
            packageIdDataGridViewTextBoxColumn1.Name = "packageIdDataGridViewTextBoxColumn1";
            packageIdDataGridViewTextBoxColumn1.ReadOnly = true;
            packageIdDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            packageIdDataGridViewTextBoxColumn1.Width = 97;
            // 
            // pkgNameDataGridViewTextBoxColumn1
            // 
            pkgNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgNameDataGridViewTextBoxColumn1.DataPropertyName = "PkgName";
            pkgNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            pkgNameDataGridViewTextBoxColumn1.Name = "pkgNameDataGridViewTextBoxColumn1";
            pkgNameDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgNameDataGridViewTextBoxColumn1.Width = 70;
            // 
            // pkgStartDateDataGridViewTextBoxColumn1
            // 
            pkgStartDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgStartDateDataGridViewTextBoxColumn1.DataPropertyName = "PkgStartDate";
            pkgStartDateDataGridViewTextBoxColumn1.HeaderText = "Start Date";
            pkgStartDateDataGridViewTextBoxColumn1.Name = "pkgStartDateDataGridViewTextBoxColumn1";
            pkgStartDateDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgStartDateDataGridViewTextBoxColumn1.Width = 81;
            // 
            // pkgEndDateDataGridViewTextBoxColumn1
            // 
            pkgEndDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgEndDateDataGridViewTextBoxColumn1.DataPropertyName = "PkgEndDate";
            pkgEndDateDataGridViewTextBoxColumn1.HeaderText = "End Date";
            pkgEndDateDataGridViewTextBoxColumn1.Name = "pkgEndDateDataGridViewTextBoxColumn1";
            pkgEndDateDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgEndDateDataGridViewTextBoxColumn1.Width = 97;
            // 
            // pkgDescDataGridViewTextBoxColumn1
            // 
            pkgDescDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgDescDataGridViewTextBoxColumn1.DataPropertyName = "PkgDesc";
            pkgDescDataGridViewTextBoxColumn1.HeaderText = "Description";
            pkgDescDataGridViewTextBoxColumn1.Name = "pkgDescDataGridViewTextBoxColumn1";
            pkgDescDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgDescDataGridViewTextBoxColumn1.Width = 133;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn1
            // 
            pkgBasePriceDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgBasePriceDataGridViewTextBoxColumn1.DataPropertyName = "PkgBasePrice";
            pkgBasePriceDataGridViewTextBoxColumn1.HeaderText = "Base Price";
            pkgBasePriceDataGridViewTextBoxColumn1.Name = "pkgBasePriceDataGridViewTextBoxColumn1";
            pkgBasePriceDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgBasePriceDataGridViewTextBoxColumn1.Width = 114;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn1
            // 
            pkgAgencyCommissionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pkgAgencyCommissionDataGridViewTextBoxColumn1.DataPropertyName = "PkgAgencyCommission";
            pkgAgencyCommissionDataGridViewTextBoxColumn1.HeaderText = "Agency Commission";
            pkgAgencyCommissionDataGridViewTextBoxColumn1.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn1";
            pkgAgencyCommissionDataGridViewTextBoxColumn1.ReadOnly = true;
            pkgAgencyCommissionDataGridViewTextBoxColumn1.Width = 170;
            // 
            // packageBindingSource
            // 
            packageBindingSource.DataSource = typeof(Package);
            // 
            // ProductsTab
            // 
            ProductsTab.Controls.Add(dgvProducts);
            ProductsTab.Location = new Point(4, 24);
            ProductsTab.Margin = new Padding(4);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Padding = new Padding(4);
            ProductsTab.Size = new Size(1487, 419);
            ProductsTab.TabIndex = 1;
            ProductsTab.Tag = "ProductsTab";
            ProductsTab.Text = "Products";
            ProductsTab.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, prodNameDataGridViewTextBoxColumn });
            dgvProducts.DataSource = productBindingSource;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(4, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(1479, 411);
            dgvProducts.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 124;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            prodNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            prodNameDataGridViewTextBoxColumn.HeaderText = "Name";
            prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            prodNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // SuppliersTab
            // 
            SuppliersTab.Controls.Add(dgvSuppliers);
            SuppliersTab.Location = new Point(4, 24);
            SuppliersTab.Name = "SuppliersTab";
            SuppliersTab.Padding = new Padding(3);
            SuppliersTab.Size = new Size(1487, 419);
            SuppliersTab.TabIndex = 2;
            SuppliersTab.Tag = "SuppliersTab";
            SuppliersTab.Text = "Suppliers";
            SuppliersTab.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.AutoGenerateColumns = false;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { supplierIdDataGridViewTextBoxColumn, supNameDataGridViewTextBoxColumn });
            dgvSuppliers.DataSource = supplierBindingSource;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(3, 3);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowTemplate.Height = 25;
            dgvSuppliers.Size = new Size(1481, 413);
            dgvSuppliers.TabIndex = 0;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            supplierIdDataGridViewTextBoxColumn.Width = 133;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            supNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            supNameDataGridViewTextBoxColumn.DataPropertyName = "SupName";
            supNameDataGridViewTextBoxColumn.HeaderText = "Name";
            supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            supNameDataGridViewTextBoxColumn.ReadOnly = true;
            supNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            supNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Supplier);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 469);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(219, 469);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(119, 469);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 43);
            btnModify.TabIndex = 3;
            btnModify.Text = "MODIFY";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            packageIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            packageIdDataGridViewTextBoxColumn.HeaderText = "Package ID";
            packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            packageIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgNameDataGridViewTextBoxColumn
            // 
            pkgNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgNameDataGridViewTextBoxColumn.DataPropertyName = "PkgName";
            pkgNameDataGridViewTextBoxColumn.HeaderText = "Name";
            pkgNameDataGridViewTextBoxColumn.Name = "pkgNameDataGridViewTextBoxColumn";
            // 
            // pkgStartDateDataGridViewTextBoxColumn
            // 
            pkgStartDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            pkgStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            pkgEndDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            pkgEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            pkgDescDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            pkgDescDataGridViewTextBoxColumn.HeaderText = "Description";
            pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            pkgBasePriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "Base Price";
            pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            pkgAgencyCommissionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "Agency Commission";
            pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            // 
            // bookingsDataGridViewTextBoxColumn
            // 
            bookingsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bookingsDataGridViewTextBoxColumn.DataPropertyName = "Bookings";
            bookingsDataGridViewTextBoxColumn.HeaderText = "Bookings";
            bookingsDataGridViewTextBoxColumn.Name = "bookingsDataGridViewTextBoxColumn";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1435, 469);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 43);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 522);
            Controls.Add(btnRemove);
            Controls.Add(btnModify);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(tabControl1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "frmMain";
            Text = "Travel Experts - Database Administration";
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            PackagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).EndInit();
            ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            SuppliersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage PackagesTab;
        private TabPage ProductsTab;
        private TabPage SuppliersTab;
        private DataGridView dgvProducts;
        private DataGridView dgvSuppliers;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnModify;
        private DataGridView dgvPackages;
        private BindingSource packageBindingSource;
        private BindingSource productBindingSource;
        private BindingSource supplierBindingSource;
        private DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingsDataGridViewTextBoxColumn;
        private Button btnExit;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
    }
}