using Hotel_Management.Models;
using Hotel_Management.Pages;
using Syncfusion.WinForms.Controls;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace Hotel_Management.Forms
{
    public partial class MainForm : SfForm
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;

        static DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        RoomPage roomPage = new RoomPage(db);
        CustomerPage customerPage = new CustomerPage(db);
        ReservationPage reservationPage = new ReservationPage(db);
        EmployeePage employeePage = new EmployeePage(db);
        AccountPage accountPage = new AccountPage(db);

        Account account;

        public MainForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            foreach (Control c in Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.AntiqueWhite;
                    c.Dock = DockStyle.None;
                    int window = GetWindowLong(c.Handle, GWL_EXSTYLE);
                    window &= ~WS_EX_CLIENTEDGE;
                    SetWindowLong(c.Handle, GWL_EXSTYLE, window);
                    c.Dock = DockStyle.Fill;
                }
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.SetBevel(false);
            tabbedMDI.TabControlAdded += TabbedMDI_TabControlAdded;

            roomPage.MdiParent = this;
            customerPage.MdiParent = this;
            reservationPage.MdiParent = this;
            employeePage.MdiParent = this;
            accountPage.MdiParent = this;

            accountPage.Show();
            employeePage.Show();
            reservationPage.Show();
            customerPage.Show();
            roomPage.Show();
        }

        private void TabbedMDI_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            args.TabControl.Alignment = TabAlignment.Left;
            args.TabControl.RotateTextWhenVertical = true;
            args.TabControl.BorderStyle = BorderStyle.None;
        }
    }
}
