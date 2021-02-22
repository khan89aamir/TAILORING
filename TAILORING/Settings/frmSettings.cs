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

namespace TAILORING.Settings
{
    public partial class frmSettings : KryptonForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataTable dtSetting = new DataTable();
        int pSoftwareSettingID = 0;

        private void LoadSettingsData()
        {
            dtSetting = ObjDAL.ExecuteSelectStatement("SELECT TOP 1 SoftwareSettingID,ImagePath,GenericImagePath,CopyOrderMonth FROM " + clsUtility.DBName + ".dbo.tblSoftwareSetting");

            if (ObjUtil.ValidateTable(dtSetting))
            {
                pSoftwareSettingID = Convert.ToInt32(dtSetting.Rows[0]["SoftwareSettingID"]);
                txtImagePath.Text = dtSetting.Rows[0]["ImagePath"].ToString();
                txtGenericImage.Text = dtSetting.Rows[0]["GenericImagePath"].ToString();
                numericUpDown1.Value = Convert.ToDecimal(dtSetting.Rows[0]["CopyOrderMonth"]);
            }
            else
            {
                pSoftwareSettingID = 0;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadSettingsData();
            txtImagePath.SelectionStart = txtImagePath.MaxLength;
        }

        private bool ValidateData()
        {
            bool b = false;
            if (ObjUtil.IsControlTextEmpty(txtImagePath))
            {
                clsUtility.ShowInfoMessage("Please Select Image Path for Garments");
                btnBrowseImage.Focus();
            }
            else if (ObjUtil.IsControlTextEmpty(txtGenericImage))
            {
                clsUtility.ShowInfoMessage("Please Select Generic Image Path for Garments");
                btnBrowseGeneric.Focus();
            }
            else
            {
                b = true;
            }
            return b;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (ObjUtil.ValidateTable(dtSetting))
                {
                    UpdateSettings();
                }
                else
                {
                    SaveSettings();
                }
            }
        }

        private void SaveSettings()
        {
            ObjDAL.SetColumnData("ImagePath", SqlDbType.VarChar, txtImagePath.Text.Trim());
            ObjDAL.SetColumnData("GenericImagePath", SqlDbType.VarChar, txtGenericImage.Text.Trim());
            ObjDAL.SetColumnData("CopyOrderMonth", SqlDbType.Int, numericUpDown1.Value);
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);

            int i = ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblSoftwareSetting", true);
            if (i > 0)
            {
                clsUtility.ShowInfoMessage("Setting Saved Successfully...");
            }
            else
            {
                clsUtility.ShowErrorMessage("Setting not Saved Successfully...");
            }
            ObjDAL.ResetData();
        }

        private void UpdateSettings()
        {
            ObjDAL.UpdateColumnData("ImagePath", SqlDbType.VarChar, txtImagePath.Text.Trim());
            ObjDAL.UpdateColumnData("GenericImagePath", SqlDbType.VarChar, txtGenericImage.Text.Trim());
            ObjDAL.UpdateColumnData("CopyOrderMonth", SqlDbType.Int, numericUpDown1.Value);
            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID);
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            int i = ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblSoftwareSetting", "SoftwareSettingID=" + pSoftwareSettingID);
            if (i > 0)
            {
                clsUtility.ShowInfoMessage("Setting Updated Successfully...");
            }
            else
            {
                clsUtility.ShowErrorMessage("Setting not Updated Successfully...");
            }
            ObjDAL.ResetData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.Description = "Select your location for Garments Image.";
            DialogResult d = fld.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtImagePath.Text = fld.SelectedPath;
            }
        }

        private void btnBrowseGeneric_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.Description = "Select your location for Garments Generic Image.";
            DialogResult d = fld.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtGenericImage.Text = fld.SelectedPath;
            }
        }
    }
}