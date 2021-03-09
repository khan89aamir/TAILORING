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
    public partial class frmMonthlyReport : KryptonForm
    {
        public frmMonthlyReport()
        {
            InitializeComponent();
        }
        DataTable dtMonthlyReort = new DataTable();
        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtMonthlyReort.Columns.Add("OrderNo");
            dtMonthlyReort.Columns.Add("Shirt");
            dtMonthlyReort.Columns.Add("Trouser");
            dtMonthlyReort.Columns.Add("TwoPCSuit");
            dtMonthlyReort.Columns.Add("ThreePCSuit");
            dtMonthlyReort.Columns.Add("Blazer");
            dtMonthlyReort.Columns.Add("Kurta");
            dtMonthlyReort.Columns.Add("Shirt_Urgetn");


            AddRows("INV-1", "2", "0", "0", "0", "0", "1", "0");
            AddRows("INV-2", "1", "0", "0", "0", "0", "0", "0");
            AddRows("INV-3", "0", "0", "1", "0", "0", "1", "0");
            AddRows("INV-4", "0", "1", "0", "0", "0", "0", "0");
            AddRows("INV-5", "0", "0", "2", "0", "0", "1", "0");
            AddRows("INV-6", "0", "0", "0", "0", "0", "0", "0");
            AddRows("INV-1", "0", "1", "0", "0", "0", "0", "0");
            AddRows("INV-7", "1", "0", "0", "0", "0", "0", "0");
            AddRows("INV-8", "1", "0", "0", "0", "0", "1", "0");
            AddRows("INV-9", "0", "1", "0", "0", "0", "0", "0");
            AddRows("INV-10", "0", "0", "0", "0", "0", "0", "0");
            AddRows("INV-11", "0", "0", "0", "0", "0", "0", "0");
            AddRows("INV-12", "0", "0", "0", "0", "0", "1", "0");
            AddRows("INV-13", "1", "1", "0", "0", "0", "0", "0");
            AddRows("INV-14", "1", "0", "0", "0", "0", "0", "0");
            AddRows("INV-15", "2", "0", "0", "0", "0", "0", "0");
            AddRows("INV-16", "0", "0", "0", "0", "0", "0", "0");
            AddRows(" ", " ", " ", " ", " ", " ", " ", " ");
            AddRows("Total", " 8", "3", "1", "0", "0", "5", "0");



            ReportDataSource rds2 = new ReportDataSource("dsMonthly", dtMonthlyReort);
            reportViewer1.LocalReport.DataSources.Add(rds2);
          
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();


        }
        private void AddRows(string OrderNo, string Shirt, string Trouser, string TowPC, string ThreePC, string Blazer, string Kurta, string shirtU)
        {

             DataRow dRow= dtMonthlyReort.NewRow();
            dRow["OrderNo"] = OrderNo;
            dRow["Shirt"] = Shirt;
            dRow["Trouser"] = Trouser;
            dRow["TwoPCSuit"] = TowPC;
            dRow["OrderNo"] = OrderNo;
            dRow["ThreePCSuit"] = ThreePC;
            dRow["Blazer"] = Blazer;
            dRow["Kurta"] = Kurta;
            dRow["Shirt_Urgetn"] = shirtU;

            dtMonthlyReort.Rows.Add(dRow);

        }
            
    }
}