
namespace TAILORING.Masters
{
    partial class frmGSTMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGSTMaster));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpGST = new gGlowBox.gGlowGroupBox();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvGSTMaster = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.grpGST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGSTMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg_green;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 40);
            this.panel2.TabIndex = 316;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "GST Management";
            // 
            // txtIGST
            // 
            this.txtIGST.BackColor = System.Drawing.Color.White;
            this.grpGST.SetEffectType(this.txtIGST, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtIGST.Enabled = false;
            this.txtIGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(113, 68);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGST.MaxLength = 100;
            this.txtIGST.Name = "txtIGST";
            this.grpGST.SetsGlowColor(this.txtIGST, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtIGST.sGlowColor"))));
            this.txtIGST.Size = new System.Drawing.Size(240, 25);
            this.txtIGST.TabIndex = 2;
            this.txtIGST.Enter += new System.EventHandler(this.txtCGST_Enter);
            this.txtIGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCGST_KeyPress);
            this.txtIGST.Leave += new System.EventHandler(this.txtCGST_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(28, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 286;
            this.label4.Text = "IGST :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(715, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 283;
            this.label1.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(355, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 282;
            this.label8.Text = "*";
            // 
            // txtSGST
            // 
            this.txtSGST.BackColor = System.Drawing.Color.White;
            this.grpGST.SetEffectType(this.txtSGST, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtSGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(473, 14);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtSGST.MaxLength = 10;
            this.txtSGST.Name = "txtSGST";
            this.grpGST.SetsGlowColor(this.txtSGST, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtSGST.sGlowColor"))));
            this.txtSGST.Size = new System.Drawing.Size(240, 25);
            this.txtSGST.TabIndex = 1;
            this.txtSGST.TextChanged += new System.EventHandler(this.txtCGST_TextChanged);
            this.txtSGST.Enter += new System.EventHandler(this.txtCGST_Enter);
            this.txtSGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCGST_KeyPress);
            this.txtSGST.Leave += new System.EventHandler(this.txtCGST_Leave);
            // 
            // txtCGST
            // 
            this.txtCGST.BackColor = System.Drawing.Color.White;
            this.grpGST.SetEffectType(this.txtCGST, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.txtCGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(113, 15);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtCGST.MaxLength = 100;
            this.txtCGST.Name = "txtCGST";
            this.grpGST.SetsGlowColor(this.txtCGST, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtCGST.sGlowColor"))));
            this.txtCGST.Size = new System.Drawing.Size(240, 25);
            this.txtCGST.TabIndex = 0;
            this.txtCGST.TextChanged += new System.EventHandler(this.txtCGST_TextChanged);
            this.txtCGST.Enter += new System.EventHandler(this.txtCGST_Enter);
            this.txtCGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCGST_KeyPress);
            this.txtCGST.Leave += new System.EventHandler(this.txtCGST_Leave);
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(388, 18);
            this.lblCustomerPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            this.lblCustomerPhoneNo.Size = new System.Drawing.Size(50, 17);
            this.lblCustomerPhoneNo.TabIndex = 2;
            this.lblCustomerPhoneNo.Text = "SGST :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(28, 19);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "CGST :";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(598, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 298;
            this.btnCancel.Values.Image = global::TAILORING.Properties.Resources.btnCancel_Values_Image;
            this.btnCancel.Values.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(503, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 297;
            this.btnDelete.Values.Image = global::TAILORING.Properties.Resources.btnDelete_Values_Image;
            this.btnDelete.Values.Text = " Delete ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(408, 49);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.TabIndex = 296;
            this.btnUpdate.Values.Image = global::TAILORING.Properties.Resources.btnUpdate_Values_Image;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(313, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(78, 34);
            this.btnEdit.TabIndex = 295;
            this.btnEdit.Values.Image = global::TAILORING.Properties.Resources.btnEdit_Values_Image;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(218, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.TabIndex = 294;
            this.btnSave.Values.Image = global::TAILORING.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(123, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(78, 34);
            this.btnAdd.TabIndex = 293;
            this.btnAdd.Values.Image = global::TAILORING.Properties.Resources.btnAdd_Values_Image;
            this.btnAdd.Values.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Location = new System.Drawing.Point(7, 96);
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.grpGST);
            this.grpKrytonHeader.Size = new System.Drawing.Size(757, 146);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.TabIndex = 326;
            this.grpKrytonHeader.ValuesPrimary.Heading = "GST Details";
            this.grpKrytonHeader.ValuesPrimary.Image = null;
            // 
            // grpGST
            // 
            this.grpGST.BackColor = System.Drawing.Color.Transparent;
            this.grpGST.Controls.Add(this.txtIGST);
            this.grpGST.Controls.Add(this.txtSGST);
            this.grpGST.Controls.Add(this.label4);
            this.grpGST.Controls.Add(this.lblCustomerName);
            this.grpGST.Controls.Add(this.label1);
            this.grpGST.Controls.Add(this.lblCustomerPhoneNo);
            this.grpGST.Controls.Add(this.label8);
            this.grpGST.Controls.Add(this.txtCGST);
            this.grpGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGST.Enabled = false;
            this.grpGST.GlowAmount = 22;
            this.grpGST.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpGST.GlowFeather = 60;
            this.grpGST.GlowOn = true;
            this.grpGST.Location = new System.Drawing.Point(0, 0);
            this.grpGST.Name = "grpGST";
            this.grpGST.Size = new System.Drawing.Size(755, 121);
            this.grpGST.TabIndex = 287;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(7, 247);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dgvGSTMaster);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(758, 233);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderSecondary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.TabIndex = 327;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "GST Details";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::TAILORING.Properties.Resources.Gridview_ValuesPrimary_Image;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Total Records : 0";
            // 
            // dgvGSTMaster
            // 
            this.dgvGSTMaster.AllowUserToAddRows = false;
            this.dgvGSTMaster.AllowUserToDeleteRows = false;
            this.dgvGSTMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGSTMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGSTMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvGSTMaster.Name = "dgvGSTMaster";
            this.dgvGSTMaster.ReadOnly = true;
            this.dgvGSTMaster.Size = new System.Drawing.Size(756, 187);
            this.dgvGSTMaster.TabIndex = 0;
            this.dgvGSTMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGSTMaster_CellDoubleClick);
            this.dgvGSTMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGSTMaster_DataBindingComplete);
            // 
            // frmGSTMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmGSTMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Management";
            this.Load += new System.EventHandler(this.frmGSTMaster_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.grpGST.ResumeLayout(false);
            this.grpGST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGSTMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private gGlowBox.gGlowGroupBox grpGST;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvGSTMaster;
    }
}