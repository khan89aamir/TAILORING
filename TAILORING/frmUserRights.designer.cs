namespace TAILORING
{
    partial class frmUserRights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRights));
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUserRIghts = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.FormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUserGridview = new System.Windows.Forms.GroupBox();
            this.dgvUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.grpRights = new System.Windows.Forms.GroupBox();
            this.grpUserName = new System.Windows.Forms.GroupBox();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRIghts)).BeginInit();
            this.grpUserGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.grpRights.SuspendLayout();
            this.grpUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "User Rights";
            // 
            // dgvUserRIghts
            // 
            this.dgvUserRIghts.AllowUserToAddRows = false;
            this.dgvUserRIghts.AllowUserToDeleteRows = false;
            this.dgvUserRIghts.AllowUserToResizeRows = false;
            this.dgvUserRIghts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserRIghts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRIghts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormID,
            this.FormName,
            this.View,
            this.Save,
            this.Update,
            this.Delete,
            this.Other,
            this.ParentID});
            this.dgvUserRIghts.Location = new System.Drawing.Point(6, 20);
            this.dgvUserRIghts.MultiSelect = false;
            this.dgvUserRIghts.Name = "dgvUserRIghts";
            this.dgvUserRIghts.RowHeadersVisible = false;
            this.dgvUserRIghts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUserRIghts.Size = new System.Drawing.Size(601, 443);
            this.dgvUserRIghts.TabIndex = 192;
            this.dgvUserRIghts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRIghts_CellContentClick);
            this.dgvUserRIghts.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUserRIghts_CurrentCellDirtyStateChanged);
            this.dgvUserRIghts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // FormID
            // 
            this.FormID.DataPropertyName = "FormID";
            this.FormID.HeaderText = "FormID";
            this.FormID.Name = "FormID";
            this.FormID.Visible = false;
            // 
            // FormName
            // 
            this.FormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormName.DataPropertyName = "FormName";
            this.FormName.HeaderText = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ReadOnly = true;
            // 
            // View
            // 
            this.View.DataPropertyName = "View";
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Width = 60;
            // 
            // Save
            // 
            this.Save.DataPropertyName = "Save";
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            this.Save.Width = 60;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Width = 60;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 60;
            // 
            // Other
            // 
            this.Other.DataPropertyName = "Other";
            this.Other.HeaderText = "Other";
            this.Other.Name = "Other";
            this.Other.Width = 60;
            // 
            // ParentID
            // 
            this.ParentID.DataPropertyName = "ParentID";
            this.ParentID.HeaderText = "ParentID";
            this.ParentID.Name = "ParentID";
            this.ParentID.Visible = false;
            // 
            // grpUserGridview
            // 
            this.grpUserGridview.BackColor = System.Drawing.Color.Transparent;
            this.grpUserGridview.Controls.Add(this.dgvUser);
            this.grpUserGridview.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserGridview.ForeColor = System.Drawing.Color.White;
            this.grpUserGridview.Location = new System.Drawing.Point(12, 288);
            this.grpUserGridview.Name = "grpUserGridview";
            this.grpUserGridview.Size = new System.Drawing.Size(225, 305);
            this.grpUserGridview.TabIndex = 193;
            this.grpUserGridview.TabStop = false;
            this.grpUserGridview.Text = "Existing Users";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(5, 24);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUser.Size = new System.Drawing.Size(210, 275);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            this.dgvUser.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUser_DataBindingComplete);
            // 
            // grpRights
            // 
            this.grpRights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRights.BackColor = System.Drawing.Color.Transparent;
            this.grpRights.Controls.Add(this.dgvUserRIghts);
            this.grpRights.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRights.ForeColor = System.Drawing.Color.White;
            this.grpRights.Location = new System.Drawing.Point(240, 118);
            this.grpRights.Name = "grpRights";
            this.grpRights.Size = new System.Drawing.Size(613, 470);
            this.grpRights.TabIndex = 194;
            this.grpRights.TabStop = false;
            this.grpRights.Text = "Form Rights";
            // 
            // grpUserName
            // 
            this.grpUserName.BackColor = System.Drawing.Color.Transparent;
            this.grpUserName.Controls.Add(this.txtName);
            this.grpUserName.Controls.Add(this.lblCategoryName);
            this.grpUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserName.ForeColor = System.Drawing.Color.White;
            this.grpUserName.Location = new System.Drawing.Point(6, 118);
            this.grpUserName.Name = "grpUserName";
            this.grpUserName.Size = new System.Drawing.Size(234, 164);
            this.grpUserName.TabIndex = 194;
            this.grpUserName.TabStop = false;
            this.grpUserName.Text = "Select User :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 31);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 10;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateNormal.Border.Rounding = 20;
            this.txtName.TabIndex = 380;
            this.txtName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(12, 22);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(84, 17);
            this.lblCategoryName.TabIndex = 189;
            this.lblCategoryName.Text = "User Name :";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(13, 53);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(74, 25);
            this.txtUserID.TabIndex = 190;
            this.txtUserID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(687, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 28);
            this.panel1.TabIndex = 195;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(810, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 28);
            this.panel3.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 190;
            this.label1.Text = "Parent Menu :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 197;
            this.label2.Text = "Sub Menu :";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(733, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 348;
            this.btnCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Values.Image")));
            this.btnCancel.Values.Text = " Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(638, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 347;
            this.btnDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Values.Image")));
            this.btnDelete.Values.Text = " Delete ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(543, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.TabIndex = 346;
            this.btnUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Values.Image")));
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(448, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(78, 34);
            this.btnEdit.TabIndex = 345;
            this.btnEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Values.Image")));
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(353, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.TabIndex = 344;
            this.btnSave.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Values.Image")));
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(258, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(78, 34);
            this.btnAdd.TabIndex = 343;
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label12);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel1.Size = new System.Drawing.Size(853, 40);
            this.kryptonPanel1.TabIndex = 371;
            // 
            // frmUserRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 600);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.grpUserName);
            this.Controls.Add(this.grpRights);
            this.Controls.Add(this.grpUserGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserRights";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Rights";
            this.Load += new System.EventHandler(this.frmUserRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRIghts)).EndInit();
            this.grpUserGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.grpRights.ResumeLayout(false);
            this.grpUserName.ResumeLayout(false);
            this.grpUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpUserGridview;
        private System.Windows.Forms.GroupBox grpRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn View;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Save;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Other;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
        private System.Windows.Forms.GroupBox grpUserName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvUserRIghts;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}