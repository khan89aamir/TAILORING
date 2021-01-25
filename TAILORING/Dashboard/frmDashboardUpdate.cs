using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Dashboard
{
    public partial class frmDashboardUpdate : KryptonForm
    {
        public frmDashboardUpdate()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void frmDashboardUpdate_Load(object sender, EventArgs e)
        {
            label4.Text = "Date : " + DateTime.Now.ToShortDateString();
            //this.BackgroundImage = Properties.Resources.Background;
            this.BackColor = Color.FromArgb(82, 91, 114);
        }

        private void SearchByCustomerName()
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
                    int CustomerID = 0;
                    string strCustName = string.Empty;
                    string strMobileNo = string.Empty;
                    string strAddress = string.Empty;

                    strCustName = dt.Rows[0]["Name"].ToString();
                    strMobileNo = dt.Rows[0]["MobileNo"].ToString();
                    strAddress = dt.Rows[0]["Address"].ToString();
                    CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);

                    if (dt.Rows.Count > 1)
                    {
                        clsUtility.ShowInfoMessage(dt.Rows.Count + " Customers Name " + txtSearchByCustomerName.Text + " is found");
                    }
                    Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                    Obj.CustomerID = CustomerID;
                    Obj.CustName = strCustName;
                    Obj.CustMobileNo = strMobileNo;
                    Obj.CustAddress = strAddress;
                    this.Close();
                    Obj.ShowDialog();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Customer Name " + txtSearchByCustomerName.Text + " is not found");
                    txtSearchByCustomerName.Focus();
                }
            }

        }

        private void SearchByCustomerMobileNo()
        {
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtSearchByCustomerMobileNo.Text, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    int CustomerID = 0;
                    string strCustName = string.Empty;
                    string strMobileNo = string.Empty;
                    string strAddress = string.Empty;

                    strCustName = dt.Rows[0]["Name"].ToString();
                    strMobileNo = dt.Rows[0]["MobileNo"].ToString();
                    strAddress = dt.Rows[0]["Address"].ToString();
                    CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);

                    if (dt.Rows.Count > 1)
                    {
                        clsUtility.ShowInfoMessage(dt.Rows.Count + " Customers Mobile No. " + txtSearchByCustomerMobileNo.Text + " is found");
                    }
                    Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                    Obj.CustomerID = CustomerID;
                    Obj.CustName = strCustName;
                    Obj.CustMobileNo = strMobileNo;
                    Obj.CustAddress = strAddress;
                    this.Close();
                    Obj.ShowDialog();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Customer Mobile No. " + txtSearchByCustomerMobileNo.Text + " is not found");
                    txtSearchByCustomerMobileNo.Focus();
                }
            }
        }

        private void picSearchByName_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmOrderManagement) || clsUtility.IsAdmin)
            {
                if (txtSearchByCustomerName.Text.Length > 0)
                {
                    SearchByCustomerName();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Enter Customer Name to create an Order");
                    txtSearchByCustomerName.Focus();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void picSearchByMobileNo_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmOrderManagement) || clsUtility.IsAdmin)
            {
                if (txtSearchByCustomerMobileNo.Text.Length > 0)
                {
                    SearchByCustomerMobileNo();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Enter Customer Mobile No. to create an Order");
                    txtSearchByCustomerMobileNo.Focus();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void SearchByOrderNo()
        {
            ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("FromDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ToDate", SqlDbType.Date, DBNull.Value, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("OrderNo", SqlDbType.VarChar, txtSearchByOrderNo.Text.Trim(), clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_OrderList");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    int CustomerID = 0;
                    string strCustName = string.Empty;
                    string strMobileNo = string.Empty;
                    string strAddress = string.Empty;

                    strCustName = dt.Rows[0]["Name"].ToString();
                    strMobileNo = dt.Rows[0]["MobileNo"].ToString();
                    strAddress = dt.Rows[0]["Address"].ToString();
                    CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);

                    if (dt.Rows.Count > 1)
                    {
                        clsUtility.ShowInfoMessage(dt.Rows.Count + " Order No. " + txtSearchByOrderNo.Text + " is found");
                    }
                    Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                    Obj.CustomerID = CustomerID;
                    Obj.CustName = strCustName;
                    Obj.CustMobileNo = strMobileNo;
                    Obj.CustAddress = strAddress;
                    this.Close();
                    Obj.ShowDialog();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Order No. " + txtSearchByOrderNo.Text + " is not found");
                    txtSearchByOrderNo.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmOrderManagement) || clsUtility.IsAdmin)
            {
                frmQuickCustomer Obj = new frmQuickCustomer();
                Obj.ShowDialog();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KryptonTextBox txt = (KryptonTextBox)sender;
            if (e.KeyChar != 13)
            {
                e.Handled = ObjUtil.IsString(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                    txtSearchByCustomerName.Focus();
                }
            }
        }

        private void txtSearchByMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KryptonTextBox txt = (KryptonTextBox)sender;
            if (e.KeyChar != 13)
            {
                e.Handled = ObjUtil.IsNumeric(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
                    txtSearchByCustomerMobileNo.Focus();
                }
            }
        }

        private void picSearchOrderReceive_Click(object sender, EventArgs e)
        {
            if (txtOrderReceive.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Order No to receive.");
            }
            else
            {
                frmOrderReceive frmOrderReceive = new frmOrderReceive();
                frmOrderReceive.OrderNo = txtOrderReceive.Text;
                frmOrderReceive.Show();

            }

        }

        private void frmDashboardUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearchByCustomerName.Text.Trim().Length > 0)
                {
                    picSearchByName_Click(sender, e);
                }
                else if (txtSearchByCustomerMobileNo.Text.Trim().Length > 0)
                {
                    picSearchByMobileNo_Click(sender, e);
                }
                else if (txtSearchByOrderNo.Text.Trim().Length > 0)
                {
                    picSearchByOrderNo_Click(sender, e);
                }
            }
        }

        private void picSearchByOrderNo_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmOrderManagement) || clsUtility.IsAdmin)
            {
                if (txtSearchByOrderNo.Text.Length > 0)
                {
                    SearchByOrderNo();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Enter Order No. to create an Order");
                    txtSearchByOrderNo.Focus();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void txtSearchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            txtSearchByCustomerMobileNo.Clear();
            txtSearchByOrderNo.Clear();
        }

        private void txtSearchByCustomerMobileNo_TextChanged(object sender, EventArgs e)
        {
            txtSearchByCustomerName.Clear();
            txtSearchByOrderNo.Clear();
        }

        private void txtSearchByOrderNo_TextChanged(object sender, EventArgs e)
        {
            txtSearchByCustomerName.Clear();
            txtSearchByCustomerMobileNo.Clear();
        }
    }
}
