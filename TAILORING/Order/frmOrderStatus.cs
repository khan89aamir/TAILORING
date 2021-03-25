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

namespace TAILORING.Order
{
    public partial class frmOrderStatus : KryptonForm
    {
        public frmOrderStatus()
        {
            InitializeComponent();
        }

        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        private void kryptonRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        private void BindOrderStatus()
        {
            DataTable dtOrderStatus = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.tblOrderStatusMaster WITH(NOLOCK) ");
            if (ObjUtil.ValidateTable(dtOrderStatus))
            {
                cmbOrderStatus.DataSource = dtOrderStatus;
                cmbOrderStatus.DisplayMember = "OrderStatus";
                cmbOrderStatus.ValueMember = "Id";
            }
            cmbOrderStatus.SelectedIndex = -1;
        }

        private void SearchData()
        {
            string strQ = " SELECT OrderNo, SubOrderNo,GarmentName,StichType [Stitch Type],FitType [Fit Type],ServiceType,OrderStatus,gTrailDate [TrailDate]," +
                      " ReceivedDate,DeliveredDate,ReceivedBy,DeliveredBy FROM " + clsUtility.DBName + ".[dbo].[vw_OrderDetails_RDLC] ";

            if (radOrderNo.Checked)
            {
                strQ += "WHERE OrderNo ='" + txtCustomerOrderNo.Text + "'";
            }
            else if (radSuborder.Checked)
            {
                strQ += "WHERE SubOrderNo ='" + txtCustomerOrderNo.Text + "'";
            }
            else if (radOrderStatus.Checked)
            {
                strQ += "WHERE OrderStatus ='" + cmbOrderStatus.Text + "'";
            }
            else if (checkBox1.Checked)
            {
                strQ += "WHERE gTrailDate!='' ";
            }

            DataTable dt = ObjDAL.ExecuteSelectStatement(strQ);
            dgvOrderDetails.DataSource = dt;
            if (ObjUtil.ValidateTable(dt))
            {
                grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dt.Rows.Count;
            }
            else
            {
                grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
            }
        }

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmOrderStatus_Load(object sender, EventArgs e)
        {
            BindOrderStatus();
            SearchData();
        }

        private void txtCustomerOrderNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerOrderNo.Text.Trim().Length > 0)
            {
                SearchData();
            }
        }

        private void txtSubORderNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSubORderNo.Text.Trim().Length > 0)
            {
                SearchData();
            }
        }

        private void radOrderStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radOrderStatus.Checked)
            {
                cmbOrderStatus.Enabled = true;
                cmbOrderStatus.Focus();
            }
            else
            {
                cmbOrderStatus.SelectedIndex = -1;
                cmbOrderStatus.Enabled = false;
            }
        }

        private void radSuborder_CheckedChanged(object sender, EventArgs e)
        {
            if (radSuborder.Checked)
            {
                txtSubORderNo.Enabled = true;
                txtSubORderNo.Focus();
            }
            else
            {
                txtSubORderNo.Enabled = false;
                txtSubORderNo.Clear();
            }
        }

        private void radOrderNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radOrderNo.Checked)
            {
                txtCustomerOrderNo.Enabled = true;
                txtCustomerOrderNo.Focus();
            }
            else
            {
                txtCustomerOrderNo.Enabled = false;
                txtCustomerOrderNo.Clear();
            }
        }

        private void cmbOrderStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbOrderStatus.SelectedValue != null)
            {
                SearchData();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}