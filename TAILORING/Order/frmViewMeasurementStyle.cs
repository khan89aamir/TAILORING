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
    public partial class frmViewMeasurementStyle : Form
    {
        public frmViewMeasurementStyle()
        {
            InitializeComponent();
        }
        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataSet dsMeasure = new DataSet();

        DataTable dtGarmentList = new DataTable();
        DataTable dtMasterMeasurement = null;
        DataTable dtStyle = new DataTable();
        DataTable dtStyleImages = new DataTable();

        DataTable dtTempMeasurement = new DataTable();
        DataTable dtTempStyle = new DataTable();
        DataTable dtTempPosture = new DataTable();

        Image B_Leave = TAILORING.Properties.Resources.B_click;
        Image B_Enter = TAILORING.Properties.Resources.B_on;

        Image Pending = TAILORING.Properties.Resources.bulet;
        Image Done = TAILORING.Properties.Resources.tick;

        public bool IsEdit = false;
        public int pOrderID = 0;
        public string OrderNo = "NA";
        int GarmentID = 0, StyleID = 0;

        private void frmViewMeasurementStyle_Load(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = B_Leave;
            btnCancel.BackgroundImage = B_Leave;
            lblOrderNo.Text = "Order No : " + OrderNo;

            IsAdmin();

            if (!ObjUtil.ValidateDataSet(dsMeasure))
            {
                dsMeasure.Tables.Add(dtGarmentList);
                dsMeasure.Tables[0].TableName = "Garment";

                dsMeasure.Tables.Add(dtTempMeasurement);
                dsMeasure.Tables[1].TableName = "Measurement";

                dsMeasure.Tables.Add(dtTempStyle);
                dsMeasure.Tables[2].TableName = "Style";

                dsMeasure.Tables.Add(dtTempPosture);
                dsMeasure.Tables[3].TableName = "BodyPosture";
            }
            GetGarmentData();

            BindStichType(); //Bind Stich Type
            BindFitType(); //Bind Fit Type
            GetStichFitType(); // Selected Stich AND Fit Type
            ChangeMeasurementStyleStatus();
        }

        private void IsAdmin()
        {
            if (clsUtility.IsAdmin || clsFormRights.HasFormRight(clsFormRights.Forms.frmViewMeasurementStyle, clsFormRights.Operation.Update))
            {
                flowStyleImage.Enabled = true;
                btnSave.Enabled = true;
                IsEdit = true;
            }
            else
            {
                flowStyleImage.Enabled = false;
                btnSave.Enabled = false;
                IsEdit = false;
                //clsUtility.ShowInfoMessage("You have no rights to perform this task");
            }
        }

        private void GetGarmentData()
        {
            ObjDAL.SetStoreProcedureData("OrderID", SqlDbType.Int, pOrderID, clsConnection_DAL.ParamType.Input);
            dsMeasure = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentMeasurementStyle");
            if (ObjUtil.ValidateDataSet(dsMeasure))
            {
                dtGarmentList = dsMeasure.Tables[0];
                if (ObjUtil.ValidateTable(dtGarmentList))
                {
                    if (!dtGarmentList.Columns.Contains("Measurement"))
                    {
                        dtGarmentList.Columns.Add("Measurement", typeof(Image));
                        dtGarmentList.Columns.Add("Style", typeof(Image));
                    }
                    dataGridView1.DataSource = dtGarmentList;
                    dtTempStyle = dsMeasure.Tables[1];
                    dtTempPosture = dsMeasure.Tables[2];

                    AddGarments();
                }
            }
        }

        private void AddGarments()
        {
            flowGarmentList.Controls.Clear();
            for (int i = 0; i < dtGarmentList.Rows.Count; i++)
            {
                //Panel panel = new Panel();
                FlowLayoutPanel panel = new FlowLayoutPanel();

                PictureBox pic = new PictureBox();
                Label lbl = new Label();

                panel.Name = "pnl";
                panel.Size = new Size(120, 200);
                panel.Cursor = Cursors.Hand;

                lbl.Name = dtGarmentList.Rows[i]["GarmentID"].ToString();
                lbl.Text = dtGarmentList.Rows[i]["GarmentName"].ToString();
                //lbl.AutoSize = true;
                //lbl.Location = new Point(pic.Location.X, pic.Size.Height+20);
                lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);
                lbl.TextAlign = ContentAlignment.TopCenter;

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                if (System.IO.File.Exists(dtGarmentList.Rows[i]["Photo"].ToString()))
                {
                    pic.Image = Image.FromFile(dtGarmentList.Rows[i]["Photo"].ToString());
                }
                else
                {
                    pic.Image = TAILORING.Properties.Resources.NoImage;
                }
                pic.Name = dtGarmentList.Rows[i]["GarmentID"].ToString();
                pic.Size = new Size(panel.Size.Width-10, panel.Size.Height - 20);
                pic.Click += Pic_GarmentList_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);
                flowGarmentList.Controls.Add(panel);

                GetDefaultSelectSKU();

                int a = GetSelectedStyleImage(GarmentID, StyleID);
                if (pic.Name == a.ToString())
                {
                    pic.Parent.BackColor = Color.LightGray;
                }
            }
        }

        private void Pic_GarmentList_Click(object sender, EventArgs e)
        {
            ClearGarmentSelection();

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;

            GetSelectedSKU(p);
        }

        private void GetSelectedSKU(PictureBox p)
        {
            DataRow[] drow = dtGarmentList.Select("GarmentID=" + p.Name);
            if (drow.Length > 0)
            {
                lblSKUName.Text = "SKU Selected : " + drow[0]["GarmentName"];
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
                int QTY = Convert.ToInt32(drow[0]["QTY"]);

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                AddStyleQTY(QTY);

                GetGarmentStyle(GarmentID);// Garment Style

                checkBox1.Enabled = false;
            }
        }

        private void GetDefaultSelectSKU()
        {
            Control[] ctrl = flowGarmentList.Controls.Find("pnl", true);
            if (ctrl.Length > 0)
            {
                ctrl[0].BackColor = Color.LightGray;
                lblSKUName.Text = "SKU Selected : " + ctrl[0].Controls[1].Text;
                DataRow[] drow = dtGarmentList.Select("GarmentName='" + ctrl[0].Controls[1].Text + "'");
                if (drow.Length > 0)
                {
                    GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
                    int QTY = Convert.ToInt32(drow[0]["QTY"]);

                    ctrlMeasurment1.ProductCount = 1;
                    GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                    AddStyleQTY(QTY);

                    GetGarmentStyle(GarmentID);// Garment Style

                    checkBox1.Enabled = false;
                }
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
                    ctrlMeasurment1.IsEditable = IsEdit;
                    ctrlMeasurment1.SetMendatoryList(lstMendatory);
                    DataTable dt = GetEnteredGarmentMeasurement(dtMeasurement);
                    ctrlMeasurment1.DataSource = dt;
                }
            }
        }

        private DataTable GetEnteredGarmentMeasurement(DataTable dtMeasurement)
        {
            ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, pOrderID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Show", SqlDbType.Int, -1, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_MeasurementValue_Report");
            if (ObjUtil.ValidateDataSet(ds))
            {
                //dtMeasurement = ds.Tables[0];
                dtTempMeasurement = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtTempMeasurement))
                {
                    dtTempMeasurement.Rows[0].Delete();
                    dtTempMeasurement.AcceptChanges();
                }
            }
            return dtTempMeasurement;
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

        private void AddGarmentStyleList()
        {
            for (int i = 0; i < dtStyle.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();
                btn.Cursor = Cursors.Hand;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.AutoSize = true;
                btn.Click += btnStyleName_Click;

                int a = GetSelectedStyleImage(GarmentID, Convert.ToInt32(btn.Name));
                if (a > 0)
                    btn.BackColor = Color.FromArgb(17, 241, 41);
                else
                    btn.BackColor = Color.LightGray;

                flowStyleName.Controls.Add(btn);
            }
        }

        private void btnStyleName_Click(object sender, EventArgs e)
        {
            ClearSyleNameSelection();

            Button btn = (Button)sender;

            if (btn.BackColor != Color.FromArgb(17, 241, 41))
                btn.BackColor = Color.FromArgb(0, 191, 255);

            StyleID = Convert.ToInt32(btn.Name);
            GetGarmentStyleImages(GarmentID, StyleID);
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

        private int GetSelectedStyleImage(int pGarmentID, int pStyleID)
        {
            int StyleImgID = 0;
            if (ObjUtil.ValidateTable(dtTempStyle))
            {
                DataRow[] drow = dtTempStyle.Select("GarmentID=" + pGarmentID + " AND StyleID=" + pStyleID + " AND QTY=" + cmbStyleQTY.Text);
                if (drow.Length > 0)
                {
                    StyleImgID = Convert.ToInt32(drow[0]["StyleImageID"].ToString());
                }
            }
            return StyleImgID;
        }

        private void AddStyleImages()
        {
            flowStyleImage.Controls.Clear();
            for (int i = 0; i < dtStyleImages.Rows.Count; i++)
            {
                Panel panel = new Panel();
                PictureBox pic = new PictureBox();
                //Label lbl = new Label();
                panel.Name = "pnl";

                //lbl.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                //lbl.Text = dtStyleImages.Rows[i]["ImageName"].ToString();
                //lbl.AutoSize = true;
                //lbl.BackColor = Color.Transparent;
                //lbl.Location = new Point(pic.Location.X + 17, pic.Location.Y + 80);
                //lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                panel.Size = new Size(140, 130);
                panel.Cursor = Cursors.Hand;

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                if (System.IO.File.Exists(dtStyleImages.Rows[i]["ImagePath"].ToString()))
                {
                    pic.Image = Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString());
                }
                else
                {
                    pic.Image = TAILORING.Properties.Resources.NoImage;
                }
                pic.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                pic.Size = new Size(panel.Width - 5, panel.Height - 5);
                pic.Click += Pic_StyleImg_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                //panel.Controls.Add(lbl);

                flowStyleImage.Controls.Add(panel);

                int a = GetSelectedStyleImage(GarmentID, StyleID);
                if (pic.Name == a.ToString())
                {
                    pic.Parent.BackColor = Color.LightGray;
                }
            }
        }

        private void Pic_StyleImg_Click(object sender, EventArgs e)
        {
            ClearSyleImageSelection();

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;

            AddTempdtStyle(p);
            Control[] ctr = flowStyleName.Controls.Find(StyleID.ToString(), false);
            for (int i = 0; i < ctr.Length; i++)
            {
                ctr[i].BackColor = Color.FromArgb(17, 241, 41);
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
                DataRow drow = dtTempStyle.NewRow();
                drow["GarmentID"] = GarmentID;
                drow["StyleID"] = StyleID;
                drow["StyleImageID"] = p.Name;
                drow["QTY"] = cmbStyleQTY.Text;

                dtTempStyle.Rows.Add(drow);
            }
            dtTempStyle.AcceptChanges();
        }

        private void ClearSyleNameSelection()
        {
            for (int i = 0; i < flowStyleName.Controls.Count; i++)
            {
                if (flowStyleName.Controls[i].BackColor != Color.FromArgb(17, 241, 41))// Green
                {
                    //flowStyleName.Controls[i].BackColor = Color.FromArgb(0, 191, 255);
                    flowStyleName.Controls[i].BackColor = Color.LightGray;
                }
            }
        }

        private void ClearGarmentSelection()
        {
            flowStyleImage.Controls.Clear();
            Control[] ctrl = flowGarmentList.Controls.Find("pnl", true);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }
        }

        private void BindStichType()
        {
            //ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_StichType");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    cmbStichType.DataSource = dt;
                    cmbStichType.DisplayMember = "StichTypeName";
                    cmbStichType.ValueMember = "StichTypeID";
                }
                else
                {
                    cmbStichType.DataSource = null;
                }
                cmbStichType.SelectedIndex = -1;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["GarmentName"].HeaderText = "Garment";
            //dataGridView1.Columns["TrailDate"].Visible = false;
            //dataGridView1.Columns["DeliveryDate"].Visible = false;
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["QTY"].Visible = false;
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["StichTypeID"].Visible = false;
            dataGridView1.Columns["FitTypeID"].Visible = false;

            dataGridView1.ClearSelection();
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Transparent;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void BindFitType()
        {
            //ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_FitType");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    cmbFitType.DataSource = dt;
                    cmbFitType.DisplayMember = "FitTypeName";
                    cmbFitType.ValueMember = "FitTypeID";
                }
                else
                {
                    cmbFitType.DataSource = null;
                }
                cmbFitType.SelectedIndex = -1;
            }
        }

        private void GetStichFitType()
        {
            if (ObjUtil.ValidateTable(dtGarmentList))
            {
                DataRow[] drow = dtGarmentList.Select("GarmentID=" + GarmentID);
                if (drow.Length > 0)
                {
                    if (drow[0]["StichTypeID"] != DBNull.Value)
                    {
                        cmbStichType.SelectedValue = drow[0]["StichTypeID"];
                    }
                    else
                    {
                        cmbStichType.SelectedIndex = -1;
                    }
                    if (drow[0]["FitTypeID"] != DBNull.Value)
                    {
                        cmbFitType.SelectedValue = drow[0]["FitTypeID"];
                    }
                    else
                    {
                        cmbFitType.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                cmbStichType.SelectedIndex = -1;
                cmbFitType.SelectedIndex = -1;
            }
        }

        private void lnkAddItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBodyPosture obj = new frmBodyPosture();
            obj.GarmentID = this.GarmentID;
            obj.dtTempPosture = this.dtTempPosture;
            obj.ShowDialog();
        }

        private void cmbStyleQTY_SelectionChangeCommitted(object sender, EventArgs e)
        {
            flowStyleImage.Controls.Clear();
            GetGarmentStyle(GarmentID);// Garment Style
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            //Update Code
        }

        private void ChangeMeasurementStyleStatus()//char ps, int garmentid
        {
            for (int i = 0; i < dtGarmentList.Rows.Count; i++)
            {
                dtGarmentList.Rows[i]["Style"] = Done;
                dtGarmentList.Rows[i]["Measurement"] = Done;
            }
            dtGarmentList.AcceptChanges();
        }
    }
}