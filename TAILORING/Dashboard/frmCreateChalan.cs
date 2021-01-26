using ComponentFactory.Krypton.Toolkit;
using CoreApp;
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
    public partial class frmCreateChalan : KryptonForm
    {
        public frmCreateChalan()
        {
            InitializeComponent();
        }
        CoreApp.clsConnection_DAL ObjDAL = new CoreApp.clsConnection_DAL(true);
        CoreApp.clsUtility ObjUtil = new clsUtility();
        private void frmCreateChalan_Load(object sender, EventArgs e)
        {
            LoadInProcess();
        }
        private void LoadInProcess()
        {
            DataTable dt = ObjDAL.ExecuteSelectStatement("select * from " + clsUtility.DBName + ".dbo.vw_GetOrderStatusDetails where OrderStatusID in (2,3)");
            if (ObjUtil.ValidateTable(dt))
            {
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LoadInProcess();
            }
        }
    }
}
