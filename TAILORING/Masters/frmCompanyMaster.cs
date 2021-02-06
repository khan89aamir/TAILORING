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

namespace TAILORING.Masters
{
    public partial class frmCompanyMaster : KryptonForm
    {
        public frmCompanyMaster()
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
            btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnSave.PaletteMode = PaletteMode.SparklePurple;
            btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnEdit.PaletteMode = PaletteMode.SparklePurple;
            btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnUpdate.PaletteMode = PaletteMode.SparklePurple;
            btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnDelete.PaletteMode = PaletteMode.SparklePurple;
            btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnCancel.PaletteMode = PaletteMode.SparklePurple;
            btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void SetDataGridviewPaletteMode(KryptonDataGridView dgv)
        {
            dgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void frmCompanyMaster_Load(object sender, EventArgs e)
        {
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dgvCompanyMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvCompanyMaster.RowHeadersVisible = false; // set it to false if not needed

            LoadTailoringTheme();
            SetDataGridviewPaletteMode(dgvCompanyMaster);
            LoadData();

            EnableDisable(false);
        }

        private void EnableDisable(bool b)
        {
            txtCompanyName.Enabled = b;
            txtCompanyMobileNo.Enabled = b;
            txtCompanyEmailID.Enabled = b;
            txtCompanyAddress.Enabled = b;

            //chkDefaultCompany.Enabled = b;
        }

        private void ClearAll()
        {
            txtCompanyName.Clear();
            txtCompanyAddress.Clear();
            txtCompanyMobileNo.Clear();
            txtCompanyEmailID.Clear();
            chkDefaultCompany.Checked = false;
            txtCompanyName.Focus();
        }

        private void LoadData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Company");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCompanyMaster.DataSource = dt;
                }
                else
                {
                    dgvCompanyMaster.DataSource = null;
                }
            }
            else
            {
                dgvCompanyMaster.DataSource = null;
            }
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtCompanyName))
            {
                clsUtility.ShowInfoMessage("Enter Company Name       ", clsUtility.strProjectTitle);
                txtCompanyName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Company Mobile No.      ", clsUtility.strProjectTitle);
                txtCompanyMobileNo.Focus();
                return false;
            }
            else if (txtCompanyMobileNo.Text.Trim().Length < 10)
            {
                clsUtility.ShowInfoMessage("Enter Valid Company Mobile No.      ", clsUtility.strProjectTitle);
                txtCompanyMobileNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyEmailID))
            {
                clsUtility.ShowInfoMessage("Enter Company Email ID.      ", clsUtility.strProjectTitle);
                txtCompanyEmailID.Focus();
                return false;
            }
            else if (ObjUtil.ValidateEmail(txtCompanyEmailID.Text))
            {
                clsUtility.ShowInfoMessage("Enter Valid Company Email ID.      ", clsUtility.strProjectTitle);
                txtCompanyEmailID.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyAddress))
            {
                clsUtility.ShowInfoMessage("Enter Company Address.      ", clsUtility.strProjectTitle);
                txtCompanyAddress.Focus();
                return false;
            }
            else if (chkDefaultCompany.Checked)
            {
                int a = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.CompanyMaster WITH(NOLOCK) WHERE ISNULL(IsDefault,0)=1");
                if (a > 0 && ID == 0)
                {
                    clsUtility.ShowInfoMessage("Already Default Company is presnet..");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CompanyMaster", "MobileNo='" + txtCompanyMobileNo.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CompanyMaster", "MobileNo='" + txtCompanyMobileNo.Text + "' AND CompanyID !=" + i);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            EnableDisable(true);
            txtCompanyName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, txtCompanyName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCompanyAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCompanyMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCompanyEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("IsDefault", SqlDbType.Bit, chkDefaultCompany.Checked, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Company");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Company Name : '" + txtCompanyName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            EnableDisable(false);
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Company Name : '" + txtCompanyName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is already exist..", clsUtility.strProjectTitle);
                        txtCompanyName.Focus();
                    }
                    ObjDAL.ResetData();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                EnableDisable(true);
                txtCompanyName.Focus();
                txtCompanyName.SelectionStart = txtCompanyName.MaxLength;
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(ID))
                    {
                        ObjDAL.SetStoreProcedureData("CompanyID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, txtCompanyName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCompanyAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCompanyMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCompanyEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("IsDefault", SqlDbType.Bit, chkDefaultCompany.Checked, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_Company");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                            clsUtility.ShowInfoMessage("'" + txtCompanyName.Text + "' Company is Updated", clsUtility.strProjectTitle);
                            LoadData();
                            ClearAll();
                            EnableDisable(false);
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is not Updated", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is already exist..", clsUtility.strProjectTitle);
                        txtCompanyName.Focus();
                    }
                    ObjDAL.ResetData();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
                //DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCompanyName.Text + "' Company ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                bool d = clsUtility.ShowQuestionMessage("Are you sure want to delete '" + txtCompanyName.Text + "' Company ");
                if (d)
                {
                    ObjDAL.SetStoreProcedureData("CompanyID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_Company");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtCompanyName.Text + "' Company is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        EnableDisable(false);
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is not deleted  ", clsUtility.strProjectTitle);
                    }
                    ObjDAL.ResetData();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadData();
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                EnableDisable(false);
            }
        }

        private void dgvCompanyMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvCompanyMaster.SelectedRows[0].Cells["CompanyID"].Value);
                    txtCompanyName.Text = dgvCompanyMaster.SelectedRows[0].Cells["CompanyName"].Value.ToString();
                    txtCompanyAddress.Text = dgvCompanyMaster.SelectedRows[0].Cells["Address"].Value.ToString();
                    txtCompanyMobileNo.Text = dgvCompanyMaster.SelectedRows[0].Cells["MobileNo"].Value.ToString();
                    txtCompanyEmailID.Text = dgvCompanyMaster.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    chkDefaultCompany.Checked = Convert.ToBoolean(dgvCompanyMaster.SelectedRows[0].Cells["DefaultValue"].Value);
                    EnableDisable(false);
                    txtCompanyName.Focus();
                }
                catch { }
            }
        }

        private void dgvCompanyMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvCompanyMaster);
            //ObjUtil.SetDataGridProperty(dgvCompanyMaster, DataGridViewAutoSizeColumnsMode.Fill);
            dgvCompanyMaster.Columns["CompanyID"].Visible = false;
            dgvCompanyMaster.Columns["DefaultValue"].Visible = false;
            dgvCompanyMaster.Columns["LastChange"].Visible = false;
            dgvCompanyMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompanyMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvCompanyMaster.Rows.Count;
        }

        private void txtCompanyMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 13)
            //{
            KryptonTextBox txt = (KryptonTextBox)sender;
            e.Handled = ObjUtil.IsNumeric(e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
                txt.Focus();
            }
            //}
        }
    }
}