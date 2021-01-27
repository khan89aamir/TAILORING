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
using Microsoft.Reporting.WinForms;

namespace TAILORING.Report.Forms
{
    public partial class frmChalan : KryptonForm
    {
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        public frmChalan()
        {
            InitializeComponent();
        }
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
        private void frmChalan_Load(object sender, EventArgs e)
        {
            
            DataTable dtCompany = ObjDAL.ExecuteSelectStatement("select * from " + clsUtility.DBName + ".dbo.CompanyMaster");
            if (dtCompany.Rows.Count>0)
            {
                strcomName = dtCompany.Rows[0]["CompanyName"].ToString();
                parmGSTNo = dtCompany.Rows[0]["GST"].ToString();
                storeAddress = dtCompany.Rows[0]["Address"].ToString();
                strCompMobile = dtCompany.Rows[0]["MobileNo"].ToString();
                strCompEmail = dtCompany.Rows[0]["EmailID"].ToString();


                // creating the parameter with the extact name as in the report.
                ReportParameter param1 = new ReportParameter("parmStoreName",strcomName, true);
             
                
          
                ReportParameter param6 = new ReportParameter("parmAddress", storeAddress, true);
                
                ReportParameter param8 = new ReportParameter("parmGSTNo", parmGSTNo, true);
                ReportParameter param9 = new ReportParameter("parmCompanyMobile", strCompMobile, true);
                ReportParameter param10 = new ReportParameter("parmCompanyEmail", strCompEmail, true);
                ReportParameter param11 = new ReportParameter("parmDate", DateTime.Now.ToShortDateString(), true);


                DataTable dt = ObjDAL.ExecuteSelectStatement("select * from vw_Chalan_Rdlc where SalesOrderID in (" + OrderList + ")");

                ReportDataSource rds2 = new ReportDataSource("dsChalan", dt);
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
       


       
      
    }
}
