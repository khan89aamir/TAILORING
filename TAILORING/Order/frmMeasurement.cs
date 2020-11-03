﻿using System;
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

        Image Pending = TAILORING.Properties.Resources.bulet;
        Image Done = TAILORING.Properties.Resources.tick;

        public DataTable dtGarmentList = new DataTable();

        DataTable dtMasterMeasurement = null;
        DataTable dtStyle = new DataTable();
        DataTable dtStyleImages = new DataTable();

        DataTable dtTempMeasurement = new DataTable();
        DataTable dtTempStyle = new DataTable();

        ImageList imageList = new ImageList();

        int GarmentID = 0, StyleID = 0;

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            btnMeasureSave.BackgroundImage = B_Leave;
            btnStyleSave.BackgroundImage = B_Leave;

            InitTempdtMeasurement();
            InitTempdtStyle();

            if (ObjUtil.ValidateTable(dtGarmentList))
            {
                if (!dtGarmentList.Columns.Contains("Measurement"))
                {
                    dtGarmentList.Columns.Add("Measurement", typeof(Image));
                    dtGarmentList.Columns.Add("Style", typeof(Image));
                }
                dataGridView1.DataSource = dtGarmentList;

                SKUList.Items.Clear();
                for (int i = 0; i < dtGarmentList.Rows.Count; i++)
                {
                    Image img = Image.FromFile(dtGarmentList.Rows[i]["Photo"].ToString());

                    SKUList.Items.Add(dtGarmentList.Rows[i]["GarmentName"].ToString());

                    dataGridView1.Rows[i].Cells["Measurement"].Value = Pending;
                    dataGridView1.Rows[i].Cells["Style"].Value = Pending;

                    imageList.Images.Add(img);
                    //imageList.ImageSize = new Size(48, 56);
                    imageList.ImageSize = new Size(111, 96);
                    SKUList.View = System.Windows.Forms.View.LargeIcon;
                    SKUList.LargeImageList = imageList;

                    SKUList.Items[i].ImageIndex = i;
                }
                SKUList.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                SKUList.Items[0].Selected = true;
                GetDefaultSelectSKU();
            }
            else
            {
                dataGridView1.DataSource = null;
                ctrlMeasurment1.Visible = false;
            }
        }

        private void InitTempdtMeasurement()
        {
            dtTempMeasurement.Columns.Add("CustomerID", typeof(int));
            dtTempMeasurement.Columns.Add("GarmentID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementValue", typeof(int));
        }

        private void InitTempdtStyle()
        {
            dtTempStyle.Columns.Add("CustomerID", typeof(int));
            dtTempStyle.Columns.Add("GarmentID", typeof(int));
            dtTempStyle.Columns.Add("StyleID", typeof(int));
            dtTempStyle.Columns.Add("StyleImageID", typeof(int));
            dtTempStyle.Columns.Add("QTY", typeof(int));
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
                    DataTable dt = GetEnteredGarmentMeasurement(dtMeasurement);
                    ctrlMeasurment1.DataSource = dt;
                }
            }
        }

        private void AddGarmentStyleList()
        {
            for (int i = 0; i < dtStyle.Rows.Count; i++)
            {
                //Panel panel = new Panel();
                Button btn = new Button();
                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();
                btn.Cursor = Cursors.Hand;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Click += btnStyleName_Click;
                //panel.Cursor = Cursors.Hand;
                //panel.Click += Panel_Click;
                //panel.Controls.Add(btn);

                //flowStyleName.Controls.Add(panel);
                flowStyleName.Controls.Add(btn);
            }
        }

        private int GetSelectedStyleImage(int pGarmentID, int pStyleID)
        {
            int StyleImgID = 0;
            DataRow[] drow = dtTempStyle.Select("GarmentID=" + pGarmentID + " AND StyleID=" + pStyleID + " AND QTY=" + cmbStyleQTY.Text);
            if (drow.Length > 0)
            {
                StyleImgID = Convert.ToInt32(drow[0]["StyleImageID"].ToString());
            }
            return StyleImgID;
        }

        private void btnStyleName_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 2;
            //btn.BackgroundImage = B_Enter;
            StyleID = Convert.ToInt32(btn.Name);
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
            dataGridView1.Columns["Photo"].Visible = false;

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
                lbl.Location = new Point(pic.Location.X + 17, pic.Location.Y + 80);
                lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                panel.Size = new Size(160, 100);
                panel.Cursor = Cursors.Hand;

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString());
                pic.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                pic.Size = new Size(panel.Width - 40, panel.Height - 20);
                pic.Click += Pic_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);

                flowStyleImage.Controls.Add(panel);

                int a = GetSelectedStyleImage(GarmentID, StyleID);
                if (pic.Name == a.ToString())
                {
                    //pic.BackColor = Color.LightGray;
                    pic.Parent.BackColor = Color.LightGray;
                }
            }
        }

        private void AddTempdtStyle(PictureBox p)
        {
            if (ObjUtil.ValidateTable(dtTempStyle))
            {
                DataRow[] dr = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID<>" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempStyle.AcceptChanges();
                }
            }
            DataRow drow = dtTempStyle.NewRow();
            drow["CustomerID"] = 1;
            drow["GarmentID"] = GarmentID;
            drow["StyleID"] = StyleID;
            drow["StyleImageID"] = p.Name;
            drow["QTY"] = cmbStyleQTY.Text;

            dtTempStyle.Rows.Add(drow);
            dtTempStyle.AcceptChanges();
        }

        private DataTable GetEnteredGarmentMeasurement(DataTable dtMeasurement)
        {
            if (ObjUtil.ValidateTable(dtTempMeasurement))
            {
                DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
                if (dr.Length > 0)
                {
                    if (dtMeasurement.Rows.Count == 0)
                    {
                        DataRow drow = dtMeasurement.NewRow();
                        dtMeasurement.Rows.Add(drow);
                        dtMeasurement.AcceptChanges();
                    }
                    for (int i = 0; i < dtMeasurement.Columns.Count; i++)
                    {
                        dtMeasurement.Rows[0][i] = dr[i]["MeasurementValue"].ToString() == "0" ? "" : dr[i]["MeasurementValue"];
                    }
                }
            }
            return dtMeasurement;
        }

        private void CopyPreviousGarmentStyle()
        {
            int qty = Convert.ToInt32(cmbStyleQTY.Text);
            if (ObjUtil.ValidateTable(dtTempStyle))
            {
                DataRow[] dr = dtTempStyle.Select("GarmentID=" + GarmentID + " AND QTY=" + (qty - 1));
                for (int i = 0; i < dr.Length; i++)
                {
                    DataRow drow = dtTempStyle.NewRow();
                    drow["CustomerID"] = dr[i]["CustomerID"];
                    drow["GarmentID"] = dr[i]["GarmentID"];
                    drow["StyleID"] = dr[i]["StyleID"];
                    drow["StyleImageID"] = dr[i]["StyleImageID"];
                    drow["QTY"] = cmbStyleQTY.Text;

                    dtTempStyle.Rows.Add(drow);
                }
            }
            else
            {
                clsUtility.ShowInfoMessage("There is no Data to copy.");
                checkBox1.Checked = false;
            }
        }

        private void ClearSyleImageSelection()
        {
            Control[] ctrl = flowStyleImage.Controls.Find("pnl", false);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            ClearSyleImageSelection();

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;

            AddTempdtStyle(p);
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
            //SaveddtMeasurement(); // Auto Saved Garment Measurement value

            lblSKUName.Text = "SKU Selected : " + SKUList.SelectedItems[0].Text.ToString();
            DataRow[] drow = dtGarmentList.Select("GarmentName='" + SKUList.SelectedItems[0].Text + "'");
            if (drow.Length > 0)
            {
                flowStyleImage.Controls.Clear();
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
                int QTY = Convert.ToInt32(drow[0]["QTY"]);

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                GetGarmentStyle(GarmentID);// Garment Style
                AddStyleQTY(QTY);
                checkBox1.Enabled = false;
            }
        }

        private void AddStyleQTY(int QTY)
        {
            cmbStyleQTY.Items.Clear();
            for (int i = 1; i <= QTY; i++)
            {
                cmbStyleQTY.Items.Add(i);
            }
            cmbStyleQTY.SelectedIndex = 0;
        }

        private void GetDefaultSelectSKU()
        {
            lblSKUName.Text = "SKU Selected : " + SKUList.Items[0].Text;
            DataRow[] drow = dtGarmentList.Select("GarmentName='" + SKUList.Items[0].Text + "'");
            if (drow.Length > 0)
            {
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
                int QTY = Convert.ToInt32(drow[0]["QTY"]);

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                GetGarmentStyle(GarmentID);// Garment Style
                AddStyleQTY(QTY);
                checkBox1.Enabled = false;
            }
        }

        private void btnMeasureSave_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnMeasureSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void ResetdtMeasurement()
        {
            if (ObjUtil.ValidateTable(dtTempMeasurement))
            {
                DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempMeasurement.AcceptChanges();
                }
            }
        }

        private void btnMeasureSave_Click(object sender, EventArgs e)
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt1 = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt1))
                {
                    ResetdtMeasurement();
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        DataRow drow = dtTempMeasurement.NewRow();
                        drow["MeasurementID"] = dtMasterMeasurement.Rows[i]["MeasurementID"];
                        drow["MeasurementValue"] = dt1.Rows[0][i].ToString() == "" ? 0 : dt1.Rows[0][i];
                        drow["GarmentID"] = GarmentID;
                        drow["CustomerID"] = 1;
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Please Enter Measurement for Garment.");
                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CopyPreviousGarmentStyle();
            }
        }

        private void cmbStyleQTY_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbStyleQTY.SelectedItem) > 1)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            flowStyleImage.Controls.Clear();
        }

        private void lnkAddItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBodyPosture obj = new frmBodyPosture();
            obj.ShowDialog();
        }

        private void SaveddtMeasurement()
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt1 = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt1))
                {
                    ResetdtMeasurement();
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        DataRow drow = dtTempMeasurement.NewRow();
                        drow["MeasurementID"] = dtMasterMeasurement.Rows[i]["MeasurementID"];
                        drow["MeasurementValue"] = dt1.Rows[0][i].ToString() == "" ? 0 : dt1.Rows[0][i];
                        drow["GarmentID"] = GarmentID;
                        drow["CustomerID"] = 1;
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();
                }
            }
        }
    }
}