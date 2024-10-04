using Hotel_Management.Forms;
using System;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU4NUAzMjM3MkUzMTJFMzluT08wbzRnYm4zUlFDOVRzWVpYbUtuSEl0aUhTZmNMYjQxekhrV0NVRnlzPQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
