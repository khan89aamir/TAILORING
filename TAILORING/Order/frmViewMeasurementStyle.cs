using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmViewMeasurementStyle : KryptonForm
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
        DataTable dtPosture = new DataTable();

        DataTable dtTempMeasurement = new DataTable();
        DataTable dtTempStyle = new DataTable();
        DataTable dtTempPosture = new DataTable();

        public bool IsEdit = false;
        public int pOrderID = 0;
        public string OrderNo = "NA";
        int GarmentID = 0, StyleID = 0;

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

        private void frmViewMeasurementStyle_Load(object sender, EventArgs e)
        {
            lblOrderNo.Text = "Order No : " + OrderNo;

            IsAdmin();

            LoadTailoringTheme();

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
                pic.Size = new Size(panel.Size.Width - 10, panel.Size.Height - 20);
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
            if (picBody.Visible)
            {
                GetBodyPostureDetails();
            }
        }

        private void GetSelectedSKU(PictureBox p)
        {
            SaveddtMeasurement(); // Auto Saved Garment Measurement value
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

        private void SaveddtMeasurement()
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt1 = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt1))
                {
                    ResetdtMeasurement();
                    //for (int i = 0; i < dt1.Columns.Count; i++)
                    //{
                    //    DataRow drow = dtTempMeasurement.NewRow();
                    //    drow["MeasurementID"] = dtMasterMeasurement.Rows[i]["MeasurementID"];
                    //    drow["MeasurementValue"] = dt1.Rows[0][i].ToString() == "" ? 0 : dt1.Rows[0][i];
                    //    drow["GarmentID"] = GarmentID;
                    //    dtTempMeasurement.Rows.Add(drow);
                    //}
                    dtTempMeasurement.AcceptChanges();

                    ChangeMeasurementStyleStatus('M', GarmentID);
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

        #region Garment Style Code
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
                KryptonButton btn = new KryptonButton();
                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();
                btn.Cursor = Cursors.Hand;
                // for flat style
                btn.PaletteMode = PaletteMode.Office2010Blue;
                // add round corner
                btn.StateCommon.Border.Rounding = 5;

                btn.StateCommon.Content.ShortText.Color1 = Color.Black;
                btn.StateCommon.Content.ShortText.Color2 = Color.Black;

                btn.AutoSize = false;
                btn.Size = new Size(187, 45);
                btn.Click += btnStyleName_Click;
                btn.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 12.3f, FontStyle.Bold);
                int a = GetSelectedStyleImage(GarmentID, Convert.ToInt32(btn.Name));
                if (a > 0)
                {
                    btn.StateCommon.Back.Color1 = Color.FromArgb(78, 148, 132);//17, 
                    btn.StateCommon.Back.Color2 = Color.FromArgb(78, 148, 132);

                    btn.OverrideFocus.Back.Color1 = Color.FromArgb(78, 148, 132);//17, 
                    btn.OverrideFocus.Back.Color2 = Color.FromArgb(78, 148, 132);

                    btn.OverrideDefault.Back.Color1 = Color.FromArgb(78, 148, 132);//17, 
                    btn.OverrideDefault.Back.Color2 = Color.FromArgb(78, 148, 132);

                    //btn.StateCommon.Content.ShortText.Color1 = Color.White;
                }
                else
                {
                    btn.StateCommon.Back.Color1 = Color.LightGray;
                    btn.StateCommon.Back.Color2 = Color.LightGray;
                }

                flowStyleName.Controls.Add(btn);
            }
        }

        private void btnStyleName_Click(object sender, EventArgs e)
        {
            ClearSyleNameSelection();

            KryptonButton btn = (KryptonButton)sender;

            if (btn.StateCommon.Back.Color1 != Color.FromArgb(78, 148, 132))
            {
                //btn.StateCommon.Content.ShortText.Color1 = Color.Black;

                btn.StateCommon.Back.Color1 = Color.FromArgb(0, 191, 255);
                btn.StateCommon.Back.Color2 = Color.FromArgb(0, 191, 255);

                btn.OverrideFocus.Back.Color1 = Color.FromArgb(0, 191, 255);
                btn.OverrideFocus.Back.Color2 = Color.FromArgb(0, 191, 255);

                btn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 191, 255);
                btn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 191, 255);
            }

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

                panel.Size = new Size(175, 160);
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
                //ctr[i].BackColor = Color.FromArgb(17, 241, 41);
                KryptonButton btn = (KryptonButton)ctr[i];
                if (p.Parent.BackColor != Color.Transparent)
                {
                    //ctr[i].BackColor = Color.FromArgb(17, 241, 41);
                    btn.StateCommon.Back.Color1 = Color.FromArgb(78, 148, 132);
                    btn.StateCommon.Back.Color2 = Color.FromArgb(78, 148, 132);
                }
                else
                {
                    btn.StateCommon.Back.Color1 = Color.LightGray;
                    btn.StateCommon.Back.Color2 = Color.LightGray;
                }
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
                DataRow[] drdup = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID=" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                if (drdup.Length > 0)
                {
                    p.Parent.BackColor = Color.Transparent;
                    drdup[0].Delete();
                    dtTempStyle.AcceptChanges();
                    return;
                }// above added

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
                KryptonButton btn = (KryptonButton)flowStyleName.Controls[i];
                if (btn.StateCommon.Back.Color1 != Color.FromArgb(78, 148, 132))// Dark Green
                {
                    //flowStyleName.Controls[i].BackColor = Color.FromArgb(0, 191, 255);

                    btn.StateCommon.Back.Color1 = Color.LightGray;
                    btn.StateCommon.Back.Color2 = Color.LightGray;
                }
            }
        }

        #endregion

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void PrintOrder()
        {
            Report.Forms.frmBill Obj = new Report.Forms.frmBill();
            Obj.OrderID = pOrderID.ToString();
            Obj.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateGarmentStyle())
            {
                //PrintOrder();
                //this.Close();
                //Update Code
            }
        }

        private void btnBodyPosture_Click(object sender, EventArgs e)
        {
            picBody.Visible = true;
            picMeasure.Visible = false;
            picStyle.Visible = false;
            tabControl1.SelectedIndex = 0;
            GetBodyPostureDetails();
        }

        private void btnMeasurment_Click(object sender, EventArgs e)
        {
            picBody.Visible = false;
            picMeasure.Visible = true;
            picStyle.Visible = false;
            tabControl1.SelectedIndex = 1;
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            picBody.Visible = false;
            picMeasure.Visible = false;
            picStyle.Visible = true;
            tabControl1.SelectedIndex = 2;
        }

        private void ChangeMeasurementStyleStatus()//char ps, int garmentid
        {
            btnStyle.Image = Properties.Resources.StyleCheck;
            btnMeasurment.Image = Properties.Resources.measurcheck;
            btnBodyPosture.Image = Properties.Resources.bodyCheck;
            //for (int i = 0; i < dtGarmentList.Rows.Count; i++)
            //{
            //    dtGarmentList.Rows[i]["Style"] = Done;
            //    dtGarmentList.Rows[i]["Measurement"] = Done;
            //}
            dtGarmentList.AcceptChanges();
        }

        #region Body Posture Code

        private void GetBodyPostureDetails()
        {
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_BodyPosture_ByGarmentID");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    if (ds.Tables.Count > 1)
                    {
                        dtPosture = ds.Tables[1];
                    }
                    BindBodyPostures(dt, dtPosture);
                }
            }
        }

        private void BindBodyPostures(DataTable dt, DataTable dt1)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GroupBox grp = new GroupBox();
                FlowLayoutPanel pnlContainer = new FlowLayoutPanel();

                grp.Name = "grp";
                grp.Size = new Size(kryptonHeaderGroup4.Size.Width - 60, 185);
                grp.Text = dt.Rows[i]["BodyPostureType"].ToString();
                grp.Font = new Font("Times", 11.1f, FontStyle.Bold);

                pnlContainer.BorderStyle = BorderStyle.FixedSingle;
                pnlContainer.AutoScroll = true;
                pnlContainer.Size = new Size(grp.Size.Width - 30, 155);
                pnlContainer.Location = new Point(grp.Location.X + 13, grp.Location.Y + 22);
                //pnlContainer.BackColor = Color.Blue;

                grp.Controls.Add(pnlContainer);

                //grp.BackColor = Color.Purple;
                DataRow[] dr = dt1.Select("BodyPostureID=" + dt.Rows[i]["BodyPostureID"]);
                if (dr.Length > 0)
                {
                    for (int j = 0; j < dr.Length; j++)
                    {
                        Panel panel = new Panel();
                        PictureBox pic = new PictureBox();
                        Label lbl = new Label();
                        panel.Name = "pnl";

                        lbl.Name = dr[j]["BodyPostureMappingID"].ToString();
                        lbl.Text = dr[j]["BodyPostureName"].ToString();
                        lbl.AutoSize = true;
                        lbl.BackColor = Color.Transparent;
                        lbl.Location = new Point(pic.Location.X + 22, pic.Location.Y + 85);
                        lbl.Font = new Font("Times New Roman", 11.4f, FontStyle.Bold);

                        panel.Size = new Size(180, 145);
                        panel.Cursor = Cursors.Hand;
                        //panel.BackColor = Color.Red;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Click += PicBody_Click;
                        if (File.Exists(dr[j]["Photo"].ToString()))
                        {
                            pic.Image = Image.FromFile(dr[j]["Photo"].ToString());
                        }
                        else
                        {
                            pic.Image = TAILORING.Properties.Resources.NoImage;
                        }
                        pic.Name = dr[j]["BodyPostureMappingID"].ToString();
                        pic.Size = new Size(panel.Width - 30, panel.Height - 10);
                        pic.Location = new Point(pic.Location.X, pic.Location.Y + 5);
                        pic.BorderStyle = BorderStyle.None;

                        panel.Controls.Add(pic);
                        panel.Controls.Add(lbl);

                        pnlContainer.Controls.Add(panel);

                        bool b = GetSelectedPostureImage(Convert.ToInt32(pic.Name));
                        if (b)
                        {
                            pic.Parent.BackColor = Color.LightGray;
                        }
                    }
                }
                flowLayoutPanel1.Controls.Add(grp);
            }
        }

        private bool GetSelectedPostureImage(int pBodyPostureMappingID)
        {
            bool b = false;
            if (ObjUtil.ValidateTable(dtTempPosture))
            {
                DataRow[] dr = dtTempPosture.Select("BodyPostureMappingID=" + pBodyPostureMappingID);
                if (dr.Length > 0)
                {
                    b = true;
                }
            }
            return b;
        }

        private void ClearBodyPostureImgSelection(Control flowctrl)
        {
            Control[] ctrl = flowctrl.Controls.Find("pnl", true);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }
        }

        private void PicBody_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            ClearBodyPostureImgSelection(p.Parent.Parent);

            p.Parent.BackColor = Color.LightGray;
            AddTempdtPosture(p);

            // after work done.. mark the menu as done.
            btnBodyPosture.Image = Properties.Resources.bodyCheck;
        }

        private void AddTempdtPosture(PictureBox p)
        {
            int BodyPostureID = 0;
            if (ObjUtil.ValidateTable(dtPosture))
            {
                DataRow[] dr = dtPosture.Select("BodyPostureMappingID=" + p.Name);
                if (dr.Length > 0)
                {
                    BodyPostureID = Convert.ToInt32(dr[0]["BodyPostureID"]);
                }
            }

            if (ObjUtil.ValidateTable(dtTempPosture))
            {
                DataRow[] dr = dtTempPosture.Select("BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID<>" + p.Name);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempPosture.AcceptChanges();
                }
            }
            DataRow drow = dtTempPosture.NewRow();
            drow["BodyPostureMappingID"] = p.Name;
            drow["BodyPostureID"] = BodyPostureID;
            drow["GarmentID"] = GarmentID;

            dtTempPosture.Rows.Add(drow);
            dtTempPosture.AcceptChanges();
        }

        #endregion

        private bool ValidateGarmentStyle()
        {
            bool b = false;
            DataSet ds = ctrlMeasurment1.GetMeasurement();
            if (!ObjUtil.ValidateDataSet(ds))
            { }
            else if (ObjUtil.ValidateDataSet(ds))
            {
                SaveMeasurement();
                DataTable dt = dtTempMeasurement.DefaultView.ToTable(true, "GarmentID");
                if (dt.Rows.Count != dtGarmentList.Rows.Count)
                {
                    clsUtility.ShowInfoMessage("Please Fill All Garments Measurement..");
                }
                else if (ObjUtil.IsControlTextEmpty(cmbStichType))
                {
                    clsUtility.ShowInfoMessage("Please Select StichType..");
                    cmbStichType.Focus();
                }
                else if (ObjUtil.IsControlTextEmpty(cmbFitType))
                {
                    clsUtility.ShowInfoMessage("Please Select FitType..");
                    cmbFitType.Focus();
                }
                else if (!ObjUtil.ValidateTable(dtTempStyle))
                {
                    clsUtility.ShowInfoMessage("Please Select Styles for Garments..");
                }
                else if (ObjUtil.ValidateTable(dtTempStyle))
                {
                    for (int i = 0; i < dtGarmentList.Rows.Count; i++)
                    {
                        int pQTY = 0;
                        pQTY = Convert.ToInt32(dtGarmentList.Rows[i]["QTY"]);
                        for (int j = 1; j <= pQTY; j++)
                        {
                            DataRow[] drow = dtTempStyle.Select("GarmentID=" + dtGarmentList.Rows[i]["GarmentID"] + " AND QTY=" + j);
                            if (drow.Length == 0)
                            {
                                b = false;
                                clsUtility.ShowInfoMessage("Please Select Style for All QTY");
                                return b;
                                //break;
                            }
                            else
                            {
                                b = true;
                            }
                        }
                    }
                }
            }
            return b;
        }

        private void SaveMeasurement()
        {
            DataSet ds = ctrlMeasurment1.GetMeasurement();
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt1 = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt1))
                {
                    ResetdtMeasurement(); // Delete row if same Garment measurement is already exists.
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        DataRow drow = dtTempMeasurement.NewRow();
                        drow["MeasurementID"] = dtMasterMeasurement.Rows[i]["MeasurementID"];
                        drow["MeasurementValue"] = dt1.Rows[0][i].ToString() == "" ? 0 : dt1.Rows[0][i];
                        drow["GarmentID"] = GarmentID;
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();

                    //CopyCommonMeasurement();
                    ChangeMeasurementStyleStatus('M', GarmentID);
                }
                else
                {
                    clsUtility.ShowInfoMessage("Please Enter Measurement for Garment.");
                    return;
                }
            }
        }
        int OldGarmentID = 0;
        private void CopyCommonMeasurement()
        {
            //ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, OldGarmentID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet dscommon = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_CommonMeasurement");
            if (ObjUtil.ValidateDataSet(dscommon))
            {
                DataTable dtcommon = dscommon.Tables[0];
                if (ObjUtil.ValidateTable(dtcommon))
                {
                    double pMeasurementValue = 0;
                    for (int i = 0; i < dtcommon.Rows.Count; i++)
                    {
                        int pGarmentID = Convert.ToInt32(dtcommon.Rows[i]["GarmentID"]);
                        int pMeasurementID = Convert.ToInt32(dtcommon.Rows[i]["MeasurementID"]);
                        DataRow[] dr = dtTempMeasurement.Select("MeasurementID=" + pMeasurementID);
                        //if (dr.Length > 0)
                        for (int k = 0; k < dr.Length; k++)
                        {
                            pMeasurementValue = Convert.ToDouble(dr[k]["MeasurementValue"]);

                            DataRow[] drexists = dtTempMeasurement.Select("GarmentID=" + GarmentID + " AND MeasurementID=" + pMeasurementID);
                            if (drexists.Length == 0)
                            {
                                ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
                                DataSet dsMeasure = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentMeasurement");

                                if (ObjUtil.ValidateDataSet(dsMeasure))
                                {
                                    DataTable dtMeasure = dsMeasure.Tables[0];
                                    for (int j = 0; j < dtMeasure.Rows.Count; j++)
                                    {
                                        DataRow drow = dtTempMeasurement.NewRow();
                                        drow["GarmentID"] = GarmentID;
                                        drow["MeasurementID"] = dtMeasure.Rows[j]["MeasurementID"];
                                        drow["MeasurementValue"] = Convert.ToInt32(dtMeasure.Rows[j]["MeasurementID"]) == pMeasurementID ? pMeasurementValue : 0;

                                        dtTempMeasurement.Rows.Add(drow);
                                    }
                                }
                            }
                            else
                            {
                                drexists[0]["MeasurementValue"] = pMeasurementValue;
                            }
                            dtTempMeasurement.AcceptChanges();
                            pMeasurementValue = 0;
                            //return;
                        }
                    }
                }
            }
        }

        private void ChangeMeasurementStyleStatus(char ps, int garmentid)
        {
            DataRow[] dr = dtGarmentList.Select("GarmentID=" + garmentid);
            if (dr.Length > 0)
            {
                if (ps == 'S')
                {
                    //dr[0]["Style"] = Done;
                    btnStyle.Image = Properties.Resources.StyleCheck;
                }
                else
                {
                    //dr[0]["Measurement"] = Done;
                    btnMeasurment.Image = Properties.Resources.measurcheck;
                }
            }
            dtGarmentList.AcceptChanges();
        }

        private void ResetdtMeasurement()
        {
            if (ObjUtil.ValidateTable(dtTempMeasurement))
            {
                //DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
                //if (dr.Length > 0)
                //{
                //    for (int i = 0; i < dr.Length; i++)
                //    {
                //        dr[i].Delete();
                //    }
                //    dtTempMeasurement.AcceptChanges();
                //}
            }
        }
    }
}