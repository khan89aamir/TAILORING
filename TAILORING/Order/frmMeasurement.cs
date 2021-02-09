using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmMeasurement : KryptonForm
    {
        public frmMeasurement()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        public DataTable dtGarmentList = new DataTable();
        public DataSet dsMeasure = new DataSet();

        DataTable dtMasterMeasurement = null;
        DataTable dtStyle = new DataTable();
        DataTable dtStyleImages = new DataTable();

        DataTable dtTempMeasurement = new DataTable();
        DataTable dtTempStyle = new DataTable();
        DataTable dtTempPosture = new DataTable();

        public DataTable dtTempOrderDetails = new DataTable();

        //ImageList imageList = new ImageList();

        int GarmentID = 0, StyleID = 0;
        public int CustomerID = 0;

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
                    Image.FromFile(dtGarmentList.Rows[i]["Photo"].ToString()).Dispose();
                }
                else
                {
                    pic.Image = Properties.Resources.NoImage;
                }
                pic.Name = dtGarmentList.Rows[i]["GarmentID"].ToString();
                pic.Size = new Size(panel.Size.Width - 10, panel.Size.Height - 20);
                pic.Click += Pic_GarmentList_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);
                flowGarmentList.Controls.Add(panel);

                if (i == 0)
                {
                    GetDefaultSelectSKU();
                }

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
            OldGarmentID = GarmentID;
            DataRow[] drow = dtGarmentList.Select("GarmentID=" + p.Name);
            if (drow.Length > 0)
            {
                lblSKUName.Text = "SKU Selected : " + drow[0]["GarmentName"];
                GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
                int QTY = Convert.ToInt32(drow[0]["QTY"]);

                CopyCommonMeasurement();

                ctrlMeasurment1.ProductCount = 1;
                GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

                AddStyleQTY(QTY);

                GetGarmentStyle(GarmentID);// Garment Style

                checkBox1.Checked = false;
                checkBox1.Enabled = false;

                GetStichFitType();

                //Get current Garment selection Status
                GetGarmentSelectionStatus();
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

        private void CopyGarmentDetails_LastOrder()
        {
            for (int i = 0; i < dtGarmentList.Rows.Count; i++)
            {
                ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, CustomerID, clsConnection_DAL.ParamType.Input);
                ObjDAL.SetStoreProcedureData("GarmentID", SqlDbType.Int, dtGarmentList.Rows[i]["GarmentID"], clsConnection_DAL.ParamType.Input);
                DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.SPR_Get_GarmentMeasurementStyle_CopyOrder");
                if (ObjUtil.ValidateDataSet(ds))
                {
                    DataTable dt = ds.Tables[0];
                    if (ObjUtil.ValidateTable(dt))
                    {
                        GarmentID = Convert.ToInt32(dtGarmentList.Rows[i]["GarmentID"]);
                        //GetStichFitType();
                        if (Convert.ToInt32(dt.Rows[0]["SalesOrderID"]) == 0)
                        {
                            //GetStichFitType();
                            //clsUtility.ShowInfoMessage("No previous order found..");
                        }
                        else
                        {
                            //GetStichFitType();

                            if (ds.Tables.Count > 1)
                                CopyMeasurement_LastOrder(ds.Tables[1]);
                            if (ds.Tables.Count > 2)
                                CopyStyle_LastOrder(ds.Tables[2]);
                            if (ds.Tables.Count > 3)
                                CopyBodyPosture_LastOrder(ds.Tables[3]);
                        }
                    }
                }
            }
            GarmentID = 0;
        }

        private void CopyMeasurement_LastOrder(DataTable dtMeasure)
        {
            if (ObjUtil.ValidateTable(dtMeasure))
            {
                for (int i = 0; i < dtMeasure.Rows.Count; i++)
                {
                    DataRow[] drow = dtTempMeasurement.Select("GarmentID=" + dtMeasure.Rows[i]["GarmentID"] + " AND MeasurementID=" + dtMeasure.Rows[i]["MeasurementID"]);
                    if (drow.Length == 0)
                    {
                        DataRow dr = dtTempMeasurement.NewRow();
                        dr["GarmentID"] = dtMeasure.Rows[i]["GarmentID"];
                        dr["MeasurementID"] = dtMeasure.Rows[i]["MeasurementID"];
                        dr["MeasurementValue"] = dtMeasure.Rows[i]["MeasurementValue"].ToString() == "" ? "0" : dtMeasure.Rows[i]["MeasurementValue"];

                        dtTempMeasurement.Rows.Add(dr);

                        ChangeMeasurementStyleStatus('M', Convert.ToInt32(dtMeasure.Rows[i]["GarmentID"]));
                    }
                }
                dtTempMeasurement.AcceptChanges();
            }
        }

        private void CopyStyle_LastOrder(DataTable dtStyle)
        {
            if (ObjUtil.ValidateTable(dtStyle))
            {
                for (int i = 0; i < dtStyle.Rows.Count; i++)
                {
                    DataRow[] drow = dtTempStyle.Select("GarmentID=" + dtStyle.Rows[i]["GarmentID"] + " AND StyleID=" + dtStyle.Rows[i]["StyleID"]);
                    if (drow.Length == 0)
                    {
                        DataRow dr = dtTempStyle.NewRow();
                        dr["GarmentID"] = dtStyle.Rows[i]["GarmentID"];
                        dr["StyleID"] = dtStyle.Rows[i]["StyleID"];
                        dr["QTY"] = dtStyle.Rows[i]["QTY"];
                        dr["StyleImageID"] = dtStyle.Rows[i]["StyleImageID"];

                        dtTempStyle.Rows.Add(dr);
                        ChangeMeasurementStyleStatus('S', Convert.ToInt32(dtStyle.Rows[i]["GarmentID"]));
                    }
                }
                dtTempStyle.AcceptChanges();
            }
        }

        private void CopyBodyPosture_LastOrder(DataTable dtPosture)
        {
            if (ObjUtil.ValidateTable(dtPosture))
            {
                for (int i = 0; i < dtPosture.Rows.Count; i++)
                {
                    DataRow[] drow = dtTempPosture.Select("GarmentID=" + dtPosture.Rows[i]["GarmentID"] + " AND BodyPostureID=" + dtPosture.Rows[i]["BodyPostureID"]);
                    if (drow.Length == 0)
                    {
                        DataRow dr = dtTempPosture.NewRow();
                        dr["GarmentID"] = dtPosture.Rows[i]["GarmentID"];
                        dr["BodyPostureID"] = dtPosture.Rows[i]["BodyPostureID"];
                        dr["BodyPostureMappingID"] = dtPosture.Rows[i]["BodyPostureMappingID"];

                        dtTempPosture.Rows.Add(dr);
                        ChangeMeasurementStyleStatus('B', Convert.ToInt32(dtPosture.Rows[i]["GarmentID"]));
                    }
                }
                dtTempPosture.AcceptChanges();
            }
        }

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            //HorizontalScroll.Maximum = 0;
            ctrlMeasurment1.IsEditable = true;

            LoadTailoringTheme();

            BindStichType();
            BindFitType();

            if (!ObjUtil.ValidateDataSet(dsMeasure))
            {
                dsMeasure.Tables.Add(dtTempMeasurement);
                dsMeasure.Tables[0].TableName = "Measurement";

                dsMeasure.Tables.Add(dtTempStyle);
                dsMeasure.Tables[1].TableName = "Style";

                dsMeasure.Tables.Add(dtTempPosture);
                dsMeasure.Tables[2].TableName = "BodyPosture";

                InitTempdtMeasurement();
                InitTempdtStyle();
                InitTempdtPosture();

                //CopyGarmentDetails_LastOrder();
            }
            else
            {
                dtTempMeasurement = dsMeasure.Tables[0];
                dtTempStyle = dsMeasure.Tables[1];
                dtTempPosture = dsMeasure.Tables[2];
            }
            if (ObjUtil.ValidateTable(dtGarmentList))
            {
                if (!dtGarmentList.Columns.Contains("Measurement"))
                {
                    dtGarmentList.Columns.Add("Measurement", typeof(string));
                    dtGarmentList.Columns.Add("Style", typeof(string));
                    dtGarmentList.Columns.Add("Posture", typeof(string));
                }
                dataGridView1.DataSource = dtGarmentList;

                CopyGarmentDetails_LastOrder();

                AddGarments();
            }
            else
            {
                dataGridView1.DataSource = null;
                ctrlMeasurment1.Visible = false;
            }
        }

        private void InitTempdtMeasurement()
        {
            dtTempMeasurement.Columns.Add("GarmentID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementID", typeof(int));
            dtTempMeasurement.Columns.Add("MeasurementValue", typeof(double));
        }

        private void InitTempdtStyle()
        {
            dtTempStyle.Columns.Add("GarmentID", typeof(int));
            dtTempStyle.Columns.Add("StyleID", typeof(int));
            dtTempStyle.Columns.Add("StyleImageID", typeof(int));
            dtTempStyle.Columns.Add("QTY", typeof(int));
        }

        private void InitTempdtPosture()
        {
            dtTempPosture.Columns.Add("BodyPostureID", typeof(int));
            dtTempPosture.Columns.Add("BodyPostureMappingID", typeof(int));
            dtTempPosture.Columns.Add("GarmentID", typeof(int));
        }

        private void BindStichType()
        {
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

        private void BindFitType()
        {
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
                KryptonButton btn = new KryptonButton();
                btn.PaletteMode = PaletteMode.SparklePurple;
                // add round corner
                btn.StateCommon.Border.Rounding = 5;
                btn.StateCommon.Content.ShortText.Color1 = Color.Black;
                btn.StateCommon.Content.ShortText.Color2 = Color.Black;

                btn.AutoSize = false;
                btn.Size = new Size(187, 45);

                btn.Name = dtStyle.Rows[i]["StyleID"].ToString();
                btn.Text = dtStyle.Rows[i]["StyleName"].ToString();
                btn.Cursor = Cursors.Hand;
                btn.AutoSize = false;
                btn.Click += btnStyleName_Click;
                btn.StateCommon.Content.ShortText.Font = new Font("Times New Roman", 12.3f, FontStyle.Bold);
                int a = GetSelectedStyleImage(GarmentID, Convert.ToInt32(btn.Name));
                if (a > 0)
                {
                    btn.StateCommon.Content.ShortText.Color1 = Color.White;
                    btn.StateCommon.Content.ShortText.Color2 = Color.White;

                    btn.StateCommon.Back.Color1 = Color.FromArgb(78, 148, 132);//78, 148, 132
                    btn.StateCommon.Back.Color2 = Color.FromArgb(78, 148, 132);

                    btn.OverrideFocus.Back.Color1 = Color.FromArgb(78, 148, 132);//78, 148, 132
                    btn.OverrideFocus.Back.Color2 = Color.FromArgb(78, 148, 132);

                    btn.OverrideDefault.Back.Color1 = Color.FromArgb(78, 148, 132);//78, 148, 132
                    btn.OverrideDefault.Back.Color2 = Color.FromArgb(78, 148, 132);
                }
                else
                {
                    btn.StateCommon.Back.Color1 = Color.LightGray;
                    btn.StateCommon.Back.Color2 = Color.LightGray;
                }
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
            ClearSyleNameSelection();
            KryptonButton btn = (KryptonButton)sender;
            //KryptonButton btn = (KryptonButton)sender;

            //if (btn.BackColor != Color.FromArgb(17, 241, 41))
            //{
            //    btn.BackColor = Color.FromArgb(0, 191, 255); // Blue
            //}
            if (btn.StateCommon.Back.Color1 != Color.FromArgb(78, 148, 132))
            {
                //btn.StateCommon.Content.ShortText.Color1 = Color.White;//17, 241, 41
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
                //btn.StatePressed.Back.Color1 = Color.FromArgb(17, 241, 41);
                //btn.StatePressed.Back.Color2 = Color.FromArgb(17, 241, 41);

                //btn.OverrideFocus.Back.Color1 = Color.FromArgb(17, 241, 41);
                //btn.OverrideFocus.Back.Color2 = Color.FromArgb(17, 241, 41);

                //btn.OverrideDefault.Back.Color1 = Color.FromArgb(17, 241, 41);
                //btn.OverrideDefault.Back.Color2 = Color.FromArgb(17, 241, 41);

                //0, 191, 255
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
            //ObjUtil.SetDataGridProperty(dataGridView1, DataGridViewAutoSizeColumnsMode.Fill);

            dataGridView1.Columns["GarmentName"].HeaderText = "Garment";
            dataGridView1.Columns["GarmentID"].Visible = false;
            dataGridView1.Columns["GarmentCode"].Visible = false;
            dataGridView1.Columns["QTY"].Visible = false;
            dataGridView1.Columns["Photo"].Visible = false;

            dataGridView1.ClearSelection();
            //dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            //dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Transparent;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddStyleImages()
        {
            try
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
                        Image.FromFile(dtStyleImages.Rows[i]["ImagePath"].ToString()).Dispose();
                    }
                    else
                    {
                        pic.Image = Properties.Resources.NoImage;
                    }
                    pic.Name = dtStyleImages.Rows[i]["StyleImageID"].ToString();
                    pic.Size = new Size(panel.Width - 5, panel.Height - 5);
                    pic.Click += Pic_Click;
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
            catch (OutOfMemoryException ex)
            {
                clsUtility.ShowErrorMessage(ex.ToString());
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
                }
                DataRow[] dr = dtTempStyle.Select("StyleID=" + StyleID + " AND GarmentID=" + GarmentID + " AND StyleImageID<>" + p.Name + " AND QTY=" + cmbStyleQTY.Text);
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                    dtTempStyle.AcceptChanges();
                }
            }
            DataRow drow = dtTempStyle.NewRow();
            drow["GarmentID"] = GarmentID;
            drow["StyleID"] = StyleID;
            drow["StyleImageID"] = p.Name;
            drow["QTY"] = cmbStyleQTY.Text;

            dtTempStyle.Rows.Add(drow);
            dtTempStyle.AcceptChanges();

            ChangeMeasurementStyleStatus('S', GarmentID);
        }

        private void ChangeMeasurementStyleStatus(char ps, int garmentid)
        {
            DataRow[] dr = dtGarmentList.Select("GarmentID=" + garmentid);
            if (dr.Length > 0)
            {
                if (ps == 'S')
                {
                    dr[0]["Style"] = "1";
                    btnStyle.Image = Properties.Resources.StyleCheck;
                }
                else if (ps == 'M')
                {
                    dr[0]["Measurement"] = "1";
                    btnMeasurment.Image = Properties.Resources.measurcheck;
                }
                else if (ps == 'B')
                {
                    dr[0]["Posture"] = "1";
                    btnBodyPosture.Image = Properties.Resources.bodyCheck;
                }
            }
            dtGarmentList.AcceptChanges();
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
                ChangeMeasurementStyleStatus('S', GarmentID);
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
                //if (flowStyleName.Controls[i].BackColor != Color.FromArgb(17, 241, 41))// Green
                //{
                //    //flowStyleName.Controls[i].BackColor = Color.FromArgb(0, 191, 255);
                //    flowStyleName.Controls[i].BackColor = Color.LightGray;
                //}
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            ClearSyleImageSelection();

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;

            AddTempdtStyle(p);

            Control[] ctr = flowStyleName.Controls.Find(StyleID.ToString(), false);
            for (int i = 0; i < ctr.Length; i++)
            {
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

        private void GetStichFitType()
        {
            if (ObjUtil.ValidateTable(dtTempOrderDetails))
            {
                int index = 0;
                index = Convert.ToInt32(cmbStyleQTY.Text);
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
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

        private void SKUList_MouseClick(object sender, MouseEventArgs e)
        {
            //SaveddtMeasurement(); // Auto Saved Garment Measurement value

            //lblSKUName.Text = SKUList.SelectedItems[0].Text.ToString();
            //DataRow[] drow = dtGarmentList.Select("GarmentName='" + SKUList.SelectedItems[0].Text + "'");
            //if (drow.Length > 0)
            //{
            //    flowStyleImage.Controls.Clear();
            //    GarmentID = Convert.ToInt32(drow[0]["GarmentID"]);
            //    int QTY = Convert.ToInt32(drow[0]["QTY"]);

            //    ctrlMeasurment1.ProductCount = 1;
            //    GetGarmentMasterMeasurement(GarmentID);// Garment Measurement

            //    GetGarmentStyle(GarmentID);// Garment Style
            //    AddStyleQTY(QTY);
            //    checkBox1.Enabled = false;

            //    GetStichFitType();
            //}
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

                    // Get Current Garment selection status
                    GetGarmentSelectionStatus();

                    GetStichFitType();
                }
            }
        }

        private void GetGarmentSelectionStatus()
        {
            DataRow[] dr = dtGarmentList.Select("GarmentID=" + GarmentID);
            if (dr.Length > 0)
            {
                if (dr[0]["Measurement"].ToString() == "1")
                {
                    btnMeasurment.Image = Properties.Resources.measurcheck;
                }
                else
                {
                    btnMeasurment.Image = Properties.Resources.picmeasurment;
                }

                if (dr[0]["Style"].ToString() == "1")
                {
                    btnStyle.Image = Properties.Resources.StyleCheck;
                }
                else
                {
                    btnStyle.Image = Properties.Resources.picStyle;
                }

                if (dr[0]["Posture"].ToString() == "1")
                {
                    btnBodyPosture.Image = Properties.Resources.bodyCheck;
                }
                else
                {
                    btnBodyPosture.Image = Properties.Resources.picBodyPosture;
                }
            }
        }

        private void ResetdtMeasurement()
        {
            if (ObjUtil.ValidateTable(dtTempMeasurement))
            {
                DataRow[] dr = dtTempMeasurement.Select("GarmentID=" + GarmentID);
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

        private void btnMeasureSave_Click(object sender, EventArgs e)
        {
            SaveMeasurement();
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

                    CopyCommonMeasurement();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CopyPreviousGarmentStyle();

                ChangedStyleQTY();
                //checkBox1.Checked = true;
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
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
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
                DataRow[] drow = dtTempOrderDetails.Select("GarmentID=" + GarmentID);
                if (drow.Length > 0 && pqty <= drow.Length)
                {
                    drow[pqty - 1]["FitTypeID"] = cmbFitType.SelectedValue;
                    dtTempOrderDetails.AcceptChanges();
                }
            }
        }

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
                else if (ObjUtil.ValidateTable(dtGarmentList))
                {
                    b = false;
                    for (int i = 0; i < dtGarmentList.Rows.Count; i++)
                    {
                        if (dtGarmentList.Rows[i]["StichTypeID"].ToString() == "")
                        {
                            clsUtility.ShowInfoMessage("Please Select Stich Type for " + dtGarmentList.Rows[i]["GarmentName"]);
                            return b;
                        }
                        else if (dtGarmentList.Rows[i]["FitTypeID"].ToString() == "")
                        {
                            clsUtility.ShowInfoMessage("Please Select Fit Type for " + dtGarmentList.Rows[i]["GarmentName"]);
                            return b;
                        }
                    }
                    b = true;
                }
            }
            return b;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateGarmentStyle())
            {
                this.Close();
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
                        dtTempMeasurement.Rows.Add(drow);
                    }
                    dtTempMeasurement.AcceptChanges();

                    ChangeMeasurementStyleStatus('M', GarmentID);
                }
            }
        }

        #region Body Posture Code

        DataTable dtPosture = new DataTable();

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
                        Label lbl = new Label();
                        panel.Name = "pnl";
                        panel.BorderStyle = BorderStyle.None;

                        lbl.Name = dr[j]["BodyPostureMappingID"].ToString();
                        lbl.Text = dr[j]["BodyPostureName"].ToString();
                        lbl.AutoSize = true;
                        lbl.BackColor = Color.Transparent;
                        lbl.Location = new Point(pic.Location.X + 22, pic.Location.Y + 85);
                        lbl.Font = new Font("Times New Roman", 11.4f, FontStyle.Bold);

                        panel.Size = new Size(180, 145);
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
                        pic.Size = new Size(panel.Width - 30, panel.Height - 10);
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
                DataRow[] dr = dtTempPosture.Select("BodyPostureMappingID=" + pBodyPostureMappingID + " AND GarmentID=" + GarmentID);
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

            //btnBodyPosture.Image = Properties.Resources.bodyCheck;
            ChangeMeasurementStyleStatus('B', GarmentID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMeasurement_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
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
                DataRow[] drup = dtTempPosture.Select("GarmentID=" + GarmentID + " AND BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID=" + p.Name);
                if (drup.Length > 0)
                {
                    p.Parent.BackColor = Color.Transparent;
                    drup[0].Delete();
                    dtTempPosture.AcceptChanges();
                    return;
                }
                //DataRow[] dr = dtTempPosture.Select("BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID<>" + p.Name);
                DataRow[] dr = dtTempPosture.Select("GarmentID=" + GarmentID + " AND BodyPostureID=" + BodyPostureID + " AND BodyPostureMappingID<>" + p.Name);
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
    }
}