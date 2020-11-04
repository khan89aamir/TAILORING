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
    public partial class frmBodyPosture : Form
    {
        public frmBodyPosture()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        
        DataTable dtStmouch = new DataTable();
        DataTable dtShoulder = new DataTable();

        private void frmBodyPosture_Load(object sender, EventArgs e)
        {
            AddStmouchPosture();
            AddShoulderPosture();
        }

        private void AddStmouchPosture()
        {
            flowStmouch.Controls.Clear();
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
                lbl.Location = new Point(pic.Location.X + 17, pic.Location.Y + 80);
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

                flowStmouch.Controls.Add(panel);

                //int a = GetSelectedStyleImage(GarmentID, StyleID);
                //if (pic.Name == a.ToString())
                //{
                //    //pic.BackColor = Color.LightGray;
                //    pic.Parent.BackColor = Color.LightGray;
                //}
            }
        }

        private void AddShoulderPosture()
        {
            flowShoulder.Controls.Clear();
            for (int i = 0; i < dtShoulder.Rows.Count; i++)
            {
                Panel panel = new Panel();
                PictureBox pic = new PictureBox();
                Label lbl = new Label();
                panel.Name = "pnl";

                lbl.Name = dtShoulder.Rows[i]["StyleImageID"].ToString();
                lbl.Text = dtShoulder.Rows[i]["ImageName"].ToString();
                lbl.AutoSize = true;
                lbl.BackColor = Color.Transparent;
                lbl.Location = new Point(pic.Location.X + 17, pic.Location.Y + 80);
                lbl.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                panel.Size = new Size(160, 100);
                panel.Cursor = Cursors.Hand;

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(dtShoulder.Rows[i]["ImagePath"].ToString());
                pic.Name = dtShoulder.Rows[i]["StyleImageID"].ToString();
                pic.Size = new Size(panel.Width - 40, panel.Height - 20);
                //pic.Click += Pic_Click;
                pic.BorderStyle = BorderStyle.None;

                panel.Controls.Add(pic);
                panel.Controls.Add(lbl);

                flowShoulder.Controls.Add(panel);

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
