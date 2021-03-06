﻿using System;
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

        DataTable dtOrderDetails = new DataTable();

        DataTable dtTempMeasurement = new DataTable();
        DataTable dtTempStyle = new DataTable();
        DataTable dtTempPosture = new DataTable();
        DataTable dtTempOrderDetails = new DataTable();

        DataTable dtMeasurementData = new DataTable();
        DataTable dtStyleData = new DataTable();
        DataTable dtBodyPostureData = new DataTable();

        public bool IsEdit = false;
        public int pOrderID = 0;
        public string OrderNo = "NA";
        int GarmentID = 0, MasterGarmentID = 0, StyleID = 0;
        int OrderStatus = 0;

        int StyleCount = 0;
        List<int> lstStyleMan = new List<int>();

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

        private void InitTempdtMeasurement()
        {
            dtTempMeasurement.Columns.Add("MasterGarmentID", typeof(int));
            dtTempMeasurement.Columns.Add("GarmentID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementValue", typeof(double));
        }

        private void InitMeasurementTable()
        {
            dtMeasurementData.Columns.Add("SalesOrderID");
            dtMeasurementData.Columns.Add("MasterGarmentID");
            dtMeasurementData.Columns.Add("GarmentID");
            dtMeasurementData.Columns.Add("MeasurementID");
            dtMeasurementData.Columns.Add("MeasurementValue", typeof(double));
            dtMeasurementData.Columns.Add("CreatedBy", typeof(int));

            dtMeasurementData.AcceptChanges();
        }

        private void InitStyleTable()
        {
            dtStyleData.Columns.Add("SalesOrderID");
            dtStyleData.Columns.Add("MasterGarmentID");
            dtStyleData.Columns.Add("GarmentID");
            dtStyleData.Columns.Add("StyleID");
            dtStyleData.Columns.Add("QTY");
            dtStyleData.Columns.Add("StyleImageID");
            dtStyleData.Columns.Add("CreatedBy", typeof(int));

            dtStyleData.AcceptChanges();
        }

        private void InitBodyPostureTable()
        {
            dtBodyPostureData.Columns.Add("SalesOrderID");
            dtBodyPostureData.Columns.Add("MasterGarmentID");
            dtBodyPostureData.Columns.Add("GarmentID");
            dtBodyPostureData.Columns.Add("BodyPostureID");
            dtBodyPostureData.Columns.Add("BodyPostureMappingID");
            dtBodyPostureData.Columns.Add("CreatedBy", typeof(int));

            dtBodyPostureData.AcceptChanges();
        }

        private void InitOrderDetailsTable()
        {
            dtOrderDetails.Columns.Add("SalesOrderID");
            dtOrderDetails.Columns.Add("SalesOrderDetailsID");
            dtOrderDetails.Columns.Add("StichTypeID", typeof(int));
            dtOrderDetails.Columns.Add("FitTypeID", typeof(int));
            dtOrderDetails.Columns.Add("MasterGarmentID");
            dtOrderDetails.Columns.Add("GarmentID");
            dtOrderDetails.Columns.Add("Service");
            dtOrderDetails.Columns.Add("TrailDate");
            dtOrderDetails.Columns.Add("DeliveryDate");
            dtOrderDetails.Columns.Add("TrimAmount");
            dtOrderDetails.Columns.Add("QTY");
            dtOrderDetails.Columns.Add("Rate");
            dtOrderDetails.Columns.Add("Total");
            dtOrderDetails.Columns.Add("CreatedBy", typeof(int));

            dtOrderDetails.AcceptChanges();
        }

        private void frmViewMeasurementStyle_Load(object sender, EventArgs e)
        {
            lblOrderNo.Text = "Order No : " + OrderNo;

            LoadTailoringTheme();

            InitMeasurementTable();
            InitTempdtMeasurement();
            InitStyleTable();
            InitBodyPostureTable();
            InitOrderDetailsTable();

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

        private void EnableDisable_Update(bool b)
        {
            flowStyleImage.Enabled = b;
            btnSave.Enabled = b;
            IsEdit = b;
        }

        private void IsAdmin()
        {
            if ((clsUtility.IsAdmin || clsFormRights.HasFormRight(clsFormRights.Forms.frmViewMeasurementStyle, clsFormRights.Operation.Update)) && OrderStatus == 3)
            {
                //flowStyleImage.Enabled = true;
                //btnSave.Enabled = true;
                //IsEdit = true;
                EnableDisable_Update(true);
            }
            else
            {
                //flowStyleImage.Enabled = false;
                //btnSave.Enabled = false;
                //IsEdit = false;
                EnableDisable_Update(false);
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
                        dtGarmentList.Columns.Add("Measurement", typeof(string));
                        dtGarmentList.Columns.Add("Style", typeof(string));
                        dtGarmentList.Columns.Add("Posture", typeof(string));
                    }
                    dataGridView1.DataSource = dtGarmentList;
                    dtTempMeasurement = dsMeasure.Tables[1];
                    dtTempStyle = dsMeasure.Tables[2];
                    dtTempPosture = dsMeasure.Tables[3];
                    dtTempOrderDetails = dsMeasure.Tables[4];
                    AddGarments();
                }
            }
        }

        private void AddGarments()
        {
            flowGarmentList.Controls.Clear();
            //dtGarmentList.DefaultView.Sort = "MasterGarmentID ASC,GarmentID ASC";
            //dtGarmentList = dtGarmentList.DefaultView.ToTable();
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
                if (File.Exists(dtGarmentList.Rows[i]["Photo"].ToString()))
                {
                    pic.Image = Image.FromFile(dtGarmentList.Rows[i]["Photo"].ToString());
                    Image.FromFile(dtGarmentList.Rows[i]["Photo"].ToString()).Dispose();
                }
                else
                {
                    pic.Image = Properties.Resources.NoImage;
                }
                pic.Name = dtGarmentList.Rows[i]["GarmentID"].ToString();
                pic.Tag = dtGarmentList.Rows[i]["MasterGarmentID"].ToString();

                pic.Size = new Size(panel.Size.Width - 10, panel.Size.Height - 20);
                pic.Click += Pic_GarmentList_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);
                flowGarmentList.Controls.Add(panel);

                if (i == 0)
                {
                    MasterGarmentID = Convert.ToInt32(pic.Tag);
                    GetDefaultSelectSKU();
                }

                //lstStyleMan.Clear();
                //DataTable dtst = GetGarmentStyleData(Convert.ToInt32(dtGarmentList.Rows[i]["GarmentID"]));
                //if (ObjUtil.ValidateTable(dtst))
                //{
                //    for (int j = 0; j < dtst.Rows.Count; j++)
                //    {
                //        if (Convert.ToBoolean(dtst.Rows[j]["IsMandatory"]))
                //        {
                //            lstStyleMan.Add(Convert.ToInt32(dtst.Rows[j]["StyleID"]));
                //        }
                //    }
                //}

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
                MasterGarmentID = Convert.ToInt32(p.Tag);
                int QTY = Convert.ToInt32(drow[0]["QTY"]);
                OrderStatus = Convert.ToInt32(drow[0]["OrderStatus"]);

                IsAdmin();

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                AddStyleQTY(QTY);

                GetGarmentStyle(GarmentID);// Garment Style

                checkBox1.Checked = false;
                checkBox1.Enabled = false;

                GetStichFitType();
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
                    MasterGarmentID = Convert.ToInt32(drow[0]["MasterGarmentID"]);
                    int QTY = Convert.ToInt32(drow[0]["QTY"]);
                    OrderStatus = Convert.ToInt32(drow[0]["OrderStatus"]);

                    IsAdmin();

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
                    for (int i = 0; i < dt1.Columns.Count; i++)
                    {
                        DataRow drow = dtTempMeasurement.NewRow();
                        drow["MeasurementID"] = dtMasterMeasurement.Rows[i]["MeasurementID"];
                        drow["MeasurementValue"] = dt1.Rows[0][i].ToString() == "" ? 0 : dt1.Rows[0][i];
                        drow["GarmentID"] = GarmentID;
                        drow["MasterGarmentID"] = MasterGarmentID;
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();

                    ChangeMeasurementStyleStatus('M', GarmentID, "1");
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
            ObjDAL.SetStoreProcedureData("MasterGarmentID", SqlDbType.Int, MasterGarmentID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Show", SqlDbType.Int, -1, clsConnection_DAL.ParamType.Input);

            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_MeasurementValue_Report");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dtMeasurement = ds.Tables[0];
                //dtTempMeasurement = ds.Tables[0];
                if (ObjUtil.ValidateTable(dtMeasurement))
                {
                    dtMeasurement.Rows[0].Delete();
                    dtMeasurement.AcceptChanges();

                    if (ObjUtil.ValidateTable(dtTempMeasurement))
                    {
                        //DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
                        DataRow[] dr = dtTempMeasurement.Select("MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + GarmentID);
                        if (dr.Length > 0)
                        {
                            for (int i = 0; i < dtMeasurement.Columns.Count; i++)
                            {
                                dtMeasurement.Rows[0][i] = dr[i]["MeasurementValue"].ToString() == "0" ? "" : dr[i]["MeasurementValue"];
                            }
                        }
                    }
                    dtMeasurement.AcceptChanges();
                }
            }
            return dtMeasurement;
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
            lstStyleMan.Clear();
            for (int i = 0; i < dtStyle.Rows.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = "*";
                lbl.ForeColor = Color.FromArgb(192, 0, 0);
                lbl.Name = dtStyle.Rows[i]["GarmentStyleID"].ToString();
                lbl.AutoSize = false;
                lbl.Size = new Size(15, 17);

                KryptonButton btn = new KryptonButton();
                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();
                btn.Cursor = Cursors.Hand;
                // for flat style
                btn.PaletteMode = PaletteMode.SparklePurple;

                // add round corner
                btn.StateCommon.Border.Rounding = 5;
                btn.StateCommon.Content.ShortText.Color1 = Color.Black;
                btn.StateCommon.Content.ShortText.Color2 = Color.Black;

                btn.AutoSize = false;
                btn.Size = new Size(180, 42);//187,45
                btn.Click += btnStyleName_Click;
                btn.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 10.25f, FontStyle.Bold);
                int a = GetSelectedStyleImage(GarmentID, Convert.ToInt32(btn.Name));
                if (a > 0)
                {
                    btn.StateCommon.Content.ShortText.Color1 = Color.White;
                    btn.StateCommon.Content.ShortText.Color2 = Color.White;

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

                    //btn.StateCommon.Content.ShortText.Color1 = Color.Black;
                    //btn.StateCommon.Content.ShortText.Color2 = Color.Black;
                }
                flowStyleName.Controls.Add(btn);
                if (Convert.ToBoolean(dtStyle.Rows[i]["IsMandatory"]))
                {
                    flowStyleName.Controls.Add(lbl);
                    lstStyleMan.Add(Convert.ToInt32(btn.Name));
                }
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
            else if (btn.StateCommon.Back.Color1 == Color.FromArgb(78, 148, 132))
            {
                //btn.StateCommon.Content.ShortText.Color1 = Color.White;//17, 241, 41
                btn.StatePressed.Back.Color1 = Color.FromArgb(0, 191, 255);
                btn.StatePressed.Back.Color2 = Color.FromArgb(0, 191, 255);

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
                //DataRow[] drow = dtTempStyle.Select("GarmentID=" + pGarmentID + " AND StyleID=" + pStyleID + " AND QTY=" + cmbStyleQTY.Text);
                DataRow[] drow = dtTempStyle.Select("MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + pGarmentID + " AND StyleID=" + pStyleID + " AND QTY=" + cmbStyleQTY.Text);
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
                gGlowBox.gGlowBox glow = new gGlowBox.gGlowBox();
                glow.Name = "pnl";
                glow.Cursor = Cursors.Hand;
                //Panel panel = new Panel();
                //panel.Name = "pnl";

                PictureBox pic = new PictureBox();
                //Label lbl = new Label();


                //lbl.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                //lbl.Text = dtStyleImages.Rows[i]["ImageName"].ToString();
                //lbl.AutoSize = true;
                //lbl.BackColor = Color.Transparent;
                //lbl.Location = new Point(pic.Location.X + 17, pic.Location.Y + 80);
                //lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                //panel.Size = new Size(175, 160);
                //panel.Cursor = Cursors.Hand;
                glow.AutoSize = false;
                glow.Size = new Size(195, 185); //195, 185

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                if (System.IO.File.Exists(dtStyleImages.Rows[i]["ImagePath"].ToString()))
                {
                    pic.Image = Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString());
                    Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString()).Dispose();
                }
                else
                {
                    pic.Image = Properties.Resources.NoImage;
                }
                pic.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                //pic.Size = new Size(panel.Width - 5, panel.Height - 5);
                pic.Size = new Size(glow.Width - 10, glow.Height - 10);//5,5
                pic.Click += Pic_StyleImg_Click;
                pic.BorderStyle = BorderStyle.None;

                //panel.Controls.Add(pic);
                glow.Controls.Add(pic);
                //panel.Controls.Add(lbl);

                flowStyleImage.Controls.Add(glow);
                //flowStyleImage.Controls.Add(panel);

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
            StyleCount = 0;
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

                    btn.StateCommon.Content.ShortText.Color1 = Color.White;
                    btn.StateCommon.Content.ShortText.Color2 = Color.White;
                }
                else
                {
                    btn.StateCommon.Back.Color1 = Color.LightGray;
                    btn.StateCommon.Back.Color2 = Color.LightGray;

                    btn.StateCommon.Content.ShortText.Color1 = Color.Black;
                    btn.StateCommon.Content.ShortText.Color2 = Color.Black;
                }
            }
            GetStyleImageStatusChecked();
        }

        private void ClearSyleImageSelection()
        {
            Control[] ctrl = flowStyleImage.Controls.Find("pnl", false);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }
        }

        private void GetStyleImageStatusChecked()
        {
            StyleCount = 0;
            int qty = 0;
            qty = cmbStyleQTY.Text.Trim().Length == 0 ? 1 : Convert.ToInt32(cmbStyleQTY.Text);
            //DataRow[] dr = dtTempStyle.Select("GarmentID=" + GarmentID + " AND QTY=" + qty);
            DataRow[] dr = dtTempStyle.Select("MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + GarmentID + " AND QTY=" + qty);
            for (int i = 0; i < dr.Length; i++)
            {
                if (lstStyleMan.Contains(Convert.ToInt32(dr[i]["StyleID"])))
                {
                    StyleCount++;
                }
            }
            if (lstStyleMan.Count > 0 && lstStyleMan.Count == StyleCount)
            {
                ChangeMeasurementStyleStatus('S', GarmentID, "1");
            }
            else
            {
                ChangeMeasurementStyleStatus('S', GarmentID, "0");
            }
        }

        private void AddTempdtStyle(PictureBox p)
        {
            if (ObjUtil.ValidateTable(dtTempStyle))
            {
                //DataRow[] drdup = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID=" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                DataRow[] drdup = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID=" + p.Name + " AND QTY=" + cmbStyleQTY.Text + " AND MasterGarmentID=" + MasterGarmentID);
                if (drdup.Length > 0)
                {
                    p.Parent.BackColor = Color.Transparent;
                    drdup[0].Delete();
                    dtTempStyle.AcceptChanges();
                    return;
                }// above added

                //DataRow[] dr = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID<>" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                DataRow[] dr = dtTempStyle.Select("StyleID=" + StyleID + " AND MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + GarmentID + " AND StyleImageID<>" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempStyle.AcceptChanges();
                }
                DataRow drow = dtTempStyle.NewRow();
                drow["MasterGarmentID"] = MasterGarmentID;
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
                Control ctr = flowStyleName.Controls[i];
                if (ctr.GetType() == typeof(Label))
                {
                    continue;
                }
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
            if (ObjUtil.ValidateTable(dtTempOrderDetails))
            {
                int index = 0;
                index = Convert.ToInt32(cmbStyleQTY.Text);
                //DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID + " AND MasterGarmentID=" + MasterGarmentID);
                if (drow.Length > 0 && index <= drow.Length)
                {
                    if (drow[index - 1]["StichTypeID"] != DBNull.Value)
                    {
                        cmbStichType.SelectedValue = drow[index - 1]["StichTypeID"];
                    }
                    else
                    {
                        cmbStichType.SelectedIndex = -1;
                    }
                    if (drow[index - 1]["FitTypeID"] != DBNull.Value)
                    {
                        cmbFitType.SelectedValue = drow[index - 1]["FitTypeID"];
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

        private void ChangedStyleQTY()
        {
            if (Convert.ToInt32(cmbStyleQTY.SelectedItem) > 1)
            {
                //checkBox1.Checked = false;
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            flowStyleImage.Controls.Clear();
            GetGarmentStyle(GarmentID);// Garment Style
        }

        private void cmbStyleQTY_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangedStyleQTY();
            checkBox1.Checked = false;
            GetStichFitType();
        }

        private void PrintOrder()
        {
            Report.Forms.frmBill Obj = new Report.Forms.frmBill();
            Obj.OrderID = pOrderID.ToString();
            Obj.Show();
        }

        private void FillMeasurementData()
        {
            DataTable dttempMeasure = dtTempMeasurement;
            dtMeasurementData.Clear();
            for (int i = 0; i < dttempMeasure.Rows.Count; i++)
            {
                DataRow drow = dtMeasurementData.NewRow();
                drow["SalesOrderID"] = pOrderID;
                drow["MasterGarmentID"] = dttempMeasure.Rows[i]["MasterGarmentID"];
                drow["GarmentID"] = dttempMeasure.Rows[i]["GarmentID"];
                drow["MeasurementID"] = dttempMeasure.Rows[i]["MeasurementID"];
                drow["MeasurementValue"] = dttempMeasure.Rows[i]["MeasurementValue"].ToString() == "" ? "0" : dttempMeasure.Rows[i]["MeasurementValue"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtMeasurementData.Rows.Add(drow);
            }
            dtMeasurementData.AcceptChanges();
        }

        private void FillStyleData()
        {
            DataTable dttempStyle = dtTempStyle;
            dtStyleData.Clear();
            for (int i = 0; i < dttempStyle.Rows.Count; i++)
            {
                //dtStyle = dttempStyle.Copy();

                DataRow drow = dtStyleData.NewRow();
                drow["SalesOrderID"] = pOrderID;
                drow["MasterGarmentID"] = dttempStyle.Rows[i]["MasterGarmentID"];
                drow["GarmentID"] = dttempStyle.Rows[i]["GarmentID"];
                drow["StyleID"] = dttempStyle.Rows[i]["StyleID"];
                drow["QTY"] = dttempStyle.Rows[i]["QTY"];
                drow["StyleImageID"] = dttempStyle.Rows[i]["StyleImageID"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtStyleData.Rows.Add(drow);
            }
            dtStyleData.AcceptChanges();
        }

        private void FillBodyPostureData()
        {
            DataTable dttempPosture = dtTempPosture;
            dtBodyPostureData.Clear();
            for (int i = 0; i < dttempPosture.Rows.Count; i++)
            {
                //dtBodyPosture = dttempPosture.Copy();

                DataRow drow = dtBodyPostureData.NewRow();
                drow["SalesOrderID"] = pOrderID;
                drow["MasterGarmentID"] = dttempPosture.Rows[i]["MasterGarmentID"];
                drow["GarmentID"] = dttempPosture.Rows[i]["GarmentID"];
                drow["BodyPostureID"] = dttempPosture.Rows[i]["BodyPostureID"];
                drow["BodyPostureMappingID"] = dttempPosture.Rows[i]["BodyPostureMappingID"];
                drow["CreatedBy"] = clsUtility.LoginID;

                dtBodyPostureData.Rows.Add(drow);
            }
            dtBodyPostureData.AcceptChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateGarmentStyle())
            {
                dtGarmentList.DefaultView.Sort = "MasterGarmentID ASC,GarmentID ASC";
                dtGarmentList = dtGarmentList.DefaultView.ToTable();
                bool b = UpdateSalesOrderDetails();
                if (b)
                {
                    clsUtility.ShowInfoMessage("Invoice " + OrderNo + " is Updated.");
                    this.Close();
                    PrintOrder();
                    return;
                }
                else
                {
                    clsUtility.ShowErrorMessage("Invoice " + OrderNo + " is not Updated.");
                }
                //this.Close();
                //Update Code
            }
        }

        private bool UpdateSalesOrderDetails()
        {
            bool b = false;
            dtOrderDetails.Clear();
            for (int i = 0; i < dtTempOrderDetails.Rows.Count; i++) //Sales Details
            {
                DataRow drow = dtOrderDetails.NewRow();
                drow["SalesOrderID"] = pOrderID;
                drow["SalesOrderDetailsID"] = dtTempOrderDetails.Rows[i]["SalesOrderDetailsID"];
                drow["MasterGarmentID"] = dtTempOrderDetails.Rows[i]["MasterGarmentID"];
                drow["GarmentID"] = dtTempOrderDetails.Rows[i]["GarmentID"];
                drow["StichTypeID"] = dtTempOrderDetails.Rows[i]["StichTypeID"];
                drow["FitTypeID"] = dtTempOrderDetails.Rows[i]["FitTypeID"];
                drow["CreatedBy"] = clsUtility.LoginID;
                dtOrderDetails.Rows.Add(drow);
            }

            FillMeasurementData();
            FillStyleData();
            FillBodyPostureData();

            ObjDAL.SetStoreProcedureData("dtSalesOrderDetails", SqlDbType.Structured, dtOrderDetails, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtMeasurement", SqlDbType.Structured, dtMeasurementData, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtStyle", SqlDbType.Structured, dtStyleData, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("dtBodyPosture", SqlDbType.Structured, dtBodyPostureData, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("SalesOrderID", SqlDbType.Int, pOrderID, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("Flag", SqlDbType.Int, 0, clsConnection_DAL.ParamType.Output);

            b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.SPR_Update_SalesOrderDetails");
            DataTable dtOutput = ObjDAL.GetOutputParmData();
            if (ObjUtil.ValidateTable(dtOutput))
            {
                b = Convert.ToBoolean(dtOutput.Rows[0][1]);
            }
            ObjDAL.ResetData();
            return b;
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
            if (ObjUtil.ValidateTable(dtTempPosture))
            {
                btnBodyPosture.Image = Properties.Resources.bodyCheck;
            }
            else
            {
                btnBodyPosture.Image = Properties.Resources.picBodyPosture;
            }
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
                else
                {
                    flowLayoutPanel1.Controls.Clear();
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
                pnlContainer.BorderStyle = BorderStyle.None;

                grp.Name = "grp";
                grp.Size = new Size(kryptonHeaderGroup4.Size.Width - 60, 185);
                grp.Text = dt.Rows[i]["BodyPostureType"].ToString();
                grp.Font = new Font("Times", 11.1f, FontStyle.Bold);

                //pnlContainer.BorderStyle = BorderStyle.FixedSingle;
                pnlContainer.AutoScroll = true;
                pnlContainer.Size = new Size(grp.Size.Width - 30, 155);
                pnlContainer.Location = new Point(grp.Location.X + 13, grp.Location.Y + 22);

                grp.Controls.Add(pnlContainer);

                DataRow[] dr = dt1.Select("BodyPostureID=" + dt.Rows[i]["BodyPostureID"]);
                if (dr.Length > 0)
                {
                    for (int j = 0; j < dr.Length; j++)
                    {
                        Panel panel = new Panel();
                        PictureBox pic = new PictureBox();
                        //Label lbl = new Label();
                        panel.Name = "pnl";
                        panel.BorderStyle = BorderStyle.None;

                        //lbl.Name = dr[j]["BodyPostureMappingID"].ToString();
                        //lbl.Text = dr[j]["BodyPostureName"].ToString();
                        //lbl.AutoSize = true;
                        //lbl.BackColor = Color.Transparent;
                        //lbl.Location = new Point(pic.Location.X + 22, pic.Location.Y + 85);
                        //lbl.Font = new Font("Times New Roman", 11.4f, FontStyle.Bold);

                        panel.Size = new Size(155, 145);
                        //panel.Size = new Size(180, 145);
                        panel.Cursor = Cursors.Hand;

                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Click += PicBody_Click;
                        if (File.Exists(dr[j]["Photo"].ToString()))
                        {
                            Image.FromFile(dr[j]["Photo"].ToString()).Dispose();
                            pic.Image = Image.FromFile(dr[j]["Photo"].ToString());
                        }
                        else
                        {
                            pic.Image = Properties.Resources.NoImage;
                        }
                        pic.Name = dr[j]["BodyPostureMappingID"].ToString();
                        pic.Size = new Size(panel.Size.Width - 0, panel.Size.Height - 10);
                        //pic.Size = new Size(panel.Width - 30, panel.Height - 10);
                        pic.Location = new Point(pic.Location.X, pic.Location.Y + 5);
                        pic.BorderStyle = BorderStyle.None;

                        panel.Controls.Add(pic);
                        //panel.Controls.Add(lbl);

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
                //DataRow[] dr = dtTempPosture.Select("BodyPostureMappingID=" + pBodyPostureMappingID);
                //DataRow[] dr = dtTempPosture.Select("BodyPostureMappingID=" + pBodyPostureMappingID + " AND GarmentID=" + GarmentID);
                DataRow[] dr = dtTempPosture.Select("BodyPostureMappingID=" + pBodyPostureMappingID + " AND GarmentID=" + GarmentID + " AND MasterGarmentID=" + MasterGarmentID);
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
                DataRow[] drup = dtTempPosture.Select("MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + GarmentID + " AND BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID=" + p.Name);
                if (drup.Length > 0)
                {
                    p.Parent.BackColor = Color.Transparent;
                    drup[0].Delete();
                    dtTempPosture.AcceptChanges();
                    return;
                }
                //DataRow[] dr = dtTempPosture.Select("BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID<>" + p.Name);
                DataRow[] dr = dtTempPosture.Select("MasterGarmentID=" + MasterGarmentID + " AND GarmentID=" + GarmentID + " AND BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID<>" + p.Name);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempPosture.AcceptChanges();
                }
            }
            DataRow drow = dtTempPosture.NewRow();
            drow["BodyPostureMappingID"] = p.Name;
            drow["BodyPostureID"] = BodyPostureID;
            drow["MasterGarmentID"] = MasterGarmentID;
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
                DataTable dt1 = dtGarmentList.DefaultView.ToTable(true, "GarmentID");

                if (dt.Rows.Count != dt1.Rows.Count) //if (dt.Rows.Count != dtGarmentList.Rows.Count)
                {
                    clsUtility.ShowInfoMessage("Please Fill All Garments Measurement..");
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
                            //DataRow[] drow = dtTempStyle.Select("GarmentID=" + dtGarmentList.Rows[i]["GarmentID"] + " AND QTY=" + j);
                            DataRow[] drow = dtTempStyle.Select("MasterGarmentID=" + dtGarmentList.Rows[i]["MasterGarmentID"] + " AND GarmentID=" + dtGarmentList.Rows[i]["GarmentID"] + " AND QTY=" + j);
                            if (drow.Length == 0)
                            {
                                b = false;
                                clsUtility.ShowInfoMessage("Please Select Style for All QTY");
                                return b;
                                //break;
                            }
                            else
                            {
                                //b = true;
                                b = false;
                                DataTable dtStyleMan = new DataTable();
                                dtStyleMan = GetGarmentStyleData(Convert.ToInt32(dtGarmentList.Rows[i]["GarmentID"]));
                                //b = true;
                                int MandatoryCount = 0;
                                List<string> lstMendatory = new List<string>();
                                //DataRow[] dr = dtStyleMan.Select("StyleID=" + drow[k]["StyleID"] + " AND IsMandatory='True'");
                                DataRow[] dr = dtStyleMan.Select("IsMandatory='True'");
                                for (int k1 = 0; k1 < dr.Length; k1++)
                                {
                                    lstMendatory.Add(dr[k1]["StyleID"].ToString());
                                }
                                for (int k = 0; k < drow.Length; k++)
                                {
                                    if (lstMendatory.Contains(drow[k]["StyleID"].ToString()))
                                    {
                                        MandatoryCount++;
                                        b = true;
                                    }
                                    else
                                    {
                                        b = false;
                                    }
                                }
                                if (MandatoryCount != lstMendatory.Count)
                                {
                                    b = false;
                                    clsUtility.ShowInfoMessage("Please Select All Mandatory Styles");
                                    return b;
                                }
                                else
                                    b = true;
                            }
                        }
                    }
                }
            }
            return b;
        }

        private DataTable GetGarmentStyleData(int GarmentID)
        {
            DataTable dt = null;
            ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, GarmentID, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentStyle");
            if (ObjUtil.ValidateDataSet(ds))
            {
                dt = ds.Tables[0];
            }
            return dt;
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
                        drow["MasterGarmentID"] = MasterGarmentID;
                        drow["GarmentID"] = GarmentID;
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();

                    //CopyCommonMeasurement();
                    ChangeMeasurementStyleStatus('M', GarmentID, "1");
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

        private void ChangeMeasurementStyleStatus(char ps, int garmentid, string valve)
        {
            DataRow[] dr = dtGarmentList.Select("GarmentID=" + garmentid);
            //if (dr.Length > 0)
            for (int i = 0; i < dr.Length; i++)
            {
                if (ps == 'S')
                {
                    dr[i]["Style"] = valve;
                    if (valve == "1")
                        btnStyle.Image = Properties.Resources.StyleCheck;
                    else
                        btnStyle.Image = Properties.Resources.picStyle;
                }
                else if (ps == 'M')
                {
                    //dr[0]["Measurement"] = Done;
                    btnMeasurment.Image = Properties.Resources.measurcheck;
                }
                else if (ps == 'B')
                {
                    dr[i]["Posture"] = valve;
                    if (valve == "1")
                        btnBodyPosture.Image = Properties.Resources.bodyCheck;
                    else
                        btnBodyPosture.Image = Properties.Resources.picBodyPosture;
                }
                dtGarmentList.AcceptChanges();
            }
        }
        private void cmbStichType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (ObjUtil.ValidateTable(dtGarmentList))
            //{
            //    DataRow[] drow = dtGarmentList.Select("GarmentID=" + GarmentID);
            //    if (drow.Length > 0)
            //    {
            //        drow[0]["StichTypeID"] = cmbStichType.SelectedValue;
            //        dtGarmentList.AcceptChanges();
            //    }
            //}

            if (ObjUtil.ValidateTable(dtTempOrderDetails))
            {
                int pqty = Convert.ToInt32(cmbStyleQTY.Text);
                //DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID + " AND MasterGarmentID=" + MasterGarmentID);
                if (drow.Length > 0 && pqty <= drow.Length)
                {
                    drow[pqty - 1]["StichTypeID"] = cmbStichType.SelectedValue;
                    dtTempOrderDetails.AcceptChanges();
                }
            }
        }

        private void cmbFitType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (ObjUtil.ValidateTable(dtGarmentList))
            //{
            //    DataRow[] drow = dtGarmentList.Select("GarmentID=" + GarmentID);
            //    if (drow.Length > 0)
            //    {
            //        drow[0]["FitTypeID"] = cmbFitType.SelectedValue;
            //        dtGarmentList.AcceptChanges();
            //    }
            //}

            if (ObjUtil.ValidateTable(dtTempOrderDetails))
            {
                int pqty = Convert.ToInt32(cmbStyleQTY.Text);
                //DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID + " AND MasterGarmentID=" + MasterGarmentID);
                if (drow.Length > 0 && pqty <= drow.Length)
                {
                    drow[pqty - 1]["FitTypeID"] = cmbFitType.SelectedValue;
                    dtTempOrderDetails.AcceptChanges();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CopyPreviousGarmentStyle();

                ChangedStyleQTY();
            }
        }

        private void CopyPreviousGarmentStyle()
        {
            if (ObjUtil.ValidateTable(dtTempStyle))
            {
                //DataRow[] dr = dtTempStyle.Select("GarmentID=" + GarmentID + " AND QTY=" + (qty - 1));
                DataRow[] dr = dtTempStyle.Select("GarmentID=" + GarmentID + " AND QTY = 1");
                for (int i = 0; i < dr.Length; i++)
                {
                    DataRow drow = dtTempStyle.NewRow();
                    drow["GarmentID"] = dr[i]["GarmentID"];
                    drow["StyleID"] = dr[i]["StyleID"];
                    drow["StyleImageID"] = dr[i]["StyleImageID"];
                    drow["QTY"] = cmbStyleQTY.Text;
                    dtTempStyle.Rows.Add(drow);
                }
                ChangeMeasurementStyleStatus('S', GarmentID, "1");
            }
            else
            {
                clsUtility.ShowInfoMessage("There is no Data to copy.");
                checkBox1.Checked = false;
            }
        }

        private void frmViewMeasurementStyle_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetdtMeasurement()
        {
            if (ObjUtil.ValidateTable(dtTempMeasurement))
            {
                //DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
                DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID + " AND MasterGarmentID=" + MasterGarmentID);
                if (dr.Length > 0)
                {
                    for (int i = 0; i < dr.Length; i++)
                    {
                        dr[i].Delete();
                    }
                    dtTempMeasurement.AcceptChanges();
                }
            }
        }
    }
}