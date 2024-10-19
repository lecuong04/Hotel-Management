using Hotel_Management.Models;
using Hotel_Management.Pages;
using Syncfusion.WinForms.Controls;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class MainForm : SfForm
    {
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
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
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
        }

        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void MainForm_Deactivate(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            roomPage.Close();
            customerPage.Close();
            reservationPage.Close();
            employeePage.Close();
            accountPage.Close();
        }
    }
}
