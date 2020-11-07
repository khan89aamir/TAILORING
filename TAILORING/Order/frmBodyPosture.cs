using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;

namespace TAILORING.Order
{
    public partial class frmBodyPosture : Form
    {
        public frmBodyPosture()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        DataTable dtStmouch = new DataTable();
        DataTable dtShoulder = new DataTable();

        DataTable dtPosture = new DataTable();

        public int GarmentID = 1;

        private void frmBodyPosture_Load(object sender, EventArgs e)
        {
            //AddShoulderPosture();

            GetBodyPostureDetails();
        }

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

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GroupBox grp = new GroupBox();
                FlowLayoutPanel pnlContainer = new FlowLayoutPanel();

                grp.Name = "grp";
                grp.Size = new Size(750, 185);
                grp.Text = dt.Rows[i]["BodyPostureType"].ToString();

                pnlContainer.BorderStyle = BorderStyle.FixedSingle;
                pnlContainer.AutoScroll = true;
                pnlContainer.Size = new Size(730, 155);
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
                        lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                        panel.Size = new Size(160, 100);
                        panel.Cursor = Cursors.Hand;
                        //panel.BackColor = Color.Red;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Click += Pic_Click;
                        if (File.Exists(dr[j]["Photo"].ToString()))
                        {
                            pic.Image = Image.FromFile(dr[j]["Photo"].ToString());
                        }
                        else
                        {
                            pic.Image = TAILORING.Properties.Resources.NoImage;
                        }
                        pic.Name = dr[j]["BodyPostureMappingID"].ToString();
                        pic.Size = new Size(panel.Width - 40, panel.Height - 20);
                        pic.Location = new Point(pic.Location.X, pic.Location.Y + 5);
                        //pic.Click += Pic_Click;
                        pic.BorderStyle = BorderStyle.None;

                        panel.Controls.Add(pic);
                        panel.Controls.Add(lbl);

                        pnlContainer.Controls.Add(panel);
                    }
                }
                flowLayoutPanel1.Controls.Add(grp);
            }
        }

        private void ClearBodyPostureImgSelection()
        {
            Control[] ctrl = flowLayoutPanel1.Controls.Find("pnl", true);
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].BackColor = Color.Transparent;
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            ClearBodyPostureImgSelection();

            PictureBox p = (PictureBox)sender;
            p.Parent.BackColor = Color.LightGray;
        }

        private void AddStmouchPosture()
        {
            //flowStmouch.Controls.Clear();
            for (int i = 0; i < dtStmouch.Rows.Count; i++)
            {
                Panel panel = new Panel();
                PictureBox pic = new PictureBox();
                Label lbl = new Label();
                panel.Name = "pnl";

                lbl.Name = dtStmouch.Rows[i]["StyleImageID"].ToString();
                lbl.Text = dtStmouch.Rows[i]["ImageName"].ToString();
                lbl.AutoSize = true;
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(pic.Location.X + 15, pic.Location.Y + 80);
                lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                panel.Size = new Size(160, 100);
                panel.Cursor = Cursors.Hand;

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(dtStmouch.Rows[i]["ImagePath"].ToString());
                pic.Name = dtStmouch.Rows[i]["StyleImageID"].ToString();
                pic.Size = new Size(panel.Width - 40, panel.Height - 20);
                //pic.Click += Pic_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);

                //flowStmouch.Controls.Add(panel);

                //int a = GetSelectedStyleImage(GarmentID, StyleID);
                //if (pic.Name == a.ToString())
                //{
                //    //pic.BackColor = Color.LightGray;
                //    pic.Parent.BackColor = Color.LightGray;
                //}
            }
        }
    }
}