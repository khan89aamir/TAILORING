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
    public partial class frmOrderList : KryptonForm
    {
        public frmOrderList()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        //Image B_Leave = TAILORING.Properties.Resources.B_click;
        //Image B_Enter = TAILORING.Properties.Resources.B_on;

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = TAILORING.Properties.Resources.Background;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvOrderDetails.RowHeadersVisible = false; // set it to false if not needed

            LoadTailoringTheme();

            radByDate_CheckedChanged(sender, e);
            SearchByDates();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                clsUtility.ShowInfoMessage("From date can not be greater then To Date.");
                return;
            }
            SearchByDates();
        }

        private void radByCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (radByCustomerName.Checked)
            {
                txtCustomerName.Enabled = true;
                txtCustomerName.Focus();
            }
            else
            {
                txtCustomerName.Enabled = false;
                txtCustomerName.Clear();
            }
        }

        private void radByCustomerMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radByCustomerMobileNo.Checked)
            {
                txtCustomerMobileNo.Enabled = true;
                txtCustomerMobileNo.Focus();
            }
            else
            {
                txtCustomerMobileNo.Enabled = false;
                txtCustomerMobileNo.Clear();
            }
        }

        private void radByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radByDate.Checked)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
                dtpFromDate.Focus();
            }
            else
            {
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAll.Checked)
            {
                ShowAll();

                txtCustomerName.Enabled = false;
                txtCustomerName.Clear();

                txtCustomerMobileNo.Enabled = false;
                txtCustomerMobileNo.Clear();

                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void ShowAll()
        {
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("FromDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ToDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderList]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = dgvOrderDetails.Rows.Count.ToString();
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void SearchByCustomerName()
        {
            int CustomerID = txtCustomerID.Text.Length > 0 ? Convert.ToInt32(txtCustomerID.Text) : 0;
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, CustomerID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("FromDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ToDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderList]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = dgvOrderDetails.Rows.Count.ToString();
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void SearchByCustomerMobileNo()
        {
            int CustomerID = txtCustomerID.Text.Length > 0 ? Convert.ToInt32(txtCustomerID.Text) : 0;
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, CustomerID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("FromDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ToDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderList]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = dgvOrderDetails.Rows.Count.ToString();
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void SearchByDates()
        {
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("FromDate", SqlDbType.Date, dtpFromDate.Value.ToString("yyyy-MM-dd"), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ToDate", SqlDbType.Date, dtpToDate.Value.ToString("yyyy-MM-dd"), clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderList]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    //try
                    //{
                    //    DataRelation Datatablerelation = new DataRelation("OrderDetails", ds.Tables[0].Columns["SalesOrderID"], ds.Tables[1].Columns["SalesOrderID"], true);
                    //    ds.Relations.Add(Datatablerelation);
                    //}
                    //catch { }
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = dgvOrderDetails.Rows.Count.ToString();
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtCustomerName.Text, clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, '0', clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtCustomerName, "Name");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");
                        ObjUtil.ShowDataPopup(dt, txtCustomerName, this, groupBox1);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["LastChange"].Visible = false;
                                ObjUtil.SetDataPopupSize(350, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += frmOrderDetails_SearchByCustomerName_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += frmOrderDetails_SearchByCustomerName_KeyDown;
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

        private void frmOrderDetails_SearchByCustomerName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = (DataTable)dgv.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                txtCustomerName.SelectionStart = txtCustomerName.MaxLength;
                txtCustomerName.Focus();
                SearchByCustomerName();
            }
        }

        private void frmOrderDetails_SearchByCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCustomerName.SelectionStart = txtCustomerName.MaxLength;
                txtCustomerName.Focus();
                SearchByCustomerName();
            }
        }

        private void frmOrderDetails_SearchByCustomerMobileNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = (DataTable)dgv.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                txtCustomerMobileNo.SelectionStart = txtCustomerMobileNo.MaxLength;
                txtCustomerMobileNo.Focus();
                SearchByCustomerMobileNo();
            }
        }

        private void frmOrderDetails_SearchByCustomerMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCustomerMobileNo.SelectionStart = txtCustomerMobileNo.MaxLength;
                txtCustomerMobileNo.Focus();
                SearchByCustomerMobileNo();
            }
        }

        private void txtCustomerMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerMobileNo.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCustomerMobileNo.Text, clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtCustomerMobileNo, "MobileNo");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");
                        ObjUtil.ShowDataPopup(dt, txtCustomerMobileNo, this, groupBox1);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["LastChange"].Visible = false;
                                ObjUtil.SetDataPopupSize(350, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += frmOrderDetails_SearchByCustomerMobileNo_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += frmOrderDetails_SearchByCustomerMobileNo_KeyDown;
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

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            SearchByDates();
        }

        private void Int_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string k = e.KeyChar.ToString();
            //TextBox txt = (TextBox)sender;
            e.Handled = ObjUtil.IsNumeric(e);
        }

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrderDetails.Columns["CustomerID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;

            if (dgvOrderDetails.Columns.Contains("ColViewDetail"))
            {
                dgvOrderDetails.Columns.Remove("ColViewDetail");
            }
            if (dgvOrderDetails.Columns.Contains("ColViewMeasure"))
            {
                dgvOrderDetails.Columns.Remove("ColViewMeasure");
            }
            DataGridViewButtonColumn ColViewDetail = new DataGridViewButtonColumn();
            ColViewDetail.DataPropertyName = "ViewDetail";
            ColViewDetail.HeaderText = "ViewDetail";
            ColViewDetail.Name = "ColViewDetail";
            ColViewDetail.Text = "ViewDetail";
            ColViewDetail.UseColumnTextForButtonValue = true;
            //dgvOrderDetails.Columns.Add(ColViewDetail);
            dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColViewDetail });

            DataGridViewButtonColumn ColViewMeasure = new DataGridViewButtonColumn();
            ColViewMeasure.DataPropertyName = "ViewMeasure";
            ColViewMeasure.HeaderText = "ViewMeasure";
            ColViewMeasure.Name = "ColViewMeasure";
            ColViewMeasure.Text = "ViewMeasure";
            ColViewMeasure.UseColumnTextForButtonValue = true;
            //dgvOrderDetails.Columns.Add(ColViewMeasure);
            dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColViewMeasure });
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "ColViewDetail")
                {
                    int pSalesOrderID = 0;
                    pSalesOrderID = dgvOrderDetails.Rows[e.RowIndex].Cells["SalesOrderID"].Value == DBNull.Value
                        ? 0 : Convert.ToInt32(dgvOrderDetails.Rows[e.RowIndex].Cells["SalesOrderID"].Value);

                    frmOrderDetails Obj = new frmOrderDetails();
                    Obj.SalesOrderID = pSalesOrderID;
                    Obj.ShowDialog();
                }
                else if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "ColViewMeasure")
                {
                    int pSalesOrderID = 0;
                    string pOrderNo = "NA";
                    pSalesOrderID = dgvOrderDetails.Rows[e.RowIndex].Cells["SalesOrderID"].Value == DBNull.Value
                        ? 0 : Convert.ToInt32(dgvOrderDetails.Rows[e.RowIndex].Cells["SalesOrderID"].Value);
                    pOrderNo = dgvOrderDetails.Rows[e.RowIndex].Cells["OrderNo"].Value.ToString();

                    frmViewMeasurementStyle Obj = new frmViewMeasurementStyle();
                    Obj.pOrderID = pSalesOrderID;
                    Obj.OrderNo = pOrderNo;
                    Obj.ShowDialog();
                }
            }
        }
    }
}