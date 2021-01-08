namespace TAILORING.Masters
{
    partial class frmProductRateMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductRateMaster));
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpProduct = new gGlowBox.gGlowGroupBox();
            this.cmbGarmentName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rdSearchByService = new System.Windows.Forms.RadioButton();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdSearchByProduct = new System.Windows.Forms.RadioButton();
            this.txtSearchByGarment = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).BeginInit();
            this.grpGridview.Panel.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(583, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 311;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(488, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 310;
            this.btnDelete.Values.Image = global::TAILORING.Properties.Resources.btnDelete_Values_Image;
            this.btnDelete.Values.Text = " Delete ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(393, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.TabIndex = 309;
            this.btnUpdate.Values.Image = global::TAILORING.Properties.Resources.btnUpdate_Values_Image;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(298, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(78, 34);
            this.btnEdit.TabIndex = 308;
            this.btnEdit.Values.Image = global::TAILORING.Properties.Resources.btnEdit_Values_Image;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(203, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.TabIndex = 307;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(108, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(80, 34);
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 306;
            this.btnAdd.Values.Image = global::TAILORING.Properties.Resources.btnAdd_Values_Image;
            this.btnAdd.Values.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg_green;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 40);
            this.panel2.TabIndex = 305;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Product Rate Management";
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Location = new System.Drawing.Point(15, 98);
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpProduct);
            this.grpKrytonHeader.Size = new System.Drawing.Size(738, 138);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.TabIndex = 328;
            this.grpKrytonHeader.ValuesPrimary.Heading = "Product Rate Details";
            this.grpKrytonHeader.ValuesPrimary.Image = null;
            // 
            // grpProduct
            // 
            this.grpProduct.BackColor = System.Drawing.Color.Transparent;
            this.grpProduct.Controls.Add(this.cmbGarmentName);
            this.grpProduct.Controls.Add(this.label5);
            this.grpProduct.Controls.Add(this.txtRate);
            this.grpProduct.Controls.Add(this.label3);
            this.grpProduct.Controls.Add(this.label1);
            this.grpProduct.Controls.Add(this.label4);
            this.grpProduct.Controls.Add(this.cmbService);
            this.grpProduct.Controls.Add(this.label2);
            this.grpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProduct.Enabled = false;
            this.grpProduct.GlowAmount = 22;
            this.grpProduct.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpProduct.GlowFeather = 60;
            this.grpProduct.GlowOn = true;
            this.grpProduct.Location = new System.Drawing.Point(0, 0);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(736, 113);
            this.grpProduct.TabIndex = 287;
            // 
            // cmbGarmentName
            // 
            this.cmbGarmentName.DropDownHeight = 306;
            this.cmbGarmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpProduct.SetEffectType(this.cmbGarmentName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbGarmentName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGarmentName.FormattingEnabled = true;
            this.cmbGarmentName.IntegralHeight = false;
            this.cmbGarmentName.Location = new System.Drawing.Point(133, 18);
            this.cmbGarmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGarmentName.Name = "cmbGarmentName";
            this.grpProduct.SetsGlowColor(this.cmbGarmentName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbGarmentName.sGlowColor"))));
            this.cmbGarmentName.Size = new System.Drawing.Size(198, 25);
            this.cmbGarmentName.TabIndex = 326;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 325;
            this.label5.Text = "Garment Name :";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.grpProduct.SetEffectType(this.txtRate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtRate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(133, 64);
            this.txtRate.MaxLength = 100;
            this.txtRate.Name = "txtRate";
            this.grpProduct.SetsGlowColor(this.txtRate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtRate.sGlowColor"))));
            this.txtRate.Size = new System.Drawing.Size(198, 25);
            this.txtRate.TabIndex = 323;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 324;
            this.label3.Text = "Rate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(639, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 322;
            this.label1.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 321;
            this.label4.Text = "Service :";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpProduct.SetEffectType(this.cmbService, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.cmbService.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cmbService.Location = new System.Drawing.Point(440, 19);
            this.cmbService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbService.Name = "cmbService";
            this.grpProduct.SetsGlowColor(this.cmbService, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbService.sGlowColor"))));
            this.cmbService.Size = new System.Drawing.Size(198, 25);
            this.cmbService.TabIndex = 320;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(334, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 285;
            this.label2.Text = "*";
            // 
            // grpGridview
            // 
            this.grpGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGridview.Location = new System.Drawing.Point(18, 334);
            this.grpGridview.Name = "grpGridview";
            // 
            // grpGridview.Panel
            // 
            this.grpGridview.Panel.Controls.Add(this.dataGridView1);
            this.grpGridview.Size = new System.Drawing.Size(737, 208);
            this.grpGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.TabIndex = 331;
            this.grpGridview.ValuesPrimary.Heading = "List Of Product Rate";
            this.grpGridview.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.grpGridview.ValuesSecondary.Heading = "Total Records : 0";
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
            this.dataGridView1.Size = new System.Drawing.Size(735, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(17, 242);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(736, 86);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 330;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Search By";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::TAILORING.Properties.Resources.grpSearch_Values_Image;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.rdSearchByService);
            this.groupBox1.Controls.Add(this.rdShowAll);
            this.groupBox1.Controls.Add(this.rdSearchByProduct);
            this.groupBox1.Controls.Add(this.txtSearchByGarment);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.GlowAmount = 22;
            this.groupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox1.GlowFeather = 60;
            this.groupBox1.GlowOn = true;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 61);
            this.groupBox1.TabIndex = 287;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox1.SetEffectType(this.comboBox2, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.comboBox2.Location = new System.Drawing.Point(436, 15);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.groupBox1.SetsGlowColor(this.comboBox2, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("comboBox2.sGlowColor"))));
            this.comboBox2.Size = new System.Drawing.Size(198, 25);
            this.comboBox2.TabIndex = 327;
            // 
            // rdSearchByService
            // 
            this.rdSearchByService.AutoSize = true;
            this.groupBox1.SetEffectType(this.rdSearchByService, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByService.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByService.Location = new System.Drawing.Point(356, 17);
            this.rdSearchByService.Name = "rdSearchByService";
            this.groupBox1.SetsGlowColor(this.rdSearchByService, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByService.sGlowColor"))));
            this.rdSearchByService.Size = new System.Drawing.Size(77, 21);
            this.rdSearchByService.TabIndex = 14;
            this.rdSearchByService.Text = "Service :";
            this.rdSearchByService.UseVisualStyleBackColor = true;
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.groupBox1.SetEffectType(this.rdShowAll, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAll.Location = new System.Drawing.Point(647, 17);
            this.rdShowAll.Name = "rdShowAll";
            this.groupBox1.SetsGlowColor(this.rdShowAll, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAll.sGlowColor"))));
            this.rdShowAll.Size = new System.Drawing.Size(79, 21);
            this.rdShowAll.TabIndex = 13;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Show All";
            this.rdShowAll.UseVisualStyleBackColor = true;
            // 
            // rdSearchByProduct
            // 
            this.rdSearchByProduct.AutoSize = true;
            this.groupBox1.SetEffectType(this.rdSearchByProduct, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdSearchByProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByProduct.Location = new System.Drawing.Point(12, 17);
            this.rdSearchByProduct.Name = "rdSearchByProduct";
            this.groupBox1.SetsGlowColor(this.rdSearchByProduct, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByProduct.sGlowColor"))));
            this.rdSearchByProduct.Size = new System.Drawing.Size(124, 21);
            this.rdSearchByProduct.TabIndex = 9;
            this.rdSearchByProduct.Text = "Garment Name :";
            this.rdSearchByProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearchByGarment
            // 
            this.txtSearchByGarment.BackColor = System.Drawing.Color.White;
            this.groupBox1.SetEffectType(this.txtSearchByGarment, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtSearchByGarment.Enabled = false;
            this.txtSearchByGarment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByGarment.Location = new System.Drawing.Point(141, 16);
            this.txtSearchByGarment.MaxLength = 100;
            this.txtSearchByGarment.Name = "txtSearchByGarment";
            this.groupBox1.SetsGlowColor(this.txtSearchByGarment, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtSearchByGarment.sGlowColor"))));
            this.txtSearchByGarment.Size = new System.Drawing.Size(206, 25);
            this.txtSearchByGarment.TabIndex = 10;
            // 
            // frmProductRateMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 554);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProductRateMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Rate Management";
            this.Load += new System.EventHandler(this.frmProductRateMaster_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).EndInit();
            this.grpGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).EndInit();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private gGlowBox.gGlowGroupBox grpProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGarmentName;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rdSearchByService;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdSearchByProduct;
        private System.Windows.Forms.TextBox txtSearchByGarment;
    }
}