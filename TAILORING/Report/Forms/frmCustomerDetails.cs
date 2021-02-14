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
    public partial class frmCustomerDetails : KryptonForm
    {
        public frmCustomerDetails()
        {
            InitializeComponent();
        }
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

        CoreApp.clsConnection_DAL ObjDAL = new CoreApp.clsConnection_DAL(true);
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            DataTable dtCompany = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.CompanyMaster WITH(NOLOCK) WHERE ISNULL(IsDefault,1)=1");
            if (dtCompany != null && dtCompany.Rows.Count > 0)
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

                DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.CustomerMaster WITH(NOLOCK)");

                ReportDataSource rds2 = new ReportDataSource("dsCustomer", dt);
                reportViewer1.LocalReport.DataSources.Add(rds2);
                reportViewer1.LocalReport.SetParameters(param1);
                reportViewer1.LocalReport.SetParameters(param6);
                reportViewer1.LocalReport.SetParameters(param8);
                reportViewer1.LocalReport.SetParameters(param9);
                reportViewer1.LocalReport.SetParameters(param10);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}