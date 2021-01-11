﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ServiceProcess;
using TAILORING.Order;

[assembly: SuppressIldasm]
namespace TAILORING
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Application is already running", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string myServiceName = System.Configuration.ConfigurationSettings.AppSettings["ServiceName"].ToString();
                //string myServiceName = "MSSQLSERVER"; //service name of SQL Server Express AAMIR

                if (myServiceName.Length > 0)
                {
                    string status; //service status (For example, Running or Stopped)
                    //display service status: For example, Running, Stopped, or Paused
                    ServiceController mySC = new ServiceController(myServiceName);
                    try
                    {
                        status = mySC.Status.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Service not found. It is probably not installed. [exception=" + ex.Message + "]");
                        return;
                    }
                    //display service status: For example, Running, Stopped, or Paused
                    //MessageBox.Show("Service status : " + status);

                    //if service is Stopped or StopPending, you can run it with the following code.
                    if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
                    {
                        try
                        {
                            MessageBox.Show("Starting the service...");
                            mySC.Start();
                            mySC.WaitForStatus(ServiceControllerStatus.Running);
                            MessageBox.Show("The service is now " + mySC.Status.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error in starting the service: " + ex.Message);
                        }
                    }
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
              // Application.Run(new Others.Test.Form1());
               Application.Run(new Dashboard.frmDashboardUpdate ());
               // Application.Run(new Masters.Customer_Master());
                //Application.Run(new Report.Forms.frmBill());
            }
        }
    }
}