namespace TAILORING.Order
{
    partial class frmMeasurement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeasurement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSKUName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMeasureSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbStyleQTY = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFitType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStichType = new System.Windows.Forms.ComboBox();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpMeasurement = new gGlowBox.gGlowGroupBox();
            this.ctrlMeasurment1 = new TAILORING.Others.ctrlMeasurment();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpStyle = new gGlowBox.gGlowGroupBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowStyleImage = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStyleName = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpSKUList = new gGlowBox.gGlowGroupBox();
            this.SKUList = new System.Windows.Forms.ListView();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lnkAddItem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpMeasurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.grpStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.grpSKUList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg_green;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblSKUName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 40);
            this.panel2.TabIndex = 323;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(1103, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 358;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(1013, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 357;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(314, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 356;
            this.label5.Text = "SKU Selected :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Measurement & Style";
            this.label12.UseMnemonic = false;
            // 
            // lblSKUName
            // 
            this.lblSKUName.AutoSize = true;
            this.lblSKUName.BackColor = System.Drawing.Color.Transparent;
            this.lblSKUName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKUName.ForeColor = System.Drawing.Color.White;
            this.lblSKUName.Location = new System.Drawing.Point(429, 11);
            this.lblSKUName.Name = "lblSKUName";
            this.lblSKUName.Size = new System.Drawing.Size(88, 19);
            this.lblSKUName.TabIndex = 339;
            this.lblSKUName.Text = "SKU Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 342;
            this.label2.Text = "Select SKU Style No.";
            // 
            // btnMeasureSave
            // 
            this.btnMeasureSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeasureSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasureSave.Enabled = false;
            this.btnMeasureSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeasureSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasureSave.Location = new System.Drawing.Point(740, 238);
            this.btnMeasureSave.Name = "btnMeasureSave";
            this.btnMeasureSave.Size = new System.Drawing.Size(85, 27);
            this.btnMeasureSave.TabIndex = 345;
            this.btnMeasureSave.Text = "Save";
            this.btnMeasureSave.UseVisualStyleBackColor = true;
            this.btnMeasureSave.Visible = false;
            this.btnMeasureSave.Click += new System.EventHandler(this.btnMeasureSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.grpStyle.SetEffectType(this.checkBox1, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(252, 13);
            this.checkBox1.Name = "checkBox1";
            this.grpStyle.SetsGlowColor(this.checkBox1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("checkBox1.sGlowColor"))));
            this.checkBox1.Size = new System.Drawing.Size(180, 21);
            this.checkBox1.TabIndex = 346;
            this.checkBox1.Text = "Copy style as per previous";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbStyleQTY
            // 
            this.cmbStyleQTY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStyleQTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpStyle.SetEffectType(this.cmbStyleQTY, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbStyleQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyleQTY.FormattingEnabled = true;
            this.cmbStyleQTY.Location = new System.Drawing.Point(163, 11);
            this.cmbStyleQTY.Name = "cmbStyleQTY";
            this.grpStyle.SetsGlowColor(this.cmbStyleQTY, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbStyleQTY.sGlowColor"))));
            this.cmbStyleQTY.Size = new System.Drawing.Size(75, 25);
            this.cmbStyleQTY.TabIndex = 347;
            this.cmbStyleQTY.SelectionChangeCommitted += new System.EventHandler(this.cmbStyleQTY_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(925, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 353;
            this.label4.Text = "*";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(676, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 352;
            this.label14.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 350;
            this.label3.Text = "Fit Type :";
            // 
            // cmbFitType
            // 
            this.cmbFitType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpStyle.SetEffectType(this.cmbFitType, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbFitType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFitType.FormattingEnabled = true;
            this.cmbFitType.Location = new System.Drawing.Point(772, 11);
            this.cmbFitType.Name = "cmbFitType";
            this.grpStyle.SetsGlowColor(this.cmbFitType, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbFitType.sGlowColor"))));
            this.cmbFitType.Size = new System.Drawing.Size(150, 25);
            this.cmbFitType.TabIndex = 351;
            this.cmbFitType.SelectionChangeCommitted += new System.EventHandler(this.cmbFitType_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 348;
            this.label1.Text = "Stich Type :";
            // 
            // cmbStichType
            // 
            this.cmbStichType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStichType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpStyle.SetEffectType(this.cmbStichType, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbStichType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStichType.FormattingEnabled = true;
            this.cmbStichType.Location = new System.Drawing.Point(523, 11);
            this.cmbStichType.Name = "cmbStichType";
            this.grpStyle.SetsGlowColor(this.cmbStichType, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbStichType.sGlowColor"))));
            this.cmbStichType.Size = new System.Drawing.Size(150, 25);
            this.cmbStichType.TabIndex = 349;
            this.cmbStichType.SelectionChangeCommitted += new System.EventHandler(this.cmbStichType_SelectionChangeCommitted);
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Location = new System.Drawing.Point(215, 45);
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpMeasurement);
            this.grpKrytonHeader.Size = new System.Drawing.Size(610, 187);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.grpKrytonHeader.TabIndex = 352;
            this.grpKrytonHeader.ValuesPrimary.Heading = "Garment Measurement";
            this.grpKrytonHeader.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpKrytonHeader.ValuesPrimary.Image")));
            // 
            // grpMeasurement
            // 
            this.grpMeasurement.BackColor = System.Drawing.Color.Transparent;
            this.grpMeasurement.Controls.Add(this.ctrlMeasurment1);
            this.grpMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMeasurement.GlowAmount = 22;
            this.grpMeasurement.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpMeasurement.GlowFeather = 60;
            this.grpMeasurement.GlowOn = true;
            this.grpMeasurement.Location = new System.Drawing.Point(0, 0);
            this.grpMeasurement.Name = "grpMeasurement";
            this.grpMeasurement.Size = new System.Drawing.Size(608, 162);
            this.grpMeasurement.TabIndex = 287;
            // 
            // ctrlMeasurment1
            // 
            this.ctrlMeasurment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMeasurment1.BackColor = System.Drawing.Color.White;
            this.ctrlMeasurment1.DataSource = null;
            this.ctrlMeasurment1.IsEditable = false;
            this.ctrlMeasurment1.Location = new System.Drawing.Point(6, 7);
            this.ctrlMeasurment1.Name = "ctrlMeasurment1";
            this.ctrlMeasurment1.ProductCount = 0;
            this.ctrlMeasurment1.Size = new System.Drawing.Size(597, 145);
            this.ctrlMeasurment1.TabIndex = 0;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(215, 269);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.grpStyle);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(967, 420);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup1.TabIndex = 354;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Garment Style";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // grpStyle
            // 
            this.grpStyle.BackColor = System.Drawing.Color.Transparent;
            this.grpStyle.Controls.Add(this.kryptonButton1);
            this.grpStyle.Controls.Add(this.label4);
            this.grpStyle.Controls.Add(this.flowStyleImage);
            this.grpStyle.Controls.Add(this.label14);
            this.grpStyle.Controls.Add(this.flowStyleName);
            this.grpStyle.Controls.Add(this.label3);
            this.grpStyle.Controls.Add(this.label2);
            this.grpStyle.Controls.Add(this.cmbFitType);
            this.grpStyle.Controls.Add(this.checkBox1);
            this.grpStyle.Controls.Add(this.label1);
            this.grpStyle.Controls.Add(this.cmbStyleQTY);
            this.grpStyle.Controls.Add(this.cmbStichType);
            this.grpStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStyle.GlowAmount = 22;
            this.grpStyle.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpStyle.GlowFeather = 60;
            this.grpStyle.GlowOn = true;
            this.grpStyle.Location = new System.Drawing.Point(0, 0);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(965, 395);
            this.grpStyle.TabIndex = 287;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpStyle.SetEffectType(this.kryptonButton1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.kryptonButton1.Location = new System.Drawing.Point(844, 40);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.grpStyle.SetsGlowColor(this.kryptonButton1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("kryptonButton1.sGlowColor"))));
            this.kryptonButton1.Size = new System.Drawing.Size(78, 28);
            this.kryptonButton1.TabIndex = 359;
            this.kryptonButton1.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.kryptonButton1.Values.Text = "Save";
            this.kryptonButton1.Visible = false;
            // 
            // flowStyleImage
            // 
            this.flowStyleImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowStyleImage.AutoScroll = true;
            this.flowStyleImage.BackColor = System.Drawing.Color.White;
            this.flowStyleImage.Location = new System.Drawing.Point(22, 165);
            this.flowStyleImage.Name = "flowStyleImage";
            this.flowStyleImage.Size = new System.Drawing.Size(931, 221);
            this.flowStyleImage.TabIndex = 340;
            // 
            // flowStyleName
            // 
            this.flowStyleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowStyleName.AutoScroll = true;
            this.flowStyleName.BackColor = System.Drawing.Color.White;
            this.flowStyleName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowStyleName.Location = new System.Drawing.Point(22, 74);
            this.flowStyleName.Name = "flowStyleName";
            this.flowStyleName.Size = new System.Drawing.Size(931, 84);
            this.flowStyleName.TabIndex = 341;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(8, 42);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.grpSKUList);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(191, 647);
            this.kryptonHeaderGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup2.TabIndex = 355;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Selected SKUs";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            // 
            // grpSKUList
            // 
            this.grpSKUList.BackColor = System.Drawing.Color.Transparent;
            this.grpSKUList.Controls.Add(this.SKUList);
            this.grpSKUList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSKUList.GlowAmount = 22;
            this.grpSKUList.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpSKUList.GlowFeather = 60;
            this.grpSKUList.GlowOn = true;
            this.grpSKUList.Location = new System.Drawing.Point(0, 0);
            this.grpSKUList.Name = "grpSKUList";
            this.grpSKUList.Size = new System.Drawing.Size(189, 622);
            this.grpSKUList.TabIndex = 287;
            // 
            // SKUList
            // 
            this.SKUList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSKUList.SetEffectType(this.SKUList, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.SKUList.HideSelection = false;
            this.SKUList.Location = new System.Drawing.Point(0, 0);
            this.SKUList.Name = "SKUList";
            this.grpSKUList.SetsGlowColor(this.SKUList, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("SKUList.sGlowColor"))));
            this.SKUList.Size = new System.Drawing.Size(189, 622);
            this.SKUList.TabIndex = 345;
            this.SKUList.UseCompatibleStateImageBehavior = false;
            this.SKUList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SKUList_MouseClick);
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(847, 45);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.dataGridView1);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(335, 188);
            this.kryptonHeaderGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup3.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.HeaderSecondary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup3.TabIndex = 356;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "SKU Status";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Total Customer : 10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(333, 163);
            this.dataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dataGridView1.StateCommon.DataCell.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dataGridView1.TabIndex = 287;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // lnkAddItem
            // 
            this.lnkAddItem.AutoSize = true;
            this.lnkAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAddItem.Location = new System.Drawing.Point(214, 237);
            this.lnkAddItem.Name = "lnkAddItem";
            this.lnkAddItem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lnkAddItem.Size = new System.Drawing.Size(116, 28);
            this.lnkAddItem.StateNormal.Content.LongText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddItem.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lnkAddItem.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lnkAddItem.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddItem.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lnkAddItem.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lnkAddItem.TabIndex = 359;
            this.lnkAddItem.Values.Image = ((System.Drawing.Image)(resources.GetObject("lnkAddItem.Values.Image")));
            this.lnkAddItem.Values.Text = "Body Posture";
            this.lnkAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // frmMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Controls.Add(this.lnkAddItem);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnMeasureSave);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMeasurement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement And Style";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMeasurement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpMeasurement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.grpSKUList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Others.ctrlMeasurment ctrlMeasurment1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSKUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMeasureSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbStyleQTY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStichType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private gGlowBox.gGlowGroupBox grpMeasurement;
        private gGlowBox.gGlowGroupBox grpStyle;
        private System.Windows.Forms.FlowLayoutPanel flowStyleImage;
        private System.Windows.Forms.FlowLayoutPanel flowStyleName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private gGlowBox.gGlowGroupBox grpSKUList;
        private System.Windows.Forms.ListView SKUList;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton lnkAddItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}