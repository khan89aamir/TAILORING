
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.txtCustomerOrderNo = new System.Windows.Forms.TextBox();
            this.radByOrderNo = new System.Windows.Forms.RadioButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.radByCustomerMobileNo = new System.Windows.Forms.RadioButton();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.radByCustomerName = new System.Windows.Forms.RadioButton();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.radByDate = new System.Windows.Forms.RadioButton();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.grpCustomerGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvOrderDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg_green;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label12);
            this.panel2.Name = "panel2";
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
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup1.ValuesPrimary.Heading");
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCustomerOrderNo);
            this.groupBox1.Controls.Add(this.radByOrderNo);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.txtCustomerMobileNo);
            this.groupBox1.Controls.Add(this.radByCustomerMobileNo);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.radByCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerName);
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
            this.txtCustomerOrderNo.BackColor = System.Drawing.Color.White;
            this.groupBox1.SetEffectType(this.txtCustomerOrderNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtCustomerOrderNo, "txtCustomerOrderNo");
            this.txtCustomerOrderNo.Name = "txtCustomerOrderNo";
            this.groupBox1.SetsGlowColor(this.txtCustomerOrderNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCustomerOrderNo.sGlowColor"))));
            // 
            // radByOrderNo
            // 
            resources.ApplyResources(this.radByOrderNo, "radByOrderNo");
            this.groupBox1.SetEffectType(this.radByOrderNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.radByOrderNo.Name = "radByOrderNo";
            this.groupBox1.SetsGlowColor(this.radByOrderNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByOrderNo.sGlowColor"))));
            this.radByOrderNo.UseVisualStyleBackColor = true;
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
            this.label1.Name = "label1";
            // 
            // dtpToDate
            // 
            this.groupBox1.SetEffectType(this.dtpToDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dtpToDate, "dtpToDate");
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Name = "dtpToDate";
            this.groupBox1.SetsGlowColor(this.dtpToDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpToDate.sGlowColor"))));
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.BackColor = System.Drawing.Color.White;
            this.groupBox1.SetEffectType(this.txtCustomerMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtCustomerMobileNo, "txtCustomerMobileNo");
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.groupBox1.SetsGlowColor(this.txtCustomerMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCustomerMobileNo.sGlowColor"))));
            this.txtCustomerMobileNo.TextChanged += new System.EventHandler(this.txtCustomerMobileNo_TextChanged);
            this.txtCustomerMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_Control_KeyPress);
            // 
            // radByCustomerMobileNo
            // 
            resources.ApplyResources(this.radByCustomerMobileNo, "radByCustomerMobileNo");
            this.groupBox1.SetEffectType(this.radByCustomerMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.radByCustomerMobileNo.Name = "radByCustomerMobileNo";
            this.groupBox1.SetsGlowColor(this.radByCustomerMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByCustomerMobileNo.sGlowColor"))));
            this.radByCustomerMobileNo.UseVisualStyleBackColor = true;
            this.radByCustomerMobileNo.CheckedChanged += new System.EventHandler(this.radByCustomerMobileNo_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.groupBox1.SetEffectType(this.dtpFromDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dtpFromDate, "dtpFromDate");
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Name = "dtpFromDate";
            this.groupBox1.SetsGlowColor(this.dtpFromDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpFromDate.sGlowColor"))));
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // radByCustomerName
            // 
            resources.ApplyResources(this.radByCustomerName, "radByCustomerName");
            this.groupBox1.SetEffectType(this.radByCustomerName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.radByCustomerName.Name = "radByCustomerName";
            this.groupBox1.SetsGlowColor(this.radByCustomerName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByCustomerName.sGlowColor"))));
            this.radByCustomerName.UseVisualStyleBackColor = true;
            this.radByCustomerName.CheckedChanged += new System.EventHandler(this.radByCustomerName_CheckedChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.groupBox1.SetEffectType(this.txtCustomerName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.Name = "txtCustomerName";
            this.groupBox1.SetsGlowColor(this.txtCustomerName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCustomerName.sGlowColor"))));
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // radByDate
            // 
            resources.ApplyResources(this.radByDate, "radByDate");
            this.radByDate.Checked = true;
            this.groupBox1.SetEffectType(this.radByDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.radByDate.Name = "radByDate";
            this.groupBox1.SetsGlowColor(this.radByDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("radByDate.sGlowColor"))));
            this.radByDate.TabStop = true;
            this.radByDate.UseVisualStyleBackColor = true;
            this.radByDate.CheckedChanged += new System.EventHandler(this.radByDate_CheckedChanged);
            // 
            // rdShowAll
            // 
            resources.ApplyResources(this.rdShowAll, "rdShowAll");
            this.groupBox1.SetEffectType(this.rdShowAll, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdShowAll.Name = "rdShowAll";
            this.groupBox1.SetsGlowColor(this.rdShowAll, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAll.sGlowColor"))));
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.rdShowAll_CheckedChanged);
            // 
            // grpCustomerGridview
            // 
            resources.ApplyResources(this.grpCustomerGridview, "grpCustomerGridview");
            this.grpCustomerGridview.Name = "grpCustomerGridview";
            // 
            // grpCustomerGridview.Panel
            // 
            this.grpCustomerGridview.Panel.Controls.Add(this.dgvOrderDetails);
            this.grpCustomerGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.grpCustomerGridview.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpCustomerGridview.StateCommon.HeaderSecondary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            this.dgvOrderDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderDetails_DataBindingComplete);
            // 
            // frmOrderList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.Controls.Add(this.grpCustomerGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderList";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox groupBox1;
        private System.Windows.Forms.RadioButton radByOrderNo;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.RadioButton radByCustomerMobileNo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton radByCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.RadioButton radByDate;
        private System.Windows.Forms.RadioButton rdShowAll;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpCustomerGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOrderDetails;
        public System.Windows.Forms.TextBox txtCustomerOrderNo;
    }
}