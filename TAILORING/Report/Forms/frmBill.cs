using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Report.Forms
{
    public partial class frmBill : Form
    {
        CoreApp.clsConnection_DAL ObjCon = new CoreApp.clsConnection_DAL(true);
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            OrderID = "4";
            LoadData();


        }
        public string OrderID = "";
        private void LoadData()
        {
            reportViewer1.LocalReport.EnableExternalImages = true;

            
            string strcomName = "";
            string parmGSTNo = "";
            string storeAddress = "";
            string Orderdate = "";
            string OrderNo = "";
            string strCustomerName = "";
            string strCustomerMobile = "";
            string CustomerID = "";
            string strCustomerAddress = "";
            string strCompMobile = "";
            string strCompEmail = "";



             DataTable dtCompany= ObjCon.ExecuteSelectStatement("select * from "+clsUtility.DBName+ ".dbo.CompanyMaster");
            if (dtCompany.Rows.Count>0)
            {
                strcomName = dtCompany.Rows[0]["CompanyName"].ToString();
                parmGSTNo = dtCompany.Rows[0]["GST"].ToString();
                storeAddress= dtCompany.Rows[0]["Address"].ToString();
                strCompMobile= dtCompany.Rows[0]["MobileNo"].ToString();
                strCompEmail = dtCompany.Rows[0]["EmailID"].ToString();
            }

            DataTable dtOrderMaster = ObjCon.ExecuteSelectStatement("select * FROM "+ clsUtility.DBName+ ".[dbo].[tblSalesOrder] where SalesOrderID="+OrderID);
            if (dtOrderMaster.Rows.Count>0)
            {
                Orderdate = dtOrderMaster.Rows[0]["OrderDate"].ToString();
                OrderNo = dtOrderMaster.Rows[0]["OrderNo"].ToString();
                CustomerID = dtOrderMaster.Rows[0]["CustomerID"].ToString();
            }

            DataTable dtCustomer = ObjCon.ExecuteSelectStatement("select * FROM " + clsUtility.DBName + ".[dbo].[CustomerMaster] where CustomerID=" + CustomerID);
            if (dtCustomer!=null && dtCustomer.Rows.Count > 0)
            {
                strCustomerName = dtCustomer.Rows[0]["Name"].ToString();
                strCustomerMobile = dtCustomer.Rows[0]["MobileNo"].ToString();
                strCustomerAddress = dtCustomer.Rows[0]["Address"].ToString();
            }
           // creating the parameter with the extact name as in the report.
            ReportParameter param1 = new ReportParameter("parmStoreName", strcomName, true);
            ReportParameter param2 = new ReportParameter("parmOrderDate", Convert.ToDateTime(Orderdate).Date.ToShortDateString(), true);
            ReportParameter param3 = new ReportParameter("parmOrderNo", OrderNo, true);
            ReportParameter param4 = new ReportParameter("parmCustomerName", strCustomerName, true);
            ReportParameter param5 = new ReportParameter("parmMobile", strCustomerMobile, true);
            
            ReportParameter param6 = new ReportParameter("parmAddress", storeAddress, true);
            ReportParameter param7 = new ReportParameter("parmCustomerAddress", strCustomerAddress, true);
            ReportParameter param8 = new ReportParameter("parmGSTNo", parmGSTNo, true);
            ReportParameter param9 = new ReportParameter("parmCompanyMobile", strCompMobile, true);
            ReportParameter param10 = new ReportParameter("parmCompanyEmail", strCompEmail, true);

          

            // adding the parameter in the report dynamically
            reportViewer1.LocalReport.SetParameters(param1);
            reportViewer1.LocalReport.SetParameters(param2);
            reportViewer1.LocalReport.SetParameters(param3);
            reportViewer1.LocalReport.SetParameters(param4);
            reportViewer1.LocalReport.SetParameters(param5);
            reportViewer1.LocalReport.SetParameters(param6);
            reportViewer1.LocalReport.SetParameters(param7);
            reportViewer1.LocalReport.SetParameters(param8);
            reportViewer1.LocalReport.SetParameters(param9);
            reportViewer1.LocalReport.SetParameters(param10);

            reportViewer1.LocalReport.DataSources.Clear();
          
            ObjCon.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, OrderID);
            DataSet dataSet = ObjCon.ExecuteStoreProcedure_Get("SPR_Get_OrderDetails");
            if (dataSet.Tables.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("dsItemDetails", dataSet.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }

            string strCalculation = "  select OrderAmount,(select SUM(t2.TrimAmount) from  [TAILORING_01].[dbo].[tblSalesOrderDetails] t2 " +
                                   " where t2.SalesOrderID="+OrderID+" ) as TrimAmount,t1.AdvanceAmount, '0.00'as Tax,t1.TotalAmount " +
                                   " FROM [TAILORING_01].[dbo].[tblSalesOrder] t1 where t1.SalesOrderID="+OrderID;

        DataTable dtCalculation=    ObjCon.ExecuteSelectStatement(strCalculation);
            if (dtCalculation.Rows.Count>0)
            {
                ReportDataSource rds = new ReportDataSource("dsTotalCalculation", dataSet.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(rds);

            }

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();


        }
    }
}
