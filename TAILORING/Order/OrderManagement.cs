using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmOrderManagement : Form
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        DataTable dt = null;

        DataTable dtOrder = new DataTable();
        DataTable dtOrderDetails = new DataTable();

        DataSet dsMeasure = new DataSet();
        DataTable dtMeasurement = new DataTable();
        DataTable dtStyle = new DataTable();
        DataTable dtBodyPosture = new DataTable();

        int CustomerID = 0;
        int OrderID = 0;
        string InvoiceNo = string.Empty;

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            btnMeasurement.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnSaveCustomer.BackgroundImage = B_Leave;
            btnNewCustomer.BackgroundImage = B_Leave;

            InitItemTable();
            InitOrderDetailsTable(); //Order Details
            InitMeasurementTable(); //Measurement
            InitStyleTable(); //Style
            InitBodyPostureTable(); //BodyPosture
            FillGSTData();// Load CGST,SGST

            dtpTrailDate.Value.AddDays(4);
            dtpDeliveryDate.Value.AddDays(5);
        }

        private void InitItemTable()
        {
            //Gridview
            dtOrder.Columns.Add("GarmentID");
            dtOrder.Columns.Add("StichTypeID");
            dtOrder.Columns.Add("FitTypeID");
            dtOrder.Columns.Add("GarmentCode");
            dtOrder.Columns.Add("GarmentName");
            dtOrder.Columns.Add("Service");
            dtOrder.Columns.Add("TrailDate");
            dtOrder.Columns.Add("DeliveryDate");
            dtOrder.Columns.Add("Trim Amount");
            dtOrder.Columns.Add("ServiceID", typeof(int));
            dtOrder.Columns.Add("QTY", typeof(int));
            dtOrder.Columns.Add("Rate", typeof(double));
            dtOrder.Columns.Add("Total", typeof(double));
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
            dt = null;
            //dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblProductMaster", "GarmentID,GarmentName,Rate", "OrderType=" + cmbOrderType.SelectedIndex, "GarmentName ASC");
            ObjDAL.SetStoreProcedureData("OrderType", SqlDbType.Int, cmbOrderType.SelectedIndex, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product_Rate");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dt = ds.Tables[0];
                cmbGarmentName.DataSource = dt;
                cmbGarmentName.DisplayMember = "GarmentCodeName";
                cmbGarmentName.ValueMember = "GarmentID";
            }
            else
            {
                cmbGarmentName.DataSource = null;
            }

            cmbGarmentName.SelectedIndex = -1;
        }
        double CGST = 0, SGST = 0;
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

                    lblCGST.Text = lblCGST.Text + " (" + CGST + ") :";
                    lblSGST.Text = lblSGST.Text + " (" + SGST + ") :";
                }
                txtCGST.Text = "0";
                txtSGST.Text = "0";
            }
        }

        private void rdSearchByCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCustomerName.Checked)
            {
                txtSearchByCustomerName.Enabled = true;
                txtSearchByCustomerName.Focus();
            }
            else
            {
                txtSearchByCustomerName.Enabled = false;
                txtSearchByCustomerName.Clear();

                ClearCustomerFields(false);
            }
        }

        private void rdSearchByCustomerMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCustomerMobileNo.Checked)
            {
                txtSearchByMobileNo.Enabled = true;
                txtSearchByMobileNo.Focus();
            }
            else
            {
                txtSearchByMobileNo.Enabled = false;
                txtSearchByMobileNo.Clear();

                ClearCustomerFields(false);
            }
        }

        private void txtSearchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCustomerName.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtSearchByCustomerName.Text, clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, '0', clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtSearchByCustomerName, "Name");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");
                        ObjUtil.ShowDataPopup(dt, txtSearchByCustomerName, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.SetDataPopupSize(278, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += frmOrderManagement_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += frmOrderManagement_KeyDown;
                    }
                    else
                    {
                        ObjUtil.CloseAutoExtender();
                    }
                }
            }
            else
            {
                txtCustomerID.Clear();
                ObjUtil.CloseAutoExtender();
            }
        }

        private void frmOrderManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = (DataTable)dgv.DataSource;
            if (ObjUtil.ValidateTable(dt))
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();
                txtCustomerName.Text = dt.Rows[0]["Name"].ToString();
                txtCustomerAdd.Text = dt.Rows[0]["Address"].ToString();
                txtCustomerMobileNo.Text = dt.Rows[0]["MobileNo"].ToString();

                btnMeasurement.Enabled = true;
            }
            else
            {
                btnMeasurement.Enabled = false;
            }
            cmbOrderType.Enabled = true;
        }

        private void frmOrderManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();
                SearchByCustomerID();
            }
            cmbOrderType.Enabled = true;
        }

        private void SearchByCustomerID()
        {
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, '0', clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, txtCustomerID.Text, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    txtCustomerName.Text = dt.Rows[0]["Name"].ToString();
                    txtCustomerAdd.Text = dt.Rows[0]["Address"].ToString();
                    txtCustomerMobileNo.Text = dt.Rows[0]["MobileNo"].ToString();

                    btnMeasurement.Enabled = true;
                }
                else
                {
                    btnMeasurement.Enabled = false;
                }
            }
        }

        private void frmOrderManagement_Mobile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = (DataTable)dgv.DataSource;
            if (ObjUtil.ValidateTable(dt))
            {
                txtSearchByMobileNo.SelectionStart = txtSearchByMobileNo.MaxLength;
                txtSearchByMobileNo.Focus();
                txtCustomerName.Text = dt.Rows[0]["Name"].ToString();
                txtCustomerAdd.Text = dt.Rows[0]["Address"].ToString();
                txtCustomerMobileNo.Text = dt.Rows[0]["MobileNo"].ToString();

                btnMeasurement.Enabled = true;
            }
            else
            {
                btnMeasurement.Enabled = false;
            }
            cmbOrderType.Enabled = true;
        }

        private void frmOrderManagement_Mobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSearchByMobileNo.SelectionStart = txtSearchByMobileNo.MaxLength;
                txtSearchByMobileNo.Focus();
                SearchByCustomerID();
                //lblCustomerName.Text = dgv.Rows[0].Cells["Name"].ToString();
                //lblCustomerAdd.Text = dgv.Rows[0].Cells["Address"].ToString();
            }
            cmbOrderType.Enabled = true;
        }

        private void cmbOrderType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpNewOrder.Enabled = true;
            cmbGarmentName.Focus();
            FillGarmentData();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                ObjUtil.SetRowNumber(dataGridView1);
                ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
                dataGridView1.Columns["GarmentID"].Visible = false;
                dataGridView1.Columns["Photo"].Visible = false;
                if (dataGridView1.Columns.Contains("ServiceID"))
                {
                    dataGridView1.Columns["ServiceID"].Visible = false;
                }
                if (dataGridView1.Columns.Contains("Measurement"))
                {
                    dataGridView1.Columns["Measurement"].Visible = false;
                }
                if (dataGridView1.Columns.Contains("Style"))
                {
                    dataGridView1.Columns["Style"].Visible = false;
                }
                //if (dataGridView1.Columns.Contains("StichTypeID"))
                //{
                dataGridView1.Columns["StichTypeID"].Visible = false;
                //}
                //if (dataGridView1.Columns.Contains("FitTypeID"))
                //{
                dataGridView1.Columns["FitTypeID"].Visible = false;
                //}
                CalcTotalAmount();

                if (dataGridView1.Columns.Contains("ColDelete"))
                {
                    dataGridView1.Columns.Remove("ColDelete");
                }
                DataGridViewButtonColumn ColDelete = new DataGridViewButtonColumn();
                ColDelete.DataPropertyName = "Delete";
                ColDelete.HeaderText = "Delete";
                ColDelete.Name = "ColDelete";
                ColDelete.Text = "Delete";
                ColDelete.UseColumnTextForButtonValue = true;
                //dataGridView1.Columns.Add(ColDelete);
                dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColDelete });
            }
            catch { }
        }

        private void cmbGarmentName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] drow = dt.Select("GarmentID=" + cmbGarmentName.SelectedValue);
            if (drow.Length > 0)
            {
                txtRate.Text = drow[0]["Rate"].ToString();
            }
            else
            {
                txtRate.Text = "0";
            }
            lnkAddItem.Enabled = true;
        }

        private void AddDefaultRow()
        {
            DataRow dRow = dtOrder.NewRow();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //decimal trim = (txtTrimsAmount.Text.Length > 0 ? Convert.ToDecimal(txtTrimsAmount.Text) : 0);

            //DataRow dRow = dtOrder.NewRow();
            //dRow["GarmentID"] = cmbGarmentName.SelectedValue;
            //dRow["GarmentName"] = cmbGarmentName.Text;
            //dRow["Trim Amount"] = trim;
            //dRow["Rate"] = txtRate.Text;
            //dRow["QTY"] = NumericQTY.Value;
            //dRow["Total"] = trim + (NumericQTY.Value * Convert.ToDecimal(txtRate.Text));

            //dtOrder.Rows.Add(dRow);
            //dtOrder.AcceptChanges();

            AddDefaultRow();
            dataGridView1.DataSource = dtOrder;
            ResetGarmentDetails();
        }

        private void CalcTotalAmount()
        {
            object total = 0;
            double pCGST = 0, pSGST = 0, GrossAmt = 0;
            try
            {
                if (ObjUtil.ValidateTable(dtOrder) && ObjUtil.ValidateTable((DataTable)dataGridView1.DataSource))
                {
                    total = dtOrder.Compute("SUM(Total)", string.Empty);
                }

                txtTailoringAmount.Text = total.ToString();
                pCGST = CGST * 0.01;
                pSGST = SGST * 0.01;
                GrossAmt = Convert.ToDouble(total) + ((Convert.ToDouble(total) * pCGST) + (Convert.ToDouble(total) * pSGST));
                txtGrossAmt.Text = GrossAmt.ToString();
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
            txtRate.Text = "0.00";
            NumericQTY.Value = 1;
            txtTrimsAmount.Text = "0";
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

            OrderID = 0;
            CustomerID = 0;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void txtSearchByCustomerName_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtSearchByCustomerName_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
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
                            ClearAll();
                            dataGridView1.DataSource = null;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Invoice is not Generated.");
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
            ObjDAL.SetColumnData("OrderAmount", SqlDbType.Decimal, txtGrossAmt.Text);
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
            for (int i = 0; i < dtOrder.Rows.Count; i++) //Sales Details
            {
                DataRow drow = dtOrderDetails.NewRow();
                drow["SalesOrderID"] = OrderID;
                drow["StichTypeID"] = dtOrder.Rows[i]["StichTypeID"];
                drow["FitTypeID"] = dtOrder.Rows[i]["FitTypeID"];
                drow["GarmentID"] = dtOrder.Rows[i]["GarmentID"];
                drow["Service"] = dtOrder.Rows[i]["ServiceID"];
                drow["TrailDate"] = Convert.ToDateTime(dtOrder.Rows[i]["TrailDate"]).ToString("yyyy-MM-dd");
                drow["DeliveryDate"] = Convert.ToDateTime(dtOrder.Rows[i]["DeliveryDate"]).ToString("yyyy-MM-dd");
                drow["TrimAmount"] = dtOrder.Rows[i]["Trim Amount"];
                drow["QTY"] = dtOrder.Rows[i]["QTY"];
                drow["Rate"] = dtOrder.Rows[i]["Rate"];
                drow["Total"] = dtOrder.Rows[i]["Total"];
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

            b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_SalesOrderDetails");
            if (!b)
            {
                DeleteSalesOrder();
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
            if (dataGridView1.Columns.Contains("QTY"))
            {
                dataGridView1.Columns["QTY"].ReadOnly = false;
            }
            if (dataGridView1.Columns.Contains("Trim Amount"))
            {
                dataGridView1.Columns["Trim Amount"].ReadOnly = false;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            e.Cancel = false;
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;
            if (headerText == "QTY")
            {
                if (e.FormattedValue == DBNull.Value || e.FormattedValue.ToString() == "")
                {
                    clsUtility.ShowInfoMessage("Enter QTY..");
                    e.Cancel = true;
                }
                else if (Convert.ToInt32(e.FormattedValue) == 0)
                {
                    clsUtility.ShowInfoMessage("Enter Valid QTY..");
                    e.Cancel = true;
                }
                return;
            }
            //else if (headerText == "Trim Amount")
            //{
            //    if (e.FormattedValue == DBNull.Value || e.FormattedValue.ToString() == "")
            //    {
            //        clsUtility.ShowInfoMessage("Enter Trim Amount..");
            //        e.Cancel = true;
            //    }
            //    else if (Convert.ToDecimal(e.FormattedValue) == 0)
            //    {
            //        clsUtility.ShowInfoMessage("Enter Trim Amount..");
            //        e.Cancel = true;
            //    }
            //    return;
            //}
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;

            if (headerText == "Trim Amount")
            {
                e.Control.KeyPress += Decimal_Control_KeyPress;
            }
            else if (headerText == "QTY")
            {
                e.Control.KeyPress += Int_Control_KeyPress;
            }
        }

        private void Int_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string k = e.KeyChar.ToString();
            //TextBox txt = (TextBox)sender;
            e.Handled = ObjUtil.IsNumeric(e);
        }

        private void Decimal_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string k = e.KeyChar.ToString();
            TextBox txt = (TextBox)sender;
            e.Handled = ObjUtil.IsDecimal(txt, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "QTY" || dataGridView1.Columns[e.ColumnIndex].Name == "Trim Amount")
                {
                    int QTY = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);
                    double trimamt = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Trim Amount"].Value);
                    double Rate = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Rate"].Value);
                    double Total = (QTY * Rate) + trimamt;

                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = Math.Round(Total).ToString();

                    CalcTotalAmount();
                }
            }
        }

        private void txtSearchByCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsString(e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Valid Customer Name...", clsUtility.strProjectTitle);
                txtSearchByCustomerName.Focus();
            }
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
                        CalcTotalAmount();
                    }
                }
            }
        }

        private void txtSearchByMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByMobileNo.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtSearchByMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtSearchByMobileNo, "MobileNo");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");
                        ObjUtil.ShowDataPopup(dt, txtSearchByMobileNo, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.SetDataPopupSize(278, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += frmOrderManagement_Mobile_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += frmOrderManagement_Mobile_KeyDown;
                    }
                    else
                    {
                        ObjUtil.CloseAutoExtender();
                    }
                }
            }
            else
            {
                txtCustomerID.Clear();
                ObjUtil.CloseAutoExtender();
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ClearCustomerFields(true);
            txtCustomerName.Focus();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        private void SaveCustomer()
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtCustomerName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCustomerAdd.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCustomerMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Output);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Customer");
                        if (b)
                        {
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is Saved Successfully..");

                            DataTable dtout = ObjDAL.GetOutputParmData();
                            if (ObjUtil.ValidateTable(dtout))
                            {
                                CustomerID = Convert.ToInt32(dt.Rows[0][1]);
                                txtCustomerID.Text = CustomerID.ToString();
                                lnkAddItem.Enabled = true;
                                btnMeasurement.Enabled = true;
                            }
                            ClearCustomerFields(false);
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is not Saved Successfully..");
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is already exist..");
                        txtCustomerName.Focus();
                    }
                }
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtCustomerName))
            {
                clsUtility.ShowInfoMessage("Enter Customer Name       ", clsUtility.strProjectTitle);
                txtCustomerName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCustomerMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Customer Mobile No.      ", clsUtility.strProjectTitle);
                txtCustomerMobileNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCustomerAdd))
            {
                clsUtility.ShowInfoMessage("Enter Customer Address.      ", clsUtility.strProjectTitle);
                txtCustomerAdd.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CustomerMaster", "MobileNo='" + txtCustomerMobileNo.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CustomerMaster", "MobileNo='" + txtCustomerMobileNo.Text + "' AND CustomerID !=" + i);
            }
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearCustomerFields(bool b)
        {
            if (b == false)
            {
                txtCustomerName.Clear();
                txtCustomerMobileNo.Clear();
                txtCustomerAdd.Clear();
            }
            txtCustomerName.Enabled = b;
            txtCustomerMobileNo.Enabled = b;
            txtCustomerAdd.Enabled = b;
            btnSaveCustomer.Enabled = b;
        }
    }
}