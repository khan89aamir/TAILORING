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
            this.btnStyleSave = new System.Windows.Forms.Button();
            this.flowStyleImage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSKUName = new System.Windows.Forms.Label();
            this.flowStyleName = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SKUList = new System.Windows.Forms.ListView();
            this.btnMeasureSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbStyleQTY = new System.Windows.Forms.ComboBox();
            this.ctrlMeasurment1 = new TAILORING.Others.ctrlMeasurment();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(582, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(366, 133);
            this.dataGridView1.TabIndex = 322;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 40);
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
            // btnStyleSave
            // 
            this.btnStyleSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStyleSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStyleSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyleSave.Location = new System.Drawing.Point(863, 189);
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
            this.flowStyleImage.BackColor = System.Drawing.Color.White;
            this.flowStyleImage.Location = new System.Drawing.Point(482, 329);
            this.flowStyleImage.Name = "flowStyleImage";
            this.flowStyleImage.Size = new System.Drawing.Size(521, 336);
            this.flowStyleImage.TabIndex = 338;
            // 
            // lblSKUName
            // 
            this.lblSKUName.AutoSize = true;
            this.lblSKUName.BackColor = System.Drawing.Color.Transparent;
            this.lblSKUName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKUName.Location = new System.Drawing.Point(409, 186);
            this.lblSKUName.Name = "lblSKUName";
            this.lblSKUName.Size = new System.Drawing.Size(86, 19);
            this.lblSKUName.TabIndex = 339;
            this.lblSKUName.Text = "SKU Name";
            // 
            // flowStyleName
            // 
            this.flowStyleName.BackColor = System.Drawing.Color.White;
            this.flowStyleName.Location = new System.Drawing.Point(482, 252);
            this.flowStyleName.Name = "flowStyleName";
            this.flowStyleName.Size = new System.Drawing.Size(521, 71);
            this.flowStyleName.TabIndex = 339;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 341;
            this.label1.Text = "Measurement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 342;
            this.label2.Text = "Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 361);
            this.label3.TabIndex = 343;
            this.label3.Text = "-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-\r\n-";
            // 
            // SKUList
            // 
            this.SKUList.HideSelection = false;
            this.SKUList.Location = new System.Drawing.Point(15, 49);
            this.SKUList.Name = "SKUList";
            this.SKUList.Size = new System.Drawing.Size(378, 133);
            this.SKUList.TabIndex = 344;
            this.SKUList.UseCompatibleStateImageBehavior = false;
            this.SKUList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SKUList_MouseClick);
            // 
            // btnMeasureSave
            // 
            this.btnMeasureSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeasureSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasureSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeasureSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasureSave.Location = new System.Drawing.Point(308, 189);
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
            this.checkBox1.Location = new System.Drawing.Point(678, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 346;
            this.checkBox1.Text = "Copy style as per previous";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // cmbStyleQTY
            // 
            this.cmbStyleQTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyleQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyleQTY.FormattingEnabled = true;
            this.cmbStyleQTY.Location = new System.Drawing.Point(678, 193);
            this.cmbStyleQTY.Name = "cmbStyleQTY";
            this.cmbStyleQTY.Size = new System.Drawing.Size(121, 25);
            this.cmbStyleQTY.TabIndex = 347;
            this.cmbStyleQTY.SelectionChangeCommitted += new System.EventHandler(this.cmbStyleQTY_SelectionChangeCommitted);
            // 
            // ctrlMeasurment1
            // 
            this.ctrlMeasurment1.BackColor = System.Drawing.Color.White;
            this.ctrlMeasurment1.DataSource = null;
            this.ctrlMeasurment1.Location = new System.Drawing.Point(15, 224);
            this.ctrlMeasurment1.Name = "ctrlMeasurment1";
            this.ctrlMeasurment1.ProductCount = 0;
            this.ctrlMeasurment1.Size = new System.Drawing.Size(344, 441);
            this.ctrlMeasurment1.TabIndex = 0;
            // 
            // frmMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 667);
            this.Controls.Add(this.cmbStyleQTY);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnMeasureSave);
            this.Controls.Add(this.SKUList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowStyleName);
            this.Controls.Add(this.lblSKUName);
            this.Controls.Add(this.flowStyleImage);
            this.Controls.Add(this.btnStyleSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctrlMeasurment1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView SKUList;
        private System.Windows.Forms.Button btnMeasureSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbStyleQTY;
    }
}