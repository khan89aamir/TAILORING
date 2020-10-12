using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Masters
{
    public partial class Product_Master : Form
    {
        public Product_Master()
        {
            InitializeComponent();
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;
        private void ClearAll()
        {
            txtGarmentCode.Clear();
            txtGarmentName.Clear();
            txtGarmentCode.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtGarmentCode))
            {
                clsUtility.ShowInfoMessage("Enter Garment Code           ", clsUtility.strProjectTitle);
                txtGarmentCode.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtGarmentName))
            {
                clsUtility.ShowInfoMessage("Enter Garment Name           ", clsUtility.strProjectTitle);
                txtGarmentName.Focus();
                return false;
            }

            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("GarmentCode", SqlDbType.NVarChar, txtGarmentCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("GarmentName", SqlDbType.NVarChar, txtGarmentName.Text.Trim(), clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Validate_Product");
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
                        if (flag == 0)
                            txtGarmentCode.Focus();
                        else
                            txtGarmentName.Focus();

                        ObjDAL.ResetData();
                        return false;
                    }
                }
                ObjDAL.ResetData();
            }

            return true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpProduct.Enabled = true;
            txtGarmentCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Product_Master, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (Validateform())
                {
                    ObjDAL.SetStoreProcedureData("GarmentCode", SqlDbType.NVarChar, txtGarmentCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("GarmentName", SqlDbType.NVarChar, txtGarmentName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Product");
                    if (b)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                        clsUtility.ShowInfoMessage("Garment Name : '" + txtGarmentName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpProduct.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Garment Name : '" + txtGarmentName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Product_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpProduct.Enabled = true;
                txtGarmentCode.Focus();
                txtGarmentCode.SelectionStart = txtGarmentCode.MaxLength;
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Product_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                if (Validateform())
                {
                    ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("GarmentCode", SqlDbType.NVarChar, txtGarmentCode.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("GarmentName", SqlDbType.NVarChar, txtGarmentName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_Product");
                    if (b)
                    {
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                        clsUtility.ShowInfoMessage("'" + txtGarmentName.Text + "' Garment is Updated", clsUtility.strProjectTitle);
                        LoadData();
                        ClearAll();
                        grpProduct.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtGarmentName.Text + "' Garment is not Updated", clsUtility.strProjectTitle);
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
            if (clsFormRights.HasFormRight(clsFormRights.Forms.Product_Master, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtGarmentName.Text + "' Garment ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_Product");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtGarmentName.Text + "' Garment is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpProduct.Enabled = false;
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtGarmentName.Text + "' Garment is not deleted  ", clsUtility.strProjectTitle);
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
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpProduct.Enabled = false;
            }
        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GarmentID"].Value);
                    txtGarmentName.Text = dataGridView1.SelectedRows[0].Cells["GarmentName"].Value.ToString();
                    txtGarmentCode.Text = dataGridView1.SelectedRows[0].Cells["GarmentCode"].Value.ToString();
                    grpProduct.Enabled = false;
                    txtGarmentCode.Focus();
                }
                catch (Exception ex)
                {
                    clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
                }
            }
        }

        private void Product_Master_Load(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
            btnEdit.BackgroundImage = B_Leave;
            btnUpdate.BackgroundImage = B_Leave;
            btnDelete.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dataGridView1.RowHeadersVisible = false; // set it to false if not needed

            LoadData();

            grpProduct.Focus();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void rdSearchByProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByProduct.Checked)
            {
                txtSearchByGarment.Enabled = true;
                txtSearchByGarment.Focus();
            }
            else
            {
                txtSearchByGarment.Enabled = false;
                txtSearchByGarment.Clear();
            }
        }

        private void rdShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAll.Checked)
            {
                txtSearchByGarment.Enabled = false;
                txtSearchByGarment.Clear();
                LoadData();
            }
        }

        private void txtSearchByProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByGarment.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            ObjDAL.SetStoreProcedureData("GarmentName", SqlDbType.NVarChar, txtSearchByGarment.Text.Trim(), clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Product");
            if (ds != null && ds.Tables.Count > 0)
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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            lblTotalRecords.Text = "Total Records : " + dataGridView1.Rows.Count;
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsString(e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                txtGarmentName.Focus();
            }
        }

        private void txtGarmentCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsAlphaNumeric(e);
            if (e.Handled)
            {
                clsUtility.ShowInfoMessage("Enter Only Charactors or Number...", clsUtility.strProjectTitle);
                txtGarmentCode.Focus();
            }
        }
    }
}