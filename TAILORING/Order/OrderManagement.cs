﻿using System;
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

            InitItemTable();
            InitOrderDetailsTable(); //Order Details
            InitMeasurementTable(); //Measurement
            InitStyleTable(); //Style
            InitBodyPostureTable(); //BodyPosture
        }

        private void InitItemTable()
        {
            //Gridview
            dtOrder.Columns.Add("GarmentID");
            dtOrder.Columns.Add("StichTypeID");
            dtOrder.Columns.Add("FitTypeID");
            dtOrder.Columns.Add("FabricCode");
            dtOrder.Columns.Add("GarmentCode");
            dtOrder.Columns.Add("GarmentName");
            dtOrder.Columns.Add("Trim Amount");
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
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblProductMaster", "GarmentID,GarmentName,Rate", "OrderType=" + cmbOrderType.SelectedIndex, "GarmentName ASC");
            if (ObjUtil.ValidateTable(dt))
            {
                cmbGarmentName.DataSource = dt;
                cmbGarmentName.DisplayMember = "GarmentName";
                cmbGarmentName.ValueMember = "GarmentID";
            }
            else
            {
                cmbGarmentName.DataSource = null;
            }

            cmbGarmentName.SelectedIndex = -1;
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
            }
        }

        private void txtSearchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCustomerName.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtSearchByCustomerName.Text, clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, '0', clsConnection_DAL.ParamType.Input);
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
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.SetDataPopupSize(350, 0);
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
            if (dt != null && dt.Rows.Count > 0)
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();
                lblCustomerName.Text = dt.Rows[0]["Name"].ToString();
                lblCustomerAdd.Text = dt.Rows[0]["Address"].ToString();
            }
            cmbOrderType.Enabled = true;
        }

        private void frmOrderManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();

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
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["Photo"].Visible = false;

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
            dRow["FabricCode"] = "sh12";
            dRow["GarmentCode"] = "sh12";
            dRow["GarmentID"] = 1;
            dRow["GarmentName"] = "Shirt";
            dRow["Trim Amount"] = 0;
            dRow["Rate"] = 100;
            dRow["QTY"] = 1;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Shirt generic 1.png";
            dRow["Total"] = 0 + (1 * 100);

            dtOrder.Rows.Add(dRow);

            dRow = dtOrder.NewRow();
            dRow["FabricCode"] = "sh12";
            dRow["GarmentCode"] = "th01";
            dRow["GarmentID"] = 1002;
            dRow["GarmentName"] = "Trouser";
            dRow["Trim Amount"] = 0;
            dRow["Rate"] = 100;
            dRow["QTY"] = 2;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Trouser Generic 1.gif";
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
            object total = dtOrder.Compute("SUM(Total)", string.Empty);
            txtTailoringAmount.Text = total.ToString();
            txtGrossAmt.Text= total.ToString();

            double advancepaid = txtAdvancePaid.Text.Length > 0 ? Convert.ToDouble(txtAdvancePaid.Text) : 0;
            txtAmtToBePaid.Text = (Convert.ToDouble(total) - advancepaid).ToString();
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

        private void txtAdvancePaid_TextChanged(object sender, EventArgs e)
        {
            if (txtAdvancePaid.Text.Length > 0)
            {
                double total = txtTailoringAmount.Text.Length > 0 ? Convert.ToDouble(txtTailoringAmount.Text) : 0;
                if (Convert.ToDouble(txtAdvancePaid.Text) > total)
                {
                    clsUtility.ShowInfoMessage("Advance payment can't be exceeded with Tailoring amount..");
                    txtAdvancePaid.Text = "0";
                    return;
                }
            }
            CalcTotalAmount();
        }

        private void ResetGarmentDetails()
        {
            cmbGarmentName.SelectedIndex = -1;
            txtRate.Text = "0.00";
            NumericQTY.Value = 1;
            txtTrimsAmount.Text = "0";
            txtFabricCode.Text = "";
            txtFabricCode.Focus();
        }

        private void ClearAll()
        {
            txtGrossAmt.Text = "0";
            txtAdvancePaid.Text = "0";
            txtAmtToBePaid.Text = "0";
            txtTailoringAmount.Text = "0";
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
            ObjDAL.SetColumnData("AdvanceAmount", SqlDbType.Decimal, txtAdvancePaid.Text.Length == 0 ? "0" : txtAdvancePaid.Text);
            ObjDAL.SetColumnData("OrderAmount", SqlDbType.Decimal, txtAmtToBePaid.Text);
            ObjDAL.SetColumnData("OrderQTY", SqlDbType.Int, pQTY);
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
    }
}