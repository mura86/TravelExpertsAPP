namespace TravelExpertsGUI
{
    partial class frmPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeViewPackages = new TreeView();
            txtPackageID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPackageName = new TextBox();
            txtPackageStartDate = new TextBox();
            txtPackageEndDate = new TextBox();
            txtPackageDescription = new TextBox();
            txtBasePrice = new TextBox();
            txtAgencyComission = new TextBox();
            btnModifyPackage = new Button();
            btnRemovePackage = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            cboPackageProduct = new ComboBox();
            rdoAddPackage = new RadioButton();
            rdoRemovePackage = new RadioButton();
            pictureBox1 = new PictureBox();
            btnPackageDone = new Button();
            lblAddOrRemovePackage = new Label();
            lblSupplier = new Label();
            cboPackageSupplier = new ComboBox();
            panel1 = new Panel();
            lblProduct = new Label();
            lblAutoGenerate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewPackages
            // 
            treeViewPackages.Location = new Point(48, 242);
            treeViewPackages.Margin = new Padding(4);
            treeViewPackages.Name = "treeViewPackages";
            treeViewPackages.Size = new Size(962, 331);
            treeViewPackages.TabIndex = 0;
            // 
            // txtPackageID
            // 
            txtPackageID.Enabled = false;
            txtPackageID.Location = new Point(205, 12);
            txtPackageID.Name = "txtPackageID";
            txtPackageID.ReadOnly = true;
            txtPackageID.Size = new Size(515, 31);
            txtPackageID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 2;
            label1.Text = "Package ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 47);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 79);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 5;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 111);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 6;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 207);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 7;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 143);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 8;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 175);
            label7.Name = "label7";
            label7.Size = new Size(208, 23);
            label7.TabIndex = 9;
            label7.Text = "Agency Commission:";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(205, 40);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(515, 31);
            txtPackageName.TabIndex = 10;
            // 
            // txtPackageStartDate
            // 
            txtPackageStartDate.Location = new Point(205, 76);
            txtPackageStartDate.Name = "txtPackageStartDate";
            txtPackageStartDate.Size = new Size(515, 31);
            txtPackageStartDate.TabIndex = 11;
            // 
            // txtPackageEndDate
            // 
            txtPackageEndDate.Location = new Point(205, 108);
            txtPackageEndDate.Name = "txtPackageEndDate";
            txtPackageEndDate.Size = new Size(515, 31);
            txtPackageEndDate.TabIndex = 12;
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(205, 204);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(515, 31);
            txtPackageDescription.TabIndex = 13;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(205, 140);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(515, 31);
            txtBasePrice.TabIndex = 14;
            // 
            // txtAgencyComission
            // 
            txtAgencyComission.Location = new Point(205, 172);
            txtAgencyComission.Name = "txtAgencyComission";
            txtAgencyComission.Size = new Size(515, 31);
            txtAgencyComission.TabIndex = 15;
            // 
            // btnModifyPackage
            // 
            btnModifyPackage.Location = new Point(591, 735);
            btnModifyPackage.Name = "btnModifyPackage";
            btnModifyPackage.Size = new Size(166, 58);
            btnModifyPackage.TabIndex = 22;
            btnModifyPackage.Text = "MODIFY PACKAGE";
            btnModifyPackage.UseVisualStyleBackColor = true;
            btnModifyPackage.Click += btnModifyPackage_Click;
            // 
            // btnRemovePackage
            // 
            btnRemovePackage.Location = new Point(763, 735);
            btnRemovePackage.Name = "btnRemovePackage";
            btnRemovePackage.Size = new Size(166, 58);
            btnRemovePackage.TabIndex = 23;
            btnRemovePackage.Text = "REMOVE PACKAGE";
            btnRemovePackage.UseVisualStyleBackColor = true;
            btnRemovePackage.Click += btnRemovePackage_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(935, 735);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 58);
            btnExit.TabIndex = 24;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 735);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 58);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOK_Click;
            // 
            // cboPackageProduct
            // 
            cboPackageProduct.FormattingEnabled = true;
            cboPackageProduct.Location = new Point(48, 634);
            cboPackageProduct.Name = "cboPackageProduct";
            cboPackageProduct.Size = new Size(962, 31);
            cboPackageProduct.TabIndex = 31;
            // 
            // rdoAddPackage
            // 
            rdoAddPackage.AutoSize = true;
            rdoAddPackage.Location = new Point(7, 15);
            rdoAddPackage.Name = "rdoAddPackage";
            rdoAddPackage.Size = new Size(64, 27);
            rdoAddPackage.TabIndex = 38;
            rdoAddPackage.Text = "ADD";
            rdoAddPackage.UseVisualStyleBackColor = true;
            rdoAddPackage.CheckedChanged += rdoAddPackage_CheckedChanged_1;
            // 
            // rdoRemovePackage
            // 
            rdoRemovePackage.AutoSize = true;
            rdoRemovePackage.Location = new Point(77, 15);
            rdoRemovePackage.Name = "rdoRemovePackage";
            rdoRemovePackage.Size = new Size(97, 27);
            rdoRemovePackage.TabIndex = 39;
            rdoRemovePackage.Text = "REMOVE";
            rdoRemovePackage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travelpackageimage;
            pictureBox1.Location = new Point(701, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // btnPackageDone
            // 
            btnPackageDone.Location = new Point(220, 735);
            btnPackageDone.Name = "btnPackageDone";
            btnPackageDone.Size = new Size(166, 58);
            btnPackageDone.TabIndex = 43;
            btnPackageDone.Text = "DONE";
            btnPackageDone.UseVisualStyleBackColor = true;
            btnPackageDone.Visible = false;
            btnPackageDone.Click += btnPackageDone_Click;
            // 
            // lblAddOrRemovePackage
            // 
            lblAddOrRemovePackage.AutoSize = true;
            lblAddOrRemovePackage.Location = new Point(48, 584);
            lblAddOrRemovePackage.Name = "lblAddOrRemovePackage";
            lblAddOrRemovePackage.Size = new Size(230, 23);
            lblAddOrRemovePackage.TabIndex = 41;
            lblAddOrRemovePackage.Text = "Add or Remove Items:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(48, 668);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(98, 23);
            lblSupplier.TabIndex = 45;
            lblSupplier.Text = "Supplier";
            // 
            // cboPackageSupplier
            // 
            cboPackageSupplier.FormattingEnabled = true;
            cboPackageSupplier.Location = new Point(48, 694);
            cboPackageSupplier.Name = "cboPackageSupplier";
            cboPackageSupplier.Size = new Size(962, 31);
            cboPackageSupplier.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoAddPackage);
            panel1.Controls.Add(rdoRemovePackage);
            panel1.Location = new Point(272, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 47);
            panel1.TabIndex = 50;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(48, 610);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(87, 23);
            lblProduct.TabIndex = 51;
            lblProduct.Text = "Product";
            // 
            // lblAutoGenerate
            // 
            lblAutoGenerate.AutoSize = true;
            lblAutoGenerate.Enabled = false;
            lblAutoGenerate.Location = new Point(205, 14);
            lblAutoGenerate.Name = "lblAutoGenerate";
            lblAutoGenerate.Size = new Size(428, 23);
            lblAutoGenerate.TabIndex = 52;
            lblAutoGenerate.Text = "ID # to be auto-generated after adding";
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1023, 802);
            Controls.Add(lblAutoGenerate);
            Controls.Add(lblProduct);
            Controls.Add(cboPackageSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(btnPackageDone);
            Controls.Add(cboPackageProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnRemovePackage);
            Controls.Add(btnModifyPackage);
            Controls.Add(txtAgencyComission);
            Controls.Add(txtBasePrice);
            Controls.Add(txtPackageDescription);
            Controls.Add(txtPackageEndDate);
            Controls.Add(txtPackageStartDate);
            Controls.Add(txtPackageName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPackageID);
            Controls.Add(treeViewPackages);
            Controls.Add(panel1);
            Controls.Add(lblAddOrRemovePackage);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPackages";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Package Details";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewPackages;
        private TextBox txtPackageID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPackageName;
        private TextBox txtPackageStartDate;
        private TextBox txtPackageEndDate;
        private TextBox txtPackageDescription;
        private TextBox txtBasePrice;
        private TextBox txtAgencyComission;
        private Button btnModifyPackage;
        private Button btnRemovePackage;
        private Button btnExit;
        private Button btnAdd;
        private ComboBox cboPackageProduct;
        private RadioButton rdoAddPackage;
        private RadioButton rdoRemovePackage;
        private PictureBox pictureBox1;
        private Button btnPackageDone;
        private Label lblAddOrRemovePackage;
        private Label lblProductOrSupplier1;
        private Label lblSupplier;
        private ComboBox cboPackageSupplier;
        private Panel panel1;
        private Label lblProduct;
        private Label lblAutoGenerate;
    }
}