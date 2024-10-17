using Hotel_Management.Models;
using Hotel_Management.Pages;
using Syncfusion.WinForms.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class MainForm : SfForm
    {
        static DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        RoomPage roomPage = new RoomPage(db);
        CustomerPage customerPage = new CustomerPage(db);
        ReservationPage reservationPage = new ReservationPage(db);

        Account account;

        public MainForm(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.SetBevel(false);
            tabbedMDI.TabControlAdded += TabbedMDI_TabControlAdded;

            roomPage.MdiParent = this;
            roomPage.Show();

            customerPage.MdiParent = this;
            customerPage.Show();

            reservationPage.MdiParent = this;
            reservationPage.Show();

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = SystemColors.Window;
                }
            }
        }

        private void TabbedMDI_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            args.TabControl.Alignment = TabAlignment.Left;
            args.TabControl.RotateTextWhenVertical = true;
        }
    }
}
