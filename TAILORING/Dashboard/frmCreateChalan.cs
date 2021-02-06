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
            lstSubOrderListlist.Clear();
        }
        private void LoadInProcess()
        {
            // for creating chalan , get only those records, which are in process or critical.
            string strQ = "select SalesOrderID, OrderNo,OrderDate,OrderAmount,OrderQTY,TotalAmount,'View Details' as ViewDetails from " + clsUtility.DBName + ".dbo.tblSalesOrder where SalesOrderID in " +
                          "(select SalesOrderID from " + clsUtility.DBName + ".dbo.tblOrderStatus where OrderStatus in (3, 2)) order by salesorderID desc";

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
        public static List<string> lstSubOrderListlist = new List<string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            dgvOrderDetails.EndEdit();
   
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["colCheck"].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells["colCheck"].Value))
                {

                  DataTable dtSubOrderList=  ObjDAL.ExecuteSelectStatement("select SubOrderNo from " + clsUtility.DBName + ".dbo.vw_Chalan_Rdlc where SalesOrderID=" + dgvOrderDetails.Rows[i].Cells["SalesOrderID"].Value);
                    for (int j = 0; j < dtSubOrderList.Rows.Count; j++)
                    {
                        lstSubOrderListlist.Add(dtSubOrderList.Rows[j][0].ToString());
                    }
                   
                }
            }


            if (lstSubOrderListlist.Count==0)
            {
                clsUtility.ShowInfoMessage("Please select at least one order for creating chalan.");
                return;
            }

            string strOrderList ="'"+string.Join<string>("','", lstSubOrderListlist)+"'";

            Report.Forms.frmChalan frmChalan = new Report.Forms.frmChalan();
           
            frmChalan.OrderList = strOrderList;
            frmChalan.Show();
            lstSubOrderListlist.Clear();
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

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==7)
            {
               
                string orderNo = dgvOrderDetails.Rows[e.RowIndex].Cells["OrderNo"].Value.ToString();

                frmChalanSub frmChalanSub = new frmChalanSub();
                frmChalanSub.SalesOrderID = Convert.ToInt32(dgvOrderDetails.Rows[e.RowIndex].Cells["SalesOrderID"].Value);
                frmChalanSub.lblOrderNo.Text ="Order No :"+ orderNo;
                frmChalanSub.isInvoiceChk= Convert.ToBoolean(dgvOrderDetails.Rows[e.RowIndex].Cells["colCheck"].Value);
            
                frmChalanSub.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            this.Close();
          
        }
    }
}