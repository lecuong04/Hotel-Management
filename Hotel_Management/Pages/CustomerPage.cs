using Hotel_Management.Models;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel_Management.Pages
{
    public partial class CustomerPage : SfForm
    {
        DbContext db;
        public CustomerPage(DbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Name", HeaderText = "Họ tên" });
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "DoB", HeaderText = "Ngày sinh", Format = "dd-MM-yyyy" });
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Gender", HeaderText = "Giới tính" });
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Phone", HeaderText = "Số điện thoại" });
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "UniqueNumber", HeaderText = "Mã định danh" });
            customerDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Quốc tịch" });
        }

        private void listPage_Enter(object sender, EventArgs e)
        {
            customerDataGrid.DataSource = db.GetTable<Customer>();
        }

        private void addPage_Enter(object sender, EventArgs e)
        {
            cboCustomerGender.DataSource = new List<string>() { "Nam", "Nữ" };
            cboCustomerGender.SelectedIndex = 0;
            cboCustomerNationaity.DataSource = Helpers.Countries;
            cboCustomerNationaity.SelectedIndex = 181;
        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            string data = txtCustomerPhone.Text;
            if (!Regex.IsMatch(data, "^0[0-9]{0,9}$") && data.Length >= 1)
            {
                string tmp = string.Empty;
                for (int i = 0; i < data.Length; i++)
                {
                    if (Regex.IsMatch(data[i].ToString(), "[0-9]"))
                    {
                        if (i == 0 && data[i] != '0')
                            tmp = '0'.ToString();
                        else
                            tmp += data[i];
                    }
                }
                txtCustomerPhone.Text = tmp;
                txtCustomerPhone.SelectionStart = tmp.Length;
            }
        }

        private void txtCustomerPhone_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (!(e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }
    }
}
