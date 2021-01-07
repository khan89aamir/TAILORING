using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;
//using TAILORING.Barcode;
//using TAILORING.Settings;

namespace TAILORING
{
    public partial class frmHome : KryptonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        bool IsLogOut = false;
        public int Login_History_ID = 0;

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        private void otherArtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmDatabaseMaintenance) || clsUtility.IsAdmin)
            {
                DB_backupRestore.cs.frmDatabaseMaintenance Obj = new DB_backupRestore.cs.frmDatabaseMaintenance();
                Obj.ShowDialog();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void DisplayRegistrationInfo()
        {
            object ob = ObjDAL.ExecuteScalar("SELECT CONVERT(DATE,RegDate) RegDate FROM " + clsUtility.DBName + ".[dbo].[RegistrationDetails] WITH(NOLOCK) where PcName='" + Environment.MachineName + "'");
            if (ob != null)
            {
                lblRegistrationDate.Text = Convert.ToDateTime(ob).ToShortDateString();
            }
            else
            {
                lblRegistrationDate.Text = "NA";
            }

            object company = ObjDAL.ExecuteScalar("SELECT CompanyName FROM " + clsUtility.DBName + ".[dbo].[CompanyMaster] WITH(NOLOCK) WHERE ISNULL(IsDefault,0)=1");
            if (company != null)
            {
                lblLicensedTo.Text = company.ToString();
            }
            else
            {
                lblLicensedTo.Text = "NA";
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                clsUtility.DBName = "TAILORING_01";
                //clsUtility.LoginID = 0;
                //clsUtility.IsAdmin = false;
                clsUtility.IsAdmin = true;
                clsUtility.strProjectTitle = "Smart Tailor Solution";
                if (clsUtility.LoginID > 0)
                {
                    object ob = ObjDAL.ExecuteScalar("SELECT UserName from " + clsUtility.DBName + ".[dbo].[UserManagement] WITH(NOLOCK) WHERE UserID =" + clsUtility.LoginID);
                    lblLoginName.Text = "Login By : " + ob.ToString();
                }
                else
                {
                    lblLoginName.Text = "Login By : Test Admin";
                }
                lblVersion.Text = "Version : " + Application.ProductVersion;

                DisplayRegistrationInfo();
            }
            catch { }
        }
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogOut)
            {
                bool b = clsUtility.ShowQuestionMessage("Are you sure, you want to Exit?", clsUtility.strProjectTitle);
                if (b)
                {
                    ObjDAL.UpdateColumnData("LogOutTime", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    ObjDAL.UpdateData(clsUtility.DBName + ".dbo.Login_History", "Login_History_ID = " + Login_History_ID);
                    IsLogOut = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            if (clsUtility.ShowQuestionMessage("Are you sure to Logout?", clsUtility.strProjectTitle))
            {
                ObjDAL.UpdateColumnData("LogOutTime", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                ObjDAL.UpdateData(clsUtility.DBName + ".dbo.Login_History", "Login_History_ID = " + Login_History_ID);
                frmLogin Obj = new frmLogin();
                Obj.BringToFront();
                Obj.Show();
                IsLogOut = true;
                this.Close();
            }
        }

        private void EmployeeDetails_ToolStrip_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.Employee_Details));
                if (!b)
                {
                    Masters.Employee_Details Obj = new Masters.Employee_Details();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void SalesInvoice_ToolStrip_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Sales_Invoice) || clsUtility.IsAdmin)
            //{
            bool b = ObjUtil.IsAlreadyOpen(typeof(Order.frmOrderManagement));
            if (!b)
            {
                Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                Obj.Show();
            }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void SalesBillDetails_ToolStrip_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmOrderDetails) || clsUtility.IsAdmin)
            //{
            bool b = ObjUtil.IsAlreadyOpen(typeof(Order.frmOrderList));
            if (!b)
            {
                Order.frmOrderList Obj = new Order.frmOrderList();
                Obj.Show();
            }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void productMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Product_Master) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.Product_Master));
                if (!b)
                {
                    Masters.Product_Master Obj = new Masters.Product_Master();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void CustomerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.Customer_Master));
                if (!b)
                {
                    Masters.Customer_Master Obj = new Masters.Customer_Master();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void SalesReport_ToolStrip_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmSalesReport) || clsUtility.IsAdmin)
            {
                Report.Forms.frmBill frmBill = new Report.Forms.frmBill();
                frmBill.Show();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void userCreationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool b = ObjUtil.IsAlreadyOpen(typeof(UserManagement.frmUserManagement));
            if (!b)
            {
                UserManagement.frmUserManagement ObjUserManag = new UserManagement.frmUserManagement();
                ObjUserManag.LoginStatus(clsUtility.LoginID, clsUtility.IsAdmin);
                ObjUserManag.Show();
            }
        }

        private void userRightsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUtility.IsAdmin)
            {
                frmUserRights frmUserRights = new frmUserRights();
                frmUserRights.ShowDialog();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DisplayRegistrationInfo();
        }

        private void miniSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.tblMiniSalesReport) || clsUtility.IsAdmin)
            {
                //bool b = ObjUtil.IsAlreadyOpen(typeof(Report.Report_Forms.tblMiniSalesReport));
                //if (!b)
                //{
                //    Report.Report_Forms.tblMiniSalesReport frmminiSalesReport = new Report.Report_Forms.tblMiniSalesReport();
                //    frmminiSalesReport.Show();
                //}
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmDashBoard) || clsUtility.IsAdmin)
            {
                //bool b = ObjUtil.IsAlreadyOpen(typeof(Other_Forms.frmDashBoard));
                //if (!b)
                //{
                //    Other_Forms.frmDashBoard frmDashBoard = new Other_Forms.frmDashBoard();
                //    frmDashBoard.Show();
                //}
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void f1CashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesInvoice_ToolStrip_Click(null, null);
        }

        private void companyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.frmCompanyMaster));
                if (!b)
                {
                    Masters.frmCompanyMaster Obj = new Masters.frmCompanyMaster();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void picGST_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmGSTMaster) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.frmGSTMaster));
                if (!b)
                {
                    Masters.frmGSTMaster Obj = new Masters.frmGSTMaster();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void picProductRate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster) || clsUtility.IsAdmin)
            {
                bool b = ObjUtil.IsAlreadyOpen(typeof(Masters.frmProductRateMaster));
                if (!b)
                {
                    Masters.frmProductRateMaster Obj = new Masters.frmProductRateMaster();
                    Obj.Show();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }
    }
}