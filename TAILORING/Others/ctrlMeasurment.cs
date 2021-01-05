using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAILORING.Others
{
    public partial class ctrlMeasurment : UserControl
    {
        public ctrlMeasurment()
        {
            InitializeComponent();
        }

        List<string> lstMendatoryColumn;
        public int ProductCount { get; set; }
        public bool IsEditable { get; set; }

        DataTable dttemp;
        //FlowLayoutPanel pnlContainer;

        CoreApp.clsUtility ObjUtil = new CoreApp.clsUtility();

        public void SetMendatoryList(List<string> lst)
        {
            lstMendatoryColumn = lst;
        }
        public DataTable DataSource
        {
            get
            {
                return dttemp;
            }
            set
            {
                dttemp = value;

                AddControls(value);
            }
        }

        public DataSet GetMeasurement()
        {
            DataSet ds = new DataSet();
            DataTable dtRetun = null;
            dtRetun = dttemp.Copy();
            dtRetun.Rows.Clear();
            DataRow dRow = dtRetun.NewRow();
            //for (int j = 0; j < ProductCount; j++)
            //{
            //    DataTable dtRetun = dttemp.Copy();
            //    DataRow dRow = dtRetun.NewRow();

            //  flowLayoutPanel1.Controls.Count = number of products
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                //DataTable dtRetun = dttemp.Copy();
                //DataRow dRow = dtRetun.NewRow();

                // count the column given in first/ith panel
                //for (int k = 0; k < flowLayoutPanel1.Controls[i].Controls.Count; k++)
                //{
                // the txt box will alwas be at zeorth index.
                //Control[] ctr = flowLayoutPanel1.Controls[i].Controls[k].Controls.Find("txt", true);
                Control[] ctr = flowLayoutPanel1.Controls[i].Controls.Find("txt", true);

                // two lables are added in one panel .. one for name and other for mendatory
                //IEnumerable<Label> Lable = flowLayoutPanel1.Controls[i].Controls[k].Controls.OfType<Label>();
                IEnumerable<Label> Lable = flowLayoutPanel1.Controls[i].Controls.OfType<Label>();
                if (Lable.Count() > 1)
                {
                    string curCol = Lable.ElementAt(1).Text;

                    if (lstMendatoryColumn.Contains(curCol) && ctr[0].Text.Trim().Length == 0)
                    {
                        CoreApp.clsUtility.ShowInfoMessage("Please fill all the mandatory fields");
                        return null;
                    }
                    else
                    {
                        dRow[i] = ctr[0].Text;
                    }
                }
                else
                {
                    dRow[i] = ctr[0].Text;
                }
                //}
                //dtRetun.Rows.Add(dRow);
                //dtRetun.AcceptChanges();
                //ds.Tables.Add(dtRetun);
            }
            dtRetun.Rows.Add(dRow);
            dtRetun.AcceptChanges();
            ds.Tables.Add(dtRetun);
            //}
            //dtRetun.Rows.Add(dRow);
            //dtRetun.AcceptChanges();
            //ds.Tables.Add(dtRetun);

            return ds;
        }

        private void AddControls(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();
            if (dt == null)
            {
                return;
            }

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Panel panel = new Panel();
                Label label = new Label();
                TextBox txt = new TextBox();

                label.Location = new Point(13, 16);
                label.Text = dt.Columns[i].ColumnName;
                label.Font = new Font("Times New Roman", 11.2f, FontStyle.Bold);
                label.AutoSize = true;

                if (lstMendatoryColumn.Contains(label.Text))
                {
                    Label lblmendatory = new Label();
                    lblmendatory.Text = "*";
                    lblmendatory.Font = new Font("Times New Roman", 11.2f, FontStyle.Bold);
                    lblmendatory.ForeColor = Color.Red;
                    lblmendatory.BackColor = Color.Transparent;
                    lblmendatory.AutoSize = true;
                    lblmendatory.Location = new Point(110 + txt.Width + 1, 11);
                    panel.Controls.Add(lblmendatory);
                }
                txt.Name = "txt";
                txt.Font = new Font("Times New Roman", 11.2f, FontStyle.Regular);
                txt.Location = new Point(110, 13);
                txt.Enter += txtName_Enter;
                txt.Leave += txtName_Leave;
                txt.Enabled = IsEditable;
                txt.BackColor = Color.White;

                if (ObjUtil.ValidateTable(dt))
                    txt.Text = dt.Rows[0][label.Text].ToString();

                panel.Size = new Size(panel.Width + 23, panel.Height - 60);
                panel.Controls.Add(label);
                panel.Controls.Add(txt);
                panel.Location = new Point(0, 0);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            ObjUtil.SetTextHighlightColor(sender, Color.White);
        }
    }
}