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


namespace TAILORING.Dashboard
{
    public partial class frmChalanSub : KryptonForm
    {
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();
        public frmChalanSub()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["colCheck"].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells["colCheck"].Value))
                {
                    if (!frmCreateChalan.lstSubOrderListlist.Contains(dgvOrderDetails.Rows[i].Cells["SubOrderNo"].Value.ToString()))
                    {
                        frmCreateChalan.lstSubOrderListlist.Add(dgvOrderDetails.Rows[i].Cells["SubOrderNo"].Value.ToString());
                    }
                   
                }
            }
            this.Close();
        }

        public int SalesOrderID = 0;
        public bool isInvoiceChk = false;
        private void frmChalanSub_Load(object sender, EventArgs e)
        {

            ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, SalesOrderID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderDetails]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvOrderDetails.DataSource = dt;
                    grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvOrderDetails.Rows.Count.ToString();


                    if (isInvoiceChk)
                    {
                        for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                        {
                            dgvOrderDetails.Rows[i].Cells["colCheck"].Value = true;
                        }

                        dgvOrderDetails.Columns["colCheck"].ReadOnly = true;
                    }
                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                }
            }
        }

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.Columns["GarmentID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderDetailsID"].Visible = false;
            dgvOrderDetails.Columns["SubOrderNo"].Width = 136;
            

            dgvOrderDetails.Columns["StichTypeName"].HeaderText = "StichType";
            dgvOrderDetails.Columns["FitTypeName"].HeaderText = "FitTypeName";

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
