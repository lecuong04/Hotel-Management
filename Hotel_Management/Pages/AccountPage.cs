using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

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
