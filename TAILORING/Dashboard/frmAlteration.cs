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
    public partial class frmAlteration : KryptonForm
    {
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();

        bool iscolUchekced = false;
        public string OrderNo { get; set; }
        public frmAlteration()
        {
            InitializeComponent();
        }
        private void BindcustomerDetails(int custID)
        {
            DataTable dtCustomerDetails = ObjDAL.ExecuteSelectStatement("SELECT Name,MobileNo FROM " + clsUtility.DBName + ".[dbo].[CustomerMaster] WITH(NOLOCK) WHERE CustomerID=" + custID);
            if (ObjUtil.ValidateTable(dtCustomerDetails))
            {
                lblCustomerName.Text = dtCustomerDetails.Rows[0]["Name"].ToString();
                lblMobile.Text = dtCustomerDetails.Rows[0]["MobileNo"].ToString();
            }
        }
        private void LoadOrderReceive()
        {
            lblOrderNo.Text = OrderNo.ToString();

            DataTable dtOrderDetails = ObjDAL.ExecuteSelectStatement("SELECT SalesOrderID,CustomerID FROM  " + clsUtility.DBName + ".[dbo].tblSalesOrder WITH(NOLOCK) WHERE OrderNo='" + OrderNo + "'" );

            if (ObjUtil.ValidateTable(dtOrderDetails))
            {
                int _CustID = Convert.ToInt32(dtOrderDetails.Rows[0]["CustomerID"]);
                int _SalesOrderID = Convert.ToInt32(dtOrderDetails.Rows[0]["SalesOrderID"]);

                BindcustomerDetails(_CustID);

                DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".dbo.vw_GetOrderStatusDetails WHERE SalesOrderID=" + _SalesOrderID + " AND OrderStatus='Delivered'");
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
        private void SetDataGridviewPaletteMode(KryptonDataGridView dgv)
        {
            dgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }
        private void SetGridFont(KryptonDataGridView kryptonDataGridView)
        {
            kryptonDataGridView.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
            kryptonDataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
        }
        private void frmAlteration_Load(object sender, EventArgs e)
        {
            SetDataGridviewPaletteMode(dgvOrderDetails);
            LoadOrderReceive();
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
            dgvOrderDetails.Columns["StichTypeName"].HeaderText = "Stitch Type";
            dgvOrderDetails.Columns["FitTypeName"].HeaderText = "Fit Type";
            dgvOrderDetails.Columns["TrimAmount"].Visible = false;
            dgvOrderDetails.Columns["OrderStatusID"].Visible = false;

            SetGridFont(dgvOrderDetails);

            grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();

            for (int i = 0; i < dgvOrderDetails.Columns.Count; i++)
            {
                if (i != 0)
                {
                    dgvOrderDetails.Columns[i].ReadOnly = true;
                }
            }
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Received")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Green; ;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                  
                }
                else if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Delivered")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(50, 122, 179);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 122, 179);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                   
                }
                else if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "In Process")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(96, 44, 24);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 44, 24);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else if (dgvOrderDetails.Rows[i].Cells["OrderStatus"].Value.ToString() == "Critical")
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(177, 0, 0);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(177, 0, 0);
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void dgvOrderDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetails.IsCurrentCellDirty)
            {
                dgvOrderDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsUtility.ShowInfoMessage("Select Garment sent for the alteration.");
        }
    }
}