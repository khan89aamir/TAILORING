
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpGST = new System.Windows.Forms.GroupBox();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGSTMaster = new System.Windows.Forms.DataGridView();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.grpGST.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(774, 40);
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
            // grpGST
            // 
            this.grpGST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGST.BackColor = System.Drawing.Color.Transparent;
            this.grpGST.Controls.Add(this.txtIGST);
            this.grpGST.Controls.Add(this.label4);
            this.grpGST.Controls.Add(this.label1);
            this.grpGST.Controls.Add(this.label8);
            this.grpGST.Controls.Add(this.txtSGST);
            this.grpGST.Controls.Add(this.txtCGST);
            this.grpGST.Controls.Add(this.lblCustomerPhoneNo);
            this.grpGST.Controls.Add(this.lblCustomerName);
            this.grpGST.Enabled = false;
            this.grpGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpGST.Location = new System.Drawing.Point(16, 101);
            this.grpGST.Margin = new System.Windows.Forms.Padding(2);
            this.grpGST.Name = "grpGST";
            this.grpGST.Padding = new System.Windows.Forms.Padding(2);
            this.grpGST.Size = new System.Drawing.Size(721, 126);
            this.grpGST.TabIndex = 317;
            this.grpGST.TabStop = false;
            this.grpGST.Text = "GST Management";
            // 
            // txtIGST
            // 
            this.txtIGST.BackColor = System.Drawing.Color.White;
            this.txtIGST.Enabled = false;
            this.txtIGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(102, 78);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGST.MaxLength = 100;
            this.txtIGST.Name = "txtIGST";
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
            this.label4.Location = new System.Drawing.Point(17, 81);
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
            this.label1.Location = new System.Drawing.Point(704, 24);
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
            this.label8.Location = new System.Drawing.Point(344, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 282;
            this.label8.Text = "*";
            // 
            // txtSGST
            // 
            this.txtSGST.BackColor = System.Drawing.Color.White;
            this.txtSGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(462, 24);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtSGST.MaxLength = 10;
            this.txtSGST.Name = "txtSGST";
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
            this.txtCGST.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(102, 25);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtCGST.MaxLength = 100;
            this.txtCGST.Name = "txtCGST";
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
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(377, 28);
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
            this.lblCustomerName.Location = new System.Drawing.Point(17, 29);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "CGST :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(381, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 27);
            this.btnUpdate.TabIndex = 322;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(545, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 27);
            this.btnCancel.TabIndex = 324;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(463, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 27);
            this.btnDelete.TabIndex = 323;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(301, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 27);
            this.btnEdit.TabIndex = 321;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(219, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
            this.btnSave.TabIndex = 320;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(130, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 27);
            this.btnAdd.TabIndex = 319;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // dgvGSTMaster
            // 
            this.dgvGSTMaster.AllowUserToAddRows = false;
            this.dgvGSTMaster.AllowUserToDeleteRows = false;
            this.dgvGSTMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGSTMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvGSTMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGSTMaster.Location = new System.Drawing.Point(14, 251);
            this.dgvGSTMaster.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGSTMaster.Name = "dgvGSTMaster";
            this.dgvGSTMaster.ReadOnly = true;
            this.dgvGSTMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGSTMaster.RowTemplate.Height = 24;
            this.dgvGSTMaster.Size = new System.Drawing.Size(749, 188);
            this.dgvGSTMaster.TabIndex = 318;
            this.dgvGSTMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGSTMaster_CellDoubleClick);
            this.dgvGSTMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGSTMaster_DataBindingComplete);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(11, 445);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(121, 17);
            this.lblTotalRecords.TabIndex = 325;
            this.lblTotalRecords.Text = "Total Records : 0";
            // 
            // frmGSTMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 470);
            this.Controls.Add(this.grpGST);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGSTMaster);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmGSTMaster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Management";
            this.Load += new System.EventHandler(this.frmGSTMaster_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpGST.ResumeLayout(false);
            this.grpGST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGSTMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpGST;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGSTMaster;
        private System.Windows.Forms.Label lblTotalRecords;
    }
}