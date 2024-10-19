using Hotel_Management.Models;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;

namespace Hotel_Management.Pages
{
    public partial class EmployeePage : SfForm
    {
        DbContext db;

        public EmployeePage(DbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Id", HeaderText = "Mã nhân viên" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Name", HeaderText = "Họ tên" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "DoB", HeaderText = "Ngày sinh", Format = "dd-MM-yyyy" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Phone", HeaderText = "Số điện thoại" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "UniqueNumber", HeaderText = "Mã căn cước" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Address", HeaderText = "Địa chỉ" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Gender", HeaderText = "Giới tính" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Position", HeaderText = "Chức vụ" });
            employeeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "DoW", HeaderText = "Ngày vào làm", Format = "dd-MM-yyyy" });
        }

        private void listPage_Enter(object sender, EventArgs e)
        {
            employeeDataGrid.DataSource = db.GetTable<Employee>();
        }
    }
}
