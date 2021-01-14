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

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = null;
            this.PaletteMode = PaletteMode.SparklePurple;
            this.BackColor = Color.FromArgb(82, 91, 114);

            btnAdd.PaletteMode = PaletteMode.SparklePurple;
            btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnSave.PaletteMode = PaletteMode.SparklePurple;
            btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnEdit.PaletteMode = PaletteMode.SparklePurple;
            btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnUpdate.PaletteMode = PaletteMode.SparklePurple;
            btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnDelete.PaletteMode = PaletteMode.SparklePurple;
            btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnCancel.PaletteMode = PaletteMode.SparklePurple;
            btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        private void frmProductRateMaster_Load(object sender, EventArgs e)
        {
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dataGridView1.RowHeadersVisible = false; // set it to false if not needed

            EnableDisable(false);
            LoadTailoringTheme();

            LoadProductData();
            LoadProductRateData();

            grpProduct.Focus();
        }

        private void LoadProductData()
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

            EnableDisable(true);

            cmbGarmentName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmProductRateMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(0))
                    {
                        SaveProductRateDetails();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + cmbGarmentName.Text + "' Garment is already exist..", clsUtility.strProjectTitle);
                        cmbGarmentName.Focus();
                    }
                }
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

                EnableDisable(true);

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
                if (ValidateForm())
                {
                    if (DuplicateUser(ID))
                    {
                        UpdateProductRateDetails();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + cmbGarmentName.Text + "' Garment is already exist..", clsUtility.strProjectTitle);
                        cmbGarmentName.Focus();
                    }
                }
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
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + cmbGarmentName.Text + "' Garment", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    ObjDAL.SetStoreProcedureData("GarmentRateID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_Product_Rate");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + cmbGarmentName.Text + "' Garment is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadProductRateData();

                        EnableDisable(false);

                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + cmbGarmentName.Text + "' Garment is not deleted  ", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
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

                EnableDisable(false);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            //ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentRateID"].Visible = false;
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
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GarmentRateID"].Value);
                    cmbGarmentName.Text = dataGridView1.SelectedRows[0].Cells["GarmentName"].Value.ToString();
                    txtRate.Text = dataGridView1.SelectedRows[0].Cells["Rate"].Value.ToString();
                    cmbService.Text = dataGridView1.SelectedRows[0].Cells["OrderType"].Value.ToString();

                    EnableDisable(false);

                    cmbGarmentName.Focus();
                }
                catch (Exception ex)
                {
                    clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
                }
            }
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(cmbGarmentName))
            {
                clsUtility.ShowInfoMessage("Select Garment..       ", clsUtility.strProjectTitle);
                cmbGarmentName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbService))
            {
                clsUtility.ShowInfoMessage("Select Service Type for " + cmbGarmentName.Text, clsUtility.strProjectTitle);
                cmbService.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtRate))
            {
                clsUtility.ShowInfoMessage("Enter Rate for " + cmbGarmentName.Text, clsUtility.strProjectTitle);
                txtRate.Focus();
                return false;
            }
            else if (txtRate.Text == "0")
            {
                clsUtility.ShowInfoMessage("Enter Valid Rate for " + cmbGarmentName.Text, clsUtility.strProjectTitle);
                txtRate.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblProductRateMaster", "GarmentID=" + cmbGarmentName.SelectedValue + " AND OrderType=" + cmbService.SelectedIndex);
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblProductRateMaster", "GarmentID=" + cmbGarmentName.SelectedValue + " AND GarmentRateID !=" + i + " AND OrderType=" + cmbService.SelectedIndex);
            }
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SaveProductRateDetails()
        {
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, cmbGarmentName.SelectedValue, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("OrderType", SqlDbType.Int, cmbService.SelectedIndex, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Rate", SqlDbType.Decimal, txtRate.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

            bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Product_Rate");
            if (b)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                clsUtility.ShowInfoMessage("Garment : '" + cmbGarmentName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                ClearAll();
                LoadProductRateData();
                EnableDisable(false);
            }
            else
            {
                clsUtility.ShowInfoMessage("Garment : '" + cmbGarmentName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
            }
            ObjDAL.ResetData();
        }

        private void UpdateProductRateDetails()
        {
            ObjDAL.SetStoreProcedureData("GarmentRateID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, cmbGarmentName.SelectedValue, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("OrderType", SqlDbType.Int, cmbService.SelectedIndex, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Rate", SqlDbType.Decimal, txtRate.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

            bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_Product_Rate");
            if (b)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                clsUtility.ShowInfoMessage("Garment : '" + cmbGarmentName.Text + "' is Updated Successfully..", clsUtility.strProjectTitle);
                ClearAll();
                LoadProductRateData();

                EnableDisable(false);
            }
            else
            {
                clsUtility.ShowInfoMessage("Garment : '" + cmbGarmentName.Text + "' is not Updated Successfully..", clsUtility.strProjectTitle);
            }
            ObjDAL.ResetData();
        }

        private void EnableDisable(bool b)
        {
            cmbGarmentName.Enabled = b;
            cmbService.Enabled = b;
            txtRate.Enabled = b;

            cmbGarmentName.SelectedIndex = -1;
        }

        private void rdSearchByProduct_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchByGarment.Enabled = true;
            txtSearchByGarment.Focus();

            cmbSearchByService.SelectedIndex = -1;
            cmbSearchByService.Enabled = false;
        }

        private void rdSearchByService_CheckedChanged(object sender, EventArgs e)
        {
            cmbSearchByService.Enabled = true;
            cmbSearchByService.Focus();

            txtSearchByGarment.Clear();
            txtSearchByGarment.Enabled = false;
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchByGarment.Clear();
            txtSearchByGarment.Enabled = false;

            cmbSearchByService.SelectedIndex = -1;
            cmbSearchByService.Enabled = false;
        }
    }
}