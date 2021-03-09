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
using OfficeOpenXml;

namespace TAILORING.Report.Forms
{
    public partial class frmMonthlyReport : KryptonForm
    {
        public frmMonthlyReport()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Report()
        {
            ObjDAL.SetStoreProcedureData("MonthDate", SqlDbType.Date, dtpFromDate1.Value.ToString("yyyy-MM-dd"), clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_MOM_Sales_Report");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate_Report();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            dataGridView1.Columns["SalesOrderID"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grpGridview.ValuesSecondary.Heading = "Total Records : " + dataGridView1.Rows.Count;
        }

        private void ExportXLSX()
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (ObjUtil.ValidateTable(dt))
                {
                    if (!Directory.Exists(System.Environment.CurrentDirectory + "\\Download"))
                    {
                        Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\Download");
                    }
                    string strFileName = "Monthly Report_" + dtpFromDate1.Value.ToString("MMM-yyyy") + ".xlsx";
                    FileStream stream = new FileStream(System.Environment.CurrentDirectory + "\\Download\\" + strFileName, FileMode.Create, FileAccess.ReadWrite);

                    using (ExcelPackage excelPackage = new ExcelPackage(stream))
                    {
                        ExcelWorkbook myWorkbook = excelPackage.Workbook;
                        ExcelWorksheet myWorksheet = myWorkbook.Worksheets.Add("Sheet1");

                        myWorksheet.Cells.LoadFromDataTable(dt, true);
                        myWorksheet.DeleteColumn(1); // Delete SalesOrderID Column
                        myWorksheet.InsertRow(1, 1); // Insert Row to append below TEXT.
                        myWorksheet.Cells.LoadFromText("MONTH OF " + dtpFromDate1.Value.ToString("MMM yyyy"));
                        //myWorksheet.InsertRow(1, 1);

                        excelPackage.Save();
                        stream.Flush();
                        stream.Close();

                        clsUtility.ShowInfoMessage("Monthly Report Exported..");
                        System.Diagnostics.Process.Start(System.Environment.CurrentDirectory + "\\Download");
                    }
                }
            }
            catch (Exception ex)
            {
                clsUtility.ShowErrorMessage(ex.Message);
            }
        }

        private void btnDownloadXLSX_Click(object sender, EventArgs e)
        {
            ExportXLSX();
        }
    }
}