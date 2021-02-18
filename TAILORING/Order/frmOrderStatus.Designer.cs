namespace TAILORING.Order
{
    partial class frmOrderStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderStatus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadShowAll = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radOrderStatus = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radSuborder = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radOrderNo = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtSubORderNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbOrderStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCustomerOrderNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvOrderDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).BeginInit();
            this.grpCustomerGridview.Panel.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadShowAll);
            this.groupBox1.Controls.Add(this.radOrderStatus);
            this.groupBox1.Controls.Add(this.radSuborder);
            this.groupBox1.Controls.Add(this.radOrderNo);
            this.groupBox1.Controls.Add(this.txtSubORderNo);
            this.groupBox1.Controls.Add(this.cmbOrderStatus);
            this.groupBox1.Controls.Add(this.txtCustomerOrderNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter :";
            // 
            // RadShowAll
            // 
            this.RadShowAll.Checked = true;
            this.RadShowAll.Location = new System.Drawing.Point(679, 69);
            this.RadShowAll.Name = "RadShowAll";
            this.RadShowAll.Size = new System.Drawing.Size(82, 21);
            this.RadShowAll.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.RadShowAll.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadShowAll.TabIndex = 396;
            this.RadShowAll.Values.Text = "Show All";
            this.RadShowAll.CheckedChanged += new System.EventHandler(this.kryptonRadioButton4_CheckedChanged);
            // 
            // radOrderStatus
            // 
            this.radOrderStatus.Location = new System.Drawing.Point(679, 31);
            this.radOrderStatus.Name = "radOrderStatus";
            this.radOrderStatus.Size = new System.Drawing.Size(109, 21);
            this.radOrderStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.radOrderStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrderStatus.TabIndex = 395;
            this.radOrderStatus.Values.Text = "Order Status :";
            this.radOrderStatus.CheckedChanged += new System.EventHandler(this.radOrderStatus_CheckedChanged);
            // 
            // radSuborder
            // 
            this.radSuborder.Location = new System.Drawing.Point(324, 31);
            this.radSuborder.Name = "radSuborder";
            this.radSuborder.Size = new System.Drawing.Size(118, 21);
            this.radSuborder.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.radSuborder.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSuborder.TabIndex = 394;
            this.radSuborder.Values.Text = "Sub Order No :";
            this.radSuborder.CheckedChanged += new System.EventHandler(this.radSuborder_CheckedChanged);
            // 
            // radOrderNo
            // 
            this.radOrderNo.Location = new System.Drawing.Point(6, 31);
            this.radOrderNo.Name = "radOrderNo";
            this.radOrderNo.Size = new System.Drawing.Size(90, 21);
            this.radOrderNo.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.radOrderNo.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrderNo.TabIndex = 393;
            this.radOrderNo.Values.Text = "Order No :";
            this.radOrderNo.CheckedChanged += new System.EventHandler(this.radOrderNo_CheckedChanged);
            // 
            // txtSubORderNo
            // 
            this.txtSubORderNo.Enabled = false;
            this.txtSubORderNo.Location = new System.Drawing.Point(448, 24);
            this.txtSubORderNo.Name = "txtSubORderNo";
            this.txtSubORderNo.Size = new System.Drawing.Size(213, 31);
            this.txtSubORderNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSubORderNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtSubORderNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSubORderNo.StateCommon.Border.Rounding = 10;
            this.txtSubORderNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubORderNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSubORderNo.StateNormal.Border.Rounding = 20;
            this.txtSubORderNo.TabIndex = 392;
            this.txtSubORderNo.TextChanged += new System.EventHandler(this.txtSubORderNo_TextChanged);
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderStatus.DropDownWidth = 209;
            this.cmbOrderStatus.Enabled = false;
            this.cmbOrderStatus.Location = new System.Drawing.Point(794, 25);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cmbOrderStatus.Size = new System.Drawing.Size(213, 27);
            this.cmbOrderStatus.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbOrderStatus.StateCommon.ComboBox.Border.Rounding = 7;
            this.cmbOrderStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderStatus.TabIndex = 391;
            this.cmbOrderStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbOrderStatus_SelectionChangeCommitted);
            // 
            // txtCustomerOrderNo
            // 
            this.txtCustomerOrderNo.Enabled = false;
            this.txtCustomerOrderNo.Location = new System.Drawing.Point(96, 26);
            this.txtCustomerOrderNo.Name = "txtCustomerOrderNo";
            this.txtCustomerOrderNo.Size = new System.Drawing.Size(213, 31);
            this.txtCustomerOrderNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCustomerOrderNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCustomerOrderNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerOrderNo.StateCommon.Border.Rounding = 10;
            this.txtCustomerOrderNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerOrderNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerOrderNo.StateNormal.Border.Rounding = 20;
            this.txtCustomerOrderNo.TabIndex = 386;
            this.txtCustomerOrderNo.TextChanged += new System.EventHandler(this.txtCustomerOrderNo_TextChanged);
            // 
            // grpCustomerGridview
            // 
            this.grpCustomerGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerGridview.Location = new System.Drawing.Point(7, 104);
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            this.grpCustomerGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvOrderDetails);
            this.grpCustomerGridview.Size = new System.Drawing.Size(1100, 400);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpCustomerGridview.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpCustomerGridview.StateCommon.Border.Rounding = 10;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.TabIndex = 332;
            this.grpCustomerGridview.ValuesPrimary.Heading = "Order Status";
            this.grpCustomerGridview.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpCustomerGridview.ValuesPrimary.Image")));
            this.grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.Size = new System.Drawing.Size(1098, 350);
            this.dgvOrderDetails.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dgvOrderDetails.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvOrderDetails.TabIndex = 0;
            this.dgvOrderDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderDetails_DataBindingComplete);
            // 
            // frmOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1112, 516);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmOrderStatus";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Order Status";
            this.Load += new System.EventHandler(this.frmOrderStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).EndInit();
            this.grpCustomerGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).EndInit();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RadShowAll;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radOrderStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radSuborder;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radOrderNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubORderNo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbOrderStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerOrderNo;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOrderDetails;
    }
}