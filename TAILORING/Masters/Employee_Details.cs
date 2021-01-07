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
    public partial class Employee_Details : KryptonForm
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        int EmployeeID = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicEmployee.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            dtpDOB.ShowCheckBox = true;
            dtpDOB.Checked = false;

            //btnAdd.BackgroundImage = B_Leave;
            //btnSave.BackgroundImage = B_Leave;
            //btnEdit.BackgroundImage = B_Leave;
            //btnUpdate.BackgroundImage = B_Leave;
            //btnDelete.BackgroundImage = B_Leave;
            //btnCancel.BackgroundImage = B_Leave;

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            LoadData();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpEmployee.Enabled = true;
            txtEmployeeCode.Focus();
        }

        private void ClearAll()
        {
            txtName.Clear();
            txtPass.Clear();
            txtUsername.Clear();
            txtEmployeeCode.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            txtAdd.Clear();
            PicEmployee.Image = null;
            txtMobileNo.Clear();
            EmployeeID = 0;
            txtEmail.Clear();
            dtpDOB.Value = DateTime.Now;
            dtpDOB.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                EmployeeID = 0;
                if (ValidateEmployee())
                {
                    SaveEmployee();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }
        private void CreateNewUser(int EmployeeID)
        {
            bool b = cmbEmployeeType.SelectedIndex == 0 ? true : false;
            ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, txtUsername.Text.Trim());
            ObjDAL.SetColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPass.Text.Trim(), true));
            ObjDAL.SetColumnData("EmailID", SqlDbType.NVarChar, txtEmail.Text.Trim());
            ObjDAL.SetColumnData("IsAdmin", SqlDbType.Bit, b);
            ObjDAL.SetColumnData("IsBlock", SqlDbType.Bit, false);
            ObjDAL.SetColumnData("EmployeeID", SqlDbType.Int, EmployeeID);

            if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.UserManagement", true) > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("User has been added Successfully.", clsUtility.strProjectTitle);
                ClearAll();
                LoadData();
                grpEmployee.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the User.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private bool ValidateEmployee()
        {
            if (ObjUtil.IsControlTextEmpty(txtEmployeeCode))
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Code.", clsUtility.strProjectTitle);
                txtEmployeeCode.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtName))
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Name.", clsUtility.strProjectTitle);
                txtName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtMobileNo))
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Mobile No.", clsUtility.strProjectTitle);
                txtMobileNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbEmployeeType))
            {
                clsUtility.ShowInfoMessage("Please Select Employee Type.", clsUtility.strProjectTitle);
                cmbEmployeeType.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbActiveStatus))
            {
                clsUtility.ShowInfoMessage("Please Select Active Status.", clsUtility.strProjectTitle);
                cmbActiveStatus.Focus();
                return false;
            }
            else if (radFemale.Checked == false && radMale.Checked == false)
            {
                clsUtility.ShowInfoMessage("Please Select Gender.", clsUtility.strProjectTitle);
                radMale.Focus();
                radMale.Checked = false;
                radFemale.Checked = false;

                return false;
            }

            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, EmployeeID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Validate_Employee");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    int flag = Convert.ToInt32(dt.Rows[0]["Flag"]);
                    string msg = string.Empty;
                    if (flag <= 0)
                    {
                        msg = dt.Rows[0]["Msg"].ToString();
                        clsUtility.ShowInfoMessage(msg, clsUtility.strProjectTitle);
                        if (flag == 0 || flag == -2)
                            txtEmployeeCode.Focus();
                        else if(flag == -1)
                            txtMobileNo.Focus();

                        ObjDAL.ResetData();
                        return false;
                    }
                    ObjDAL.ResetData();
                } 
            }

            if (txtUsername.Text.Trim().Length > 0) // if user name is entered
            {
                if (ObjUtil.IsControlTextEmpty(txtPass))
                {
                    clsUtility.ShowInfoMessage("Please Enter Password.", clsUtility.strProjectTitle);
                    txtPass.Focus();
                    return false;
                }

                int countuser = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.UserManagement WITH(NOLOCK) WHERE UserName='" + txtUsername.Text + "' AND EmployeeID<>" + EmployeeID);
                if (countuser > 0)
                {
                    clsUtility.ShowInfoMessage("The user name already exist.Please enter different user name.", clsUtility.strProjectTitle);
                    txtUsername.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveEmployee()
        {
            ObjDAL.SetStoreProcedureData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtName.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtMobileNo.Text, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0, clsConnection_DAL.ParamType.Input);
            if (radMale.Checked)
            {
                ObjDAL.SetStoreProcedureData("Gender", SqlDbType.Bit, true, clsConnection_DAL.ParamType.Input);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.SetStoreProcedureData("Gender", SqlDbType.Bit, false, clsConnection_DAL.ParamType.Input);
            }
            if (dtpDOB.Checked)
            {
                ObjDAL.SetStoreProcedureData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"), clsConnection_DAL.ParamType.Input);
            }
            else
            {
                ObjDAL.SetStoreProcedureData("DOB", SqlDbType.DateTime, null, clsConnection_DAL.ParamType.Input);
            }
            ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtAdd.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("EmployeeType", SqlDbType.Int, cmbEmployeeType.SelectedIndex, clsConnection_DAL.ParamType.Input);

            if (PicEmployee.Image != null)
            {
                ObjDAL.SetStoreProcedureData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image), clsConnection_DAL.ParamType.Input);
            }
            ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Output);

            bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Employee");
            if (b)
            {
                DataTable dt = ObjDAL.GetOutputParmData();
                if (ObjUtil.ValidateTable(dt))
                {
                    EmployeeID = Convert.ToInt32(dt.Rows[0][1]);
                }
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                clsUtility.ShowInfoMessage("Employee has been added Successfully.", clsUtility.strProjectTitle);

                if (txtUsername.Text.Trim().Length != 0 && txtPass.Text.Trim().Length != 0)
                {
                    CreateNewUser(EmployeeID);
                }
                ClearAll();
                LoadData();
                grpEmployee.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the Employee.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void LoadData()
        {
            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, clsUtility.IsAdmin == true ? 0 : clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Employee");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dataTable = ds.Tables[0];
                if (ObjUtil.ValidateTable(dataTable))
                {
                    dgvEmployee.DataSource = dataTable;
                    grpCustomerGridview.ValuesSecondary.Heading = "Total Employee Count : " + dgvEmployee.Rows.Count.ToString();
                }
                else
                {
                    dgvEmployee.DataSource = null;
                    grpCustomerGridview.ValuesSecondary.Heading = "Total Employee Count : 0";
                }
            }
            else
            {
                dgvEmployee.DataSource = null;
                grpCustomerGridview.ValuesSecondary.Heading = "Total Employee Count : 0";
            }
        }

        private void dgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvEmployee);
            //ObjUtil.SetDataGridProperty(dgvEmployee, DataGridViewAutoSizeColumnsMode.Fill);
            dgvEmployee.Columns["Photo"].Visible = false;
            dgvEmployee.Columns["EmpID"].Visible = false;
            dgvEmployee.Columns["LastChange"].Visible = false;

            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grpCustomerGridview.ValuesSecondary.Heading = "Total Records : " + dgvEmployee.Rows.Count;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicEmployee.Image = null;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpEmployee.Enabled = false;
            }
        }

        private void BindUserDetails()
        {
            DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".[dbo].[UserManagement] WITH(NOLOCK) WHERE EmployeeID=" + EmployeeID);
            if (ObjUtil.ValidateTable(dt))
            {
                txtUsername.Text = dt.Rows[0]["UserName"].ToString();
                txtPass.Text = ObjUtil.Decrypt(dt.Rows[0]["Password"].ToString(), true);
                txtEmail.Text = dt.Rows[0]["EmailID"].ToString();
            }
        }
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ClearAll();
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    EmployeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmpID"].Value);
                    txtEmployeeCode.Text = dgvEmployee.SelectedRows[0].Cells["EmployeeCode"].Value.ToString();
                    txtName.Text = dgvEmployee.SelectedRows[0].Cells["Name"].Value.ToString();
                    txtMobileNo.Text = dgvEmployee.SelectedRows[0].Cells["MobileNo"].Value.ToString();

                    if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && dgvEmployee.SelectedRows[0].Cells["Gender"].Value.ToString() == "Male")
                    {
                        radMale.Checked = true;
                    }
                    else if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && dgvEmployee.SelectedRows[0].Cells["Gender"].Value.ToString() == "Female")
                    {
                        radFemale.Checked = true;
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["DOB"].Value != DBNull.Value)
                    {
                        dtpDOB.Value = Convert.ToDateTime(dgvEmployee.SelectedRows[0].Cells["DOB"].Value);
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Address"].Value != DBNull.Value)
                    {
                        txtAdd.Text = dgvEmployee.SelectedRows[0].Cells["Address"].Value.ToString();
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Photo"].Value != DBNull.Value)
                    {
                        PicEmployee.Image = ObjUtil.GetImage((byte[])dgvEmployee.SelectedRows[0].Cells["Photo"].Value);
                    }

                    grpEmployee.Enabled = false;
                    BindUserDetails();
                }
                catch { }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpEmployee.Enabled = true;
                txtEmployeeCode.Focus();
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                if (ValidateEmployee())
                {
                    UpdateEmployee();
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }
        private void UpdateEmployee()
        {
            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, EmployeeID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtName.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtMobileNo.Text, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0, clsConnection_DAL.ParamType.Input);
            if (radMale.Checked)
            {
                ObjDAL.SetStoreProcedureData("Gender", SqlDbType.Bit, true, clsConnection_DAL.ParamType.Input);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.SetStoreProcedureData("Gender", SqlDbType.Bit, false, clsConnection_DAL.ParamType.Input);
            }
            if (dtpDOB.Checked)
            {
                ObjDAL.SetStoreProcedureData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"), clsConnection_DAL.ParamType.Input);
            }
            else
            {
                ObjDAL.SetStoreProcedureData("DOB", SqlDbType.DateTime, null, clsConnection_DAL.ParamType.Input);
            }
            ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtAdd.Text.Trim(), clsConnection_DAL.ParamType.Input);

            if (PicEmployee.Image != null)
            {
                ObjDAL.SetStoreProcedureData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image), clsConnection_DAL.ParamType.Input);
            }
            ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
            bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_Employee");
            if (b)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                clsUtility.ShowInfoMessage("Employee Record has been updated.", clsUtility.strProjectTitle);

                if (txtUsername.Text.Trim().Length != 0 && txtPass.Text.Trim().Length != 0)
                {
                    int countuser = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.UserManagement WITH(NOLOCK) WHERE UserName='" + txtUsername.Text + "'");

                    if (countuser > 0)
                    {
                        UpdateUserDetails();
                    }
                    else
                    {
                        CreateNewUser(EmployeeID);
                    }
                }
                LoadData();
                ClearAll();
                grpEmployee.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the employee data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void UpdateUserDetails()
        {
            bool b = cmbEmployeeType.SelectedIndex == 0 ? true : false;
            ObjDAL.UpdateColumnData("UserName", SqlDbType.NVarChar, txtUsername.Text.Trim());
            ObjDAL.UpdateColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPass.Text.Trim(), true));
            ObjDAL.UpdateColumnData("EmailID", SqlDbType.NVarChar, txtEmail.Text.Trim());
            ObjDAL.UpdateColumnData("IsAdmin", SqlDbType.Bit, b);
            //if user is blocked then if his details will update from this form then could be auto unblock

            //ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, false);
            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.UserManagement", "EmployeeID = " + EmployeeID + "") > 0)
            {
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                clsUtility.ShowInfoMessage("User Login Record has been updated.", clsUtility.strProjectTitle);
                LoadData();
                ClearAll();
                grpEmployee.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the User Login Data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtName.Text + "' ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    ObjDAL.SetStoreProcedureData("EmpID", SqlDbType.Int, EmployeeID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_Employee");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtName.Text + "' Employee has been deleted.  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpEmployee.Enabled = false;
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("Failed to delete the employee. ", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void txtEmployeeCode_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtEmployeeCode_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            e.Handled = ObjUtil.IsString(e);
            if (e.Handled == true)
            {
                clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                txt.Focus();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            e.Handled = ObjUtil.IsNumeric(e);
            if (e.Handled == true)
            {
                clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
                txt.Focus();
            }
        }

        private void txtSearchByEmpName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByEmpName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }

            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, clsUtility.IsAdmin == true ? 0 : clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtSearchByEmpName.Text, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Employee");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvEmployee.DataSource = dt;
                }
                else
                {
                    dgvEmployee.DataSource = null;
                }
            }
            else
            {
                dgvEmployee.DataSource = null;
            }
        }

        private void txtSearchByEmpMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByEmpMobileNo.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }

            ObjDAL.SetStoreProcedureData("EMPID", SqlDbType.Int, clsUtility.IsAdmin == true ? 0 : clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, '0', clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.NVarChar, txtSearchByEmpMobileNo.Text, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Employee");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvEmployee.DataSource = dt;
                }
                else
                {
                    dgvEmployee.DataSource = null;
                }
            }
            else
            {
                dgvEmployee.DataSource = null;
            }
        }

        private void rdSearchByEmpName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByEmpName.Checked)
            {
                txtSearchByEmpName.Enabled = true;
                txtSearchByEmpName.Focus();
            }
            else
            {
                txtSearchByEmpName.Enabled = false;
                txtSearchByEmpName.Clear();
            }
        }

        private void rdSearchByEmpMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByEmpMobileNo.Checked)
            {
                txtSearchByEmpMobileNo.Enabled = true;
                txtSearchByEmpMobileNo.Focus();
            }
            else
            {
                txtSearchByEmpMobileNo.Enabled = false;
                txtSearchByEmpMobileNo.Clear();
            }
        }

        private void rdShowAllOfEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllOfEmp.Checked)
            {
                txtSearchByEmpMobileNo.Enabled = false;
                txtSearchByEmpMobileNo.Clear();

                txtSearchByEmpName.Enabled = false;
                txtSearchByEmpName.Clear();

                LoadData();
            }
        }
    }
}