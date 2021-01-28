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

namespace TAILORING.Dashboard
{
    public partial class frmQuickCustomer : KryptonForm
    {
        public frmQuickCustomer()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int CustomerID = 0;

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = null;
            this.PaletteMode = PaletteMode.SparklePurple;
            this.BackColor = Color.FromArgb(82, 91, 114);

            btnSave.PaletteMode = PaletteMode.SparklePurple;
            btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnCancel.PaletteMode = PaletteMode.SparklePurple;
            btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void frmQuickCustomer_Load(object sender, EventArgs e)
        {
            LoadTailoringTheme();
            txtCustomerName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, DBNull.Value, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, CustomerID, clsConnection_DAL.ParamType.Output);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Insert_Customer");
                        if (b)
                        {
                            clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            DataTable dtOutput = ObjDAL.GetOutputParmData();
                            if (ObjUtil.ValidateTable(dtOutput))
                            {
                                CustomerID = Convert.ToInt32(dtOutput.Rows[0][1]);

                                Order.frmOrderManagement Obj = new Order.frmOrderManagement();
                                Obj.CustomerID = CustomerID;
                                Obj.CustName = txtCustomerName.Text;
                                Obj.CustMobileNo = txtCustomerMobileNo.Text;
                                Obj.CustAddress = txtCustomerAddress.Text;
                                this.Close();
                                Obj.ShowDialog();
                            }
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
                clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
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

        private void txtCustomerMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                e.Handled = ObjUtil.IsNumeric(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Number..");
                    txtCustomerMobileNo.Focus();
                }
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                e.Handled = ObjUtil.IsString(e);
                if (e.Handled)
                {
                    clsUtility.ShowInfoMessage("Enter Only Charactor..");
                    txtCustomerName.Focus();
                }
            }
        }

        private void frmQuickCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
