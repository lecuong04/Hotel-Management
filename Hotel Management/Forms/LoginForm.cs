using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Hotel_Management.Forms
{
    public partial class LoginForm : SfForm
    {
        BannerTextProvider watermark = new BannerTextProvider();

        public LoginForm()
        {
            InitializeComponent();

            watermark.SetBannerText(txtUsername, new BannerTextInfo() { Text = "Tên đăng nhập", Mode = BannerTextMode.EditMode, Visible = true });
            watermark.SetBannerText(txtPassword, new BannerTextInfo() { Text = "Mật khẩu", Mode = BannerTextMode.EditMode, Visible = true });
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            TextBoxExt c = sender as TextBoxExt;
            if (c != null)
            {
                c.BorderColor = Color.Black;
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Length != 0 && password.Length != 0)
            {

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
                c.BorderColor = Color.Black;
        }
    }
}
