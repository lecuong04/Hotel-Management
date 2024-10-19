using Hotel_Management.Models;
using Hotel_Management.Models.Extensions;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class CreateAdminForm : SfForm
    {
        DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        public CreateAdminForm()
        {
            InitializeComponent();
        }

        private void CreateAdminForm_Load(object sender, EventArgs e)
        {
            cboGender.DataSource = new List<string>() { "Nam", "Nữ" };
            cboGender.SelectedIndex = 0;
            DateTime tmp = DateTime.Now;
            dDoB.MaxDateTime = new DateTime(tmp.Year - 18, tmp.Month, tmp.Day);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string data = txtPhone.Text;
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
                txtPhone.Text = tmp;
                txtPhone.SelectionStart = tmp.Length;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (!(e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }

        private void dDoB_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            if (e.NewValue.HasValue)
            {
                if (DateTime.Now.Subtract(e.NewValue.Value).TotalDays < 6574)
                {
                    DateTime tmp = DateTime.Now;
                    dDoB.Value = new DateTime(tmp.Year - 18, tmp.Month, tmp.Day);
                }
            }
        }

        private void txtUniqueNumber_TextChanged(object sender, EventArgs e)
        {
            string data = txtUniqueNumber.Text;
            if (!Regex.IsMatch(data, "^[0-9]{0,12}$"))
            {
                string tmp = string.Empty;
                for (int i = 0; i < data.Length; i++)
                {
                    if (Regex.IsMatch(data[i].ToString(), "[0-9]"))
                        tmp += data[i];
                }
                txtUniqueNumber.Text = tmp;
                txtUniqueNumber.SelectionStart = tmp.Length;
            }
        }

        private void txtUniqueNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            string rePass = txtRepeatPassword.Text;
            if (pass.Equals(rePass, StringComparison.Ordinal))
            {
                List<string> errors = new List<string>();

                string fullName = Regex.Replace(Regex.Replace(txtFullName.Text, "\\s+", " ").Trim(), @"\b([a-z])", m => m.Value.ToUpper());
                string phone = txtPhone.Text;
                string uniqueNumber = txtUniqueNumber.Text;
                string address = txtAddress.Text;
                string gender = cboGender.SelectedItem.ToString();
                string position = txtPosition.Text;
                DateTime dob = dDoB.Value.Value;

                if (fullName.Length < 3)
                    errors.Add("Họ tên tối thiểu 3 kí tự!");
                if (phone.Length < 10)
                    errors.Add("Số điện thoại không hợp lệ!");
                if (uniqueNumber.Length < 12)
                    errors.Add("Số căn cước không hợp lệ!");
                if (gender != "Nam" && gender != "Nữ")
                    errors.Add("Vui lòng chọn giới tính!");
                if (address.Length == 0)
                    errors.Add("Địa chỉ không được để trống!");
                if (position.Length == 0)
                    errors.Add("Chức vụ không được để trống!");

                if (errors.Count == 0)
                {
                    DateTime now = DateTime.Now;
                    Employee empl = db.AddRow(new Employee()
                    {
                        Name = fullName,
                        Address = address,
                        Gender = gender,
                        Phone = phone,
                        UniqueNumber = uniqueNumber,
                        Position = position,
                        DoB = dob,
                        DoW = now
                    });
                    if (empl.Id > 0)
                    {
                        db.AddRow(new Account()
                        {
                            CreatedAt = now,
                            IsActive = true,
                            Password = BCrypt.Net.BCrypt.HashPassword(pass),
                            PasswordUpdatedAt = now,
                            Role = "Quản trị viên",
                            Employee = empl.Id,
                        });
                        Close();
                    }
                }
                else
                    MessageBox.Show(string.Join("\n", errors), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CreateAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
