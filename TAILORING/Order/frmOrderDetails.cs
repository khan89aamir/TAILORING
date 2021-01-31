using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmOrderDetails : KryptonForm
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        public int SalesOrderID = 0;

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = null;
            this.PaletteMode = PaletteMode.SparklePurple;
            this.BackColor = Color.FromArgb(82, 91, 114);
        }
        public string strSubOrderNo;
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvOrderDetails.RowHeadersVisible = false; // set it to false if not needed
            
            LoadTailoringTheme();

            LoadData();
        }

        private void LoadData()
        {
            if (isFromDashboard)
            {
                lblSuborderNo.Visible = true;
                label1.Visible = true;
                lblSuborderNo.Text = strSubOrderNo;
             
                string[] arr = strSubOrderNo.Replace("/", "@").Split('@');
                lblOrderNo.Text = arr[2];
                lblOrderNo.Visible = true;
                label3.Visible = true;

                SalesOrderID = ObjDAL.ExecuteScalarInt("select SalesOrderID from tblSalesOrderDetails where SubOrderNo='"+strSubOrderNo+"'");
            }

            ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, SalesOrderID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".[dbo].[SPR_Get_OrderDetails]");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
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
       public bool isFromDashboard = false;

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.Columns["GarmentID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderDetailsID"].Visible = false;

            dgvOrderDetails.Columns["StichTypeName"].HeaderText = "StichType";
            dgvOrderDetails.Columns["FitTypeName"].HeaderText = "FitTypeName";

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (isFromDashboard)
            {
                MarkSubOrderNo();
                dgvOrderDetails.ClearSelection();
            }
          
        }
        private void MarkSubOrderNo()
        {
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells["SubOrderNo"].Value.ToString()==strSubOrderNo)
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
                else
                {
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    dgvOrderDetails.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;

                }

            }
           
        }

        private void frmOrderDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}