
namespace TAILORING.Order
{
    partial class frmOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderList));
            this.label12 = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.txtCustomerOrderNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.radByOrderNo = new System.Windows.Forms.RadioButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.radByCustomerMobileNo = new System.Windows.Forms.RadioButton();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.radByCustomerName = new System.Windows.Forms.RadioButton();
            this.radByDate = new System.Windows.Forms.RadioButton();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvOrderDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).BeginInit();
            this.grpCustomerGridview.Panel.SuspendLayout();
            this.grpCustomerGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // kryptonHeaderGroup1
            // 
            resources.ApplyResources(this.kryptonHeaderGroup1, "kryptonHeaderGroup1");
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup1.ValuesPrimary.Heading");
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCustomerOrderNo);
            this.groupBox1.Controls.Add(this.txtCustomerMobileNo);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.radByOrderNo);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.radByCustomerMobileNo);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.radByCustomerName);
            this.groupBox1.Controls.Add(this.radByDate);
            this.groupBox1.Controls.Add(this.rdShowAll);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.GlowAmount = 22;
            this.groupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox1.GlowFeather = 60;
            this.groupBox1.GlowOn = true;
            this.groupBox1.Name = "groupBox1";
            // 
            // txtCustomerOrderNo
            // 
            resources.ApplyResources(this.txtCustomerOrderNo, "txtCustomerOrderNo");
            this.txtCustomerOrderNo.Name = "txtCustomerOrderNo";
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
            this.txtCustomerOrderNo.TextChanged += new System.EventHandler(this.txtCustomerOrderNo_TextChanged);
            // 
            // txtCustomerMobileNo
            // 
            resources.ApplyResources(this.txtCustomerMobileNo, "txtCustomerMobileNo");
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.ShortcutsEnabled = false;
            this.txtCustomerMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCustomerMobileNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtCustomerMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateCommon.Border.Rounding = 10;
            this.txtCustomerMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMobileNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerMobileNo.StateNormal.Border.Rounding = 20;
            this.txtCustomerMobileNo.TextChanged += new System.EventHandler(this.txtCustomerMobileNo_TextChanged);
            this.txtCustomerMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_Control_KeyPress);
            // 
            // txtCustomerName
            // 
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ShortcutsEnabled = false;
            this.txtCustomerName.StateCommon.Back.Color1 = System.Drawing.Color.White;
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
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // radByOrderNo
            // 
            resources.ApplyResources(this.radByOrderNo, "radByOrderNo");
            this.groupBox1.SetEffectType(this.radByOrderNo, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.radByOrderNo.ForeColor = System.Drawing.Color.White;
            this.radByOrderNo.Name = "radByOrderNo";
            this.groupBox1.SetsGlowColor(this.radByOrderNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByOrderNo.sGlowColor"))));
            this.groupBox1.SetUseEffect(this.radByOrderNo, false);
            this.radByOrderNo.UseVisualStyleBackColor = true;
            this.radByOrderNo.CheckedChanged += new System.EventHandler(this.radByOrderNo_CheckedChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.groupBox1.SetEffectType(this.txtCustomerID, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtCustomerID, "txtCustomerID");
            this.txtCustomerID.Name = "txtCustomerID";
            this.groupBox1.SetsGlowColor(this.txtCustomerID, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCustomerID.sGlowColor"))));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // dtpToDate
            // 
            this.groupBox1.SetEffectType(this.dtpToDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dtpToDate, "dtpToDate");
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.groupBox1.SetsGlowColor(this.dtpToDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpToDate.sGlowColor"))));
            this.dtpToDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpToDate.StateCommon.Border.Rounding = 7;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // radByCustomerMobileNo
            // 
            resources.ApplyResources(this.radByCustomerMobileNo, "radByCustomerMobileNo");
            this.groupBox1.SetEffectType(this.radByCustomerMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.radByCustomerMobileNo.ForeColor = System.Drawing.Color.White;
            this.radByCustomerMobileNo.Name = "radByCustomerMobileNo";
            this.groupBox1.SetsGlowColor(this.radByCustomerMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByCustomerMobileNo.sGlowColor"))));
            this.groupBox1.SetUseEffect(this.radByCustomerMobileNo, false);
            this.radByCustomerMobileNo.UseVisualStyleBackColor = true;
            this.radByCustomerMobileNo.CheckedChanged += new System.EventHandler(this.radByCustomerMobileNo_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.groupBox1.SetEffectType(this.dtpFromDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dtpFromDate, "dtpFromDate");
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.groupBox1.SetsGlowColor(this.dtpFromDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpFromDate.sGlowColor"))));
            this.dtpFromDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpFromDate.StateCommon.Border.Rounding = 7;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // radByCustomerName
            // 
            resources.ApplyResources(this.radByCustomerName, "radByCustomerName");
            this.groupBox1.SetEffectType(this.radByCustomerName, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.radByCustomerName.ForeColor = System.Drawing.Color.White;
            this.radByCustomerName.Name = "radByCustomerName";
            this.groupBox1.SetsGlowColor(this.radByCustomerName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByCustomerName.sGlowColor"))));
            this.groupBox1.SetUseEffect(this.radByCustomerName, false);
            this.radByCustomerName.UseVisualStyleBackColor = true;
            this.radByCustomerName.CheckedChanged += new System.EventHandler(this.radByCustomerName_CheckedChanged);
            // 
            // radByDate
            // 
            resources.ApplyResources(this.radByDate, "radByDate");
            this.radByDate.Checked = true;
            this.groupBox1.SetEffectType(this.radByDate, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.radByDate.ForeColor = System.Drawing.Color.White;
            this.radByDate.Name = "radByDate";
            this.groupBox1.SetsGlowColor(this.radByDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByDate.sGlowColor"))));
            this.radByDate.TabStop = true;
            this.groupBox1.SetUseEffect(this.radByDate, false);
            this.radByDate.UseVisualStyleBackColor = true;
            this.radByDate.CheckedChanged += new System.EventHandler(this.radByDate_CheckedChanged);
            // 
            // rdShowAll
            // 
            resources.ApplyResources(this.rdShowAll, "rdShowAll");
            this.groupBox1.SetEffectType(this.rdShowAll, gGlowBox.gGlowGroupBox.eEffectType.Shadow);
            this.rdShowAll.ForeColor = System.Drawing.Color.White;
            this.rdShowAll.Name = "rdShowAll";
            this.groupBox1.SetsGlowColor(this.rdShowAll, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAll.sGlowColor"))));
            this.groupBox1.SetUseEffect(this.rdShowAll, false);
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.rdShowAll_CheckedChanged);
            // 
            // grpCustomerGridview
            // 
            resources.ApplyResources(this.grpCustomerGridview, "grpCustomerGridview");
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            this.grpCustomerGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvOrderDetails);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpCustomerGridview.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpCustomerGridview.StateCommon.Border.Rounding = 10;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.ValuesPrimary.Heading = resources.GetString("grpCustomerGridview.ValuesPrimary.Heading");
            this.grpCustomerGridview.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.grpCustomerGridview.ValuesSecondary.Heading = resources.GetString("grpCustomerGridview.ValuesSecondary.Heading");
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvOrderDetails, "dgvOrderDetails");
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dgvOrderDetails.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            this.dgvOrderDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderDetails_DataBindingComplete);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.label12);
            resources.ApplyResources(this.kryptonPanel1, "kryptonPanel1");
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TAILORING.Properties.Resources.orderdetailswhite;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmOrderList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderList";
            this.ShowIcon = false;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview.Panel)).EndInit();
            this.grpCustomerGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerGridview)).EndInit();
            this.grpCustomerGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox groupBox1;
        private System.Windows.Forms.RadioButton radByOrderNo;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private System.Windows.Forms.RadioButton radByCustomerMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton radByCustomerName;
        private System.Windows.Forms.RadioButton radByDate;
        private System.Windows.Forms.RadioButton rdShowAll;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOrderDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerOrderNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}