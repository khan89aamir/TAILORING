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

    

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
