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

namespace TAILORING.Barcode
{
    public partial class frmBarcodePrint : KryptonForm
    {
        public frmBarcodePrint()
        {
            InitializeComponent();
        }
        CoreApp.clsConnection_DAL ObjDAL = new CoreApp.clsConnection_DAL(true);
        CoreApp.clsUtility ObjUtil = new CoreApp.clsUtility();

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // for creating chalan , get only those records, which are in process or critical.
            string strQ = "select SalesOrderID, SubOrderNo,GarmentName,GarmentCode,StichTypeName,FitTypeName,TrailDate,DeliveryDate from[dbo].[vw_GetOrderStatusDetails]" +
                            " where SalesOrderID in (select SalesOrderID from tblSalesOrder where OrderNo = '" + txtInvoiceNo.Text + "');";

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

        private void SetGridFont(KryptonDataGridView kryptonDataGridView)
        {
            kryptonDataGridView.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
            kryptonDataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.0f, FontStyle.Regular);
        }

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;

            SetGridFont(dgvOrderDetails);

            grpCustomerGridview.ValuesSecondary.Description = dgvOrderDetails.Rows.Count.ToString();

            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetDataGridviewPaletteMode(KryptonDataGridView dgv)
        {
            dgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void frmBarcodePrint_Load(object sender, EventArgs e)
        {
            SetDataGridviewPaletteMode(dgvOrderDetails);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRecive())
            {
                clsUtility.ShowInfoMessage("Please Select your record to be printed.");
                return;
            }

            clsUtility.ShowInfoMessage("Printer Not Configured !");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}