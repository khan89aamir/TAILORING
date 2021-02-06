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

        CoreApp.clsConnection_DAL ObjDAL = new CoreApp.clsConnection_DAL(true);
        CoreApp.clsUtility ObjUtil = new CoreApp.clsUtility();

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

            DataTable dtOrderDetails = ObjDAL.ExecuteSelectStatement("select SalesOrderID,CustomerID from  " + clsUtility.DBName + ".[dbo].tblSalesOrder WITH(NOLOCK) where OrderNo='" + OrderNo + "'");

            if (ObjUtil.ValidateTable(dtOrderDetails))
            {
                int _CustID = Convert.ToInt32(dtOrderDetails.Rows[0]["CustomerID"]);
                int _SalesOrderID = Convert.ToInt32(dtOrderDetails.Rows[0]["SalesOrderID"]);

                // only show received order and deliverd order
                DataTable dt = ObjDAL.ExecuteSelectStatement("select * from " + clsUtility.DBName + ".dbo.vw_GetOrderStatusDetails where SalesOrderID=" + _SalesOrderID + " AND OrderStatusID in (1,4)");
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
            dgvOrderDetails.Columns["StichTypeName"].HeaderText = "StichType";
            dgvOrderDetails.Columns["FitTypeName"].HeaderText = "FitType";
            dgvOrderDetails.Columns["TrimAmount"].Visible = false;
            dgvOrderDetails.Columns["OrderStatusID"].Visible = false;

            SetGridFont(dgvOrderDetails);

            grpCustomerGridview.ValuesSecondary.Description = dgvOrderDetails.Rows.Count.ToString();

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
                }
                else if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Received")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Green; ;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                    dgvOrderDetails.Rows[i].Cells["colCheck"].ReadOnly = false;
                }
            }
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

                    int RecordCount = ObjDAL.ExecuteScalarInt("select count(1) from " + clsUtility.DBName + ".dbo.tblOrderStatus WITH(NOLOCK) where SalesOrderID=" + SalesID + " AND SalesOrderDetailsID=" + SalesOrderDetailsID);
                    if (RecordCount > 0)
                    {
                        // 1 - Order Devlivered.
                        ObjDAL.UpdateColumnData("OrderStatus", SqlDbType.Int, 1);
                        ObjDAL.UpdateColumnData("ReceivedDate", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        ObjDAL.UpdateColumnData("ReceivedBy", SqlDbType.Int, clsUtility.LoginID);

                        ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblOrderStatus", "SalesOrderID=" + SalesID + " AND SalesOrderDetailsID=" + SalesOrderDetailsID);
                    }
                    else
                    {
                        // 1 - Order Devlivered.
                        ObjDAL.SetColumnData("OrderStatus", SqlDbType.Int, 1);
                        ObjDAL.SetColumnData("ReceivedDate", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        ObjDAL.SetColumnData("ReceivedBy", SqlDbType.Int, clsUtility.LoginID);

                        ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblOrderStatus", false);
                    }
                }
            }
            clsUtility.ShowInfoMessage("Selected Garments has been Delivered.");
            LoadOrderReceive();
        }
    }
}