using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAILORING.Dashboard
{
    public partial class frmDashboardUpdate : KryptonForm
    {
        public frmDashboardUpdate()
        {
            InitializeComponent();
        }

        private void frmDashboardUpdate_Load(object sender, EventArgs e)
        {
            label4.Text = "Date : " + DateTime.Now.ToShortDateString();
            //this.BackgroundImage = Properties.Resources.Background;
            this.BackColor = Color.FromArgb(82, 91, 114);
        }
    }
}
