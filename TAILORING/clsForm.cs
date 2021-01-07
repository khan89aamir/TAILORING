namespace TAILORING
{
    public class clsFormRights
    {
        public enum Forms
        {
            Customer_Master = 11,
            Product_Master = 13,
            frmProductRateMaster=16,
            Employee_Details = 14,
            frmCompanyMaster=15,
            frmGSTMaster=12,
            frmViewMeasurementStyle=13,
            Sales_Bill_Details = 23,
            Sales_Invoice = 24,
            frmSalesReport = 25,
            tblMiniSalesReport = 45,
            frmDashBoard=49,
            frmDatabaseMaintenance = 7///commented
        }
        public enum Operation
        {
            View = 1,
            Save = 2,
            Update = 3,
            Delete = 4,
            Other = 5
        }

        public static bool HasFormRight(Forms formName)
        {
            int fID = (int)formName;
            return CoreApp.clsUtility.HasFormRights(fID);
        }

        public static bool HasFormRight(Forms formName, Operation operation)
        {
            int fID = (int)formName;
            int Operation = (int)operation;

            return CoreApp.clsUtility.HasFormRights(fID, Operation);
        }
    }
}