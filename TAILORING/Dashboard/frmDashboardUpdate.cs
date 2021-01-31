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
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleParam = base.CreateParams;
        //        handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
        //        return handleParam;
        //    }
        //}
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void frmDashboardUpdate_Load(object sender, EventArgs e)
        {
            label4.Text = "Date : " + DateTime.Now.ToShortDateString();
            //this.BackgroundImage = Properties.Resources.Background;
            this.BackColor = Color.FromArgb(82, 91, 114);

            BindDasbhoardData();
        }

        private void GenerateKryptonButtons(string text, string CardName)
        {
            KryptonButton btn = new KryptonButton();
            btn.OverrideDefault.Back.Color1 = Color.FromArgb(116, 123, 141);
            btn.OverrideDefault.Back.Color2 = Color.FromArgb(116, 123, 141);

            btn.StateNormal.Back.Color1 = Color.FromArgb(116, 123, 141);
            btn.StateNormal.Back.Color2 = Color.FromArgb(116, 123, 141);

            btn.StateNormal.Border.Rounding = 7;
            btn.StateTracking.Border.Rounding = 7;

            btn.StateNormal.Content.ShortText.Font = new Font("Times New Roman", 10.00f, FontStyle.Bold);
            btn.StateNormal.Content.ShortText.Color1 = Color.White;
            btn.Tag = text.Trim();
            btn.Values.Text = text;
            btn.Click += Btn_Click;
            btn.Width = 200;
            btn.Height = 28;
            if (CardName=="InProcess")
            {
                pnlInprocessOrder.Controls.Add(btn);
            }
            else if (CardName == "Critical")
            {
                pnlCricitialOrder.Controls.Add(btn);

            }
            else if (CardName == "Today")
            {
                pnlTodayDeliery.Controls.Add(btn);

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            KryptonButton btn = (KryptonButton)(sender);

            Order.frmOrderDetails frmOrderDetails = new Order.frmOrderDetails();
            frmOrderDetails.isFromDashboard = true;
            frmOrderDetails.strSubOrderNo= btn.Tag.ToString();
            frmOrderDetails.Show();

        }

        private void BindDasbhoardData()
        {
          DataSet dsDashbaordData=  ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName+".dbo.SPR_GetDashboardData");
            if (dsDashbaordData.Tables.Count>0)
            {

                string strInProcess = dsDashbaordData.Tables[0].Rows[0]["In_Process"].ToString();
                string strTotayDelivery = dsDashbaordData.Tables[0].Rows[0]["TodaysDelivery"].ToString();
                string strCriticalOrder = dsDashbaordData.Tables[0].Rows[0]["Critical"].ToString();
                 
                lblInProgress.Text = strInProcess;
                lblTodayDelivery.Text = strTotayDelivery;
                lblCriticalOrder.Text = strCriticalOrder;

                // in process order
                for (int i = 0; i < dsDashbaordData.Tables[1].Rows.Count; i++)
                {
                   
                    GenerateKryptonButtons(dsDashbaordData.Tables[1].Rows[i]["SubOrderNo"].ToString(), "InProcess");
                }
                // Critical order
                for (int i = 0; i < dsDashbaordData.Tables[2].Rows.Count; i++)
                {
                    GenerateKryptonButtons(dsDashbaordData.Tables[2].Rows[i]["SubOrderNo"].ToString(), "Critical");
                }

                // Today Delivery
                for (int i = 0; i < dsDashbaordData.Tables[3].Rows.Count; i++)
                {
                    GenerateKryptonButtons(dsDashbaordData.Tables[3].Rows[i]["SubOrderNo"].ToString(), "Today");
                }
            }
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
                    else
                    {
                        Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                        Obj.CustomerID = CustomerID;
                        Obj.CustName = strCustName;
                        Obj.CustMobileNo = strMobileNo;
                        Obj.CustAddress = strAddress;
                        //this.Close();
                        Obj.ShowDialog();
                    }
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
                    else
                    {
                        Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                        Obj.CustomerID = CustomerID;
                        Obj.CustName = strCustName;
                        Obj.CustMobileNo = strMobileNo;
                        Obj.CustAddress = strAddress;
                        //this.Close();
                        Obj.ShowDialog();
                    }
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

                    //if (dt.Rows.Count > 1)
                    //{
                    //    clsUtility.ShowInfoMessage(dt.Rows.Count + " Order No. " + txtSearchByOrderNo.Text + " is found");
                    //}
                    Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                    Obj.CustomerID = CustomerID;
                    Obj.CustName = strCustName;
                    Obj.CustMobileNo = strMobileNo;
                    Obj.CustAddress = strAddress;
                    //this.Close();
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

        private void btnCreateChalan_Click(object sender, EventArgs e)
        {
            frmCreateChalan frmCreate = new frmCreateChalan();
            frmCreate.Show();
        }

        private void picSearchOrderDelivery_Click(object sender, EventArgs e)
        {
            if (txtOrderDelivery.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Please Enter Order No to Deliver.");
            }
            else
            {
                frmOrderDelivery frmOrderDelivery = new frmOrderDelivery();
                frmOrderDelivery.OrderNo = txtOrderDelivery.Text;
                frmOrderDelivery.Show();

            }
        }

        private void frmDashboardUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlCricitialOrder.BackColor = Color.Transparent;
            pnlInprocessOrder.BackColor = Color.Transparent;
            pnlTodayDeliery.BackColor = Color.Transparent;

            timer1.Stop();
        }
    }
}