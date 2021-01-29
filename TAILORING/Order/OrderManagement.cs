using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmOrderManagement : KryptonForm
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataTable dtGarment = null;
        DataTable dtOrderManagement = new DataTable();
        DataTable dtDefaultOrderManagement = new DataTable();

        DataTable dtOrder = new DataTable();
        DataTable dtOrderDetails = new DataTable();

        DataSet dsMeasure = new DataSet();
        DataTable dtMeasurement = new DataTable();
        DataTable dtStyle = new DataTable();
        DataTable dtBodyPosture = new DataTable();

        public int CustomerID = 1;
        public string CustName = string.Empty;
        public string CustMobileNo = string.Empty;
        public string CustAddress = string.Empty;

        int OrderID = 0;
        double CGST = 0, SGST = 0;
        double GarmentRate = 0;
        string InvoiceNo = string.Empty;
        string GarmentCode = string.Empty;
        string GarmentName = string.Empty;
        string strPhoto = string.Empty;

        DateTime dtTrailDate = DateTime.Now.AddDays(2);
        DateTime dtDeliveryDate = DateTime.Now.AddDays(4);

        DateTime dtPrevTrailDate = DateTime.Now;
        DateTime dtPrevDeliveryDate = DateTime.Now;

        KryptonComboBox cmbService = new KryptonComboBox();
        KryptonDateTimePicker kdtTrailDate = new KryptonDateTimePicker();
        KryptonDateTimePicker kdtDeliveryDate = new KryptonDateTimePicker();
        int GridServiceIndex = -1;

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = null;
            this.PaletteMode = PaletteMode.SparklePurple;
            this.BackColor = Color.FromArgb(82, 91, 114);

            btnAdd.PaletteMode = PaletteMode.SparklePurple;
            btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnSave.PaletteMode = PaletteMode.SparklePurple;
            btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnMeasurement.PaletteMode = PaletteMode.SparklePurple;
            btnMeasurement.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            LoadTailoringTheme();

            txtCustomerID.Text = CustomerID.ToString();
            txtCustomerName.Text = CustName;
            txtCustomerMobileNo.Text = CustMobileNo;
            txtCustomerAdd.Text = CustAddress;

            if (CustomerID > 0)
            {
                grpNewOrder.Enabled = true;
            }
            else
            {
                grpNewOrder.Enabled = false;
            }

            InitItemTable();
            InitOrderDetailsTable(); //Order Details
            InitMeasurementTable(); //Measurement
            InitStyleTable(); //Style
            InitBodyPostureTable(); //BodyPosture
            FillGSTData();// Load CGST,SGST

            FillGarmentData(); // Load unique Garment Data

            InitOrderManagement();
            //dtDefaultOrderManagement = (DataTable)dataGridView1.DataSource;
            //dtOrderManagement = (DataTable)dataGridView1.DataSource;

            //NumericQTY.Value = 2;

            dtpDeliveryDate.MinDate = dtDeliveryDate;
            dtpTrailDate.MinDate = dtTrailDate;
            dtpTrailDate.Checked = false;
        }
        private void InitOrderManagement()
        {
            dtOrderManagement.Columns.Add("GarmentID");
            dtOrderManagement.Columns.Add("GarmentCode");
            dtOrderManagement.Columns.Add("GarmentName");
            dtOrderManagement.Columns.Add("ServiceID");
            dtOrderManagement.Columns.Add("Service");
            dtOrderManagement.Columns.Add("TrailDate", typeof(DateTime));
            dtOrderManagement.Columns.Add("DeliveryDate", typeof(DateTime));
            dtOrderManagement.Columns.Add("TrimAmount");
            dtOrderManagement.Columns.Add("QTY", typeof(int));
            dtOrderManagement.Columns.Add("Rate", typeof(double));
            dtOrderManagement.Columns.Add("Total", typeof(double));
            dtOrderManagement.Columns.Add("Photo");
            //dtOrderManagement.Columns.Add("Delete");
            dtOrderManagement.AcceptChanges();

            //dataGridView1.DataSource = dtOrderManagement;

        }

        private void InitItemTable()
        {
            //dtOrder = dtOrderManagement.Copy();
            //Gridview
            dtOrder.Columns.Add("GarmentID");
            dtOrder.Columns.Add("StichTypeID");
            dtOrder.Columns.Add("FitTypeID");
            dtOrder.Columns.Add("GarmentCode");
            dtOrder.Columns.Add("GarmentName");
            dtOrder.Columns.Add("QTY", typeof(int));
            dtOrder.Columns.Add("Photo");

            //dtOrder.Columns.Add("Delete");

            //DataGridViewButtonColumn ColDelete = new DataGridViewButtonColumn();
            //ColDelete.DataPropertyName = "Delete";
            //ColDelete.HeaderText = "Delete";
            //ColDelete.Name = "ColDelete";
            //ColDelete.Text = "Delete";
            //ColDelete.UseColumnTextForButtonValue = true;

            dtOrder.AcceptChanges();

            //dataGridView1.DataSource = dtOrder;
            //dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //ColDelete});
        }
        private void InitOrderDetailsTable()
        {
            dtOrderDetails.Columns.Add("SalesOrderID");
            dtOrderDetails.Columns.Add("StichTypeID", typeof(int));
            dtOrderDetails.Columns.Add("FitTypeID", typeof(int));
            dtOrderDetails.Columns.Add("GarmentID");
            dtOrderDetails.Columns.Add("Service", typeof(int));
            dtOrderDetails.Columns.Add("TrailDate");
            dtOrderDetails.Columns.Add("DeliveryDate");
            dtOrderDetails.Columns.Add("TrimAmount");
            dtOrderDetails.Columns.Add("QTY", typeof(int));
            dtOrderDetails.Columns.Add("Rate", typeof(double));
            dtOrderDetails.Columns.Add("Total", typeof(double));
            dtOrderDetails.Columns.Add("CreatedBy", typeof(int));

            dtOrderDetails.AcceptChanges();
        }

        private void InitMeasurementTable()
        {
            dtMeasurement.Columns.Add("SalesOrderID");
            dtMeasurement.Columns.Add("GarmentID");
            dtMeasurement.Columns.Add("MeasurementID");
            dtMeasurement.Columns.Add("MeasurementValue", typeof(double));
            dtMeasurement.Columns.Add("CreatedBy", typeof(int));

            dtMeasurement.AcceptChanges();
        }

        private void InitStyleTable()
        {
            dtStyle.Columns.Add("SalesOrderID");
            dtStyle.Columns.Add("GarmentID");
            dtStyle.Columns.Add("StyleID");
            dtStyle.Columns.Add("QTY");
            dtStyle.Columns.Add("StyleImageID");
            dtStyle.Columns.Add("CreatedBy", typeof(int));

            dtStyle.AcceptChanges();
        }

        private void InitBodyPostureTable()
        {
            dtBodyPosture.Columns.Add("SalesOrderID");
            dtBodyPosture.Columns.Add("GarmentID");
            dtBodyPosture.Columns.Add("BodyPostureID");
            dtBodyPosture.Columns.Add("BodyPostureMappingID");
            dtBodyPosture.Columns.Add("CreatedBy", typeof(int));

            dtBodyPosture.AcceptChanges();
        }

        private void FillGarmentData()
        {
            dtGarment = null;
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtGarment = ds.Tables[0];
                cmbGarmentName.DataSource = dtGarment;
                cmbGarmentName.DisplayMember = "GarmentName";
                cmbGarmentName.ValueMember = "GarmentID";
            }
            else
            {
                cmbGarmentName.DataSource = null;
            }
            cmbGarmentName.SelectedIndex = -1;
        }

        private void FillGSTData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GSTData");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    CGST = Math.Round(Convert.ToDouble(dt.Rows[0]["CGST"]), 1);
                    SGST = Math.Round(Convert.ToDouble(dt.Rows[0]["SGST"]), 1);

                    lblCGST.Text = lblCGST.Text + " (" + CGST + "%) :";
                    lblSGST.Text = lblSGST.Text + " (" + SGST + "%) :";
                }
                txtCGST.Text = "0";
                txtSGST.Text = "0";
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                ObjUtil.SetRowNumber(dataGridView1);
                //ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
                dataGridView1.Columns["GarmentID"].Visible = false;
                dataGridView1.Columns["Photo"].Visible = false;

                if (dataGridView1.Columns.Contains("ServiceID"))
                {
                    //dataGridView1.Columns["ServiceID"].Visible = false;
                }
                //if (dataGridView1.Columns.Contains("Measurement"))
                //{
                //    dataGridView1.Columns["Measurement"].Visible = false;
                //}
                //if (dataGridView1.Columns.Contains("Style"))
                //{
                //    dataGridView1.Columns["Style"].Visible = false;
                //}
                //if (dataGridView1.Columns.Contains("StichTypeID"))
                //{
                //dataGridView1.Columns["StichTypeID"].Visible = false;
                //}
                //if (dataGridView1.Columns.Contains("FitTypeID"))
                //{
                //dataGridView1.Columns["FitTypeID"].Visible = false;
                //}
                CalcTotalAmount();
            }
            catch { }
        }

        private DataTable GetProductRate(int GarmentID, int OrderType)
        {
            DataTable dtGarmentRate = null;

            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("OrderType", SqlDbType.Int, OrderType, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product_Rate");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtGarmentRate = ds.Tables[0];
            }
            return dtGarmentRate;
        }
        private void cmbGarmentName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbGarmentName.SelectedValue != null)
            {
                DataRow[] drow = dtGarment.Select("GarmentID=" + cmbGarmentName.SelectedValue);
                if (drow.Length > 0)
                {
                    //txtRate.Text = drow[0]["Rate"].ToString();
                    GarmentName = drow[0]["GarmentName"].ToString();
                    GarmentCode = drow[0]["GarmentCode"].ToString();
                    strPhoto = drow[0]["Photo"].ToString();

                    DataTable dt = GetProductRate(Convert.ToInt32(cmbGarmentName.SelectedValue), 0);// 0 ->Normal OrderType
                    if (ObjUtil.ValidateTable(dt))
                    {
                        GarmentRate = Convert.ToDouble(dt.Rows[0]["Rate"]);
                    }
                    NumericQTY.Focus();
                }
            }
            btnAdd.Enabled = true;
        }

        private void AddDefaultRow()
        {
            DataRow dRow = dtOrder.NewRow();
            dRow["GarmentCode"] = "sh01";
            dRow["GarmentID"] = 1;
            dRow["GarmentName"] = "Shirt";
            dRow["Trim Amount"] = 10;
            dRow["Rate"] = 100;
            dRow["Service"] = "Urgent";
            dRow["TrailDate"] = "2020-12-26";
            dRow["DeliveryDate"] = "2020-12-28";
            dRow["ServiceID"] = 1;
            dRow["QTY"] = 3;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Shirt generic 1.png";
            dRow["Total"] = 0 + (3 * 100);

            dtOrder.Rows.Add(dRow);

            dRow = dtOrder.NewRow();
            dRow["GarmentCode"] = "th01";
            dRow["GarmentID"] = 1002;
            dRow["GarmentName"] = "Trouser";
            dRow["Trim Amount"] = 20;
            dRow["Rate"] = 150;
            dRow["Service"] = "Normal";
            dRow["TrailDate"] = "2020-12-27";
            dRow["DeliveryDate"] = "2020-12-29";
            dRow["ServiceID"] = 0;
            dRow["QTY"] = 2;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Trouser Generic 1.png";
            dRow["Total"] = 0 + (2 * 100);

            dtOrder.Rows.Add(dRow);
            dtOrder.AcceptChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbGarmentName.SelectedValue != null)
            {
                int pQty = 1;
                for (int i = 1; i <= NumericQTY.Value; i++)
                {
                    DataRow dRow = dtOrderManagement.NewRow();
                    dRow["GarmentID"] = cmbGarmentName.SelectedValue;
                    dRow["GarmentCode"] = GarmentCode.ToUpper();
                    dRow["GarmentName"] = GarmentName;
                    dRow["TrimAmount"] = "0";
                    dRow["ServiceID"] = "0";
                    dRow["Service"] = "Normal";
                    if (dtpTrailDate.Checked)
                        dRow["TrailDate"] = dtpTrailDate.Value.ToString("yyyy-MM-dd");
                    else
                        dRow["TrailDate"] = DBNull.Value;

                    dRow["DeliveryDate"] = dtpDeliveryDate.Value.ToString("yyyy-MM-dd");
                    dRow["Photo"] = strPhoto;
                    dRow["Rate"] = GarmentRate;
                    dRow["QTY"] = pQty;
                    dRow["Total"] = pQty * Convert.ToDecimal(GarmentRate);
                    //dRow["Delete"] = "Delete";
                    dtOrderManagement.Rows.Add(dRow);
                }
                dtOrderManagement.AcceptChanges();

                //AddDefaultRow();
                dataGridView1.DataSource = dtOrderManagement;

                AdddtOrder();

                ResetGarmentDetails();

                btnAdd.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Please Select Some Garments..");
            }
        }

        private void AdddtOrder()
        {
            dtOrder.Clear();
            DataTable dt = dtOrderManagement.DefaultView.ToTable(true, "GarmentID");
            if (ObjUtil.ValidateTable(dt))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bool b = AddMasterdtOrder(Convert.ToInt32(dt.Rows[i]["GarmentID"]));
                    if (b == false)
                    {
                        DataRow[] drData = dtOrderManagement.Select("GarmentID=" + dt.Rows[i]["GarmentID"]);
                        object qty = dtOrderManagement.Compute("SUM(QTY)", "GarmentID=" + dt.Rows[i]["GarmentID"]);
                        //for (int j = 0; j < drData.Length; j++)
                        if (drData.Length > 0)
                        {
                            DataRow dRow = dtOrder.NewRow();
                            dRow["GarmentID"] = drData[0]["GarmentID"];
                            dRow["GarmentCode"] = drData[0]["GarmentCode"];
                            dRow["GarmentName"] = drData[0]["GarmentName"];
                            dRow["Photo"] = drData[0]["Photo"];
                            dRow["QTY"] = qty;
                            dtOrder.Rows.Add(dRow);
                        }
                    }
                }
                dtOrder.AcceptChanges();
            }
        }

        private bool AddMasterdtOrder(int pGarmentID)
        {
            bool b = false;
            int a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblMasterGarmentMapping", "MasterGarmentID=" + pGarmentID);
            if (a > 0)
            {
                object qty = dtOrderManagement.Compute("SUM(QTY)", "GarmentID=" + pGarmentID);
                DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblMasterGarmentMapping", "GarmentID", "MasterGarmentMappingID");
                if (ObjUtil.ValidateTable(dt))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, dt.Rows[i]["GarmentID"], clsConnection_DAL.ParamType.Input);
                        DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product");
                        if (ObjUtil.ValidateDataSet(ds))
                        {
                            DataTable dtData = ds.Tables[0];
                            if (ObjUtil.ValidateTable(dtData))
                            {
                                DataRow dRow = dtOrder.NewRow();
                                dRow["GarmentID"] = dtData.Rows[0]["GarmentID"];
                                dRow["GarmentCode"] = dtData.Rows[0]["GarmentCode"].ToString();
                                dRow["GarmentName"] = dtData.Rows[0]["GarmentName"].ToString();
                                dRow["Photo"] = dtData.Rows[0]["Photo"];
                                dRow["QTY"] = qty;
                                dtOrder.Rows.Add(dRow);

                                b = true;
                            }
                            else
                                b = false;
                        }
                    }
                    dtOrder.AcceptChanges();
                }
            }
            else
            {
                b = false;
            }
            return b;
        }
        private void CalcTotalAmount()
        {
            object total = 0;
            double pCGST = 0, pSGST = 0, GrossAmt = 0;
            try
            {
                if (ObjUtil.ValidateTable(dtOrderManagement) && ObjUtil.ValidateTable((DataTable)dataGridView1.DataSource))
                {
                    total = dtOrderManagement.Compute("SUM(Total)", string.Empty);
                }

                txtTailoringAmount.Text = total.ToString();
                pCGST = Convert.ToDouble(total) * CGST * 0.01;
                pSGST = Convert.ToDouble(total) * SGST * 0.01;

                txtCGST.Text = pCGST.ToString();
                txtSGST.Text = pSGST.ToString();

                GrossAmt = Convert.ToDouble(total) + pCGST + pSGST;
                txtGrossAmt.Text = Math.Round(GrossAmt, 0).ToString();// Rounding off tailoring amount
            }
            catch { }
        }

        private void btnMeasurement_Click(object sender, EventArgs e)
        {
            if (ObjUtil.ValidateTable(dtOrder))
            {
                Order.frmMeasurement Obj = new Order.frmMeasurement();
                Obj.dtGarmentList = dtOrder;
                Obj.dsMeasure = this.dsMeasure;
                Obj.CustomerID = this.CustomerID;
                Obj.ShowDialog();

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                clsUtility.ShowInfoMessage("Please Enter some Garments");
                cmbGarmentName.Focus();
            }
        }

        private void ResetGarmentDetails()
        {
            cmbGarmentName.SelectedIndex = -1;
            NumericQTY.Value = 1;
        }

        private void ClearAll()
        {
            txtGrossAmt.Text = "0";
            txtTailoringAmount.Text = "0";
            txtCGST.Text = "0";
            txtSGST.Text = "0";
            txtCustomerID.Text = "0";
            InvoiceNo = string.Empty;

            dsMeasure.Tables.Clear();
            dtOrder.Rows.Clear();
            dtOrderDetails.Rows.Clear();
            dtMeasurement.Rows.Clear();
            dtStyle.Rows.Clear();
            dtBodyPosture.Rows.Clear();
            dtOrderManagement.Rows.Clear();

            OrderID = 0;
            CustomerID = 0;
        }

        private void PrintOrder()
        {
            Report.Forms.frmBill Obj = new Report.Forms.frmBill();
            Obj.OrderID = this.OrderID.ToString();
            Obj.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ObjUtil.ValidateTable(dtOrder))
            {
                if (ObjUtil.ValidateDataSet(dsMeasure))
                {
                    object qty = dtOrder.Compute("SUM(QTY)", string.Empty);
                    OrderID = SavedSalesOrder(Convert.ToInt32(qty));
                    if (OrderID > 0)
                    {
                        bool b = SavedSalesOrderDetails();
                        if (b)
                        {
                            clsUtility.ShowInfoMessage("Invoice " + InvoiceNo + " is Generated.");

                            PrintOrder();
                            ClearAll();
                            dataGridView1.DataSource = dtOrderManagement;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Invoice is not Generated.");
                            DeleteSalesOrder();
                        }
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                    clsUtility.ShowInfoMessage("Please Enter some Garments");
                    cmbGarmentName.Focus();
                }
            }
            else
            {
                btnSave.Enabled = false;
                clsUtility.ShowInfoMessage("Please Enter some Garments");
                cmbGarmentName.Focus();
            }
        }

        private int SavedSalesOrder(int pQTY)
        {
            InvoiceNo = GenerateInvoiceNumber();

            ObjDAL.SetColumnData("CustomerID", SqlDbType.Int, txtCustomerID.Text);
            ObjDAL.SetColumnData("OrderNo", SqlDbType.VarChar, InvoiceNo);
            ObjDAL.SetColumnData("OrderDate", SqlDbType.Date, dtpBookingDate.Value.ToString("yyyy-MM-dd"));
            ObjDAL.SetColumnData("TrailDate", SqlDbType.Date, dtpTrailDate.Value.ToString("yyyy-MM-dd"));
            ObjDAL.SetColumnData("TotalAmount", SqlDbType.Decimal, txtGrossAmt.Text);
            ObjDAL.SetColumnData("OrderAmount", SqlDbType.Decimal, txtTailoringAmount.Text);

            ObjDAL.SetColumnData("CGST", SqlDbType.Decimal, txtCGST.Text);
            ObjDAL.SetColumnData("SGST", SqlDbType.Decimal, txtSGST.Text);

            ObjDAL.SetColumnData("OrderQTY", SqlDbType.Int, pQTY);
            ObjDAL.SetColumnData("OrderMode", SqlDbType.VarChar, "System");
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);

            int a = ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblSalesOrder", true);
            ObjDAL.ResetData();

            return a;
        }

        private void DeleteSalesOrder()
        {
            ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblSalesOrder", "SalesOrderID=" + OrderID);
        }

        private string GenerateInvoiceNumber()
        {
            string Invoice = "INV-";
            int InvID = ObjDAL.ExecuteScalarInt("SELECT NEXT VALUE FOR " + clsUtility.DBName + ".[dbo].Seq_Invoice");

            return Invoice + InvID;
        }

        private bool SavedSalesOrderDetails()
        {
            bool b = false;
            for (int i = 0; i < dtOrderManagement.Rows.Count; i++) //Sales Details
            {
                DataRow drow = dtOrderDetails.NewRow();
                drow["SalesOrderID"] = OrderID;
                drow["GarmentID"] = dtOrderManagement.Rows[i]["GarmentID"];

                DataRow[] dr = dtOrder.Select("GarmentID=" + dtOrderManagement.Rows[i]["GarmentID"]);
                if (dr.Length > 0)
                {
                    drow["StichTypeID"] = dtOrder.Rows[0]["StichTypeID"];
                    drow["FitTypeID"] = dtOrder.Rows[0]["FitTypeID"];
                }
                drow["Service"] = dtOrderManagement.Rows[i]["ServiceID"];

                drow["TrailDate"] = dtOrderManagement.Rows[i]["TrailDate"] != DBNull.Value ? Convert.ToDateTime(dtOrderManagement.Rows[i]["TrailDate"]).ToString("yyyy-MM-dd") : DBNull.Value.ToString();

                drow["DeliveryDate"] = Convert.ToDateTime(dtOrderManagement.Rows[i]["DeliveryDate"]).ToString("yyyy-MM-dd");
                drow["TrimAmount"] = dtOrderManagement.Rows[i]["TrimAmount"];
                drow["QTY"] = dtOrderManagement.Rows[i]["QTY"];
                drow["Rate"] = dtOrderManagement.Rows[i]["Rate"];
                drow["Total"] = dtOrderManagement.Rows[i]["Total"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtOrderDetails.Rows.Add(drow);

                #region Commented Row wise insert
                //ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, OrderID, clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, dtOrder.Rows[i]["GarmentID"], clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("TrimAmount", SqlDbType.Decimal, dtOrder.Rows[i]["Trim Amount"], clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("QTY", SqlDbType.Int, dtOrder.Rows[i]["QTY"], clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("Rate", SqlDbType.Decimal, dtOrder.Rows[i]["Rate"], clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("Total", SqlDbType.Decimal, dtOrder.Rows[i]["Total"], clsConnection_DAL.ParamType.Input);
                //ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                //b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_SalesOrderDetails");
                #endregion
            }
            dtOrderDetails.AcceptChanges();

            FillMeasurementData();
            FillStyleData();
            FillBodyPostureData();

            ObjDAL.SetStoreProcedureData("dtSalesOrderDetails", SqlDbType.Structured, dtOrderDetails, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtMeasurement", SqlDbType.Structured, dtMeasurement, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtStyle", SqlDbType.Structured, dtStyle, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtBodyPosture", SqlDbType.Structured, dtBodyPosture, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, OrderID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Flag", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Output);

            b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_SalesOrderDetails");
            DataTable dtOutput = ObjDAL.GetOutputParmData();
            if (ObjUtil.ValidateTable(dtOutput))
            {
                b = Convert.ToBoolean(dtOutput.Rows[0][1]);
            }
            return b;
        }

        private void FillMeasurementData()
        {
            DataTable dttempMeasure = dsMeasure.Tables[0];
            for (int i = 0; i < dttempMeasure.Rows.Count; i++)
            {
                //dtMeasurement = dttempMeasure.Copy();

                DataRow drow = dtMeasurement.NewRow();
                drow["SalesOrderID"] = OrderID;
                drow["GarmentID"] = dttempMeasure.Rows[i]["GarmentID"];
                drow["MeasurementID"] = dttempMeasure.Rows[i]["MeasurementID"];
                drow["MeasurementValue"] = dttempMeasure.Rows[i]["MeasurementValue"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtMeasurement.Rows.Add(drow);
            }
            dtMeasurement.AcceptChanges();
        }

        private void FillStyleData()
        {
            DataTable dttempStyle = dsMeasure.Tables[1];
            for (int i = 0; i < dttempStyle.Rows.Count; i++)
            {
                //dtStyle = dttempStyle.Copy();

                DataRow drow = dtStyle.NewRow();
                drow["SalesOrderID"] = OrderID;
                drow["GarmentID"] = dttempStyle.Rows[i]["GarmentID"];
                drow["StyleID"] = dttempStyle.Rows[i]["StyleID"];
                drow["QTY"] = dttempStyle.Rows[i]["QTY"];
                drow["StyleImageID"] = dttempStyle.Rows[i]["StyleImageID"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtStyle.Rows.Add(drow);
            }
            dtStyle.AcceptChanges();
        }

        private void FillBodyPostureData()
        {
            DataTable dttempPosture = dsMeasure.Tables[2];
            for (int i = 0; i < dttempPosture.Rows.Count; i++)
            {
                //dtBodyPosture = dttempPosture.Copy();

                DataRow drow = dtBodyPosture.NewRow();
                drow["SalesOrderID"] = OrderID;
                drow["GarmentID"] = dttempPosture.Rows[i]["GarmentID"];
                drow["BodyPostureID"] = dttempPosture.Rows[i]["BodyPostureID"];
                drow["BodyPostureMappingID"] = dttempPosture.Rows[i]["BodyPostureMappingID"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtBodyPosture.Rows.Add(drow);
            }
            dtBodyPosture.AcceptChanges();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView1.Columns[e.Column.Index].ReadOnly = true;
            //if (dataGridView1.Columns.Contains("QTY"))
            //{
            //    dataGridView1.Columns["QTY"].ReadOnly = false;
            //}

            if (dataGridView1.Columns.Contains("TrimAmount"))
            {
                dataGridView1.Columns["TrimAmount"].ReadOnly = false;
            }
            if (dataGridView1.Columns.Contains("Service"))
            {
                dataGridView1.Columns["Service"].ReadOnly = false;
            }
            if (dataGridView1.Columns.Contains("TrailDate"))
            {
                dataGridView1.Columns["TrailDate"].ReadOnly = false;
            }
            if (dataGridView1.Columns.Contains("DeliveryDate"))
            {
                dataGridView1.Columns["DeliveryDate"].ReadOnly = false;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            e.Cancel = false;
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;
            //if (headerText == "QTY")
            //{
            //    if (e.FormattedValue == DBNull.Value || e.FormattedValue.ToString() == "")
            //    {
            //        clsUtility.ShowInfoMessage("Enter QTY..");
            //        e.Cancel = true;
            //    }
            //    else if (Convert.ToInt32(e.FormattedValue) == 0)
            //    {
            //        clsUtility.ShowInfoMessage("Enter Valid QTY..");
            //        e.Cancel = true;
            //    }
            //    return;
            //}
            if (headerText == "Trim Amount")
            {
                //if (e.FormattedValue == DBNull.Value || e.FormattedValue.ToString() == "")
                //{
                //    clsUtility.ShowInfoMessage("Enter Trim Amount..");
                //    e.Cancel = true;
                //}
                if (e.FormattedValue != DBNull.Value && Convert.ToDecimal(e.FormattedValue) < 0)
                {
                    clsUtility.ShowInfoMessage("Enter Trim Amount..");
                    e.Cancel = true;
                }
                return;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;

            if (headerText == "Trim Amount")
            {
                e.Control.KeyPress += Decimal_Control_KeyPress;
            }
            //else if (headerText == "QTY")
            //{
            //    e.Control.KeyPress += Int_Control_KeyPress;
            //}
            else if (headerText == "Service")
            {
                cmbService = (KryptonComboBox)e.Control;
                if (cmbService != null)
                {
                    if (cmbService.SelectedItem != null)
                    {
                        //cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
                        cmbService.SelectionChangeCommitted += CmbService_SelectionChangeCommitted;
                    }
                }
            }
            else if (headerText == "TrailDate")
            {
                kdtTrailDate = (KryptonDateTimePicker)e.Control;

                //kdtTrailDate.MinDate = dtTrailDate;
                kdtTrailDate.Validating += KdtTrailDate_Validating;

                //System.Diagnostics.Debug.WriteLine("Event Register TrailDate");

            }
            else if (headerText == "DeliveryDate")
            {
                kdtDeliveryDate = (KryptonDateTimePicker)e.Control;

                //kdtDeliveryDate.MinDate = dtDeliveryDate;

                kdtDeliveryDate.Validating += KdtDeliveryDate_Validating;
                //System.Diagnostics.Debug.WriteLine("Event Register DeliveryDate");
            }
        }

        private void KdtDeliveryDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dtDelivery = kdtDeliveryDate.Value;

            //System.Diagnostics.Debug.WriteLine("kdtDeliveryDate.Value "+ kdtDeliveryDate.Value+ " kdtTrailDate.Checked"+ kdtTrailDate.Checked);

            if (kdtTrailDate.Checked)
            {
                e.Cancel = false;
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value != DBNull.Value)
                {

                    DateTime dtTrail = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value);

                    //System.Diagnostics.Debug.WriteLine("dtTrail "+ dtTrail);

                    if (dtTrail >= dtDelivery)
                    {
                        clsUtility.ShowInfoMessage("Delivery Date should not be equal or less then Trail Date");
                        //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = DBNull.Value;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = dtPrevDeliveryDate;
                        //kdtDeliveryDate.Value = dtPrevDeliveryDate;
                        e.Cancel = true;
                        return;
                    }
                    else if (dtDelivery <= dtpBookingDate.Value)
                    {
                        clsUtility.ShowInfoMessage("Delivery Date should not be equal less then to Booking Date");
                        //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = DBNull.Value;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = dtPrevDeliveryDate;
                        //kdtDeliveryDate.Value = dtPrevDeliveryDate;
                        //kdtTrailDate.Checked = false;

                        e.Cancel = true;
                        return;
                    }
                }
                else if (dtDelivery <= dtpBookingDate.Value)
                {
                    clsUtility.ShowInfoMessage("Delivery Date should not be equal less then to Booking Date");
                    //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = DBNull.Value;
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = dtPrevDeliveryDate;
                    //kdtDeliveryDate.Value = dtPrevDeliveryDate;
                    //kdtTrailDate.Checked = false;

                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                if (dtDelivery <= dtpBookingDate.Value)
                {
                    clsUtility.ShowInfoMessage("Delivery Date should not be equal less then to Booking Date");
                    //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = DBNull.Value;
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = dtPrevDeliveryDate;
                    //kdtDeliveryDate.Value = dtPrevDeliveryDate;
                    //kdtTrailDate.Checked = false;

                    e.Cancel = true;
                    return;
                }
            }
            kdtDeliveryDate.Validating -= KdtDeliveryDate_Validating;
        }

        private void KdtTrailDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dtDelivery = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value != DBNull.Value ? Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value) : dtPrevDeliveryDate;

            //System.Diagnostics.Debug.WriteLine("dtDelivery " + dtDelivery + " dtPrevDeliveryDate " + dtPrevDeliveryDate+ " kdtTrailDate.Checked "+ kdtTrailDate.Checked);

            if (kdtTrailDate.Checked)
            {
                e.Cancel = false;
                if (kdtTrailDate.Value != null)
                {
                    string strTrail = kdtTrailDate.Value.ToShortDateString();
                    DateTime dtTrail = Convert.ToDateTime(strTrail);

                    //System.Diagnostics.Debug.WriteLine("kdtTrailDate.Value " + kdtTrailDate.Value + " dtpBookingDate.Value " + dtpBookingDate.Value + " dtTrail " + dtTrail);

                    if (dtTrail >= dtDelivery)
                    {
                        clsUtility.ShowInfoMessage("Trail Date should not be equal or greater then Delivery Date");

                        //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value = DBNull.Value;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value = dtPrevTrailDate;
                        //kdtTrailDate.Value = dtPrevTrailDate;
                        //kdtTrailDate.Checked = false;

                        e.Cancel = true;
                        return;
                    }
                    else if (dtTrail <= dtpBookingDate.Value)
                    {
                        clsUtility.ShowInfoMessage("Trail Date should not be equal or less then to Booking Date");

                        //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value = DBNull.Value;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TrailDate"].Value = dtPrevTrailDate;

                        //kdtTrailDate.Checked = false;

                        e.Cancel = true;
                        return;
                    }
                }
            }
            else
            {
                if (dtDelivery <= dtpBookingDate.Value)
                {
                    clsUtility.ShowInfoMessage("Delivery Date should not be equal less then to Booking Date");
                    //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = DBNull.Value;
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["DeliveryDate"].Value = dtPrevDeliveryDate;
                    //kdtTrailDate.Checked = false;

                    e.Cancel = true;
                    return;
                }
            }
            kdtTrailDate.Validating -= KdtTrailDate_Validating;
        }

        private void CmbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GridServiceIndex = cmbService.SelectedIndex;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ServiceID"].Value = GridServiceIndex;

            int pGarmentID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["GarmentID"].Value);

            DataTable dt = GetProductRate(pGarmentID, GridServiceIndex);
            if (ObjUtil.ValidateTable(dt))
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Rate"].Value = dt.Rows[0]["Rate"];
                CalcTotalAmount();
            }
            //cmbService.SelectionChangeCommitted -= CmbService_SelectionChangeCommitted;
            //return;
        }

        private void Int_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string k = e.KeyChar.ToString();
            //TextBox txt = (TextBox)sender;
            //KryptonTextBox txt = (KryptonTextBox)sender;
            e.Handled = ObjUtil.IsNumeric(e);
        }

        private void Decimal_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string k = e.KeyChar.ToString();
            //TextBox txt = (TextBox)sender;
            KryptonTextBox txt = (KryptonTextBox)sender;
            e.Handled = ObjUtil.IsDecimal(txt, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "QTY" || dataGridView1.Columns[e.ColumnIndex].Name == "Trim Amount" || dataGridView1.Columns[e.ColumnIndex].Name == "Rate")
                {
                    int QTY = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);
                    double trimamt = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["TrimAmount"].Value);
                    double Rate = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Rate"].Value);
                    double Total = (QTY * Rate) + trimamt;

                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = Math.Round(Total).ToString();

                    CalcTotalAmount();
                }
            }
        }

        private void dtpTrailDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTrailDate.Checked)
            {
                if (dtpTrailDate.Value >= dtpDeliveryDate.Value)
                {
                    clsUtility.ShowInfoMessage("Trail Date should not be equal or greater then Delivery Date");
                    dtpTrailDate.Value = dtTrailDate;

                    e.Cancel = true;
                    dtpTrailDate.Checked = false;
                    dtpTrailDate.Focus();
                }
            }
        }

        private void dtpDeliveryDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTrailDate.Checked)
            {
                if (dtpTrailDate.Value >= dtpDeliveryDate.Value)
                {
                    clsUtility.ShowInfoMessage("Delivery Date should not be equal or greater then Trail Date");
                    dtpDeliveryDate.Value = dtDeliveryDate;

                    e.Cancel = true;

                    dtpDeliveryDate.Focus();
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "TrailDate")
                {
                    if (kdtTrailDate.Checked)
                    {
                        dtPrevTrailDate = dataGridView1.Rows[e.RowIndex].Cells["TrailDate"].Value != DBNull.Value ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TrailDate"].Value) : dtTrailDate;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeliveryDate")
                {
                    dtPrevDeliveryDate = dataGridView1.Rows[e.RowIndex].Cells["DeliveryDate"].Value != DBNull.Value ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DeliveryDate"].Value) : dtDeliveryDate;
                }

            }
        }

        private void txtTailoringAmount_Enter(object sender, EventArgs e)
        {
            lblCGST.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ColDelete")
                {
                    int pSalesOrderDetailsID = 0;
                    //pSalesOrderDetailsID = dataGridView1.Rows[e.RowIndex].Cells["SalesOrderDetailsID"].Value == DBNull.Value
                    //    ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SalesOrderDetailsID"].Value);

                    DialogResult d = MessageBox.Show("Are you sure want to delete ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        int a = 0;
                        DataTable dt = (DataTable)dataGridView1.DataSource;

                        //if (pSalesOrderDetailsID > 0)
                        //{
                        //    a = ObjDAL.DeleteData(clsUtility.DBName + ".[dbo].[tblSalesOrderDetails]", "SalesOrderDetailsID=" + pSalesOrderDetailsID);
                        //}
                        if (a > 0 || pSalesOrderDetailsID == 0)
                        {
                            dt.Rows[e.RowIndex].Delete();
                            dt.AcceptChanges();
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Unable to delete Garment Name. " + dataGridView1.Rows[e.RowIndex].Cells["GarmentName"].Value, clsUtility.strProjectTitle);
                        }
                        dataGridView1.DataSource = dt;
                        AdddtOrder(); // Refresh Order QTY
                        CalcTotalAmount();
                    }
                }
            }
        }
    }
}