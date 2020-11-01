namespace TAILORING.Order
{
    partial class frmOrderManagement
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
            this.label10 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lnkAddItem = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmtToBePaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericQTY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdvancePaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTailoringAmount = new System.Windows.Forms.TextBox();
            this.cmbGarmentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerAdd = new System.Windows.Forms.Label();
            this.grpNewOrder = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrimsAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.txtSearchByMobileNo = new System.Windows.Forms.TextBox();
            this.rdSearchByCustomerMobileNo = new System.Windows.Forms.RadioButton();
            this.txtSearchByCustomerName = new System.Windows.Forms.TextBox();
            this.rdSearchByCustomerName = new System.Windows.Forms.RadioButton();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMeasurement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQTY)).BeginInit();
            this.grpNewOrder.SuspendLayout();
            this.grpCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(459, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 333;
            this.label10.Text = "Customer Address :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(176, 149);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(30, 17);
            this.lblCustomerName.TabIndex = 332;
            this.lblCustomerName.Text = "NA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.Location = new System.Drawing.Point(39, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 331;
            this.label8.Text = "Customer Name :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtCustomerID.Location = new System.Drawing.Point(988, 71);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(41, 25);
            this.txtCustomerID.TabIndex = 314;
            this.txtCustomerID.Visible = false;
            // 
            // lnkAddItem
            // 
            this.lnkAddItem.AutoSize = true;
            this.lnkAddItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddItem.Location = new System.Drawing.Point(885, 334);
            this.lnkAddItem.Name = "lnkAddItem";
            this.lnkAddItem.Size = new System.Drawing.Size(96, 21);
            this.lnkAddItem.TabIndex = 330;
            this.lnkAddItem.TabStop = true;
            this.lnkAddItem.Text = "+ Add Item";
            this.lnkAddItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label7.Location = new System.Drawing.Point(767, 672);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 329;
            this.label7.Text = "Amount to be Paid  :";
            // 
            // txtAmtToBePaid
            // 
            this.txtAmtToBePaid.BackColor = System.Drawing.Color.White;
            this.txtAmtToBePaid.Enabled = false;
            this.txtAmtToBePaid.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtAmtToBePaid.Location = new System.Drawing.Point(900, 668);
            this.txtAmtToBePaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmtToBePaid.Name = "txtAmtToBePaid";
            this.txtAmtToBePaid.Size = new System.Drawing.Size(153, 25);
            this.txtAmtToBePaid.TabIndex = 328;
            this.txtAmtToBePaid.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(516, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 298;
            this.label3.Text = "Rate :";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtRate.Location = new System.Drawing.Point(569, 32);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(91, 25);
            this.txtRate.TabIndex = 5;
            this.txtRate.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(369, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 299;
            this.label2.Text = "QTY :";
            // 
            // NumericQTY
            // 
            this.NumericQTY.Location = new System.Drawing.Point(429, 32);
            this.NumericQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumericQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQTY.Name = "NumericQTY";
            this.NumericQTY.Size = new System.Drawing.Size(57, 25);
            this.NumericQTY.TabIndex = 298;
            this.NumericQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(767, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 327;
            this.label6.Text = "Advance Paid :";
            // 
            // txtAdvancePaid
            // 
            this.txtAdvancePaid.BackColor = System.Drawing.Color.White;
            this.txtAdvancePaid.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtAdvancePaid.Location = new System.Drawing.Point(900, 628);
            this.txtAdvancePaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdvancePaid.Name = "txtAdvancePaid";
            this.txtAdvancePaid.Size = new System.Drawing.Size(153, 25);
            this.txtAdvancePaid.TabIndex = 326;
            this.txtAdvancePaid.Text = "0";
            this.txtAdvancePaid.TextChanged += new System.EventHandler(this.txtAdvancePaid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(767, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 323;
            this.label4.Text = "Tailoring Amount :";
            // 
            // txtTailoringAmount
            // 
            this.txtTailoringAmount.BackColor = System.Drawing.Color.White;
            this.txtTailoringAmount.Enabled = false;
            this.txtTailoringAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTailoringAmount.Location = new System.Drawing.Point(900, 593);
            this.txtTailoringAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTailoringAmount.Name = "txtTailoringAmount";
            this.txtTailoringAmount.Size = new System.Drawing.Size(153, 25);
            this.txtTailoringAmount.TabIndex = 322;
            this.txtTailoringAmount.Text = "0";
            // 
            // cmbGarmentName
            // 
            this.cmbGarmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarmentName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGarmentName.FormattingEnabled = true;
            this.cmbGarmentName.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cmbGarmentName.Location = new System.Drawing.Point(127, 32);
            this.cmbGarmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGarmentName.Name = "cmbGarmentName";
            this.cmbGarmentName.Size = new System.Drawing.Size(207, 25);
            this.cmbGarmentName.TabIndex = 297;
            this.cmbGarmentName.SelectionChangeCommitted += new System.EventHandler(this.cmbGarmentName_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 296;
            this.label1.Text = "Garment Name :";
            // 
            // lblCustomerAdd
            // 
            this.lblCustomerAdd.AutoSize = true;
            this.lblCustomerAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lblCustomerAdd.Location = new System.Drawing.Point(595, 149);
            this.lblCustomerAdd.Name = "lblCustomerAdd";
            this.lblCustomerAdd.Size = new System.Drawing.Size(30, 17);
            this.lblCustomerAdd.TabIndex = 334;
            this.lblCustomerAdd.Text = "NA";
            // 
            // grpNewOrder
            // 
            this.grpNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpNewOrder.Controls.Add(this.label5);
            this.grpNewOrder.Controls.Add(this.txtTrimsAmount);
            this.grpNewOrder.Controls.Add(this.label3);
            this.grpNewOrder.Controls.Add(this.txtRate);
            this.grpNewOrder.Controls.Add(this.label2);
            this.grpNewOrder.Controls.Add(this.NumericQTY);
            this.grpNewOrder.Controls.Add(this.cmbGarmentName);
            this.grpNewOrder.Controls.Add(this.label1);
            this.grpNewOrder.Enabled = false;
            this.grpNewOrder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpNewOrder.Location = new System.Drawing.Point(15, 247);
            this.grpNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNewOrder.Name = "grpNewOrder";
            this.grpNewOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNewOrder.Size = new System.Drawing.Size(969, 86);
            this.grpNewOrder.TabIndex = 320;
            this.grpNewOrder.TabStop = false;
            this.grpNewOrder.Text = "Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(690, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 327;
            this.label5.Text = "Trims Amount :";
            // 
            // txtTrimsAmount
            // 
            this.txtTrimsAmount.BackColor = System.Drawing.Color.White;
            this.txtTrimsAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTrimsAmount.Location = new System.Drawing.Point(796, 31);
            this.txtTrimsAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrimsAmount.Name = "txtTrimsAmount";
            this.txtTrimsAmount.Size = new System.Drawing.Size(131, 25);
            this.txtTrimsAmount.TabIndex = 326;
            this.txtTrimsAmount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(363, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 319;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label13.Location = new System.Drawing.Point(42, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 318;
            this.label13.Text = "Order Type :";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Enabled = false;
            this.cmbOrderType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cmbOrderType.Location = new System.Drawing.Point(156, 196);
            this.cmbOrderType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(207, 25);
            this.cmbOrderType.TabIndex = 317;
            this.cmbOrderType.SelectionChangeCommitted += new System.EventHandler(this.cmbOrderType_SelectionChangeCommitted);
            // 
            // txtSearchByMobileNo
            // 
            this.txtSearchByMobileNo.BackColor = System.Drawing.Color.White;
            this.txtSearchByMobileNo.Enabled = false;
            this.txtSearchByMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByMobileNo.Location = new System.Drawing.Point(547, 21);
            this.txtSearchByMobileNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByMobileNo.Name = "txtSearchByMobileNo";
            this.txtSearchByMobileNo.Size = new System.Drawing.Size(223, 25);
            this.txtSearchByMobileNo.TabIndex = 4;
            // 
            // rdSearchByCustomerMobileNo
            // 
            this.rdSearchByCustomerMobileNo.AutoSize = true;
            this.rdSearchByCustomerMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCustomerMobileNo.Location = new System.Drawing.Point(445, 23);
            this.rdSearchByCustomerMobileNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSearchByCustomerMobileNo.Name = "rdSearchByCustomerMobileNo";
            this.rdSearchByCustomerMobileNo.Size = new System.Drawing.Size(95, 21);
            this.rdSearchByCustomerMobileNo.TabIndex = 3;
            this.rdSearchByCustomerMobileNo.Text = "Mobile No :";
            this.rdSearchByCustomerMobileNo.UseVisualStyleBackColor = true;
            this.rdSearchByCustomerMobileNo.CheckedChanged += new System.EventHandler(this.rdSearchByCustomerMobile_CheckedChanged);
            // 
            // txtSearchByCustomerName
            // 
            this.txtSearchByCustomerName.BackColor = System.Drawing.Color.White;
            this.txtSearchByCustomerName.Enabled = false;
            this.txtSearchByCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtSearchByCustomerName.Location = new System.Drawing.Point(164, 21);
            this.txtSearchByCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByCustomerName.Name = "txtSearchByCustomerName";
            this.txtSearchByCustomerName.Size = new System.Drawing.Size(223, 25);
            this.txtSearchByCustomerName.TabIndex = 1;
            this.txtSearchByCustomerName.TextChanged += new System.EventHandler(this.txtSearchByCustomerName_TextChanged);
            // 
            // rdSearchByCustomerName
            // 
            this.rdSearchByCustomerName.AutoSize = true;
            this.rdSearchByCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.rdSearchByCustomerName.Location = new System.Drawing.Point(27, 23);
            this.rdSearchByCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSearchByCustomerName.Name = "rdSearchByCustomerName";
            this.rdSearchByCustomerName.Size = new System.Drawing.Size(130, 21);
            this.rdSearchByCustomerName.TabIndex = 0;
            this.rdSearchByCustomerName.Text = "Customer Name :";
            this.rdSearchByCustomerName.UseVisualStyleBackColor = true;
            this.rdSearchByCustomerName.CheckedChanged += new System.EventHandler(this.rdSearchByCustomerName_CheckedChanged);
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomerSearch.Controls.Add(this.txtSearchByMobileNo);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCustomerMobileNo);
            this.grpCustomerSearch.Controls.Add(this.txtSearchByCustomerName);
            this.grpCustomerSearch.Controls.Add(this.rdSearchByCustomerName);
            this.grpCustomerSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpCustomerSearch.Location = new System.Drawing.Point(15, 52);
            this.grpCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerSearch.Size = new System.Drawing.Size(969, 86);
            this.grpCustomerSearch.TabIndex = 316;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "Search By";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Order Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 366);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 209);
            this.dataGridView1.TabIndex = 321;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 40);
            this.panel2.TabIndex = 315;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(647, 668);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 336;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnMeasurement
            // 
            this.btnMeasurement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeasurement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasurement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeasurement.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasurement.Location = new System.Drawing.Point(524, 668);
            this.btnMeasurement.Name = "btnMeasurement";
            this.btnMeasurement.Size = new System.Drawing.Size(101, 31);
            this.btnMeasurement.TabIndex = 335;
            this.btnMeasurement.Text = "Measurement";
            this.btnMeasurement.UseVisualStyleBackColor = true;
            this.btnMeasurement.Click += new System.EventHandler(this.btnMeasurement_Click);
            this.btnMeasurement.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnMeasurement.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 743);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMeasurement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lnkAddItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmtToBePaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdvancePaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTailoringAmount);
            this.Controls.Add(this.lblCustomerAdd);
            this.Controls.Add(this.grpNewOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.grpCustomerSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmOrderManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericQTY)).EndInit();
            this.grpNewOrder.ResumeLayout(false);
            this.grpNewOrder.PerformLayout();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.LinkLabel lnkAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmtToBePaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericQTY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdvancePaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTailoringAmount;
        private System.Windows.Forms.ComboBox cmbGarmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerAdd;
        private System.Windows.Forms.GroupBox grpNewOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.TextBox txtSearchByMobileNo;
        private System.Windows.Forms.RadioButton rdSearchByCustomerMobileNo;
        private System.Windows.Forms.TextBox txtSearchByCustomerName;
        private System.Windows.Forms.RadioButton rdSearchByCustomerName;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrimsAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMeasurement;
    }
}