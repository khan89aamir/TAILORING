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
                //dtGarmentList.Columns.Remove("");

                dtGarmentList.Columns.Add("Measurement");
                dtGarmentList.Columns.Add("Style");
                dataGridView1.DataSource = dtGarmentList;
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

        private void GetGarmentStyle(int GarmentID)
        {
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentStyle");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtStyle = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtStyle))
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < dtStyle.Rows.Count; i++)
                    {
                        listBox1.Items.Add(dtStyle.Rows[i]["StyleName"].ToString());
                    }
                }
                else
                {
                    listBox1.DataSource = null;
                }
            }
            else
            {
                listBox1.DataSource = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;

            GarmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GarmentID"].Value);
            if (headerText == "Measurement")
            {
                listBox1.Visible = false;
                flowLayoutPanel1.Visible = false;
                ctrlMeasurment1.Visible = true;
                ctrlMeasurment1.ProductCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);
                GetGarmentMasterMeasurement(GarmentID);
            }
            else if (headerText == "Style")
            {
                ctrlMeasurment1.Visible = false;
                flowLayoutPanel1.Visible = true;
                listBox1.Visible = true;
                listBox1.Location = new Point(41, 195);
                listBox1.Size = new Size(160, 361);

                GetGarmentStyle(GarmentID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dataGridView1);
            ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["GarmentCode"].Visible = false;
            dataGridView1.Columns["QTY"].Visible = false;
            dataGridView1.Columns["Rate"].Visible = false;
            dataGridView1.Columns["Total"].Visible = false;
            dataGridView1.Columns["Trim Amount"].Visible = false;
        }

        private void AddStyleImages()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dtStyleImages.Rows.Count; i++)
            {
                Panel panel = new Panel();
                PictureBox pic = new PictureBox();
                RadioButton rd = new RadioButton();

                rd.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                rd.Text = dtStyleImages.Rows[i]["ImageName"].ToString();
                rd.AutoSize = true;
                rd.BackColor = Color.Transparent;

                //rd.Size = new System.Drawing.Size(56, 21);
                rd.CheckedChanged += Rd_CheckedChanged;
                //rd.mouse
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString());
                pic.BorderStyle = BorderStyle.FixedSingle;

                rd.Location = new Point(pic.Location.X, pic.Location.Y + 55);
                
                panel.Controls.Add(pic);
                panel.Controls.Add(rd);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            label1.Text = rd.Name;
            label1.Text = rd.Checked+" "+ rd.Text;
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
                    flowLayoutPanel1.Controls.Clear();
                }
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow[] drow = dtStyle.Select("StyleName='" + listBox1.SelectedItem.ToString() + "'");
            if (drow.Length > 0)
            {
                GetGarmentStyleImages(GarmentID, Convert.ToInt32(drow[0]["StyleID"]));
            }
        }
    }
}