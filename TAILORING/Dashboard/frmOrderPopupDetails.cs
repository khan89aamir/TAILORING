using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreApp;
namespace TAILORING.Dashboard
{
    public partial class frmOrderPopupDetails : KryptonForm
    {
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();
        public frmOrderPopupDetails()
        {
            InitializeComponent();
        }
        public string subOrderNo;

        private void SetDataGridviewPaletteMode(KryptonDataGridView dgv)
        {
            dgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void frmOrderPopupDetails_Load(object sender, EventArgs e)
        {
            SetDataGridviewPaletteMode(dgvOrderDetails);
        }
    }
}
