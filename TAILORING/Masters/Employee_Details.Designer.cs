namespace TAILORING.Masters
{
    partial class Employee_Details
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
            this.lblTotalRecords = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PicEmployee = new System.Windows.Forms.PictureBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchByEmpMobileNo = new System.Windows.Forms.TextBox();
            this.rdSearchByEmpMobileNo = new System.Windows.Forms.RadioButton();
            this.txtSearchByEmpName = new System.Windows.Forms.TextBox();
            this.rdShowAllOfEmp = new System.Windows.Forms.RadioButton();
            this.rdSearchByEmpName = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.lblTotalRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEmployee)).BeginInit();
            this.grpEmployee.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpCustomerSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 40);
            this.panel2.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Employee Details";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Controls.Add(this.dgvEmployee);
            this.lblTotalRecords.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(2, 420);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(981, 234);
            this.lblTotalRecords.TabIndex = 203;
            this.lblTotalRecords.TabStop = false;
            this.lblTotalRecords.Text = "Employee List";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(6, 23);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(969, 205);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            this.dgvEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployee_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.PicEmployee);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(732, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 247);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(172, 207);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 17);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cancel";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(8, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PicEmployee
            // 
            this.PicEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicEmployee.Location = new System.Drawing.Point(11, 25);
            this.PicEmployee.Name = "PicEmployee";
            this.PicEmployee.Size = new System.Drawing.Size(210, 179);
            this.PicEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicEmployee.TabIndex = 209;
            this.PicEmployee.TabStop = false;
            // 
            // grpEmployee
            // 
            this.grpEmployee.BackColor = System.Drawing.Color.Transparent;
            this.grpEmployee.Controls.Add(this.label16);
            this.grpEmployee.Controls.Add(this.label15);
            this.grpEmployee.Controls.Add(this.comboBox1);
            this.grpEmployee.Controls.Add(this.label14);
            this.grpEmployee.Controls.Add(this.label13);
            this.grpEmployee.Controls.Add(this.cmbEmployeeType);
            this.grpEmployee.Controls.Add(this.label5);
            this.grpEmployee.Controls.Add(this.label10);
            this.grpEmployee.Controls.Add(this.txtMobileNo);
            this.grpEmployee.Controls.Add(this.label3);
            this.grpEmployee.Controls.Add(this.grpGender);
            this.grpEmployee.Controls.Add(this.label9);
            this.grpEmployee.Controls.Add(this.label8);
            this.grpEmployee.Controls.Add(this.groupBox3);
            this.grpEmployee.Controls.Add(this.dtpDOB);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Controls.Add(this.label2);
            this.grpEmployee.Controls.Add(this.txtAdd);
            this.grpEmployee.Controls.Add(this.label1);
            this.grpEmployee.Controls.Add(this.txtName);
            this.grpEmployee.Controls.Add(this.lblCountryCode);
            this.grpEmployee.Controls.Add(this.txtEmployeeCode);
            this.grpEmployee.Controls.Add(this.groupBox2);
            this.grpEmployee.Enabled = false;
            this.grpEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.Location = new System.Drawing.Point(8, 72);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(969, 282);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(340, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 242;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label13.Location = new System.Drawing.Point(19, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 241;
            this.label13.Text = "Employee Type :";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Admin",
            "Master"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(133, 207);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(206, 25);
            this.cmbEmployeeType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(342, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 239;
            this.label5.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(19, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 238;
            this.label10.Text = "Mobile No :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtMobileNo.Location = new System.Drawing.Point(133, 121);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(206, 25);
            this.txtMobileNo.TabIndex = 2;
            this.txtMobileNo.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            this.txtMobileNo.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(681, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 236;
            this.label3.Text = "*";
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Transparent;
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.Location = new System.Drawing.Point(473, 88);
            this.grpGender.Margin = new System.Windows.Forms.Padding(2);
            this.grpGender.Name = "grpGender";
            this.grpGender.Padding = new System.Windows.Forms.Padding(2);
            this.grpGender.Size = new System.Drawing.Size(206, 53);
            this.grpGender.TabIndex = 6;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.Color.Transparent;
            this.radMale.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(19, 20);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(56, 21);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.BackColor = System.Drawing.Color.Transparent;
            this.radFemale.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(127, 20);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(69, 21);
            this.radFemale.TabIndex = 8;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(342, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 235;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(342, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 234;
            this.label8.Text = "*";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(361, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 134);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Details";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(112, 100);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 25);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label11.Location = new System.Drawing.Point(22, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 218;
            this.label11.Text = "E-Mail :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TAILORING.Properties.Resources.picIMGPass_Image;
            this.pictureBox2.Location = new System.Drawing.Point(320, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 213;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtPass.Location = new System.Drawing.Point(112, 65);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(206, 25);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label7.Location = new System.Drawing.Point(22, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 216;
            this.label7.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 215;
            this.label6.Text = "User Name :";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtUsername.Location = new System.Drawing.Point(112, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 25);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(133, 164);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(206, 25);
            this.dtpDOB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 228;
            this.label4.Text = "DOB :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(374, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 225;
            this.label2.Text = "Address :";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.White;
            this.txtAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtAdd.Location = new System.Drawing.Point(473, 35);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(240, 49);
            this.txtAdd.TabIndex = 5;
            this.txtAdd.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtAdd.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 223;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtName.Location = new System.Drawing.Point(133, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCountryCode.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCountryCode.Location = new System.Drawing.Point(19, 38);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(108, 17);
            this.lblCountryCode.TabIndex = 221;
            this.lblCountryCode.Text = "Employee Code :";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.BackColor = System.Drawing.Color.White;
            this.txtEmployeeCode.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtEmployeeCode.Location = new System.Drawing.Point(133, 35);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(206, 25);
            this.txtEmployeeCode.TabIndex = 0;
            this.txtEmployeeCode.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtEmployeeCode.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(495, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 25);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(659, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(577, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(415, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(333, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(244, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomerSearch.Controls.Add(this.txtSearchByEmpMobileNo);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByEmpMobileNo);
            this.grpCustomerSearch.Controls.Add(this.txtSearchByEmpName);
            this.grpCustomerSearch.Controls.Add(this.rdShowAllOfEmp);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByEmpName);
            this.grpCustomerSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpCustomerSearch.Location = new System.Drawing.Point(8, 359);
            this.grpCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomerSearch.Size = new System.Drawing.Size(969, 55);
            this.grpCustomerSearch.TabIndex = 204;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "Search By";
            // 
            // txtSearchByEmpMobileNo
            // 
            this.txtSearchByEmpMobileNo.BackColor = System.Drawing.Color.White;
            this.txtSearchByEmpMobileNo.Enabled = false;
            this.txtSearchByEmpMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByEmpMobileNo.Location = new System.Drawing.Point(547, 21);
            this.txtSearchByEmpMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByEmpMobileNo.Name = "txtSearchByEmpMobileNo";
            this.txtSearchByEmpMobileNo.Size = new System.Drawing.Size(222, 25);
            this.txtSearchByEmpMobileNo.TabIndex = 4;
            this.txtSearchByEmpMobileNo.TextChanged += new System.EventHandler(this.txtSearchByEmpMobileNo_TextChanged);
            this.txtSearchByEmpMobileNo.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtSearchByEmpMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            this.txtSearchByEmpMobileNo.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // rdSearchByEmpMobileNo
            // 
            this.rdSearchByEmpMobileNo.AutoSize = true;
            this.rdSearchByEmpMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByEmpMobileNo.Location = new System.Drawing.Point(446, 23);
            this.rdSearchByEmpMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByEmpMobileNo.Name = "rdSearchByEmpMobileNo";
            this.rdSearchByEmpMobileNo.Size = new System.Drawing.Size(95, 21);
            this.rdSearchByEmpMobileNo.TabIndex = 3;
            this.rdSearchByEmpMobileNo.Text = "Mobile No :";
            this.rdSearchByEmpMobileNo.UseVisualStyleBackColor = true;
            this.rdSearchByEmpMobileNo.CheckedChanged += new System.EventHandler(this.rdSearchByEmpMobileNo_CheckedChanged);
            // 
            // txtSearchByEmpName
            // 
            this.txtSearchByEmpName.BackColor = System.Drawing.Color.White;
            this.txtSearchByEmpName.Enabled = false;
            this.txtSearchByEmpName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByEmpName.Location = new System.Drawing.Point(164, 21);
            this.txtSearchByEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByEmpName.Name = "txtSearchByEmpName";
            this.txtSearchByEmpName.Size = new System.Drawing.Size(222, 25);
            this.txtSearchByEmpName.TabIndex = 1;
            this.txtSearchByEmpName.TextChanged += new System.EventHandler(this.txtSearchByEmpName_TextChanged);
            this.txtSearchByEmpName.Enter += new System.EventHandler(this.txtEmployeeCode_Enter);
            this.txtSearchByEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtSearchByEmpName.Leave += new System.EventHandler(this.txtEmployeeCode_Leave);
            // 
            // rdShowAllOfEmp
            // 
            this.rdShowAllOfEmp.AutoSize = true;
            this.rdShowAllOfEmp.Checked = true;
            this.rdShowAllOfEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdShowAllOfEmp.Location = new System.Drawing.Point(874, 23);
            this.rdShowAllOfEmp.Margin = new System.Windows.Forms.Padding(2);
            this.rdShowAllOfEmp.Name = "rdShowAllOfEmp";
            this.rdShowAllOfEmp.Size = new System.Drawing.Size(79, 21);
            this.rdShowAllOfEmp.TabIndex = 2;
            this.rdShowAllOfEmp.TabStop = true;
            this.rdShowAllOfEmp.Text = "Show All";
            this.rdShowAllOfEmp.UseVisualStyleBackColor = true;
            this.rdShowAllOfEmp.CheckedChanged += new System.EventHandler(this.rdShowAllOfEmp_CheckedChanged);
            // 
            // rdSearchByEmpName
            // 
            this.rdSearchByEmpName.AutoSize = true;
            this.rdSearchByEmpName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByEmpName.Location = new System.Drawing.Point(27, 23);
            this.rdSearchByEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByEmpName.Name = "rdSearchByEmpName";
            this.rdSearchByEmpName.Size = new System.Drawing.Size(131, 21);
            this.rdSearchByEmpName.TabIndex = 0;
            this.rdSearchByEmpName.Text = "Employee Name :";
            this.rdSearchByEmpName.UseVisualStyleBackColor = true;
            this.rdSearchByEmpName.CheckedChanged += new System.EventHandler(this.rdSearchByEmpName_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label15.Location = new System.Drawing.Point(19, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 244;
            this.label15.Text = "Active Status :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.comboBox1.Location = new System.Drawing.Point(133, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 25);
            this.comboBox1.TabIndex = 243;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(342, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 17);
            this.label16.TabIndex = 245;
            this.label16.Text = "*";
            // 
            // Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 661);
            this.Controls.Add(this.grpCustomerSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Employee_Details";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lblTotalRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEmployee)).EndInit();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox lblTotalRecords;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox PicEmployee;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.TextBox txtSearchByEmpMobileNo;
        private System.Windows.Forms.RadioButton rdSearchByEmpMobileNo;
        private System.Windows.Forms.TextBox txtSearchByEmpName;
        private System.Windows.Forms.RadioButton rdShowAllOfEmp;
        private System.Windows.Forms.RadioButton rdSearchByEmpName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
    }
}