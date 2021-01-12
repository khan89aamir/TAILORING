namespace TAILORING.Order
{
    partial class frmViewMeasurementStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMeasurementStyle));
            this.grpSKUList = new System.Windows.Forms.GroupBox();
            this.flowGarmentList = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMeasurement = new System.Windows.Forms.GroupBox();
            this.ctrlMeasurment1 = new TAILORING.Others.ctrlMeasurment();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFitType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStichType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowStyleImage = new System.Windows.Forms.FlowLayoutPanel();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.cmbStyleQTY = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowStyleName = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkAddItem = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpSKUStatus = new System.Windows.Forms.GroupBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblSKUName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSKUList.SuspendLayout();
            this.grpMeasurement.SuspendLayout();
            this.grpStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpSKUStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSKUList
            // 
            this.grpSKUList.BackColor = System.Drawing.Color.Transparent;
            this.grpSKUList.Controls.Add(this.flowGarmentList);
            this.grpSKUList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSKUList.Location = new System.Drawing.Point(8, 48);
            this.grpSKUList.Name = "grpSKUList";
            this.grpSKUList.Size = new System.Drawing.Size(201, 647);
            this.grpSKUList.TabIndex = 358;
            this.grpSKUList.TabStop = false;
            this.grpSKUList.Text = "Selected SKUs :";
            // 
            // flowGarmentList
            // 
            this.flowGarmentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowGarmentList.AutoScroll = true;
            this.flowGarmentList.BackColor = System.Drawing.Color.White;
            this.flowGarmentList.Location = new System.Drawing.Point(6, 21);
            this.flowGarmentList.Name = "flowGarmentList";
            this.flowGarmentList.Size = new System.Drawing.Size(185, 620);
            this.flowGarmentList.TabIndex = 340;
            // 
            // grpMeasurement
            // 
            this.grpMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMeasurement.BackColor = System.Drawing.Color.Transparent;
            this.grpMeasurement.Controls.Add(this.ctrlMeasurment1);
            this.grpMeasurement.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeasurement.Location = new System.Drawing.Point(215, 61);
            this.grpMeasurement.Name = "grpMeasurement";
            this.grpMeasurement.Size = new System.Drawing.Size(638, 165);
            this.grpMeasurement.TabIndex = 357;
            this.grpMeasurement.TabStop = false;
            this.grpMeasurement.Text = "Measurement :";
            // 
            // ctrlMeasurment1
            // 
            this.ctrlMeasurment1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMeasurment1.BackColor = System.Drawing.Color.White;
            this.ctrlMeasurment1.DataSource = null;
            this.ctrlMeasurment1.IsEditable = false;
            this.ctrlMeasurment1.Location = new System.Drawing.Point(10, 21);
            this.ctrlMeasurment1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ctrlMeasurment1.Name = "ctrlMeasurment1";
            this.ctrlMeasurment1.ProductCount = 0;
            this.ctrlMeasurment1.Size = new System.Drawing.Size(621, 137);
            this.ctrlMeasurment1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(921, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 353;
            this.label4.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(669, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 352;
            this.label14.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(692, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 350;
            this.label3.Text = "Fit Type :";
            // 
            // cmbFitType
            // 
            this.cmbFitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFitType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFitType.FormattingEnabled = true;
            this.cmbFitType.Location = new System.Drawing.Point(763, 24);
            this.cmbFitType.Name = "cmbFitType";
            this.cmbFitType.Size = new System.Drawing.Size(150, 25);
            this.cmbFitType.TabIndex = 351;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 348;
            this.label1.Text = "Stich Type :";
            // 
            // cmbStichType
            // 
            this.cmbStichType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStichType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStichType.FormattingEnabled = true;
            this.cmbStichType.Location = new System.Drawing.Point(511, 24);
            this.cmbStichType.Name = "cmbStichType";
            this.cmbStichType.Size = new System.Drawing.Size(150, 25);
            this.cmbStichType.TabIndex = 349;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 342;
            this.label2.Text = "Select SKU Style No.";
            // 
            // flowStyleImage
            // 
            this.flowStyleImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowStyleImage.AutoScroll = true;
            this.flowStyleImage.BackColor = System.Drawing.Color.White;
            this.flowStyleImage.Location = new System.Drawing.Point(21, 187);
            this.flowStyleImage.Name = "flowStyleImage";
            this.flowStyleImage.Size = new System.Drawing.Size(912, 221);
            this.flowStyleImage.TabIndex = 338;
            // 
            // grpStyle
            // 
            this.grpStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStyle.BackColor = System.Drawing.Color.Transparent;
            this.grpStyle.Controls.Add(this.label4);
            this.grpStyle.Controls.Add(this.label14);
            this.grpStyle.Controls.Add(this.label3);
            this.grpStyle.Controls.Add(this.cmbFitType);
            this.grpStyle.Controls.Add(this.label1);
            this.grpStyle.Controls.Add(this.cmbStichType);
            this.grpStyle.Controls.Add(this.label2);
            this.grpStyle.Controls.Add(this.cmbStyleQTY);
            this.grpStyle.Controls.Add(this.flowStyleImage);
            this.grpStyle.Controls.Add(this.checkBox1);
            this.grpStyle.Controls.Add(this.flowStyleName);
            this.grpStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStyle.Location = new System.Drawing.Point(225, 275);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(957, 420);
            this.grpStyle.TabIndex = 356;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Style :";
            // 
            // cmbStyleQTY
            // 
            this.cmbStyleQTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyleQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyleQTY.FormattingEnabled = true;
            this.cmbStyleQTY.Location = new System.Drawing.Point(163, 24);
            this.cmbStyleQTY.Name = "cmbStyleQTY";
            this.cmbStyleQTY.Size = new System.Drawing.Size(65, 25);
            this.cmbStyleQTY.TabIndex = 347;
            this.cmbStyleQTY.SelectionChangeCommitted += new System.EventHandler(this.cmbStyleQTY_SelectionChangeCommitted);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(236, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 346;
            this.checkBox1.Text = "Copy style as per previous";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // flowStyleName
            // 
            this.flowStyleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowStyleName.AutoScroll = true;
            this.flowStyleName.BackColor = System.Drawing.Color.White;
            this.flowStyleName.Location = new System.Drawing.Point(21, 96);
            this.flowStyleName.Name = "flowStyleName";
            this.flowStyleName.Size = new System.Drawing.Size(912, 84);
            this.flowStyleName.TabIndex = 339;
            // 
            // lnkAddItem
            // 
            this.lnkAddItem.AutoSize = true;
            this.lnkAddItem.BackColor = System.Drawing.Color.Transparent;
            this.lnkAddItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddItem.Location = new System.Drawing.Point(221, 235);
            this.lnkAddItem.Name = "lnkAddItem";
            this.lnkAddItem.Size = new System.Drawing.Size(113, 21);
            this.lnkAddItem.TabIndex = 353;
            this.lnkAddItem.TabStop = true;
            this.lnkAddItem.Text = "Body Posture";
            this.lnkAddItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddItem_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(328, 149);
            this.dataGridView1.TabIndex = 322;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // grpSKUStatus
            // 
            this.grpSKUStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSKUStatus.BackColor = System.Drawing.Color.Transparent;
            this.grpSKUStatus.Controls.Add(this.dataGridView1);
            this.grpSKUStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSKUStatus.Location = new System.Drawing.Point(869, 61);
            this.grpSKUStatus.Name = "grpSKUStatus";
            this.grpSKUStatus.Size = new System.Drawing.Size(334, 173);
            this.grpSKUStatus.TabIndex = 355;
            this.grpSKUStatus.TabStop = false;
            this.grpSKUStatus.Text = "SKU Status :";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderNo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.ForeColor = System.Drawing.Color.White;
            this.lblOrderNo.Location = new System.Drawing.Point(732, 12);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(76, 19);
            this.lblOrderNo.TabIndex = 356;
            this.lblOrderNo.Text = "OrderNo";
            // 
            // lblSKUName
            // 
            this.lblSKUName.AutoSize = true;
            this.lblSKUName.BackColor = System.Drawing.Color.Transparent;
            this.lblSKUName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKUName.ForeColor = System.Drawing.Color.White;
            this.lblSKUName.Location = new System.Drawing.Point(384, 12);
            this.lblSKUName.Name = "lblSKUName";
            this.lblSKUName.Size = new System.Drawing.Size(88, 19);
            this.lblSKUName.TabIndex = 339;
            this.lblSKUName.Text = "SKU Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Measurement & Style";
            this.label12.UseMnemonic = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(1035, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 359;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(1125, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 360;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCancel);
            this.kryptonPanel1.Controls.Add(this.lblOrderNo);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.label12);
            this.kryptonPanel1.Controls.Add(this.btnSave);
            this.kryptonPanel1.Controls.Add(this.lblSKUName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1215, 51);
            this.kryptonPanel1.TabIndex = 371;
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
            // frmViewMeasurementStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 701);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.grpSKUList);
            this.Controls.Add(this.grpMeasurement);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.lnkAddItem);
            this.Controls.Add(this.grpSKUStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmViewMeasurementStyle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement & Style";
            this.Load += new System.EventHandler(this.frmViewMeasurementStyle_Load);
            this.grpSKUList.ResumeLayout(false);
            this.grpMeasurement.ResumeLayout(false);
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpSKUStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSKUList;
        private Others.ctrlMeasurment ctrlMeasurment1;
        private System.Windows.Forms.GroupBox grpMeasurement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStichType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowStyleImage;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.ComboBox cmbStyleQTY;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowStyleName;
        private System.Windows.Forms.LinkLabel lnkAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpSKUStatus;
        private System.Windows.Forms.FlowLayoutPanel flowGarmentList;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblSKUName;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}