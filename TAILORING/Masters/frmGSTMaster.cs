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
    public partial class frmGSTMaster : KryptonForm
    {
        public frmGSTMaster()
        {
            InitializeComponent();
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        double CGST = 0, SGST = 0;

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

        private void frmGSTMaster_Load(object sender, EventArgs e)
        {
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dgvGSTMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvGSTMaster.RowHeadersVisible = false; // set it to false if not needed

            LoadTailoringTheme();
            SetDataGridviewPaletteMode(dgvGSTMaster);
            EnableDisable(false);
            LoadData();
        }

        private void EnableDisable(bool b)
        {
            txtCGST.Enabled = b;
            txtSGST.Enabled = b;
        }

        private void ClearAll()
        {
            txtCGST.Clear();
            txtSGST.Clear();
            txtIGST.Clear();
            CGST = 0;
            SGST = 0;

            txtCGST.Focus();
        }

        private bool ValidateForm()
        {
            DataTable dt = (DataTable)dgvGSTMaster.DataSource;

            if (ObjUtil.IsControlTextEmpty(txtCGST))
            {
                clsUtility.ShowInfoMessage("Enter CGST       ", clsUtility.strProjectTitle);
                txtCGST.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtSGST))
            {
                clsUtility.ShowInfoMessage("Enter SGST      ", clsUtility.strProjectTitle);
                txtSGST.Focus();
                return false;
            }
            else if (ObjUtil.ValidateTable(dt) && btnSave.Enabled)
            {
                clsUtility.ShowInfoMessage("Already GST information is saved..", clsUtility.strProjectTitle);
                txtCGST.Focus();
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GSTData");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvGSTMaster.DataSource = dt;

                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvGSTMaster.SelectedRows[0].Cells["GSTID"].Value);
                    txtCGST.Text = dgvGSTMaster.SelectedRows[0].Cells["CGST"].Value.ToString();
                    txtSGST.Text = dgvGSTMaster.SelectedRows[0].Cells["SGST"].Value.ToString();
                    txtIGST.Text = dgvGSTMaster.SelectedRows[0].Cells["IGST"].Value.ToString();
                    txtCGST.Focus();
                }
                else
                {
                    dgvGSTMaster.DataSource = null;
                }
            }
            else
            {
                dgvGSTMaster.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);

            EnableDisable(true);

            txtCGST.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmGSTMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    ObjDAL.SetStoreProcedureData("CGST", SqlDbType.Decimal, txtCGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("SGST", SqlDbType.Decimal, txtSGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("IGST", SqlDbType.Decimal, txtIGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_GSTData");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                        clsUtility.ShowInfoMessage("GST is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        EnableDisable(false);
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("GST is not Saved Successfully..", clsUtility.strProjectTitle);
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
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmGSTMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            {
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                EnableDisable(true);
                txtCGST.Focus();
                txtCGST.SelectionStart = txtCGST.MaxLength;
            }
            else
            {
                clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmGSTMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            {
                if (ValidateForm())
                {
                    ObjDAL.SetStoreProcedureData("GSTID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CGST", SqlDbType.Decimal, txtCGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("SGST", SqlDbType.Decimal, txtSGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("IGST", SqlDbType.Decimal, txtIGST.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_GSTData");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                        clsUtility.ShowInfoMessage("GST is Updated Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        EnableDisable(false);
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("GST is not Updated Successfully..", clsUtility.strProjectTitle);
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
            if (clsFormRights.HasFormRight(clsFormRights.Forms.frmGSTMaster, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            {
                //DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCGST.Text + "' CGST ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                bool d = clsUtility.ShowQuestionMessage("Are you sure want to delete '" + txtCGST.Text + "' CGST ");
                if (d)
                {
                    ObjDAL.SetStoreProcedureData("GSTID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Delete_GSTData");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtCGST.Text + "' CGST is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        EnableDisable(false);
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCGST.Text + "' CGST is not deleted  ", clsUtility.strProjectTitle);
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
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                ClearAll();
                LoadData();

                EnableDisable(false);
            }
        }

        private void dgvGSTMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvGSTMaster.SelectedRows[0].Cells["GSTID"].Value);
                    txtCGST.Text = dgvGSTMaster.SelectedRows[0].Cells["CGST"].Value.ToString();
                    txtSGST.Text = dgvGSTMaster.SelectedRows[0].Cells["SGST"].Value.ToString();
                    txtIGST.Text = dgvGSTMaster.SelectedRows[0].Cells["IGST"].Value.ToString();
                    EnableDisable(false);
                    txtCGST.Focus();
                }
                catch { }
            }
        }

        private void txtCGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                KryptonTextBox txt = (KryptonTextBox)sender;
                e.Handled = ObjUtil.IsDecimal(txt, e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
                    txt.Focus();
                }
            }
        }

        private void dgvGSTMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvGSTMaster);
            //  ObjUtil.SetDataGridProperty(dgvGSTMaster, DataGridViewAutoSizeColumnsMode.Fill);
            dgvGSTMaster.Columns["GSTID"].Visible = false;
            dgvGSTMaster.Columns["LastChange"].Visible = false;

            dgvGSTMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGSTMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonHeaderGroup1.ValuesSecondary.Heading = "Total Records : " + dgvGSTMaster.Rows.Count;
        }

        private void txtCGST_TextChanged(object sender, EventArgs e)
        {
            CGST = txtCGST.TextLength == 0 ? 0 : Convert.ToDouble(txtCGST.Text);
            SGST = txtSGST.TextLength == 0 ? 0 : Convert.ToDouble(txtSGST.Text);

            txtIGST.Text = (CGST + SGST).ToString();
        }
    }
}