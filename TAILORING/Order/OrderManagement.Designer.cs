namespace TAILORING.Order
{
    partial class frmOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMeasurement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCGST = new System.Windows.Forms.Label();
            this.lblSGST = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpNewOrder = new gGlowBox.gGlowGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericQTY = new System.Windows.Forms.NumericUpDown();
            this.cmbGarmentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTrailDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.grpGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.GarmentID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Column1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Column2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ServiceID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Service = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.TrailDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.DeliveryDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.TrimAmount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.QTY = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Rate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Total = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Photo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTailoringAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCGST = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSGST = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGrossAmt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerAdd = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.grpNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).BeginInit();
            this.grpGridview.Panel.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(455, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 333;
            this.label10.Text = "Customer Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 331;
            this.label8.Text = "Customer Name :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtCustomerID.Location = new System.Drawing.Point(1080, 9);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(41, 25);
            this.txtCustomerID.TabIndex = 314;
            this.txtCustomerID.Text = "0";
            this.txtCustomerID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 323;
            this.label4.Text = "Tailoring Amount :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(346, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 319;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 19);
            this.label13.TabIndex = 318;
            this.label13.Text = "Service :";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Enabled = false;
            this.cmbOrderType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cmbOrderType.Location = new System.Drawing.Point(146, 195);
            this.cmbOrderType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(198, 25);
            this.cmbOrderType.TabIndex = 317;
            this.cmbOrderType.SelectionChangeCommitted += new System.EventHandler(this.cmbOrderType_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Order Management";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Enabled = false;
            this.dtpBookingDate.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(1000, 194);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(121, 25);
            this.dtpBookingDate.TabIndex = 340;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(895, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 339;
            this.label15.Text = "Booking Date :";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnMeasurement);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Location = new System.Drawing.Point(0, 653);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1137, 40);
            this.panel5.TabIndex = 341;
            // 
            // btnMeasurement
            // 
            this.btnMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeasurement.AutoSize = true;
            this.btnMeasurement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasurement.Location = new System.Drawing.Point(927, 5);
            this.btnMeasurement.Name = "btnMeasurement";
            this.btnMeasurement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnMeasurement.Size = new System.Drawing.Size(113, 30);
            this.btnMeasurement.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnMeasurement.TabIndex = 362;
            this.btnMeasurement.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnMeasurement.Values.Image")));
            this.btnMeasurement.Values.Text = "Measurement";
            this.btnMeasurement.Click += new System.EventHandler(this.btnMeasurement_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(1049, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSave.TabIndex = 361;
            this.btnSave.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Values.Image")));
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(863, 612);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 19);
            this.label16.TabIndex = 343;
            this.label16.Text = "Gross Amount  :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 19);
            this.label19.TabIndex = 351;
            this.label19.Text = "Customer MobileNo :";
            // 
            // lblCGST
            // 
            this.lblCGST.AutoSize = true;
            this.lblCGST.BackColor = System.Drawing.Color.Transparent;
            this.lblCGST.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGST.ForeColor = System.Drawing.Color.White;
            this.lblCGST.Location = new System.Drawing.Point(385, 612);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(49, 19);
            this.lblCGST.TabIndex = 353;
            this.lblCGST.Text = "CGST";
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.BackColor = System.Drawing.Color.Transparent;
            this.lblSGST.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGST.ForeColor = System.Drawing.Color.White;
            this.lblSGST.Location = new System.Drawing.Point(593, 612);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(47, 19);
            this.lblSGST.TabIndex = 355;
            this.lblSGST.Text = "SGST";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(15, 233);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.grpNewOrder);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1107, 101);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 358;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Order Details";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // grpNewOrder
            // 
            this.grpNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpNewOrder.Controls.Add(this.label2);
            this.grpNewOrder.Controls.Add(this.NumericQTY);
            this.grpNewOrder.Controls.Add(this.cmbGarmentName);
            this.grpNewOrder.Controls.Add(this.label1);
            this.grpNewOrder.Controls.Add(this.label11);
            this.grpNewOrder.Controls.Add(this.dtpTrailDate);
            this.grpNewOrder.Controls.Add(this.label17);
            this.grpNewOrder.Controls.Add(this.dtpDeliveryDate);
            this.grpNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNewOrder.Enabled = false;
            this.grpNewOrder.GlowAmount = 22;
            this.grpNewOrder.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpNewOrder.GlowFeather = 60;
            this.grpNewOrder.GlowOn = true;
            this.grpNewOrder.Location = new System.Drawing.Point(0, 0);
            this.grpNewOrder.Name = "grpNewOrder";
            this.grpNewOrder.Size = new System.Drawing.Size(1105, 74);
            this.grpNewOrder.TabIndex = 287;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 351;
            this.label2.Text = "QTY :";
            // 
            // NumericQTY
            // 
            this.NumericQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericQTY.Location = new System.Drawing.Point(443, 24);
            this.NumericQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumericQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQTY.Name = "NumericQTY";
            this.NumericQTY.Size = new System.Drawing.Size(57, 25);
            this.NumericQTY.TabIndex = 350;
            this.NumericQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_Control_KeyPress);
            // 
            // cmbGarmentName
            // 
            this.cmbGarmentName.DropDownHeight = 306;
            this.cmbGarmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpNewOrder.SetEffectType(this.cmbGarmentName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbGarmentName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGarmentName.FormattingEnabled = true;
            this.cmbGarmentName.IntegralHeight = false;
            this.cmbGarmentName.Location = new System.Drawing.Point(130, 23);
            this.cmbGarmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGarmentName.Name = "cmbGarmentName";
            this.grpNewOrder.SetsGlowColor(this.cmbGarmentName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbGarmentName.sGlowColor"))));
            this.cmbGarmentName.Size = new System.Drawing.Size(201, 25);
            this.cmbGarmentName.TabIndex = 348;
            this.cmbGarmentName.SelectionChangeCommitted += new System.EventHandler(this.cmbGarmentName_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 347;
            this.label1.Text = "Garment Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(577, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 354;
            this.label11.Text = "Trail Date :";
            // 
            // dtpTrailDate
            // 
            this.dtpTrailDate.Checked = false;
            this.grpNewOrder.SetEffectType(this.dtpTrailDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dtpTrailDate.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dtpTrailDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTrailDate.Location = new System.Drawing.Point(658, 21);
            this.dtpTrailDate.Name = "dtpTrailDate";
            this.grpNewOrder.SetsGlowColor(this.dtpTrailDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpTrailDate.sGlowColor"))));
            this.dtpTrailDate.ShowCheckBox = true;
            this.dtpTrailDate.Size = new System.Drawing.Size(131, 25);
            this.dtpTrailDate.TabIndex = 355;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(851, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 19);
            this.label17.TabIndex = 356;
            this.label17.Text = "Delivery Date :";
            // 
            // dtpDeliveryDate
            // 
            this.grpNewOrder.SetEffectType(this.dtpDeliveryDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(956, 19);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.grpNewOrder.SetsGlowColor(this.dtpDeliveryDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpDeliveryDate.sGlowColor"))));
            this.dtpDeliveryDate.Size = new System.Drawing.Size(131, 25);
            this.dtpDeliveryDate.TabIndex = 357;
            // 
            // grpGridview
            // 
            this.grpGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGridview.HeaderVisibleSecondary = false;
            this.grpGridview.Location = new System.Drawing.Point(16, 374);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpGridview.Panel
            // 
            this.grpGridview.Panel.Controls.Add(this.dataGridView1);
            this.grpGridview.Size = new System.Drawing.Size(1106, 221);
            this.grpGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.TabIndex = 359;
            this.grpGridview.ValuesPrimary.Heading = "List Of Order Details";
            this.grpGridview.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpGridview.ValuesPrimary.Image")));
            this.grpGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GarmentID,
            this.Column1,
            this.Column2,
            this.ServiceID,
            this.Service,
            this.TrailDate,
            this.DeliveryDate,
            this.TrimAmount,
            this.QTY,
            this.Rate,
            this.Total,
            this.Photo,
            this.ColDelete,
            this.ColDelete1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1104, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // GarmentID
            // 
            this.GarmentID.DataPropertyName = "GarmentID";
            this.GarmentID.HeaderText = "GarmentID";
            this.GarmentID.Name = "GarmentID";
            this.GarmentID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GarmentID.Visible = false;
            this.GarmentID.Width = 100;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GarmentCode";
            this.Column1.HeaderText = "GarmentCode";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 100;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GarmentName";
            this.Column2.HeaderText = "GarmentName";
            this.Column2.Name = "Column2";
            this.Column2.Width = 100;
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "ServiceID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.Visible = false;
            this.ServiceID.Width = 100;
            // 
            // Service
            // 
            this.Service.DataPropertyName = "Service";
            this.Service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Service.DropDownWidth = 40;
            this.Service.HeaderText = "Service";
            this.Service.Items.AddRange(new string[] {
            "Normal",
            "Urgent"});
            this.Service.Name = "Service";
            this.Service.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Service.Width = 100;
            // 
            // TrailDate
            // 
            this.TrailDate.CalendarTodayDate = new System.DateTime(2021, 1, 13, 0, 0, 0, 0);
            this.TrailDate.Checked = false;
            this.TrailDate.DataPropertyName = "TrailDate";
            this.TrailDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TrailDate.HeaderText = "TrailDate";
            this.TrailDate.Name = "TrailDate";
            this.TrailDate.ShowCheckBox = true;
            this.TrailDate.Width = 100;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.CalendarTodayDate = new System.DateTime(2021, 1, 13, 0, 0, 0, 0);
            this.DeliveryDate.Checked = false;
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ShowCheckBox = true;
            this.DeliveryDate.Width = 100;
            // 
            // TrimAmount
            // 
            this.TrimAmount.DataPropertyName = "TrimAmount";
            this.TrimAmount.HeaderText = "Trim Amount";
            this.TrimAmount.Name = "TrimAmount";
            this.TrimAmount.Width = 100;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 100;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 100;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 100;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Photo";
            this.Photo.Name = "Photo";
            this.Photo.Visible = false;
            this.Photo.Width = 100;
            // 
            // ColDelete
            // 
            this.ColDelete.DataPropertyName = "Delete";
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Text = "Delete";
            this.ColDelete.UseColumnTextForButtonValue = true;
            // 
            // ColDelete1
            // 
            this.ColDelete1.DataPropertyName = "Delete1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ColDelete1.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDelete1.HeaderText = "Delete1";
            this.ColDelete1.Name = "ColDelete1";
            this.ColDelete1.Text = "Delete1";
            this.ColDelete1.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1035, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(87, 31);
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 361;
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTailoringAmount
            // 
            this.txtTailoringAmount.Location = new System.Drawing.Point(146, 605);
            this.txtTailoringAmount.Name = "txtTailoringAmount";
            this.txtTailoringAmount.Size = new System.Drawing.Size(119, 33);
            this.txtTailoringAmount.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtTailoringAmount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtTailoringAmount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTailoringAmount.StateCommon.Border.Rounding = 10;
            this.txtTailoringAmount.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTailoringAmount.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTailoringAmount.StateNormal.Border.Rounding = 20;
            this.txtTailoringAmount.TabIndex = 380;
            this.txtTailoringAmount.Text = "0";
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(498, 605);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(59, 33);
            this.txtCGST.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCGST.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCGST.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCGST.StateCommon.Border.Rounding = 10;
            this.txtCGST.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCGST.StateNormal.Border.Rounding = 20;
            this.txtCGST.TabIndex = 381;
            this.txtCGST.Text = "0";
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(705, 605);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(59, 33);
            this.txtSGST.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtSGST.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtSGST.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSGST.StateCommon.Border.Rounding = 10;
            this.txtSGST.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSGST.StateNormal.Border.Rounding = 20;
            this.txtSGST.TabIndex = 382;
            this.txtSGST.Text = "0";
            // 
            // txtGrossAmt
            // 
            this.txtGrossAmt.Location = new System.Drawing.Point(1006, 605);
            this.txtGrossAmt.Name = "txtGrossAmt";
            this.txtGrossAmt.Size = new System.Drawing.Size(119, 33);
            this.txtGrossAmt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtGrossAmt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtGrossAmt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGrossAmt.StateCommon.Border.Rounding = 10;
            this.txtGrossAmt.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossAmt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGrossAmt.StateNormal.Border.Rounding = 20;
            this.txtGrossAmt.TabIndex = 383;
            this.txtGrossAmt.Text = "0";
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(160, 111);
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.ReadOnly = true;
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(223, 33);
            this.txtCustomerMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCustomerMobileNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCustomerMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateCommon.Border.Rounding = 10;
            this.txtCustomerMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMobileNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateNormal.Border.Rounding = 20;
            this.txtCustomerMobileNo.TabIndex = 384;
            this.txtCustomerMobileNo.Text = "0";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(160, 69);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(223, 33);
            this.txtCustomerName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCustomerName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCustomerName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateCommon.Border.Rounding = 10;
            this.txtCustomerName.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateNormal.Border.Rounding = 20;
            this.txtCustomerName.TabIndex = 385;
            this.txtCustomerName.Text = "0";
            // 
            // txtCustomerAdd
            // 
            this.txtCustomerAdd.Location = new System.Drawing.Point(597, 66);
            this.txtCustomerAdd.Name = "txtCustomerAdd";
            this.txtCustomerAdd.ReadOnly = true;
            this.txtCustomerAdd.Size = new System.Drawing.Size(349, 84);
            this.txtCustomerAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCustomerAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerAdd.StateCommon.Border.Rounding = 20;
            this.txtCustomerAdd.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAdd.TabIndex = 386;
            this.txtCustomerAdd.Text = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.txtCustomerID);
            this.kryptonPanel1.Controls.Add(this.label12);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1137, 51);
            this.kryptonPanel1.TabIndex = 387;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 364;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 693);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txtCustomerAdd);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerMobileNo);
            this.Controls.Add(this.txtGrossAmt);
            this.Controls.Add(this.txtSGST);
            this.Controls.Add(this.txtCGST);
            this.Controls.Add(this.txtTailoringAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.lblSGST);
            this.Controls.Add(this.lblCGST);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbOrderType);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmOrderManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.grpNewOrder.ResumeLayout(false);
            this.grpNewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).EndInit();
            this.grpGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).EndInit();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCGST;
        private System.Windows.Forms.Label lblSGST;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox grpNewOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericQTY;
        private System.Windows.Forms.ComboBox cmbGarmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpTrailDate;
        private System.Windows.Forms.Label label17;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMeasurement;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTailoringAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCGST;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSGST;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGrossAmt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtCustomerAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GarmentID;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Column1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Column2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ServiceID;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn Service;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn TrailDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn DeliveryDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn TrimAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn QTY;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Rate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Total;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn ColDelete1;
    }
}