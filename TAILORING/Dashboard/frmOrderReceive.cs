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
    public partial class frmOrderReceive : KryptonForm
    {
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();
        public frmOrderReceive()
        {
            InitializeComponent();
        }
        public string OrderNo { get; set; }
     
        private void LoadOrderReceive()
        {
            lblOrderNo.Text = OrderNo.ToString();
          

           DataTable dtOrderDetails=ObjDAL.ExecuteSelectStatement("select SalesOrderID,CustomerID from  "+ clsUtility.DBName + ".[dbo].tblSalesOrder where OrderNo='"+OrderNo+"'");

            if (ObjUtil.ValidateTable(dtOrderDetails))
            {
                int _CustID = Convert.ToInt32(dtOrderDetails.Rows[0]["CustomerID"]);
                int _SalesOrderID= Convert.ToInt32(dtOrderDetails.Rows[0]["SalesOrderID"]);


                BindcustomerDetails(_CustID);

                ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, _SalesOrderID, clsConnection_DAL.ParamType.Input);

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
            else
            {
                clsUtility.ShowInfoMessage("No Order found with order no : " + OrderNo);
                this.Close();
            }
          
          

        }

        private void frmOrderReceive_Load(object sender, EventArgs e)
        {
            
            LoadOrderReceive();
        }

        private void dgvOrderDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvOrderDetails.Columns["SalesOrderID"].Visible = false;
            dgvOrderDetails.Columns["SalesOrderDetailsID"].Visible = false;
            dgvOrderDetails.Columns["Rate"].Visible = false;
            dgvOrderDetails.Columns["Total"].Visible = false;
            dgvOrderDetails.Columns["GarmentID"].Visible = false;
            grpCustomerGridview.ValuesSecondary.Description = dgvOrderDetails.Rows.Count.ToString();

            for (int i = 0; i < dgvOrderDetails.Columns.Count; i++)
            {
                if (i!=0)
                {
                    dgvOrderDetails.Columns[i].ReadOnly = true;
                }
             
            }

            ObjUtil.SetRowNumber(dgvOrderDetails);
            //ObjUtil.SetDataGridProperty(dgvOrderDetails, DataGridViewAutoSizeColumnsMode.Fill);

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private void BindcustomerDetails(int custID)
        {
           DataTable dtCustomerDetails= ObjDAL.ExecuteSelectStatement("select Name,MobileNo from "+clsUtility.DBName+".[dbo].[CustomerMaster] where CustomerID="+custID);
            if (dtCustomerDetails.Rows.Count>0)
            {
                lblCustomerName.Text = dtCustomerDetails.Rows[0]["Name"].ToString();
                lblMobile.Text = dtCustomerDetails.Rows[0]["MobileNo"].ToString();

            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    dgvOrderDetails.Rows[i].Cells[0].Value = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRecive())
            {
                clsUtility.ShowInfoMessage("Please Check Garments to be received.");
                return;
            }

            ReceviceGarments();


        }

        private void ReceviceGarments()
        {
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells[0].Value != DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells[0].Value) == true)
                {
                    int SalesID = Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["SalesOrderID"].Value);
                    int SalesOrderDetailsID = Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["SalesOrderDetailsID"].Value);
                    int GarmentID = Convert.ToInt32(dgvOrderDetails.Rows[i].Cells["GarmentID"].Value);


                  
                    ObjDAL.SetColumnData("SalesOrderID", SqlDbType.Int, SalesID);
                    ObjDAL.SetColumnData("SalesOrderDetailsID", SqlDbType.Int, SalesOrderDetailsID);
                    ObjDAL.SetColumnData("GarmentID", SqlDbType.Int, GarmentID);
                    // 4 - Order received.
                    ObjDAL.SetColumnData("OrderStatus", SqlDbType.Int,4);
                    ObjDAL.InsertData("TAILORING_01.dbo.tblOrderStatus", false);
                }
            }
            clsUtility.ShowInfoMessage("Selected Garments has been Received.");
            this.Close();
        }

        private bool ValidateRecive()
        {
            bool status = false;
            dgvOrderDetails.EndEdit();
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (dgvOrderDetails.Rows[i].Cells[0].Value!=DBNull.Value && Convert.ToBoolean(dgvOrderDetails.Rows[i].Cells[0].Value)==true)
                {
                    status = true;
                    return status;

                }
            }

            return false;
        }
    }
}
