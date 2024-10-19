using Syncfusion.WinForms.Controls;
using System;

namespace Hotel_Management.Pages
{
    public partial class AccountPage : SfForm
    {
        DbContext db;

        public AccountPage(DbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {

        }
    }
}
