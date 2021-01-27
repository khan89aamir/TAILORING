namespace TAILORING.Dashboard
{
    partial class frmCreateChalan
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.dgvOrderDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).BeginInit();
            this.grpCustomerGridview.Panel.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
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
            this.kryptonPanel1.Size = new System.Drawing.Size(954, 51);
            this.kryptonPanel1.TabIndex = 372;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TAILORING.Properties.Resources.orderdetailswhite;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 364;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(60, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Create Chalan";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 21);
            this.radioButton1.TabIndex = 374;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In Process Orders";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(564, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 21);
            this.radioButton2.TabIndex = 375;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Scan Order No :";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(702, 62);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(213, 31);
            this.txtCustomerName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.txtCustomerName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCustomerName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateCommon.Border.Rounding = 10;
            this.txtCustomerName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateNormal.Border.Rounding = 20;
            this.txtCustomerName.TabIndex = 381;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(868, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 383;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(729, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnAdd.Size = new System.Drawing.Size(127, 34);
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 382;
            this.btnAdd.Values.Image = global::TAILORING.Properties.Resources.checkSqure;
            this.btnAdd.Values.Text = "Create Chalan";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpCustomerGridview
            // 
            this.grpCustomerGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerGridview.Location = new System.Drawing.Point(0, 101);
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            this.grpCustomerGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.chkAll);
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvOrderDetails);
            this.grpCustomerGridview.Size = new System.Drawing.Size(954, 362);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.TabIndex = 384;
            this.grpCustomerGridview.ValuesPrimary.Heading = "Order Details";
            this.grpCustomerGridview.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(72, 4);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(15, 14);
            this.chkAll.TabIndex = 2;
            this.chkAll.UseVisualStyleBackColor = false;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToOrderColumns = true;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck});
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(952, 312);
            this.dgvOrderDetails.TabIndex = 0;
            this.dgvOrderDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderDetails_DataBindingComplete);
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 40;
            // 
            // frmCreateChalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(954, 498);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.kryptonPanel1);
            this.MaximizeBox = false;
            this.Name = "frmCreateChalan";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Chalan";
            this.Load += new System.EventHandler(this.frmCreateChalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).EndInit();
            this.grpCustomerGridview.Panel.ResumeLayout(false);
            this.grpCustomerGridview.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).EndInit();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private System.Windows.Forms.CheckBox chkAll;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOrderDetails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
    }
}