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
            this.BackgroundImage = TAILORING.Properties.Resources.Background;
        }

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

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.Columns["GarmentID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderDetailsID"].Visible = false;

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}