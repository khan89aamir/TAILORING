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

            LoadData();

            grpProduct.Focus();
        }

        private void LoadData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product");

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
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpProduct.Enabled = false;
            }
        }
    }
}