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
    public partial class Customer_Master : KryptonForm
    {
        public Customer_Master()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private void ClearAll()
        {
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtCustomerMobileNo.Clear();
            txtCustomerEmailID.Clear();

            txtCustomerName.Focus();
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtCustomerName))
            {
                clsUtility.ShowInfoMessage("Enter Customer Name       ", clsUtility.strProjectTitle);
                txtCustomerName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCustomerMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Customer Mobile No.      ", clsUtility.strProjectTitle);
                txtCustomerMobileNo.Focus();
                return false;
            }
            else if (txtCustomerMobileNo.Text.Length < 10)
            {
                clsUtility.ShowInfoMessage("Enter Valid Customer Mobile No.      ", clsUtility.strProjectTitle);
                txtCustomerMobileNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCustomerAddress))
            {
                clsUtility.ShowInfoMessage("Enter Customer Address.      ", clsUtility.strProjectTitle);
                txtCustomerAddress.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CustomerMaster", "MobileNo='" + txtCustomerMobileNo.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.CustomerMaster", "MobileNo='" + txtCustomerMobileNo.Text + "' AND CustomerID !=" + i);
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

        private void LoadData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Customer");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCustomerMaster.DataSource = dt;
                }
                else
                {
                    dgvCustomerMaster.DataSource = null;
                }
            }
            else
            {
                dgvCustomerMaster.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);

            EnableDisable(true);

            txtCustomerName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtCustomerName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCustomerAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCustomerMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCustomerEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Customer");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            EnableDisable(false);
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is already exist..", clsUtility.strProjectTitle);
                        txtCustomerName.Focus();
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
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);

                EnableDisable(true);

                txtCustomerName.Focus();
                txtCustomerName.SelectionStart = txtCustomerName.MaxLength;
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    if (DuplicateUser(ID))
                    {
                        ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtCustomerName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCustomerAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCustomerMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCustomerEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_Customer");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                            clsUtility.ShowInfoMessage("'" + txtCustomerName.Text + "' Customer is Updated", clsUtility.strProjectTitle);
                            LoadData();
                            ClearAll();
                            EnableDisable(false);
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is not Updated", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is already exist..", clsUtility.strProjectTitle);
                        txtCustomerName.Focus();
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
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCustomerName.Text + "' Customer ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_Customer");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtCustomerName.Text + "' Customer is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        EnableDisable(false);
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is not deleted  ", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
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

        private void dgvCustomerMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvCustomerMaster.SelectedRows[0].Cells["CustomerID"].Value);
                    txtCustomerName.Text = dgvCustomerMaster.SelectedRows[0].Cells["Name"].Value.ToString();
                    txtCustomerAddress.Text = dgvCustomerMaster.SelectedRows[0].Cells["Address"].Value.ToString();
                    txtCustomerMobileNo.Text = dgvCustomerMaster.SelectedRows[0].Cells["MobileNo"].Value.ToString();
                    txtCustomerEmailID.Text = dgvCustomerMaster.SelectedRows[0].Cells["EmailID"].Value.ToString();

                    EnableDisable(false);

                    txtCustomerName.Focus();
                }
                catch { }
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtCustomerMobileNo.Focus();
                return;
            }
        }

        private void LoadTailoringTheme()
        {
            //this.BackgroundImage = TAILORING.Properties.Resources.Background;
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

        private void Customer_Master_Load(object sender, EventArgs e)
        {
            //btnUpdate.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14.3f,FontStyle.Bold);

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dgvCustomerMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvCustomerMaster.RowHeadersVisible = false; // set it to false if not needed

            LoadTailoringTheme();

            LoadData();

            EnableDisable(false);
            //grpCustomer.Enabled = false;
        }

        private void EnableDisable(bool b)
        {
            txtCustomerName.Enabled = b;
            txtCustomerMobileNo.Enabled = b;
            txtCustomerEmailID.Enabled = b;
            txtCustomerAddress.Enabled = b;
        }

        private void rdSearchByCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCustomerName.Checked)
            {
                txtSearchByCustomerName.Enabled = true;
                txtSearchByCustomerName.Focus();
            }
            else
            {
                txtSearchByCustomerName.Enabled = false;
                txtSearchByCustomerName.Clear();
            }
        }

        private void rdShowAllOfCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllOfCustomer.Checked)
            {
                txtSearchByCustomerName.Enabled = false;
                txtSearchByCustomerName.Clear();

                txtSearchByMobileNo.Enabled = false;
                txtSearchByMobileNo.Clear();

                LoadData();
            }
        }

        private void txtSearchByCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomerMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvCustomerMaster);
            // ObjUtil.SetDataGridProperty(dgvCustomerMaster, DataGridViewAutoSizeColumnsMode.Fill);
            dgvCustomerMaster.Columns["CustomerID"].Visible = false;
            dgvCustomerMaster.Columns["LastChange"].Visible = false;


            dgvCustomerMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //kryptonHeaderGroup1.ValuesPrimary.Heading= "Total Records : " + dgvCustomerMaster.Rows.Count;
            kryptonHeaderGroup1.ValuesSecondary.Heading = "Total Records : " + dgvCustomerMaster.Rows.Count;
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            if (e.KeyChar != 13)
            {
                KryptonTextBox txt = (KryptonTextBox)sender;
                e.Handled = ObjUtil.IsString(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                    txt.Focus();
                }
            }
        }

        private void rdSearchByCustomerMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCustomerMobileNo.Checked)
            {
                txtSearchByMobileNo.Enabled = true;
                txtSearchByMobileNo.Focus();
            }
            else
            {
                txtSearchByMobileNo.Enabled = false;
                txtSearchByMobileNo.Clear();
            }
        }

        private void txtSearchByMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            if (e.KeyChar != 13)
            {
                KryptonTextBox txt = (KryptonTextBox)sender;
                e.Handled = ObjUtil.IsNumeric(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
                    txt.Focus();
                }
            }
        }

        private void txtSearchByMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByMobileNo.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtSearchByMobileNo.Text, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCustomerMaster.DataSource = dt;
                }
                else
                {
                    dgvCustomerMaster.DataSource = null;
                }
            }
            else
            {
                dgvCustomerMaster.DataSource = null;
            }
        }
    }
}