﻿namespace TAILORING.Masters
{
    partial class Product_Master
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbActiveStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSearchByCategory = new System.Windows.Forms.RadioButton();
            this.cmbSearchByCategory = new System.Windows.Forms.ComboBox();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdSearchByProduct = new System.Windows.Forms.RadioButton();
            this.txtSearchByProduct = new System.Windows.Forms.TextBox();
            this.grpGridview = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.grpPhoto = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PicProductMaster = new System.Windows.Forms.PictureBox();
            this.grpProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProductMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(380, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(544, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(462, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(300, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(218, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // grpProduct
            // 
            this.grpProduct.BackColor = System.Drawing.Color.Transparent;
            this.grpProduct.Controls.Add(this.label3);
            this.grpProduct.Controls.Add(this.label2);
            this.grpProduct.Controls.Add(this.lblProductName);
            this.grpProduct.Controls.Add(this.lblActiveStatus);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(this.cmbActiveStatus);
            this.grpProduct.Enabled = false;
            this.grpProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduct.Location = new System.Drawing.Point(19, 96);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(714, 77);
            this.grpProduct.TabIndex = 0;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(674, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 287;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(339, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 285;
            this.label2.Text = "*";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(14, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(101, 17);
            this.lblProductName.TabIndex = 187;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(379, 30);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(94, 17);
            this.lblActiveStatus.TabIndex = 189;
            this.lblActiveStatus.Text = "Active Status :";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(130, 27);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(206, 25);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // cmbActiveStatus
            // 
            this.cmbActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActiveStatus.FormattingEnabled = true;
            this.cmbActiveStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbActiveStatus.Location = new System.Drawing.Point(479, 28);
            this.cmbActiveStatus.Name = "cmbActiveStatus";
            this.cmbActiveStatus.Size = new System.Drawing.Size(193, 27);
            this.cmbActiveStatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdSearchByCategory);
            this.groupBox1.Controls.Add(this.cmbSearchByCategory);
            this.groupBox1.Controls.Add(this.rdShowAll);
            this.groupBox1.Controls.Add(this.rdSearchByProduct);
            this.groupBox1.Controls.Add(this.txtSearchByProduct);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // rdSearchByCategory
            // 
            this.rdSearchByCategory.AutoSize = true;
            this.rdSearchByCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByCategory.Location = new System.Drawing.Point(364, 23);
            this.rdSearchByCategory.Name = "rdSearchByCategory";
            this.rdSearchByCategory.Size = new System.Drawing.Size(87, 21);
            this.rdSearchByCategory.TabIndex = 11;
            this.rdSearchByCategory.Text = "Category :";
            this.rdSearchByCategory.UseVisualStyleBackColor = true;
            this.rdSearchByCategory.CheckedChanged += new System.EventHandler(this.rdSearchByCategory_CheckedChanged);
            // 
            // cmbSearchByCategory
            // 
            this.cmbSearchByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchByCategory.Enabled = false;
            this.cmbSearchByCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchByCategory.FormattingEnabled = true;
            this.cmbSearchByCategory.Location = new System.Drawing.Point(476, 20);
            this.cmbSearchByCategory.Name = "cmbSearchByCategory";
            this.cmbSearchByCategory.Size = new System.Drawing.Size(206, 27);
            this.cmbSearchByCategory.TabIndex = 12;
            this.cmbSearchByCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchByCategory_SelectionChangeCommitted);
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.rdShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAll.Location = new System.Drawing.Point(692, 23);
            this.rdShowAll.Name = "rdShowAll";
            this.rdShowAll.Size = new System.Drawing.Size(79, 21);
            this.rdShowAll.TabIndex = 13;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Show All";
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.rdShowAll_CheckedChanged);
            // 
            // rdSearchByProduct
            // 
            this.rdSearchByProduct.AutoSize = true;
            this.rdSearchByProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByProduct.Location = new System.Drawing.Point(13, 20);
            this.rdSearchByProduct.Name = "rdSearchByProduct";
            this.rdSearchByProduct.Size = new System.Drawing.Size(119, 21);
            this.rdSearchByProduct.TabIndex = 9;
            this.rdSearchByProduct.Text = "Product Name :";
            this.rdSearchByProduct.UseVisualStyleBackColor = true;
            this.rdSearchByProduct.CheckedChanged += new System.EventHandler(this.rdSearchByProduct_CheckedChanged);
            // 
            // txtSearchByProduct
            // 
            this.txtSearchByProduct.BackColor = System.Drawing.Color.White;
            this.txtSearchByProduct.Enabled = false;
            this.txtSearchByProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByProduct.Location = new System.Drawing.Point(138, 19);
            this.txtSearchByProduct.MaxLength = 100;
            this.txtSearchByProduct.Name = "txtSearchByProduct";
            this.txtSearchByProduct.Size = new System.Drawing.Size(206, 25);
            this.txtSearchByProduct.TabIndex = 10;
            this.txtSearchByProduct.TextChanged += new System.EventHandler(this.txtSearchByProduct_TextChanged);
            this.txtSearchByProduct.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtSearchByProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            this.txtSearchByProduct.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // grpGridview
            // 
            this.grpGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpGridview.Controls.Add(this.dataGridView1);
            this.grpGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.Location = new System.Drawing.Point(20, 298);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.Size = new System.Drawing.Size(1000, 239);
            this.grpGridview.TabIndex = 213;
            this.grpGridview.TabStop = false;
            this.grpGridview.Text = "List of Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(977, 209);
            this.dataGridView1.TabIndex = 214;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 40);
            this.panel2.TabIndex = 216;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Product Management";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(22, 544);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(121, 17);
            this.lblTotalRecords.TabIndex = 217;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // grpPhoto
            // 
            this.grpPhoto.BackColor = System.Drawing.Color.Transparent;
            this.grpPhoto.Controls.Add(this.linkLabel2);
            this.grpPhoto.Controls.Add(this.linkLabel1);
            this.grpPhoto.Controls.Add(this.PicProductMaster);
            this.grpPhoto.Enabled = false;
            this.grpPhoto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhoto.Location = new System.Drawing.Point(801, 55);
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.Size = new System.Drawing.Size(219, 237);
            this.grpPhoto.TabIndex = 14;
            this.grpPhoto.TabStop = false;
            this.grpPhoto.Text = "Photo";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(153, 208);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 17);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cancel";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(8, 208);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse...";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PicProductMaster
            // 
            this.PicProductMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicProductMaster.Location = new System.Drawing.Point(11, 24);
            this.PicProductMaster.Name = "PicProductMaster";
            this.PicProductMaster.Size = new System.Drawing.Size(202, 180);
            this.PicProductMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicProductMaster.TabIndex = 209;
            this.PicProductMaster.TabStop = false;
            // 
            // Product_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 569);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Product_Master";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.Product_Master_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpPhoto.ResumeLayout(false);
            this.grpPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProductMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbActiveStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdSearchByProduct;
        private System.Windows.Forms.TextBox txtSearchByProduct;
        private System.Windows.Forms.GroupBox grpGridview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.GroupBox grpPhoto;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox PicProductMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdSearchByCategory;
        private System.Windows.Forms.ComboBox cmbSearchByCategory;
    }
}