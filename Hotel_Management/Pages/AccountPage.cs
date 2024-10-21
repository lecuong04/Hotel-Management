using Hotel_Management.ViewModels;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
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
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "FullName", HeaderText = "Họ tên" });
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "UniqueNumber", HeaderText = "Mã căn cước" });
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Password", HeaderText = "Mật khẩu" });
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Role", HeaderText = "Vai trò" });
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CreatedAt", HeaderText = "Ngày lập" });
            accountDataGrid.Columns.Add(new GridTextColumn() { MappingName = "IsActive", HeaderText = "Đang hoạt động" });
        }

        private void listPage_Enter(object sender, EventArgs e)
        {
            accountDataGrid.DataSource = AccountViewModel.GetAccounts(db);
        }
    }
}
