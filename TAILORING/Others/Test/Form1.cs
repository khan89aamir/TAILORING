using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAILORING.Others.Test
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            lnkAddItem.StateCommon.Back.Color1 = Color.FromArgb(0, 191, 255);
            
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(78, 148, 132);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(78, 148, 132);

            kryptonButton2.StateCommon.Back.Color1 = Color.LightGray;
        }

        private void lnkAddItem_Click(object sender, EventArgs e)
        {
            kryptonLabel1.Text = lnkAddItem.StateCommon.Back.Color1.R + " " + lnkAddItem.StateCommon.Back.Color1.G + " " + lnkAddItem.StateCommon.Back.Color1.B;
            //lnkAddItem.StateCommon.Back.Color2 = Color.FromArgb(0, 191, 255);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonLabel1.Text = kryptonButton1.StateCommon.Back.Color1.R + " " + kryptonButton1.StateCommon.Back.Color1.G + " " + kryptonButton1.StateCommon.Back.Color1.B;
            
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(78, 148, 132);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(78, 148, 132);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonLabel1.Text = kryptonButton2.StateCommon.Back.Color1.R + " " + kryptonButton2.StateCommon.Back.Color1.G + " " + kryptonButton2.StateCommon.Back.Color1.B;
        }

        private void kryptonButton1_MouseEnter(object sender, EventArgs e)
        {
            kryptonLabel1.Text = kryptonButton1.StateCommon.Back.Color1.R + " " + kryptonButton1.StateCommon.Back.Color1.G + " " + kryptonButton1.StateCommon.Back.Color1.B;
        }

        private void kryptonButton2_MouseEnter(object sender, EventArgs e)
        {
            kryptonLabel1.Text = kryptonButton2.StateCommon.Back.Color1.R + " " + kryptonButton2.StateCommon.Back.Color1.G + " " + kryptonButton2.StateCommon.Back.Color1.B;
        }

        private void lnkAddItem_MouseEnter(object sender, EventArgs e)
        {
            kryptonLabel1.Text = lnkAddItem.StateCommon.Back.Color1.R + " " + lnkAddItem.StateCommon.Back.Color1.G + " " + lnkAddItem.StateCommon.Back.Color1.B;
        }

        private void kryptonButton1_MouseLeave(object sender, EventArgs e)
        {
            kryptonLabel1.Text = kryptonButton1.StateCommon.Back.Color1.R + " " + kryptonButton1.StateCommon.Back.Color1.G + " " + kryptonButton1.StateCommon.Back.Color1.B;
        }
    }
}
