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

namespace TAILORING.Masters
{
    public partial class frmProductRateMaster : KryptonForm
    {
        public frmProductRateMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private void frmProductRateMaster_Load(object sender, EventArgs e)
        {
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dataGridView1.RowHeadersVisible = false; // set it to false if not needed

            LoadProductDate();
            LoadProductRateData();

            grpProduct.Focus();
        }

        private void LoadProductDate()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    cmbGarmentName.DataSource = dt;
                    cmbGarmentName.DisplayMember = "GarmentName";
                    cmbGarmentName.ValueMember = "GarmentID";
                }
                else
                {
                    cmbGarmentName.DataSource = null;
                }
            }
            else
            {
                cmbGarmentName.DataSource = null;
            }
            cmbGarmentName.SelectedIndex = -1;
        }
        private void LoadProductRateData()
        {
            ObjDAL.SetStoreProcedureData("OrderType", SqlDbType.Int, 2, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product_Rate");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void ClearAll()
        {
            cmbGarmentName.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            txtRate.Clear();
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsDecimal(txtRate, e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Only Number...");
                txtRate.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpProduct.Enabled = true;
            cmbGarmentName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpProduct.Enabled = true;
                cmbGarmentName.Focus();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadProductRateData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpProduct.Enabled = false;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            //ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["LastChange"].Visible = false;
            dataGridView1.Columns["GarmentCodeName"].Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grpGridview.ValuesSecondary.Heading = "Total Records : " + dataGridView1.Rows.Count;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GarmentID"].Value);
                    cmbGarmentName.Text = dataGridView1.SelectedRows[0].Cells["GarmentName"].Value.ToString();
                    txtRate.Text = dataGridView1.SelectedRows[0].Cells["Rate"].Value.ToString();
                    cmbService.Text = dataGridView1.SelectedRows[0].Cells["OrderType"].Value.ToString();
                    grpProduct.Enabled = false;
                    cmbGarmentName.Focus();
                }
                catch (Exception ex)
                {
                    clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
                }
            }
        }
    }
}