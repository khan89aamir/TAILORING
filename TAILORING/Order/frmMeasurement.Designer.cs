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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSKUName = new System.Windows.Forms.Label();
            this.btnStyleSave = new System.Windows.Forms.Button();
            this.flowStyleImage = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStyleName = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SKUList = new System.Windows.Forms.ListView();
            this.btnMeasureSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbStyleQTY = new System.Windows.Forms.ComboBox();
            this.grpSKUStatus = new System.Windows.Forms.GroupBox();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFitType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStichType = new System.Windows.Forms.ComboBox();
            this.grpMeasurement = new System.Windows.Forms.GroupBox();
            this.lnkAddItem = new System.Windows.Forms.LinkLabel();
            this.ctrlMeasurment1 = new TAILORING.Others.ctrlMeasurment();
            this.grpSKUList = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpSKUStatus.SuspendLayout();
            this.grpStyle.SuspendLayout();
            this.grpMeasurement.SuspendLayout();
            this.grpSKUList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(333, 147);
            this.dataGridView1.TabIndex = 322;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblSKUName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 40);
            this.panel2.TabIndex = 323;
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
            this.lblSKUName.Location = new System.Drawing.Point(650, 12);
            this.lblSKUName.Name = "lblSKUName";
            this.lblSKUName.Size = new System.Drawing.Size(88, 19);
            this.lblSKUName.TabIndex = 339;
            this.lblSKUName.Text = "SKU Name";
            // 
            // btnStyleSave
            // 
            this.btnStyleSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStyleSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStyleSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyleSave.Location = new System.Drawing.Point(393, 24);
            this.btnStyleSave.Name = "btnStyleSave";
            this.btnStyleSave.Size = new System.Drawing.Size(85, 27);
            this.btnStyleSave.TabIndex = 336;
            this.btnStyleSave.Text = "Save";
            this.btnStyleSave.UseVisualStyleBackColor = true;
            this.btnStyleSave.MouseEnter += new System.EventHandler(this.btnMeasureSave_MouseEnter);
            this.btnStyleSave.MouseLeave += new System.EventHandler(this.btnMeasureSave_MouseLeave);
            // 
            // flowStyleImage
            // 
            this.flowStyleImage.AutoScroll = true;
            this.flowStyleImage.BackColor = System.Drawing.Color.White;
            this.flowStyleImage.Location = new System.Drawing.Point(10, 203);
            this.flowStyleImage.Name = "flowStyleImage";
            this.flowStyleImage.Size = new System.Drawing.Size(520, 287);
            this.flowStyleImage.TabIndex = 338;
            // 
            // flowStyleName
            // 
            this.flowStyleName.AutoScroll = true;
            this.flowStyleName.BackColor = System.Drawing.Color.White;
            this.flowStyleName.Location = new System.Drawing.Point(10, 126);
            this.flowStyleName.Name = "flowStyleName";
            this.flowStyleName.Size = new System.Drawing.Size(521, 71);
            this.flowStyleName.TabIndex = 339;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 342;
            this.label2.Text = "Select SKU Style No.";
            // 
            // SKUList
            // 
            this.SKUList.HideSelection = false;
            this.SKUList.Location = new System.Drawing.Point(6, 21);
            this.SKUList.Name = "SKUList";
            this.SKUList.Size = new System.Drawing.Size(624, 133);
            this.SKUList.TabIndex = 344;
            this.SKUList.UseCompatibleStateImageBehavior = false;
            this.SKUList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SKUList_MouseClick);
            // 
            // btnMeasureSave
            // 
            this.btnMeasureSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeasureSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasureSave.Enabled = false;
            this.btnMeasureSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeasureSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasureSave.Location = new System.Drawing.Point(328, 29);
            this.btnMeasureSave.Name = "btnMeasureSave";
            this.btnMeasureSave.Size = new System.Drawing.Size(85, 27);
            this.btnMeasureSave.TabIndex = 345;
            this.btnMeasureSave.Text = "Save";
            this.btnMeasureSave.UseVisualStyleBackColor = true;
            this.btnMeasureSave.Click += new System.EventHandler(this.btnMeasureSave_Click);
            this.btnMeasureSave.MouseEnter += new System.EventHandler(this.btnMeasureSave_MouseEnter);
            this.btnMeasureSave.MouseLeave += new System.EventHandler(this.btnMeasureSave_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(203, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 346;
            this.checkBox1.Text = "Copy style as per previous";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbStyleQTY
            // 
            this.cmbStyleQTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyleQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyleQTY.FormattingEnabled = true;
            this.cmbStyleQTY.Location = new System.Drawing.Point(203, 22);
            this.cmbStyleQTY.Name = "cmbStyleQTY";
            this.cmbStyleQTY.Size = new System.Drawing.Size(121, 25);
            this.cmbStyleQTY.TabIndex = 347;
            this.cmbStyleQTY.SelectionChangeCommitted += new System.EventHandler(this.cmbStyleQTY_SelectionChangeCommitted);
            // 
            // grpSKUStatus
            // 
            this.grpSKUStatus.BackColor = System.Drawing.Color.Transparent;
            this.grpSKUStatus.Controls.Add(this.dataGridView1);
            this.grpSKUStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSKUStatus.Location = new System.Drawing.Point(650, 42);
            this.grpSKUStatus.Name = "grpSKUStatus";
            this.grpSKUStatus.Size = new System.Drawing.Size(353, 173);
            this.grpSKUStatus.TabIndex = 348;
            this.grpSKUStatus.TabStop = false;
            this.grpSKUStatus.Text = "SKU Status :";
            // 
            // grpStyle
            // 
            this.grpStyle.BackColor = System.Drawing.Color.Transparent;
            this.grpStyle.Controls.Add(this.label4);
            this.grpStyle.Controls.Add(this.label14);
            this.grpStyle.Controls.Add(this.label3);
            this.grpStyle.Controls.Add(this.cmbFitType);
            this.grpStyle.Controls.Add(this.label1);
            this.grpStyle.Controls.Add(this.cmbStichType);
            this.grpStyle.Controls.Add(this.label2);
            this.grpStyle.Controls.Add(this.btnStyleSave);
            this.grpStyle.Controls.Add(this.cmbStyleQTY);
            this.grpStyle.Controls.Add(this.flowStyleImage);
            this.grpStyle.Controls.Add(this.checkBox1);
            this.grpStyle.Controls.Add(this.flowStyleName);
            this.grpStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStyle.Location = new System.Drawing.Point(465, 215);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(538, 496);
            this.grpStyle.TabIndex = 349;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Style :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 95);
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
            this.cmbFitType.Location = new System.Drawing.Point(369, 91);
            this.cmbFitType.Name = "cmbFitType";
            this.cmbFitType.Size = new System.Drawing.Size(150, 25);
            this.cmbFitType.TabIndex = 351;
            this.cmbFitType.SelectionChangeCommitted += new System.EventHandler(this.cmbFitType_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 95);
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
            this.cmbStichType.Location = new System.Drawing.Point(106, 91);
            this.cmbStichType.Name = "cmbStichType";
            this.cmbStichType.Size = new System.Drawing.Size(150, 25);
            this.cmbStichType.TabIndex = 349;
            this.cmbStichType.SelectionChangeCommitted += new System.EventHandler(this.cmbStichType_SelectionChangeCommitted);
            // 
            // grpMeasurement
            // 
            this.grpMeasurement.BackColor = System.Drawing.Color.Transparent;
            this.grpMeasurement.Controls.Add(this.lnkAddItem);
            this.grpMeasurement.Controls.Add(this.btnMeasureSave);
            this.grpMeasurement.Controls.Add(this.ctrlMeasurment1);
            this.grpMeasurement.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeasurement.Location = new System.Drawing.Point(8, 211);
            this.grpMeasurement.Name = "grpMeasurement";
            this.grpMeasurement.Size = new System.Drawing.Size(440, 496);
            this.grpMeasurement.TabIndex = 350;
            this.grpMeasurement.TabStop = false;
            this.grpMeasurement.Text = "Measurement :";
            // 
            // lnkAddItem
            // 
            this.lnkAddItem.AutoSize = true;
            this.lnkAddItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddItem.Location = new System.Drawing.Point(325, 68);
            this.lnkAddItem.Name = "lnkAddItem";
            this.lnkAddItem.Size = new System.Drawing.Size(113, 21);
            this.lnkAddItem.TabIndex = 340;
            this.lnkAddItem.TabStop = true;
            this.lnkAddItem.Text = "Body Posture";
            this.lnkAddItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddItem_LinkClicked);
            // 
            // ctrlMeasurment1
            // 
            this.ctrlMeasurment1.BackColor = System.Drawing.Color.White;
            this.ctrlMeasurment1.DataSource = null;
            this.ctrlMeasurment1.Location = new System.Drawing.Point(10, 25);
            this.ctrlMeasurment1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlMeasurment1.Name = "ctrlMeasurment1";
            this.ctrlMeasurment1.ProductCount = 0;
            this.ctrlMeasurment1.Size = new System.Drawing.Size(310, 464);
            this.ctrlMeasurment1.TabIndex = 0;
            // 
            // grpSKUList
            // 
            this.grpSKUList.BackColor = System.Drawing.Color.Transparent;
            this.grpSKUList.Controls.Add(this.SKUList);
            this.grpSKUList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSKUList.Location = new System.Drawing.Point(8, 42);
            this.grpSKUList.Name = "grpSKUList";
            this.grpSKUList.Size = new System.Drawing.Size(636, 163);
            this.grpSKUList.TabIndex = 351;
            this.grpSKUList.TabStop = false;
            this.grpSKUList.Text = "Selected SKUs :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(258, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 352;
            this.label14.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(522, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 353;
            this.label4.Text = "*";
            // 
            // frmMeasurement
            // 
            this.AcceptButton = this.btnMeasureSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 701);
            this.Controls.Add(this.grpSKUList);
            this.Controls.Add(this.grpMeasurement);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.grpSKUStatus);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMeasurement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement & Style";
            this.Load += new System.EventHandler(this.frmMeasurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpSKUStatus.ResumeLayout(false);
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.grpMeasurement.ResumeLayout(false);
            this.grpMeasurement.PerformLayout();
            this.grpSKUList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Others.ctrlMeasurment ctrlMeasurment1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStyleSave;
        private System.Windows.Forms.FlowLayoutPanel flowStyleImage;
        private System.Windows.Forms.Label lblSKUName;
        private System.Windows.Forms.FlowLayoutPanel flowStyleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView SKUList;
        private System.Windows.Forms.Button btnMeasureSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbStyleQTY;
        private System.Windows.Forms.GroupBox grpSKUStatus;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.GroupBox grpMeasurement;
        private System.Windows.Forms.GroupBox grpSKUList;
        private System.Windows.Forms.LinkLabel lnkAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStichType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
    }
}