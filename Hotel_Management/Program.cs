using Hotel_Management.Forms;
using Hotel_Management.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("vi-VN");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU4NUAzMjM3MkUzMTJFMzluT08wbzRnYm4zUlFDOVRzWVpYbUtuSEl0aUhTZmNMYjQxekhrV0NVRnlzPQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            Account account = loginForm.Account;
            if (account != null)
                Application.Run(new MainForm(account));
        }
    }
}
