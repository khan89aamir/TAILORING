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

        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        private void frmCreateChalan_Load(object sender, EventArgs e)
        {
            LoadInProcess();
        }
        private void LoadInProcess()
        {
            // for creating chalan , get only those records, which are in process or critical.
            string strQ = "select SalesOrderID, OrderNo,OrderDate,OrderAmount,OrderQTY,TotalAmount from " + clsUtility.DBName + ".dbo.tblSalesOrder where SalesOrderID in " +
                          "(select SalesOrderID from " + clsUtility.DBName + ".dbo.tblOrderStatus where OrderStatus in (3, 2))";

            DataTable dt = ObjDAL.ExecuteSelectStatement(strQ);
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
            if (radSearchByInProcess.Checked)
            {
                LoadInProcess();
            }
        }
        private void SetGridFont(KryptonDataGridView kryptonDataGridView)
        {
            kryptonDataGridView.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
            kryptonDataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
        }
        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            SetGridFont(dgvOrderDetails);

            grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRecive())
            {
                clsUtility.ShowInfoMessage("Please select at least one order for creating chalan.");
                return;
            }
            dgvOrderDetails.EndEdit();
            List<int> list = new List<int>();
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["colCheck"].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells["colCheck"].Value))
                {
                    list.Add(Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["SalesOrderID"].Value));
                }
            }

            string strOrderList = string.Join<int>(",", list);

            Report.Forms.frmChalan frmChalan = new Report.Forms.frmChalan();
            frmChalan.OrderList = strOrderList;
            frmChalan.Show();
        }
        private bool ValidateRecive()
        {
            bool status = false;
            dgvOrderDetails.EndEdit();
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells[0].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells[0].Value) == true)
                {
                    status = true;
                    return status;
                }
            }
            return false;
        }

        private void radSearchByOrderNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearchByOrderNo.Checked)
            {
                txtSearchByScanOrderNo.Enabled = true;
                txtSearchByScanOrderNo.Focus();
            }
            else
            {
                txtSearchByScanOrderNo.Clear();
                txtSearchByScanOrderNo.Enabled = false;
            }
        }
    }
}