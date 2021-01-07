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
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace TAILORING.Report.Forms
{
    public partial class frmBill : KryptonForm
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



            //ReportParameter parameterimg = new ReportParameter("ImagePath", ImageToBase64( @"C:\Test\MyImage.png"));
            //reportViewer1.LocalReport.SetParameters(parameterimg);
       
            
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
                ReportDataSource rds = new ReportDataSource("dsTotalCalculation", dtCalculation);
                reportViewer1.LocalReport.DataSources.Add(rds);

            }

            string str1 = "select *    FROM [IMS_Client_2].[dbo].[ProductMaster]";
            DataTable dtTest = ObjCon.ExecuteSelectStatement(str1);
            if (dtTest.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("dsTest", dtTest);
                reportViewer1.LocalReport.DataSources.Add(rds);

            }

            InitiMeasrument();
           

            ReportDataSource rds2 = new ReportDataSource("dsMeasurment", dtMeasurment);
            reportViewer1.LocalReport.DataSources.Add(rds2);

         


            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();


            
        }

        private string ImageToBase64(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        DataTable dtMeasurment = new DataTable();
        DataTable dtMeasurment2 = new DataTable();
        DataTable dtStyle = new DataTable();
        private void InitiMeasrument()
        {
            #region ProductDetails
            
            dtMeasurment.Columns.Add("ProductID");
            dtMeasurment.Columns.Add("Swatch");
            dtMeasurment.Columns.Add("PU");
            dtMeasurment.Columns.Add("Garment");
            dtMeasurment.Columns.Add("Stitch");
            dtMeasurment.Columns.Add("Service");
            dtMeasurment.Columns.Add("Fit");
            dtMeasurment.Columns.Add("TrailDate");
            dtMeasurment.Columns.Add("DeliveryDate");
            #endregion

            #region Measurement Column Name
            dtMeasurment.Columns.Add("mc1");
            dtMeasurment.Columns.Add("mc2");
            dtMeasurment.Columns.Add("mc3");
            dtMeasurment.Columns.Add("mc4");
            dtMeasurment.Columns.Add("mc5");
            dtMeasurment.Columns.Add("mc6");
            dtMeasurment.Columns.Add("mc7");
            dtMeasurment.Columns.Add("mc8");
            dtMeasurment.Columns.Add("mc9");
            dtMeasurment.Columns.Add("mc10");
            #endregion

            #region Measurement Value

            dtMeasurment.Columns.Add("mc1v");
            dtMeasurment.Columns.Add("mc2v");
            dtMeasurment.Columns.Add("mc3v");
            dtMeasurment.Columns.Add("mc4v");
            dtMeasurment.Columns.Add("mc5v");
            dtMeasurment.Columns.Add("mc6v");
            dtMeasurment.Columns.Add("mc7v");
            dtMeasurment.Columns.Add("mc8v");
            dtMeasurment.Columns.Add("mc9v");
            dtMeasurment.Columns.Add("mc10v");
            #endregion

            #region Style
            dtMeasurment.Columns.Add("s1");
            dtMeasurment.Columns.Add("s2");
            dtMeasurment.Columns.Add("s3");
            dtMeasurment.Columns.Add("s4");
            dtMeasurment.Columns.Add("s5");
            dtMeasurment.Columns.Add("s6");
            dtMeasurment.Columns.Add("s7");
            dtMeasurment.Columns.Add("s8");
            dtMeasurment.Columns.Add("s9");
            dtMeasurment.Columns.Add("s10");
            #endregion

            AddRowItem("1", "Swatch", "12", "Shirt", "ST", "Regular", "Slim Fit", "02-01-2021", "07-01-2020", "Length", "Cuff", "Hip", "Chest", "Shoulder", "Neck", "Shoulder", "NA", "NA", "NA", "12.3", "23.43", "25.33", "32.55", "32.11", "12.55", "17.3", "0", "0", "0",
                        ImageToBase64(@"C:\Tailoring Images\Bandgalan1.png"),
                        ImageToBase64(@"C:\Tailoring Images\BP Kaaj Button.png"),
                         ImageToBase64(@"C:\Tailoring Images\1 button square cuff.png"),
                           ImageToBase64(@"C:\Tailoring Images\2 Button round cuff.png"), "NA", "NA", "NA", "NA", "NA", "NA");


            //  AddRowItem("2","Swatch", "14", "Trouser", "PT", "Regular", "Slim Fit", "04-01-2021", "08-01-2020", "Length", "In- length", "fork length", "waist", "Hip", "Theigh", "Knee width", "NA", "NA", "NA", "16.3", "24.43", "21.33", "37.55", "35.11", "28.55", "22.3", "0", "0", "0",
            //  ImageToBase64(@"C:\Tailoring Images\Cross Pocket.png"),
            //  ImageToBase64(@"C:\Tailoring Images\Long Belt.png"),
            //   ImageToBase64(@"C:\Tailoring Images\Picture3.png"),
            //     ImageToBase64(@"C:\Tailoring Images\Turn up.png"), "NA", "NA", "NA", "NA", "NA", "NA");


            //  AddRowItem("3", "Swatch", "14", "Tuxedo", "PT", "Regular", "Slim Fit", "04-01-2021", "08-01-2020", "Length", "In- length", "fork length", "waist", "Hip", "Theigh", "Knee width", "NA", "NA", "NA", "16.3", "24.43", "21.33", "37.55", "35.11", "28.55", "22.3", "0", "0", "0",
            //ImageToBase64(@"C:\Tailoring Images\Cross Pocket.png"),
            //ImageToBase64(@"C:\Tailoring Images\Long Belt.png"),
            // ImageToBase64(@"C:\Tailoring Images\Picture3.png"),
            //   ImageToBase64(@"C:\Tailoring Images\Turn up.png"), "NA", "NA", "NA", "NA", "NA", "NA");
        }
  

        private void AddRowItem(string ProductID,
                                string Swatch, 
                                string PU, 
                                string Garment,
                                string Stitch,
                                string Service,
                                string Fit, 
                                string TrailDate,
                                string DeliveryDate,
                                string mc1,
                                string mc2,
                                string mc3,
                                string mc4,
                                string mc5,
                                string mc6,
                                string mc7,
                                string mc8,
                                string mc9,
                                string mc10,
                                string mc1v,
                                string mc2v,
                                string mc3v,
                                string mc4v,
                                string mc5v,
                                string mc6v,
                                string mc7v,
                                string mc8v,
                                string mc9v,
                                string mc10v,
                                string s1,
                                string s2,
                                string s3,
                                string s4,
                                string s5,
                                string s6,
                                string s7,
                                string s8,
                                string s9,
                                string s10


            )
        {

            DataRow dRow=  dtMeasurment.NewRow();
         
                 dRow["ProductID"] = ProductID;
            dRow["Swatch"] = Swatch;
            dRow["PU"] = PU;
            dRow["Garment"] = Garment;
            dRow["Stitch"] = Stitch;
            dRow["Service"] = Service;
            dRow["Fit"] = Fit;
            dRow["TrailDate"] = TrailDate;
            dRow["DeliveryDate"] = DeliveryDate;
            dRow["mc1"] = mc1;
            dRow["mc2"] = mc2;
            dRow["mc3"] = mc3;
            dRow["mc4"] = mc4;
            dRow["mc5"] = mc5;
            dRow["mc6"] = mc6;
            dRow["mc7"] = mc7;
            dRow["mc8"] = mc8;
            dRow["mc9"] = mc9;
            dRow["mc10"] = mc10;
            dRow["mc1v"] = mc1v;
            dRow["mc2v"] = mc2v;
            dRow["mc3v"] = mc3v;
            dRow["mc4v"] = mc4v;
            dRow["mc5v"] = mc5v;
            dRow["mc6v"] = mc6v;
            dRow["mc7v"] = mc7v;
            dRow["mc8v"] = mc8v;
            dRow["mc9v"] = mc9v;
            dRow["mc10v"] = mc10v;
            dRow["s1"] = s1;
            dRow["s2"] = s2;
            dRow["s3"] = s3;
            dRow["s4"] = s4;
            dRow["s5"] = s5;
            dRow["s6"] = s6;
            dRow["s7"] = s7;
            dRow["s8"] = s8;
            dRow["s9"] = s9;
            dRow["s10"] = s10;


            dtMeasurment.Rows.Add(dRow);
            dtMeasurment.AcceptChanges();

        }
        private void AddRow2(string c1, string c2, string c3, string c4 )
        {

            DataRow dRow = dtStyle.NewRow();
            dRow[0] = c1;
            dRow[1] = c2;
            dRow[2] = c3;
            dRow[3] = c4;
        

            dtStyle.Rows.Add(dRow);
            dtStyle.AcceptChanges();

        }

    }
}
