namespace TAILORING.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label8 = new System.Windows.Forms.Label();
            this.txtImagePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBrowseImage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBrowseGeneric = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtGenericImage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grpCustomer = new gGlowBox.gGlowGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Image Path :";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(193, 7);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(387, 31);
            this.txtImagePath.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtImagePath.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtImagePath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtImagePath.StateCommon.Border.Rounding = 10;
            this.txtImagePath.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtImagePath.StateNormal.Border.Rounding = 20;
            this.txtImagePath.TabIndex = 0;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpCustomer.SetEffectType(this.btnBrowseImage, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnBrowseImage.Location = new System.Drawing.Point(610, 7);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.grpCustomer.SetsGlowColor(this.btnBrowseImage, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnBrowseImage.sGlowColor"))));
            this.btnBrowseImage.Size = new System.Drawing.Size(89, 31);
            this.btnBrowseImage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseImage.StateCommon.Border.Rounding = 7;
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Values.Image = global::TAILORING.Properties.Resources.checkSqure;
            this.btnBrowseImage.Values.Text = "Browse...";
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 385;
            this.label1.Text = "Copy Order Month Limit :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.numericUpDown1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numericUpDown1.StateCommon.Border.Rounding = 10;
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(566, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 7;
            this.btnSave.TabIndex = 2;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(661, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnCancel.Size = new System.Drawing.Size(89, 31);
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 7;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowseGeneric
            // 
            this.btnBrowseGeneric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpCustomer.SetEffectType(this.btnBrowseGeneric, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnBrowseGeneric.Location = new System.Drawing.Point(610, 47);
            this.btnBrowseGeneric.Name = "btnBrowseGeneric";
            this.btnBrowseGeneric.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.grpCustomer.SetsGlowColor(this.btnBrowseGeneric, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnBrowseGeneric.sGlowColor"))));
            this.btnBrowseGeneric.Size = new System.Drawing.Size(89, 31);
            this.btnBrowseGeneric.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowseGeneric.StateCommon.Border.Rounding = 7;
            this.btnBrowseGeneric.TabIndex = 3;
            this.btnBrowseGeneric.Values.Image = global::TAILORING.Properties.Resources.checkSqure;
            this.btnBrowseGeneric.Values.Text = "Browse...";
            this.btnBrowseGeneric.Click += new System.EventHandler(this.btnBrowseGeneric_Click);
            // 
            // txtGenericImage
            // 
            this.txtGenericImage.Location = new System.Drawing.Point(193, 47);
            this.txtGenericImage.Name = "txtGenericImage";
            this.txtGenericImage.ReadOnly = true;
            this.txtGenericImage.Size = new System.Drawing.Size(387, 31);
            this.txtGenericImage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtGenericImage.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtGenericImage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGenericImage.StateCommon.Border.Rounding = 10;
            this.txtGenericImage.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenericImage.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGenericImage.StateNormal.Border.Rounding = 20;
            this.txtGenericImage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 389;
            this.label2.Text = "Generic Image Path :";
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(12, 21);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            this.kryptonHeaderGroup3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(737, 128);
            this.kryptonHeaderGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup3.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.TabIndex = 0;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Images";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = null;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.grpCustomer);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(729, 98);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.btnBrowseGeneric);
            this.grpCustomer.Controls.Add(this.txtImagePath);
            this.grpCustomer.Controls.Add(this.txtGenericImage);
            this.grpCustomer.Controls.Add(this.btnBrowseImage);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.GlowAmount = 20;
            this.grpCustomer.GlowColorDefault = System.Drawing.Color.White;
            this.grpCustomer.GlowFeather = 70;
            this.grpCustomer.GlowOn = true;
            this.grpCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(729, 98);
            this.grpCustomer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(585, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 392;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 393;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 394;
            this.label5.Text = "*";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(768, 225);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Text = "Software Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtImagePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowseImage;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numericUpDown1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowseGeneric;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGenericImage;
        private System.Windows.Forms.Label label2;
        private gGlowBox.gGlowGroupBox grpCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}