using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmMeasurement : Form
    {
        public frmMeasurement()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        public DataTable dtGarmentList = new DataTable();

        DataTable dtMasterMeasurement = null;
        DataTable dtStyle = new DataTable();
        DataTable dtStyleImages = new DataTable();

        int GarmentID = 0;

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            if (ObjUtil.ValidateTable(dtGarmentList))
            {
                if (!dtGarmentList.Columns.Contains("Measurement"))
                {
                    dtGarmentList.Columns.Add("Measurement");
                    dtGarmentList.Columns.Add("Style");
                }
                dataGridView1.DataSource = dtGarmentList;

                SKUList.Items.Clear();
                for (int i = 0; i < dtGarmentList.Rows.Count; i++)
                {
                    SKUList.Items.Add(dtGarmentList.Rows[i]["GarmentName"].ToString());

                    dataGridView1.Columns["Measurement"].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Columns["Style"].DefaultCellStyle.BackColor = Color.Red;
                }
                SKUList.Items[0].Selected = true;
                GetDefaultSelectSKU();
            }
            else
            {
                dataGridView1.DataSource = null;
                ctrlMeasurment1.Visible = false;
            }
        }

        private void GetGarmentMasterMeasurement(int GarmentID)
        {
            DataTable dtMeasurement = new DataTable();
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentMeasurement");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtMasterMeasurement = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtMasterMeasurement))
                {
                    List<string> lstMendatory = new List<string>();
                    for (int i = 0; i < dtMasterMeasurement.Rows.Count; i++)
                    {
                        dtMeasurement.Columns.Add(dtMasterMeasurement.Rows[i]["MeasurementName"].ToString());
                        if (Convert.ToInt32(dtMasterMeasurement.Rows[i]["IsMandatory"]) == 0)
                            continue;

                        lstMendatory.Add(dtMasterMeasurement.Rows[i]["MeasurementName"].ToString());
                    }
                    ctrlMeasurment1.SetMendatoryList(lstMendatory);

                    ctrlMeasurment1.DataSource = dtMeasurement;
                }
            }
        }

        private void AddGarmentStyleList()
        {
            for (int i = 0; i < dtStyle.Rows.Count; i++)
            {
                //Panel panel = new Panel();
                Button btn = new Button();
                //btn.Name = "btn";
                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();

                btn.Click += StyleName_Click;
                //panel.Cursor = Cursors.Hand;
                //panel.Click += Panel_Click;
                //panel.Controls.Add(btn);

                //flowStyleName.Controls.Add(panel);
                flowStyleName.Controls.Add(btn);
            }
        }

        private void StyleName_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int StyleID = Convert.ToInt32(btn.Name);
            GetGarmentStyleImages(GarmentID, StyleID);
        }

        private void GetGarmentStyle(int GarmentID)
        {
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentStyle");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtStyle = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtStyle))
                {
                    flowStyleName.Controls.Clear();
                    AddGarmentStyleList();
                }
                else
                {
                    flowStyleName.Controls.Clear();
                }
            }
            else
            {
                //listBox1.DataSource = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["GarmentCode"].Visible = false;
            dataGridView1.Columns["QTY"].Visible = false;
            dataGridView1.Columns["Rate"].Visible = false;
            dataGridView1.Columns["Total"].Visible = false;
            dataGridView1.Columns["Trim Amount"].Visible = false;

            dataGridView1.ClearSelection();
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Transparent;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void AddStyleImages()
        {
            flowStyleImage.Controls.Clear();
            for (int i = 0; i < dtStyleImages.Rows.Count; i++)
            {
                Panel panel = new Panel();
                PictureBox pic = new PictureBox();
                Label lbl = new Label();
                panel.Name = "pnl";

                lbl.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                lbl.Text = dtStyleImages.Rows[i]["ImageName"].ToString();
                lbl.AutoSize = true;
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(pic.Location.X, pic.Location.Y + 55);

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString());
                pic.Click += Pic_Click;
                pic.BorderStyle = BorderStyle.FixedSingle;

                panel.Cursor = Cursors.Hand;
                panel.Click += Panel_Click;
                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);

                flowStyleImage.Controls.Add(panel);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Control[] ctrl = flowStyleImage.Controls.Find("pnl", false);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;

        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Control[] ctrl = flowStyleImage.Controls.Find("pnl", false);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }

            Panel p = (Panel)sender;
            p.BackColor = Color.LightGray;
        }

        private void GetGarmentStyleImages(int GarmentID, int StyleID)
        {
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("StyleID", SqlDbType.Int, StyleID, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentStyle_Images");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtStyleImages = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtStyleImages))
                {
                    AddStyleImages();
                }
                else
                {
                    flowStyleImage.Controls.Clear();
                }
            }
        }

        private void SKUList_MouseClick(object sender, MouseEventArgs e)
        {
            lblSKUName.Text = "SKU Selected : " + SKUList.SelectedItems[0].Text.ToString();
            DataRow[] drow = dtGarmentList.Select("GarmentName='" + SKUList.SelectedItems[0].Text + "'");
            if (drow.Length > 0)
            {
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                GetGarmentStyle(GarmentID);// Garment Style
            }
        }

        private void GetDefaultSelectSKU()
        {
            lblSKUName.Text = "SKU Selected : " + SKUList.Items[0].Text;
            DataRow[] drow = dtGarmentList.Select("GarmentName='" + SKUList.Items[0].Text + "'");
            if (drow.Length > 0)
            {
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                GetGarmentStyle(GarmentID);// Garment Style
            }
        }
    }
}