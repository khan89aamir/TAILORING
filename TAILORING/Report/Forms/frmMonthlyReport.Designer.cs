namespace TAILORING.Report.Forms
{
    partial class frmMonthlyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlyReport));
            this.dtpFromDate1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpReportFilter = new gGlowBox.gGlowGroupBox();
            this.grpGridview = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnDownloadXLSX = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.grpReportFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).BeginInit();
            this.grpGridview.Panel.SuspendLayout();
            this.grpGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate1
            // 
            this.dtpFromDate1.CustomFormat = "dd-MMM-yyyy";
            this.grpReportFilter.SetEffectType(this.dtpFromDate1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dtpFromDate1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dtpFromDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate1.Location = new System.Drawing.Point(89, 12);
            this.dtpFromDate1.Name = "dtpFromDate1";
            this.dtpFromDate1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.grpReportFilter.SetsGlowColor(this.dtpFromDate1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpFromDate1.sGlowColor"))));
            this.dtpFromDate1.ShowUpDown = true;
            this.dtpFromDate1.Size = new System.Drawing.Size(116, 27);
            this.dtpFromDate1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpFromDate1.StateCommon.Border.Rounding = 7;
            this.dtpFromDate1.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate1.TabIndex = 390;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpReportFilter.SetEffectType(this.btnGenerate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnGenerate.Location = new System.Drawing.Point(233, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.grpReportFilter.SetsGlowColor(this.btnGenerate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnGenerate.sGlowColor"))));
            this.btnGenerate.Size = new System.Drawing.Size(165, 34);
            this.btnGenerate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerate.StateCommon.Border.Rounding = 12;
            this.btnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.TabIndex = 389;
            this.btnGenerate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnGenerate.Values.Text = "Generate Report";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 388;
            this.label3.Text = "Date  :";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(5, 12);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.grpReportFilter);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(919, 85);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 392;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Report Filter";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::TAILORING.Properties.Resources.orderdetails;
            // 
            // grpReportFilter
            // 
            this.grpReportFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpReportFilter.Controls.Add(this.dtpFromDate1);
            this.grpReportFilter.Controls.Add(this.label3);
            this.grpReportFilter.Controls.Add(this.btnGenerate);
            this.grpReportFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReportFilter.GlowAmount = 22;
            this.grpReportFilter.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpReportFilter.GlowFeather = 60;
            this.grpReportFilter.GlowOn = true;
            this.grpReportFilter.Location = new System.Drawing.Point(0, 0);
            this.grpReportFilter.Name = "grpReportFilter";
            this.grpReportFilter.Size = new System.Drawing.Size(911, 55);
            this.grpReportFilter.TabIndex = 287;
            // 
            // grpGridview
            // 
            this.grpGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGridview.Location = new System.Drawing.Point(6, 152);
            this.grpGridview.Name = "grpGridview";
            this.grpGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            // 
            // grpGridview.Panel
            // 
            this.grpGridview.Panel.Controls.Add(this.dataGridView1);
            this.grpGridview.Size = new System.Drawing.Size(919, 415);
            this.grpGridview.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpGridview.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpGridview.StateCommon.Border.Rounding = 10;
            this.grpGridview.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGridview.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpGridview.TabIndex = 393;
            this.grpGridview.ValuesPrimary.Heading = "Monthly Report";
            this.grpGridview.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpGridview.ValuesPrimary.Image")));
            this.grpGridview.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(917, 365);
            this.dataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btnDownloadXLSX
            // 
            this.btnDownloadXLSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadXLSX.AutoSize = true;
            this.btnDownloadXLSX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadXLSX.Location = new System.Drawing.Point(756, 112);
            this.btnDownloadXLSX.Name = "btnDownloadXLSX";
            this.btnDownloadXLSX.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnDownloadXLSX.Size = new System.Drawing.Size(165, 34);
            this.btnDownloadXLSX.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDownloadXLSX.StateCommon.Border.Rounding = 12;
            this.btnDownloadXLSX.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadXLSX.TabIndex = 391;
            this.btnDownloadXLSX.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.btnDownloadXLSX.Values.Text = "Download XLSX";
            this.btnDownloadXLSX.Click += new System.EventHandler(this.btnDownloadXLSX_Click);
            // 
            // frmMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(932, 579);
            this.Controls.Add(this.btnDownloadXLSX);
            this.Controls.Add(this.grpGridview);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMonthlyReport";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Monthly Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonthlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.grpReportFilter.ResumeLayout(false);
            this.grpReportFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview.Panel)).EndInit();
            this.grpGridview.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGridview)).EndInit();
            this.grpGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerate;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate1;
        private gGlowBox.gGlowGroupBox grpReportFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDownloadXLSX;
    }
}