using Hotel_Management.Contexts;
using Hotel_Management.Models;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class LoginForm : SfForm
    {
        BannerTextProvider watermark = new BannerTextProvider();

        Account user;
        public Account User { get => user; }

        public LoginForm()
        {
            InitializeComponent();
            watermark.SetBannerText(txtUsername, new BannerTextInfo() { Text = "CCCD", Mode = BannerTextMode.EditMode, Visible = true });
            watermark.SetBannerText(txtPassword, new BannerTextInfo() { Text = "Mật khẩu", Mode = BannerTextMode.EditMode, Visible = true });
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            TextBoxExt c = sender as TextBoxExt;
            if (c != null)
            {
                c.BorderColor = SystemColors.ActiveBorder;
                string text = c.Text;
                if (!Regex.IsMatch(text, "^[a-z0-9]+$"))
                {
                    string temp = string.Empty;
                    foreach (char ch in text)
                    {
                        if (Regex.IsMatch(ch.ToString(), "^[a-z0-9]$"))
                            temp += ch;
                    }
                    c.Text = temp;
                    c.SelectionStart = temp.Length;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // CCCD
            string password = txtPassword.Text;
            if (username.Length != 0 && password.Length != 0)
            {
                DbContext db = new DbContext();
                db.UseConfigurationManager("DefaultConnection");
                int count = db.GetTable<Account>().Count();
                if (count == 0)
                {
                    // Nếu rỗng thì tạo bảng Nhân viên và Tài khoản cho Admin
                    // Tạo Account nhớ hash password trc khi đưa vào db
                    // Code: BCrypt.Net.BCrypt.HashPassword(password);
                    if (username.Equals("root") && password.Equals("root"))
                    {
                        //TODO: Làm form này đi
                        var temp = new CreateAdminForm()
                        {
                            ShowInTaskbar = false,
                        };
                        temp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    Employee empl = db.GetTable<Employee>(x => x.UniqueNumber.Equals(username)).FirstOrDefault();
                    if (empl == null)
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Account acc = db.GetTable<Account>(x => x.Employee == empl.Id).FirstOrDefault();
                    if (acc == null)
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // Kiểm tra mật khẩu, trùng hash thì gán dữ liệu và thoát form để chuyển qua form khác đc khai báo ở Program.cs
                    if (BCrypt.Net.BCrypt.Verify(password, acc.Password))
                    {
                        user = acc;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
            }
            else
            {
                if (password.Length == 0)
                {
                    txtPassword.BorderColor = Color.Red;
                    txtPassword.Focus();
                }
                if (username.Length == 0)
                {
                    txtUsername.BorderColor = Color.Red;
                    txtUsername.Focus();
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBoxExt c = sender as TextBoxExt;
            if (c != null)
                c.BorderColor = SystemColors.ActiveBorder;
        }
    }
}
