using Hotel_Management.Forms;
using Hotel_Management.Models;
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
            LoginForm login = new LoginForm();
            Application.Run(login);
            Account account = login.User;
            if (account.Role == "Quản trị viên")
            {
                // TODO: Làm form này đi
                Application.Run(new AdminForm(account)); // Form cho quản trị viên
            }
            else
            {
                // TODO: Làm form này đi
                Application.Run(new EmployeeForm(account)); // Form cho nhân viên
            }
        }
    }
}
