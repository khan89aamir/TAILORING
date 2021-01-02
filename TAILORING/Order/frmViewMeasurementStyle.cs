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

        Image Pending = TAILORING.Properties.Resources.bulet;
        Image Done = TAILORING.Properties.Resources.tick;

        public bool IsEdit = false;
        public int pOrderID = 0;
        int GarmentID = 0, StyleID = 0;

        private void frmViewMeasurementStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
