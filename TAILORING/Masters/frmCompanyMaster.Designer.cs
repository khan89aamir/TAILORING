
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
            this.label12 = new System.Windows.Forms.Label();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpCompany = new gGlowBox.gGlowGroupBox();
            this.txtCompanyAddress = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txtCompanyEmailID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCompanyMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDefaultCompany = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvCompanyMaster = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).BeginInit();
            this.grpCustomerGridview.Panel.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 12);
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
            this.grpKrytonHeader.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpCompany);
            this.grpKrytonHeader.Size = new System.Drawing.Size(754, 162);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpKrytonHeader.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpKrytonHeader.StateCommon.Border.Rounding = 10;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.TabIndex = 328;
            this.grpKrytonHeader.ValuesPrimary.Heading = "Company Details";
            this.grpKrytonHeader.ValuesPrimary.Image = global::TAILORING.Properties.Resources.companysm;
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.Transparent;
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyEmailID);
            this.grpCompany.Controls.Add(this.txtCompanyMobileNo);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.label3);
            this.grpCompany.Controls.Add(this.label2);
            this.grpCompany.Controls.Add(this.chkDefaultCompany);
            this.grpCompany.Controls.Add(this.label4);
            this.grpCompany.Controls.Add(this.label1);
            this.grpCompany.Controls.Add(this.label8);
            this.grpCompany.Controls.Add(this.lblCustomerPhoneNo);
            this.grpCompany.Controls.Add(this.lblCustomerAddress);
            this.grpCompany.Controls.Add(this.lblCustomerName);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.GlowAmount = 22;
            this.grpCompany.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpCompany.GlowFeather = 60;
            this.grpCompany.GlowOn = true;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(746, 132);
            this.grpCompany.TabIndex = 287;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(480, 13);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(240, 65);
            this.txtCompanyAddress.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCompanyAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyAddress.StateCommon.Border.Rounding = 10;
            this.txtCompanyAddress.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAddress.TabIndex = 383;
            this.txtCompanyAddress.Text = "";
            // 
            // txtCompanyEmailID
            // 
            this.txtCompanyEmailID.Location = new System.Drawing.Point(114, 90);
            this.txtCompanyEmailID.Name = "txtCompanyEmailID";
            this.txtCompanyEmailID.Size = new System.Drawing.Size(240, 31);
            this.txtCompanyEmailID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCompanyEmailID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCompanyEmailID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyEmailID.StateCommon.Border.Rounding = 10;
            this.txtCompanyEmailID.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmailID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyEmailID.StateNormal.Border.Rounding = 20;
            this.txtCompanyEmailID.TabIndex = 382;
            // 
            // txtCompanyMobileNo
            // 
            this.txtCompanyMobileNo.Location = new System.Drawing.Point(114, 53);
            this.txtCompanyMobileNo.Name = "txtCompanyMobileNo";
            this.txtCompanyMobileNo.Size = new System.Drawing.Size(240, 31);
            this.txtCompanyMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCompanyMobileNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCompanyMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyMobileNo.StateCommon.Border.Rounding = 10;
            this.txtCompanyMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyMobileNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyMobileNo.StateNormal.Border.Rounding = 20;
            this.txtCompanyMobileNo.TabIndex = 381;
            this.txtCompanyMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompanyMobileNo_KeyPress);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(114, 13);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(240, 31);
            this.txtCompanyName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCompanyName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCompanyName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyName.StateCommon.Border.Rounding = 10;
            this.txtCompanyName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompanyName.StateNormal.Border.Rounding = 20;
            this.txtCompanyName.TabIndex = 380;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 90);
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(723, 13);
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
            this.chkDefaultCompany.ForeColor = System.Drawing.Color.White;
            this.chkDefaultCompany.Location = new System.Drawing.Point(480, 93);
            this.chkDefaultCompany.Name = "chkDefaultCompany";
            this.grpCompany.SetsGlowColor(this.chkDefaultCompany, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("chkDefaultCompany.sGlowColor"))));
            this.chkDefaultCompany.Size = new System.Drawing.Size(146, 21);
            this.chkDefaultCompany.TabIndex = 300;
            this.chkDefaultCompany.Text = "Is Default Company";
            this.grpCompany.SetUseEffect(this.chkDefaultCompany, false);
            this.chkDefaultCompany.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
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
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(356, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 297;
            this.label8.Text = "*";
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerPhoneNo.ForeColor = System.Drawing.Color.White;
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
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.White;
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
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(29, 17);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(51, 17);
            this.lblCustomerName.TabIndex = 291;
            this.lblCustomerName.Text = "Name :";
            // 
            // grpCustomerGridview
            // 
            this.grpCustomerGridview.Location = new System.Drawing.Point(18, 282);
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            this.grpCustomerGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvCompanyMaster);
            this.grpCustomerGridview.Size = new System.Drawing.Size(753, 186);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpCustomerGridview.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpCustomerGridview.StateCommon.Border.Rounding = 10;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.TabIndex = 330;
            this.grpCustomerGridview.ValuesPrimary.Heading = "List Of Company";
            this.grpCustomerGridview.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpCustomerGridview.ValuesPrimary.Image")));
            this.grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dgvCompanyMaster
            // 
            this.dgvCompanyMaster.AllowUserToAddRows = false;
            this.dgvCompanyMaster.AllowUserToDeleteRows = false;
            this.dgvCompanyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompanyMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvCompanyMaster.MultiSelect = false;
            this.dgvCompanyMaster.Name = "dgvCompanyMaster";
            this.dgvCompanyMaster.ReadOnly = true;
            this.dgvCompanyMaster.Size = new System.Drawing.Size(751, 136);
            this.dgvCompanyMaster.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dgvCompanyMaster.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCompanyMaster.TabIndex = 0;
            this.dgvCompanyMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompanyMaster_CellDoubleClick);
            this.dgvCompanyMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCompanyMaster_DataBindingComplete);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(564, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 5;
            this.btnCancel.TabIndex = 336;
            this.btnCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Values.Image")));
            this.btnCancel.Values.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(469, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 5;
            this.btnDelete.TabIndex = 335;
            this.btnDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Values.Image")));
            this.btnDelete.Values.Text = " Delete ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(374, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 5;
            this.btnUpdate.TabIndex = 334;
            this.btnUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Values.Image")));
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(279, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(78, 34);
            this.btnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 5;
            this.btnEdit.TabIndex = 333;
            this.btnEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Values.Image")));
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(184, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 5;
            this.btnSave.TabIndex = 332;
            this.btnSave.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Values.Image")));
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(89, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(80, 34);
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 5;
            this.btnAdd.TabIndex = 331;
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.label12);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel1.Size = new System.Drawing.Size(783, 51);
            this.kryptonPanel1.TabIndex = 371;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TAILORING.Properties.Resources.companywhiet;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 364;
            this.pictureBox1.TabStop = false;
            // 
            // frmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.grpKrytonHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCompanyMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Master";
            this.Load += new System.EventHandler(this.frmCompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).EndInit();
            this.grpCustomerGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).EndInit();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private gGlowBox.gGlowGroupBox grpCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDefaultCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCompanyMaster;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCompanyEmailID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCompanyMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtCompanyAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}