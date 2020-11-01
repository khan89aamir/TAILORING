using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmOrderManagement : Form
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        DataTable dtOrder = new DataTable();
        DataTable dtDefaultOrder = new DataTable();

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            InitItemTable();
            btnMeasurement.BackgroundImage = B_Leave;
            btnSave.BackgroundImage = B_Leave;
        }

        private void InitItemTable()
        {
            dtOrder.Columns.Add("GarmentID");
            dtOrder.Columns.Add("GarmentCode");
            dtOrder.Columns.Add("GarmentName");
            dtOrder.Columns.Add("Trim Amount");
            dtOrder.Columns.Add("QTY", typeof(int));
            dtOrder.Columns.Add("Rate", typeof(double));
            dtOrder.Columns.Add("Total", typeof(double));
            dtOrder.Columns.Add("Photo");
            //dtPurchaseInvoice.Columns.Add("Delete");

            //DataGridViewButtonColumn ColDelete = new DataGridViewButtonColumn();
            //ColDelete.DataPropertyName = "Delete";
            //ColDelete.HeaderText = "Delete";
            //ColDelete.Name = "ColDelete";
            //ColDelete.Text = "Delete";
            //ColDelete.UseColumnTextForButtonValue = true;

            dtOrder.AcceptChanges();
            //dataGridView1.DataSource = dtOrder;

            //dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //ColDelete});
        }

        DataTable dt = null;
        private void FillGarmentData()
        {
            dt = null;
            //DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_Product");

            //if (ObjUtil.ValidateDataSet(ds))
            //{
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblProductMaster", "GarmentID,GarmentName,Rate", "OrderType=" + cmbOrderType.SelectedIndex, "GarmentName ASC");
            //DataTable dt = ds.Tables[0];
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
            //}
            //else
            //{
            //    cmbGarmentName.DataSource = null;
            //}
            cmbGarmentName.SelectedIndex = -1;
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

        private void rdSearchByCustomerMobile_CheckedChanged(object sender, EventArgs e)
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

        private void txtSearchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCustomerName.Text.Length > 0)
            {
                ObjDAL.SetStoreProcedureData("Name", SqlDbType.NVarChar, txtSearchByCustomerName.Text, clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, '0', clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Search_Customer");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        ObjUtil.SetControlData(txtSearchByCustomerName, "Name");
                        ObjUtil.SetControlData(txtCustomerID, "CustomerID");
                        ObjUtil.ShowDataPopup(dt, txtSearchByCustomerName, this, this);

                        if (ObjUtil.GetDataPopup() != null && ObjUtil.GetDataPopup().DataSource != null)
                        {
                            ObjUtil.GetDataPopup().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (ObjUtil.GetDataPopup().ColumnCount > 0)
                            {
                                ObjUtil.GetDataPopup().Columns["Address"].Visible = false;
                                ObjUtil.GetDataPopup().Columns["CustomerID"].Visible = false;
                                ObjUtil.SetDataPopupSize(350, 0);
                            }
                        }
                        ObjUtil.GetDataPopup().CellClick += frmOrderManagement_CellClick;
                        ObjUtil.GetDataPopup().KeyDown += frmOrderManagement_KeyDown;
                    }
                    else
                    {
                        ObjUtil.CloseAutoExtender();
                    }
                }
            }
            else
            {
                txtCustomerID.Clear();
                ObjUtil.CloseAutoExtender();
            }
        }

        private void frmOrderManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = (DataTable)dgv.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();
                lblCustomerName.Text = dt.Rows[0]["Name"].ToString();
                lblCustomerAdd.Text = dt.Rows[0]["Address"].ToString();
            }
            cmbOrderType.Enabled = true;
        }

        private void frmOrderManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSearchByCustomerName.SelectionStart = txtSearchByCustomerName.MaxLength;
                txtSearchByCustomerName.Focus();

                //lblCustomerName.Text = dgv.Rows[0].Cells["Name"].ToString();
                //lblCustomerAdd.Text = dgv.Rows[0].Cells["Address"].ToString();
            }
            cmbOrderType.Enabled = true;
        }

        private void cmbOrderType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpNewOrder.Enabled = true;
            cmbGarmentName.Focus();
            FillGarmentData();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["Photo"].Visible = false;

            if (dataGridView1.Columns.Contains("Measurement"))
            {
                dataGridView1.Columns["Measurement"].Visible = false;
            }
            if (dataGridView1.Columns.Contains("Style"))
            {
                dataGridView1.Columns["Style"].Visible = false;
            }
            CalcTotalAmount();
        }

        private void cmbGarmentName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] drow = dt.Select("GarmentID=" + cmbGarmentName.SelectedValue);
            if (drow.Length > 0)
            {
                txtRate.Text = drow[0]["Rate"].ToString();
            }
            else
            {
                txtRate.Text = "0";
            }
            lnkAddItem.Enabled = true;
        }

        private void AddDefaultRow()
        {
            DataRow dRow = dtOrder.NewRow();
            dRow["GarmentID"] = 1;
            dRow["GarmentName"] = "Shirt";
            dRow["Trim Amount"] = 0;
            dRow["Rate"] = 100;
            dRow["QTY"] = 1;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Shirt generic 1.jpeg";
            dRow["Total"] = 0 + (1 * 100);

            dtOrder.Rows.Add(dRow);
            

            dRow = dtOrder.NewRow();
            dRow["GarmentID"] = 1002;
            dRow["GarmentName"] = "Trouser";
            dRow["Trim Amount"] = 0;
            dRow["Rate"] = 100;
            dRow["QTY"] = 2;
            dRow["Photo"] = @"C:\Tailoring Images\Generic\Trouser Generic 1.gif";
            dRow["Total"] = 0 + (2 * 100);

            dtOrder.Rows.Add(dRow);
            dtOrder.AcceptChanges();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //decimal trim = (txtTrimsAmount.Text.Length > 0 ? Convert.ToDecimal(txtTrimsAmount.Text) : 0);

            //DataRow dRow = dtOrder.NewRow();
            //dRow["GarmentID"] = cmbGarmentName.SelectedValue;
            //dRow["GarmentName"] = cmbGarmentName.Text;
            //dRow["Trim Amount"] = trim;
            //dRow["Rate"] = txtRate.Text;
            //dRow["QTY"] = NumericQTY.Value;
            //dRow["Total"] = trim + (NumericQTY.Value * Convert.ToDecimal(txtRate.Text));

            //dtOrder.Rows.Add(dRow);
            //dtOrder.AcceptChanges();

            AddDefaultRow();
            dataGridView1.DataSource = dtOrder;
            ClearAll();
        }

        private void CalcTotalAmount()
        {
            object total = dtOrder.Compute("SUM(Total)", string.Empty);
            txtTailoringAmount.Text = total.ToString();

            double advancepaid = txtAdvancePaid.Text.Length > 0 ? Convert.ToDouble(txtAdvancePaid.Text) : 0;
            txtAmtToBePaid.Text = (Convert.ToDouble(total) - advancepaid).ToString();
        }

        private void btnMeasurement_Click(object sender, EventArgs e)
        {
            if (ObjUtil.ValidateTable(dtOrder))
            {
                Order.frmMeasurement Obj = new Order.frmMeasurement();
                Obj.dtGarmentList = dtOrder;
                Obj.ShowDialog();
            }
            else
            {
                clsUtility.ShowInfoMessage("Please Enter some Garments");
                cmbGarmentName.Focus();
            }
        }

        private void txtAdvancePaid_TextChanged(object sender, EventArgs e)
        {
            if (txtAdvancePaid.Text.Length > 0)
            {
                double total = txtTailoringAmount.Text.Length > 0 ? Convert.ToDouble(txtTailoringAmount.Text) : 0;
                if (Convert.ToDouble(txtAdvancePaid.Text) > total)
                {
                    clsUtility.ShowInfoMessage("Advance payment can't be exceeded with Tailoring amount..");
                    txtAdvancePaid.Text = "0";
                    return;
                }
            }
            CalcTotalAmount();
        }

        private void ClearAll()
        {
            cmbGarmentName.SelectedIndex = -1;
            txtRate.Text = "0.00";
            NumericQTY.Value = 1;
            txtTrimsAmount.Text = "0";
            cmbGarmentName.Focus();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }
    }
}