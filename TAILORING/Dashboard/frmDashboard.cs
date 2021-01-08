using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;

namespace TAILORING.Dashboard
{
    public partial class frmDashboard : KryptonForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            label4.Text ="Date :  "+ DateTime.Now.ToShortDateString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Order.frmOrderList Obj = new Order.frmOrderList();
            Obj.txtCustomerOrderNo.Text = this.txtSearchByCustomerName.Text;
            Obj.Show();
        }
    }
}
