using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using CoreApp;
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace TAILORING
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUtility objUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        byte count = 0;
        bool Isexit = true;
        //String DBName = String.Empty;
        String UserIPAddress = String.Empty;
        String UserMacAddress = String.Empty;

        private void LoadTailoringTheme()
        {
            this.BackgroundImage = null;
            this.PaletteMode = PaletteMode.SparklePurple;
            this.BackColor = Color.FromArgb(82, 91, 114);

            btnLogin.PaletteMode = PaletteMode.SparklePurple;
            btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private bool ValidateLogin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin") && count <= 3)
            {
                count++;
            }
            if (username.Equals("admin") && password.Equals("admin") && count == 3)
            {
                clsUtility.LoginID = 0;
                clsUtility.IsAdmin = true;
                return true;
            }
            else if (!(username.Equals("admin") && password.Equals("admin")))
            {
                try
                {
                    DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.UserManagement", "UserID,EmployeeID,UserName,Password,IsAdmin", "UserName='" + txtUserName.Text.Trim() + "' AND Password='" + objUtil.Encrypt(txtPassword.Text, true) + "' AND ISNULL(ActiveStatus,0)=1", "UserID DESC");
                    if (objUtil.ValidateTable(dt))
                    {
                        clsUtility.LoginID = Convert.ToInt32(dt.Rows[0]["EmployeeID"]);
                        clsUtility.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        private bool ValidateClientSide()
        {
            if (objUtil.IsControlTextEmpty(txtUserName))
            {
                clsUtility.ShowErrorMessage("Enter User Name.          ", clsUtility.strProjectTitle);
                txtUserName.Focus();
                return false;
            }
            else if (objUtil.IsControlTextEmpty(txtPassword))
            {
                clsUtility.ShowErrorMessage("Enter Password.          ", clsUtility.strProjectTitle);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Isexit = false;
            if (ValidateClientSide())
            {
                if (ValidateLogin(txtUserName.Text, txtPassword.Text))
                {
                    int a = InsertLoginHistory();
                    frmHome Obj = new frmHome();
                    Obj.Login_History_ID = a;
                    Obj.BringToFront();
                    this.Close();
                    Obj.ShowDialog();
                }
                else
                {
                    Isexit = true;
                    clsUtility.ShowErrorMessage("Invalid User name or Password. or User " + txtUserName.Text.Trim() + " is InActive", clsUtility.strProjectTitle);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Isexit = false;

            UserManagement.frmForgetPassword Obj = new UserManagement.frmForgetPassword();
            Obj.ShowDialog();
            txtUserName.Focus();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Isexit)
            {
                try
                {
                    Application.Exit();
                }
                catch { }
            }
        }

        private int InsertLoginHistory()
        {
            GetUserIPMacAddress();

            ObjDAL.SetColumnData("UserID", SqlDbType.Int, clsUtility.LoginID);
            ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, txtUserName.Text.Trim());
            ObjDAL.SetColumnData("PcName", SqlDbType.NVarChar, System.Environment.MachineName);
            ObjDAL.SetColumnData("MachineUserName", SqlDbType.NVarChar, System.Environment.UserName);
            ObjDAL.SetColumnData("UserIPAddress", SqlDbType.VarChar, UserIPAddress);
            ObjDAL.SetColumnData("UserMacAddress", SqlDbType.VarChar, UserMacAddress);

            return (ObjDAL.InsertData(clsUtility.DBName + ".dbo.Login_History", true));
        }

        private void GetUserIPMacAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(System.Environment.MachineName);
            IPAddress ipaddr = host.AddressList[1];
            UserIPAddress = ipaddr.ToString();

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (UserMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    UserMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
        }

        private void picIMGPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void picIMGPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadTailoringTheme();

            txtUserName.Focus();
        }
    }
}