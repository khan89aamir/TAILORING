using ComponentFactory.Krypton.Toolkit;
using CoreApp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAILORING.Report.Forms
{
    public partial class frmOrderDetails : KryptonForm
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        public string OrderList;
        string strcomName = "";
        string parmGSTNo = "";
        string storeAddress = "";
        string Orderdate = "";
        string strCustomerName = "";
        string strCustomerMobile = "";
        string CustomerID = "";
        string strCustomerAddress = "";
        string strCompMobile = "";
        string strCompEmail = "";

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            BindOrderStatus();
        }

        private void BindOrderStatus()
        {
            DataTable dtOrderStatus = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.tblOrderStatusMaster WITH(NOLOCK) ");
            if (ObjUtil.ValidateTable(dtOrderStatus))
            {
                cmbOrderStatus.DataSource = dtOrderStatus;
                cmbOrderStatus.DisplayMember = "OrderStatus";
                cmbOrderStatus.ValueMember = "Id";
            }
            cmbOrderStatus.SelectedIndex = -1;
        }

        private void GenerateButton()
        {
            DataTable dtCompany = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.CompanyMaster WITH(NOLOCK) WHERE ISNULL(IsDefault,1)=1");
            if (ObjUtil.ValidateTable(dtCompany))
            {
                strcomName = dtCompany.Rows[0]["CompanyName"].ToString();
                parmGSTNo = dtCompany.Rows[0]["GST"].ToString();
                storeAddress = dtCompany.Rows[0]["Address"].ToString();
                strCompMobile = dtCompany.Rows[0]["MobileNo"].ToString();
                strCompEmail = dtCompany.Rows[0]["EmailID"].ToString();


                // creating the parameter with the extact name as in the report.
                ReportParameter param1 = new ReportParameter("parmStoreName", strcomName, true);
                ReportParameter param6 = new ReportParameter("parmAddress", storeAddress, true);
                ReportParameter param8 = new ReportParameter("parmGSTNo", parmGSTNo, true);
                ReportParameter param9 = new ReportParameter("parmCompanyMobile", strCompMobile, true);
                ReportParameter param10 = new ReportParameter("parmCompanyEmail", strCompEmail, true);
                ReportParameter param11 = new ReportParameter("parmDate", DateTime.Now.ToShortDateString(), true);

                string strWhere = string.Empty;
                strWhere = GetSearchInput();
                DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM vw_OrderDetails_RDLC " + strWhere);

                ReportDataSource rds2 = new ReportDataSource("dsOrderDetails", dt);
                reportViewer1.LocalReport.DataSources.Add(rds2);
                reportViewer1.LocalReport.SetParameters(param1);
                reportViewer1.LocalReport.SetParameters(param6);
                reportViewer1.LocalReport.SetParameters(param8);
                reportViewer1.LocalReport.SetParameters(param9);
                reportViewer1.LocalReport.SetParameters(param10);
                reportViewer1.LocalReport.SetParameters(param11);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                this.reportViewer1.RefreshReport();
            }
        }

        private string GetSearchInput()
        {
            string strWhere = "WHERE 1=1 ";
            if (!ObjUtil.IsControlTextEmpty(txtCustomerOrderNo))
            {
                strWhere += "AND OrderNo='" + txtCustomerOrderNo.Text.Trim() + "' ";
            }
            if (!ObjUtil.IsControlTextEmpty(cmbOrderStatus))
            {
                strWhere += "AND OrderStatus='" + cmbOrderStatus.Text + "'";
            }
            return strWhere;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GenerateButton();
        }
    }
}