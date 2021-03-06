﻿using ComponentFactory.Krypton.Toolkit;
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
    public partial class frmOrderDelivery : KryptonForm
    {
        public string OrderNo;
        public frmOrderDelivery()
        {
            InitializeComponent();
        }

        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        private void SetDataGridviewPaletteMode(KryptonDataGridView dgv)
        {
            dgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void frmOrderDelivery_Load(object sender, EventArgs e)
        {
            SetDataGridviewPaletteMode(dgvOrderDetails);
            LoadOrderReceive();
        }
        private void LoadOrderReceive()
        {
            lblOrderNo.Text = OrderNo.ToString();

            //DataTable dtOrderDetails = ObjDAL.ExecuteSelectStatement("SELECT SalesOrderID,CustomerID FROM  " + clsUtility.DBName + ".[dbo].tblSalesOrder WITH(NOLOCK) WHERE OrderNo='" + OrderNo + "'");
            DataTable dtOrderDetails = ObjDAL.ExecuteSelectStatement("EXEC [dbo].[SPR_Get_OrderList] 0,NULL,NULL,'" + OrderNo + "'");

            if (ObjUtil.ValidateTable(dtOrderDetails))
            {
                int _CustID = Convert.ToInt32(dtOrderDetails.Rows[0]["CustomerID"]);
                int _SalesOrderID = Convert.ToInt32(dtOrderDetails.Rows[0]["SalesOrderID"]);

                lblCustomerName.Text = dtOrderDetails.Rows[0]["Name"].ToString();
                lblMobile.Text = dtOrderDetails.Rows[0]["MobileNo"].ToString();

                // only show received order and deliverd order
                DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.vw_GetOrderStatusDetails WHERE SalesOrderID=" + _SalesOrderID + " AND OrderStatusID in (1,4)");
                if (ObjUtil.ValidateTable(dt))
                {
                    if (ObjUtil.ValidateTable(dt))
                    {
                        dgvOrderDetails.DataSource = dt;
                        grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();
                    }
                    else
                    {
                        grpCustomerGridview.ValuesSecondary.Heading = "Total Records : 0";
                        dgvOrderDetails.DataSource = null;
                    }
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("No Order found with order no : " + OrderNo);
                this.Close();
            }
        }
        private void SetGridFont(KryptonDataGridView kryptonDataGridView)
        {
            kryptonDataGridView.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
            kryptonDataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
        }
        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderDetailsID"].Visible = false;
            dgvOrderDetails.Columns["Rate"].Visible = false;
            dgvOrderDetails.Columns["Total"].Visible = false;
            dgvOrderDetails.Columns["QTY"].Visible = false;
            dgvOrderDetails.Columns["GarmentID"].Visible = false;
            dgvOrderDetails.Columns["TrimAmount"].Visible = false;
            dgvOrderDetails.Columns["StichTypeName"].HeaderText = "StitchType";
            dgvOrderDetails.Columns["FitTypeName"].HeaderText = "FitType";
            dgvOrderDetails.Columns["TrimAmount"].Visible = false;
            dgvOrderDetails.Columns["OrderStatusID"].Visible = false;

            SetGridFont(dgvOrderDetails);

            grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();
            bool IschkAll = true;
            for (int i = 0; i < dgvOrderDetails.Columns.Count; i++)
            {
                if (i != 0)
                {
                    dgvOrderDetails.Columns[i].ReadOnly = true;
                }
            }
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Delivered")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(50, 122, 179);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 122, 179);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvOrderDetails.Rows[i].Cells["colCheck"].ReadOnly = true;
                    IschkAll = false;
                }
                else if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Received")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Green;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvOrderDetails.Rows[i].Cells["colCheck"].ReadOnly = false;
                    IschkAll = true;
                }
            }
            chkAll.Enabled = IschkAll;
            ObjUtil.SetRowNumber(dgvOrderDetails);
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRecive())
            {
                clsUtility.ShowInfoMessage("Please Check Garments to be received.");
                return;
            }

            bool result = clsUtility.ShowQuestionMessage("Are you sure, you want to receive the selected garments?");
            if (result)
            {
                DeliveredGarments();
            }
        }

        private void DeliveredGarments()
        {
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells[0].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells[0].Value) == true)
                {
                    int SalesID = Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["SalesOrderID"].Value);
                    int SalesOrderDetailsID = Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["SalesOrderDetailsID"].Value);

                    int RecordCount = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.tblOrderStatus WITH(NOLOCK) WHERE SalesOrderID=" + SalesID + " AND SalesOrderDetailsID=" + SalesOrderDetailsID);
                    if (RecordCount > 0)
                    {
                        // 1 - Order Delivered.
                        ObjDAL.UpdateColumnData("OrderStatus", SqlDbType.Int, 1);
                        ObjDAL.UpdateColumnData("DeliveredDate", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        ObjDAL.UpdateColumnData("DeliveredBy", SqlDbType.Int, clsUtility.LoginID);

                        ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblOrderStatus", "SalesOrderID=" + SalesID + " AND SalesOrderDetailsID=" + SalesOrderDetailsID);
                    }
                    else
                    {
                        // 1 - Order Delivered.
                        ObjDAL.SetColumnData("OrderStatus", SqlDbType.Int, 1);
                        ObjDAL.SetColumnData("DeliveredDate", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        ObjDAL.SetColumnData("DeliveredBy", SqlDbType.Int, clsUtility.LoginID);

                        ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblOrderStatus", false);
                    }
                }
            }
            clsUtility.ShowInfoMessage("Selected Garments has been Delivered.");
            LoadOrderReceive();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Received")
                    {
                        dgvOrderDetails.Rows[i].Cells[0].Value = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    dgvOrderDetails.Rows[i].Cells[0].Value = false;
                }
            }
            dgvOrderDetails.EndEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}