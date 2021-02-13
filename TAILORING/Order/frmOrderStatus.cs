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
            DataTable dtOrderStatus = ObjDAL.ExecuteSelectStatement(" select * from " + clsUtility.DBName + ".dbo.tblOrderStatusMaster");
            if (dtOrderStatus.Rows.Count > 0)
            {
                cmbOrderStatus.DataSource = dtOrderStatus;
                cmbOrderStatus.DisplayMember = "OrderStatus";
                cmbOrderStatus.ValueMember = "Id";
            }
            cmbOrderStatus.SelectedIndex = -1;
        }

        private void SearchData()
        {
            string strQ = " select OrderNo, SubOrderNo,GarmentName,StichType,FitTYpe,ServiceType,OrderStatus," +
                      " ReceivedDate,DeliveredDate,ReceivedBy,DeliveredBy from [dbo].[vw_OrderDetails_RDLC]";

            if (radOrderNo.Checked)
            {
                strQ += " where OrderNo '" + txtCustomerOrderNo.Text + "'";
            }
            else if (radSuborder.Checked)
            {
                strQ += " where SubOrderNo ='" + txtCustomerOrderNo.Text + "'";
            }
            else if(radOrderStatus.Checked)
            {
                strQ += " where OrderStatus ='" + cmbOrderStatus.Text + "'";
            }

           dgvOrderDetails.DataSource=  ObjDAL.ExecuteSelectStatement(strQ);
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

        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtCustomerOrderNo_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtSubORderNo_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
