﻿
namespace TAILORING.Masters
{
    partial class frmCompanyMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpCompany = new gGlowBox.gGlowGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDefaultCompany = new System.Windows.Forms.CheckBox();
            this.txtCompanyEmailID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompanyMobileNo = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpCustomerSearch = new gGlowBox.gGlowGroupBox();
            this.txtSearchByMobileNo = new System.Windows.Forms.TextBox();
            this.rdSearchByCustomerMobileNo = new System.Windows.Forms.RadioButton();
            this.txtSearchByCustomerName = new System.Windows.Forms.TextBox();
            this.rdShowAllOfCustomer = new System.Windows.Forms.RadioButton();
            this.rdSearchByCompanyName = new System.Windows.Forms.RadioButton();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvCompanyMaster = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.grpCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).BeginInit();
            this.grpCustomerGridview.Panel.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TAILORING.Properties.Resources.titlebg_green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 45);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 22);
            this.label12.TabIndex = 83;
            this.label12.Text = "Company Master";
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Location = new System.Drawing.Point(17, 108);
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpCompany);
            this.grpKrytonHeader.Size = new System.Drawing.Size(754, 153);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.TabIndex = 328;
            this.grpKrytonHeader.ValuesPrimary.Heading = "Company Details";
            this.grpKrytonHeader.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpKrytonHeader.ValuesPrimary.Image")));
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.Transparent;
            this.grpCompany.Controls.Add(this.label3);
            this.grpCompany.Controls.Add(this.label2);
            this.grpCompany.Controls.Add(this.chkDefaultCompany);
            this.grpCompany.Controls.Add(this.txtCompanyEmailID);
            this.grpCompany.Controls.Add(this.label4);
            this.grpCompany.Controls.Add(this.label1);
            this.grpCompany.Controls.Add(this.label8);
            this.grpCompany.Controls.Add(this.txtCompanyMobileNo);
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.lblCustomerPhoneNo);
            this.grpCompany.Controls.Add(this.lblCustomerAddress);
            this.grpCompany.Controls.Add(this.lblCustomerName);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Enabled = false;
            this.grpCompany.GlowAmount = 22;
            this.grpCompany.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpCompany.GlowFeather = 60;
            this.grpCompany.GlowOn = true;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(752, 128);
            this.grpCompany.TabIndex = 287;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(356, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 302;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(723, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 301;
            this.label2.Text = "*";
            // 
            // chkDefaultCompany
            // 
            this.chkDefaultCompany.AutoSize = true;
            this.grpCompany.SetEffectType(this.chkDefaultCompany, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.chkDefaultCompany.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultCompany.Location = new System.Drawing.Point(480, 93);
            this.chkDefaultCompany.Name = "chkDefaultCompany";
            this.grpCompany.SetsGlowColor(this.chkDefaultCompany, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("chkDefaultCompany.sGlowColor"))));
            this.chkDefaultCompany.Size = new System.Drawing.Size(146, 21);
            this.chkDefaultCompany.TabIndex = 300;
            this.chkDefaultCompany.Text = "Is Default Company";
            this.chkDefaultCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompanyEmailID
            // 
            this.txtCompanyEmailID.BackColor = System.Drawing.Color.White;
            this.grpCompany.SetEffectType(this.txtCompanyEmailID, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtCompanyEmailID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmailID.Location = new System.Drawing.Point(114, 93);
            this.txtCompanyEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyEmailID.MaxLength = 100;
            this.txtCompanyEmailID.Name = "txtCompanyEmailID";
            this.grpCompany.SetsGlowColor(this.txtCompanyEmailID, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCompanyEmailID.sGlowColor"))));
            this.txtCompanyEmailID.Size = new System.Drawing.Size(240, 25);
            this.txtCompanyEmailID.TabIndex = 294;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 299;
            this.label4.Text = "Email ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(356, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 298;
            this.label1.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(356, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 297;
            this.label8.Text = "*";
            // 
            // txtCompanyMobileNo
            // 
            this.txtCompanyMobileNo.BackColor = System.Drawing.Color.White;
            this.grpCompany.SetEffectType(this.txtCompanyMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtCompanyMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyMobileNo.Location = new System.Drawing.Point(114, 53);
            this.txtCompanyMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyMobileNo.MaxLength = 10;
            this.txtCompanyMobileNo.Name = "txtCompanyMobileNo";
            this.grpCompany.SetsGlowColor(this.txtCompanyMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCompanyMobileNo.sGlowColor"))));
            this.txtCompanyMobileNo.Size = new System.Drawing.Size(240, 25);
            this.txtCompanyMobileNo.TabIndex = 292;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BackColor = System.Drawing.Color.White;
            this.grpCompany.SetEffectType(this.txtCompanyAddress, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtCompanyAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAddress.Location = new System.Drawing.Point(480, 9);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyAddress.MaxLength = 500;
            this.txtCompanyAddress.Multiline = true;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.grpCompany.SetsGlowColor(this.txtCompanyAddress, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCompanyAddress.sGlowColor"))));
            this.txtCompanyAddress.Size = new System.Drawing.Size(240, 65);
            this.txtCompanyAddress.TabIndex = 296;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.grpCompany.SetEffectType(this.txtCompanyName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(114, 13);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.MaxLength = 100;
            this.txtCompanyName.Name = "txtCompanyName";
            this.grpCompany.SetsGlowColor(this.txtCompanyName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCompanyName.sGlowColor"))));
            this.txtCompanyName.Size = new System.Drawing.Size(240, 25);
            this.txtCompanyName.TabIndex = 290;
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(29, 57);
            this.lblCustomerPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            this.lblCustomerPhoneNo.Size = new System.Drawing.Size(77, 17);
            this.lblCustomerPhoneNo.TabIndex = 295;
            this.lblCustomerPhoneNo.Text = "Mobile No :";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(398, 16);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(64, 17);
            this.lblCustomerAddress.TabIndex = 293;
            this.lblCustomerAddress.Text = "Address :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(29, 17);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(51, 17);
            this.lblCustomerName.TabIndex = 291;
            this.lblCustomerName.Text = "Name :";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(17, 278);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.grpCustomerSearch);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(752, 86);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 329;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Search By";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomerSearch.Controls.Add(this.txtSearchByMobileNo);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCustomerMobileNo);
            this.grpCustomerSearch.Controls.Add(this.txtSearchByCustomerName);
            this.grpCustomerSearch.Controls.Add(this.rdShowAllOfCustomer);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCompanyName);
            this.grpCustomerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomerSearch.GlowAmount = 22;
            this.grpCustomerSearch.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpCustomerSearch.GlowFeather = 60;
            this.grpCustomerSearch.GlowOn = true;
            this.grpCustomerSearch.Location = new System.Drawing.Point(0, 0);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Size = new System.Drawing.Size(750, 61);
            this.grpCustomerSearch.TabIndex = 287;
            // 
            // txtSearchByMobileNo
            // 
            this.txtSearchByMobileNo.BackColor = System.Drawing.Color.White;
            this.grpCustomerSearch.SetEffectType(this.txtSearchByMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtSearchByMobileNo.Enabled = false;
            this.txtSearchByMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByMobileNo.Location = new System.Drawing.Point(440, 18);
            this.txtSearchByMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByMobileNo.Name = "txtSearchByMobileNo";
            this.grpCustomerSearch.SetsGlowColor(this.txtSearchByMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtSearchByMobileNo.sGlowColor"))));
            this.txtSearchByMobileNo.Size = new System.Drawing.Size(184, 25);
            this.txtSearchByMobileNo.TabIndex = 9;
            // 
            // rdSearchByCustomerMobileNo
            // 
            this.rdSearchByCustomerMobileNo.AutoSize = true;
            this.grpCustomerSearch.SetEffectType(this.rdSearchByCustomerMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByCustomerMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCustomerMobileNo.Location = new System.Drawing.Point(340, 20);
            this.rdSearchByCustomerMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCustomerMobileNo.Name = "rdSearchByCustomerMobileNo";
            this.grpCustomerSearch.SetsGlowColor(this.rdSearchByCustomerMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByCustomerMobileNo.sGlowColor"))));
            this.rdSearchByCustomerMobileNo.Size = new System.Drawing.Size(95, 21);
            this.rdSearchByCustomerMobileNo.TabIndex = 8;
            this.rdSearchByCustomerMobileNo.Text = "Mobile No :";
            this.rdSearchByCustomerMobileNo.UseVisualStyleBackColor = true;
            // 
            // txtSearchByCustomerName
            // 
            this.txtSearchByCustomerName.BackColor = System.Drawing.Color.White;
            this.grpCustomerSearch.SetEffectType(this.txtSearchByCustomerName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtSearchByCustomerName.Enabled = false;
            this.txtSearchByCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByCustomerName.Location = new System.Drawing.Point(141, 18);
            this.txtSearchByCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByCustomerName.Name = "txtSearchByCustomerName";
            this.grpCustomerSearch.SetsGlowColor(this.txtSearchByCustomerName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtSearchByCustomerName.sGlowColor"))));
            this.txtSearchByCustomerName.Size = new System.Drawing.Size(184, 25);
            this.txtSearchByCustomerName.TabIndex = 6;
            // 
            // rdShowAllOfCustomer
            // 
            this.rdShowAllOfCustomer.AutoSize = true;
            this.rdShowAllOfCustomer.Checked = true;
            this.grpCustomerSearch.SetEffectType(this.rdShowAllOfCustomer, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdShowAllOfCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdShowAllOfCustomer.Location = new System.Drawing.Point(641, 20);
            this.rdShowAllOfCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.rdShowAllOfCustomer.Name = "rdShowAllOfCustomer";
            this.grpCustomerSearch.SetsGlowColor(this.rdShowAllOfCustomer, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAllOfCustomer.sGlowColor"))));
            this.rdShowAllOfCustomer.Size = new System.Drawing.Size(79, 21);
            this.rdShowAllOfCustomer.TabIndex = 7;
            this.rdShowAllOfCustomer.TabStop = true;
            this.rdShowAllOfCustomer.Text = "Show All";
            this.rdShowAllOfCustomer.UseVisualStyleBackColor = true;
            // 
            // rdSearchByCompanyName
            // 
            this.rdSearchByCompanyName.AutoSize = true;
            this.grpCustomerSearch.SetEffectType(this.rdSearchByCompanyName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByCompanyName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCompanyName.Location = new System.Drawing.Point(7, 20);
            this.rdSearchByCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCompanyName.Name = "rdSearchByCompanyName";
            this.grpCustomerSearch.SetsGlowColor(this.rdSearchByCompanyName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByCompanyName.sGlowColor"))));
            this.rdSearchByCompanyName.Size = new System.Drawing.Size(129, 21);
            this.rdSearchByCompanyName.TabIndex = 5;
            this.rdSearchByCompanyName.Text = "Company Name :";
            this.rdSearchByCompanyName.UseVisualStyleBackColor = true;
            // 
            // grpCustomerGridview
            // 
            this.grpCustomerGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerGridview.Location = new System.Drawing.Point(18, 372);
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvCompanyMaster);
            this.grpCustomerGridview.Size = new System.Drawing.Size(753, 209);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.TabIndex = 330;
            this.grpCustomerGridview.ValuesPrimary.Heading = "List Of Company";
            this.grpCustomerGridview.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dgvCompanyMaster
            // 
            this.dgvCompanyMaster.AllowUserToAddRows = false;
            this.dgvCompanyMaster.AllowUserToDeleteRows = false;
            this.dgvCompanyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompanyMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvCompanyMaster.Name = "dgvCompanyMaster";
            this.dgvCompanyMaster.ReadOnly = true;
            this.dgvCompanyMaster.Size = new System.Drawing.Size(751, 163);
            this.dgvCompanyMaster.TabIndex = 0;
            this.dgvCompanyMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompanyMaster_CellDoubleClick);
            this.dgvCompanyMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCompanyMaster_DataBindingComplete);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(564, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 336;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(469, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 335;
            this.btnDelete.Values.Image = global::TAILORING.Properties.Resources.btnDelete_Values_Image;
            this.btnDelete.Values.Text = " Delete ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(374, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.TabIndex = 334;
            this.btnUpdate.Values.Image = global::TAILORING.Properties.Resources.btnUpdate_Values_Image;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(279, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(78, 34);
            this.btnEdit.TabIndex = 333;
            this.btnEdit.Values.Image = global::TAILORING.Properties.Resources.btnEdit_Values_Image;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(184, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.TabIndex = 332;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(89, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(78, 34);
            this.btnAdd.TabIndex = 331;
            this.btnAdd.Values.Image = global::TAILORING.Properties.Resources.btnAdd_Values_Image;
            this.btnAdd.Values.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 593);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCompanyMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Master";
            this.Load += new System.EventHandler(this.frmCompanyMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).EndInit();
            this.grpCustomerGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).EndInit();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private gGlowBox.gGlowGroupBox grpCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDefaultCompany;
        private System.Windows.Forms.TextBox txtCompanyEmailID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompanyMobileNo;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox grpCustomerSearch;
        private System.Windows.Forms.TextBox txtSearchByMobileNo;
        private System.Windows.Forms.RadioButton rdSearchByCustomerMobileNo;
        private System.Windows.Forms.TextBox txtSearchByCustomerName;
        private System.Windows.Forms.RadioButton rdShowAllOfCustomer;
        private System.Windows.Forms.RadioButton rdSearchByCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCompanyMaster;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
    }
}