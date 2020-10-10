﻿namespace TAILORING.Masters
{
    partial class Customer_Master
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerEmailID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCustomerActiveStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblActiveStatusOfCustomer = new System.Windows.Forms.Label();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchByMobileNo = new System.Windows.Forms.TextBox();
            this.rdSearchByCustomerMobileNo = new System.Windows.Forms.RadioButton();
            this.txtSearchByCustomerName = new System.Windows.Forms.TextBox();
            this.rdShowAllOfCustomer = new System.Windows.Forms.RadioButton();
            this.rdSearchByCustomerName = new System.Windows.Forms.RadioButton();
            this.grpCustomerGridview = new System.Windows.Forms.GroupBox();
            this.dgvCustomerMaster = new System.Windows.Forms.DataGridView();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpCustomer.SuspendLayout();
            this.grpCustomerSearch.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(363, 59);
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
            this.btnCancel.Location = new System.Drawing.Point(527, 59);
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
            this.btnDelete.Location = new System.Drawing.Point(445, 59);
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
            this.btnEdit.Location = new System.Drawing.Point(283, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 3;
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
            this.btnSave.Location = new System.Drawing.Point(201, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 2;
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
            this.btnAdd.Location = new System.Drawing.Point(112, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.txtCustomerEmailID);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.cmbCustomerActiveStatus);
            this.grpCustomer.Controls.Add(this.txtCustomerMobileNo);
            this.grpCustomer.Controls.Add(this.txtCustomerAddress);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblActiveStatusOfCustomer);
            this.grpCustomer.Controls.Add(this.lblCustomerPhoneNo);
            this.grpCustomer.Controls.Add(this.lblCustomerAddress);
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.Location = new System.Drawing.Point(17, 102);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Size = new System.Drawing.Size(747, 153);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(720, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 287;
            this.label3.Text = "*";
            // 
            // txtCustomerEmailID
            // 
            this.txtCustomerEmailID.BackColor = System.Drawing.Color.White;
            this.txtCustomerEmailID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmailID.Location = new System.Drawing.Point(102, 105);
            this.txtCustomerEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerEmailID.MaxLength = 100;
            this.txtCustomerEmailID.Name = "txtCustomerEmailID";
            this.txtCustomerEmailID.Size = new System.Drawing.Size(240, 25);
            this.txtCustomerEmailID.TabIndex = 2;
            this.txtCustomerEmailID.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerEmailID.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 286;
            this.label4.Text = "Email ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(720, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 284;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(344, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 283;
            this.label1.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(344, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 282;
            this.label8.Text = "*";
            // 
            // cmbCustomerActiveStatus
            // 
            this.cmbCustomerActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerActiveStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerActiveStatus.FormattingEnabled = true;
            this.cmbCustomerActiveStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbCustomerActiveStatus.Location = new System.Drawing.Point(477, 105);
            this.cmbCustomerActiveStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomerActiveStatus.Name = "cmbCustomerActiveStatus";
            this.cmbCustomerActiveStatus.Size = new System.Drawing.Size(240, 25);
            this.cmbCustomerActiveStatus.TabIndex = 4;
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.BackColor = System.Drawing.Color.White;
            this.txtCustomerMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(102, 65);
            this.txtCustomerMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerMobileNo.MaxLength = 10;
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(240, 25);
            this.txtCustomerMobileNo.TabIndex = 1;
            this.txtCustomerMobileNo.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByMobileNo_KeyPress);
            this.txtCustomerMobileNo.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(477, 22);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerAddress.MaxLength = 500;
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(240, 65);
            this.txtCustomerAddress.TabIndex = 3;
            this.txtCustomerAddress.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerAddress.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(102, 25);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(240, 25);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // lblActiveStatusOfCustomer
            // 
            this.lblActiveStatusOfCustomer.AutoSize = true;
            this.lblActiveStatusOfCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveStatusOfCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatusOfCustomer.Location = new System.Drawing.Point(376, 109);
            this.lblActiveStatusOfCustomer.Name = "lblActiveStatusOfCustomer";
            this.lblActiveStatusOfCustomer.Size = new System.Drawing.Size(94, 17);
            this.lblActiveStatusOfCustomer.TabIndex = 190;
            this.lblActiveStatusOfCustomer.Text = "Active Status :";
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(17, 69);
            this.lblCustomerPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            this.lblCustomerPhoneNo.Size = new System.Drawing.Size(77, 17);
            this.lblCustomerPhoneNo.TabIndex = 2;
            this.lblCustomerPhoneNo.Text = "Mobile No :";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(386, 29);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(64, 17);
            this.lblCustomerAddress.TabIndex = 1;
            this.lblCustomerAddress.Text = "Address :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(17, 29);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(51, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name :";
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomerSearch.Controls.Add(this.txtSearchByMobileNo);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCustomerMobileNo);
            this.grpCustomerSearch.Controls.Add(this.txtSearchByCustomerName);
            this.grpCustomerSearch.Controls.Add(this.rdShowAllOfCustomer);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCustomerName);
            this.grpCustomerSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpCustomerSearch.Location = new System.Drawing.Point(17, 267);
            this.grpCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomerSearch.Size = new System.Drawing.Size(747, 55);
            this.grpCustomerSearch.TabIndex = 8;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "Search By";
            // 
            // txtSearchByMobileNo
            // 
            this.txtSearchByMobileNo.BackColor = System.Drawing.Color.White;
            this.txtSearchByMobileNo.Enabled = false;
            this.txtSearchByMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByMobileNo.Location = new System.Drawing.Point(440, 20);
            this.txtSearchByMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByMobileNo.Name = "txtSearchByMobileNo";
            this.txtSearchByMobileNo.Size = new System.Drawing.Size(184, 25);
            this.txtSearchByMobileNo.TabIndex = 4;
            this.txtSearchByMobileNo.TextChanged += new System.EventHandler(this.txtSearchByMobileNo_TextChanged);
            this.txtSearchByMobileNo.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtSearchByMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByMobileNo_KeyPress);
            this.txtSearchByMobileNo.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // rdSearchByCustomerMobileNo
            // 
            this.rdSearchByCustomerMobileNo.AutoSize = true;
            this.rdSearchByCustomerMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCustomerMobileNo.Location = new System.Drawing.Point(340, 22);
            this.rdSearchByCustomerMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCustomerMobileNo.Name = "rdSearchByCustomerMobileNo";
            this.rdSearchByCustomerMobileNo.Size = new System.Drawing.Size(95, 21);
            this.rdSearchByCustomerMobileNo.TabIndex = 3;
            this.rdSearchByCustomerMobileNo.Text = "Mobile No :";
            this.rdSearchByCustomerMobileNo.UseVisualStyleBackColor = true;
            this.rdSearchByCustomerMobileNo.CheckedChanged += new System.EventHandler(this.rdSearchByCustomerMobileNo_CheckedChanged);
            // 
            // txtSearchByCustomerName
            // 
            this.txtSearchByCustomerName.BackColor = System.Drawing.Color.White;
            this.txtSearchByCustomerName.Enabled = false;
            this.txtSearchByCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByCustomerName.Location = new System.Drawing.Point(141, 20);
            this.txtSearchByCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByCustomerName.Name = "txtSearchByCustomerName";
            this.txtSearchByCustomerName.Size = new System.Drawing.Size(184, 25);
            this.txtSearchByCustomerName.TabIndex = 1;
            this.txtSearchByCustomerName.TextChanged += new System.EventHandler(this.txtSearchByCustomer_TextChanged);
            this.txtSearchByCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtSearchByCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtSearchByCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // rdShowAllOfCustomer
            // 
            this.rdShowAllOfCustomer.AutoSize = true;
            this.rdShowAllOfCustomer.Checked = true;
            this.rdShowAllOfCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdShowAllOfCustomer.Location = new System.Drawing.Point(641, 22);
            this.rdShowAllOfCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.rdShowAllOfCustomer.Name = "rdShowAllOfCustomer";
            this.rdShowAllOfCustomer.Size = new System.Drawing.Size(79, 21);
            this.rdShowAllOfCustomer.TabIndex = 2;
            this.rdShowAllOfCustomer.TabStop = true;
            this.rdShowAllOfCustomer.Text = "Show All";
            this.rdShowAllOfCustomer.UseVisualStyleBackColor = true;
            this.rdShowAllOfCustomer.CheckedChanged += new System.EventHandler(this.rdShowAllOfCustomer_CheckedChanged);
            // 
            // rdSearchByCustomerName
            // 
            this.rdSearchByCustomerName.AutoSize = true;
            this.rdSearchByCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCustomerName.Location = new System.Drawing.Point(7, 22);
            this.rdSearchByCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCustomerName.Name = "rdSearchByCustomerName";
            this.rdSearchByCustomerName.Size = new System.Drawing.Size(130, 21);
            this.rdSearchByCustomerName.TabIndex = 0;
            this.rdSearchByCustomerName.Text = "Customer Name :";
            this.rdSearchByCustomerName.UseVisualStyleBackColor = true;
            this.rdSearchByCustomerName.CheckedChanged += new System.EventHandler(this.rdSearchByCustomerName_CheckedChanged);
            // 
            // grpCustomerGridview
            // 
            this.grpCustomerGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.Controls.Add(this.dgvCustomerMaster);
            this.grpCustomerGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.grpCustomerGridview.Location = new System.Drawing.Point(17, 334);
            this.grpCustomerGridview.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            this.grpCustomerGridview.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomerGridview.Size = new System.Drawing.Size(747, 200);
            this.grpCustomerGridview.TabIndex = 218;
            this.grpCustomerGridview.TabStop = false;
            this.grpCustomerGridview.Text = "List Of Customers";
            // 
            // dgvCustomerMaster
            // 
            this.dgvCustomerMaster.AllowUserToAddRows = false;
            this.dgvCustomerMaster.AllowUserToDeleteRows = false;
            this.dgvCustomerMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerMaster.Location = new System.Drawing.Point(7, 22);
            this.dgvCustomerMaster.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomerMaster.Name = "dgvCustomerMaster";
            this.dgvCustomerMaster.ReadOnly = true;
            this.dgvCustomerMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCustomerMaster.RowTemplate.Height = 24;
            this.dgvCustomerMaster.Size = new System.Drawing.Size(731, 168);
            this.dgvCustomerMaster.TabIndex = 0;
            this.dgvCustomerMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerMaster_CellDoubleClick);
            this.dgvCustomerMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomerMaster_DataBindingComplete);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(18, 543);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(121, 17);
            this.lblTotalRecords.TabIndex = 219;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 45);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 22);
            this.label12.TabIndex = 83;
            this.label12.Text = "Customer Management";
            // 
            // Customer_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 569);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.grpCustomerSearch);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Customer_Master";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.Customer_Master_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.GroupBox grpCustomerGridview;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblActiveStatusOfCustomer;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerActiveStatus;
        private System.Windows.Forms.RadioButton rdShowAllOfCustomer;
        private System.Windows.Forms.RadioButton rdSearchByCustomerName;
        private System.Windows.Forms.TextBox txtSearchByCustomerName;
        private System.Windows.Forms.DataGridView dgvCustomerMaster;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchByMobileNo;
        private System.Windows.Forms.RadioButton rdSearchByCustomerMobileNo;
        private System.Windows.Forms.TextBox txtCustomerEmailID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}