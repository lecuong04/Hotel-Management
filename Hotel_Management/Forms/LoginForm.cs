using Hotel_Management.Models;
using Hotel_Management.Models.Extensions;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class LoginForm : SfForm
    {
        DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        Account account;
        public Account Account => account;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            watermark.SetBannerText(txtUsername, new Syncfusion.Windows.Forms.BannerTextInfo() { Text = "CCCD", Visible = true, Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode });
            watermark.SetBannerText(txtPassword, new Syncfusion.Windows.Forms.BannerTextInfo() { Text = "Mật khẩu", Visible = true, Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode });
#if DEBUG
            txtUsername.Text = "031204000632";
            txtPassword.Text = "LeCuong_04";
#endif
        }

        private void txtUsername_TextChanged(object sender, System.EventArgs e)
        {
            TextBoxExt c = sender as TextBoxExt;
            if (c != null)
            {
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

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUsername.Text; // CCCD
            string password = txtPassword.Text;
            if (username.Length != 0 && password.Length != 0)
            {
                int count = db.GetTable<Employee>().Count();
                if (count > 0)
                {
                    Account curr = EmployeeExts.GetAccount(username, db);
                    if (curr != null)
                    {
                        if (BCrypt.Net.BCrypt.Verify(password, curr.Password))
                        {
                            account = curr;
                            Close();
                            return;
                        }
                    }
                    MessageBox.Show("Tài khoản không hợp lệ!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (username.Equals("root") && password.Equals("root"))
                    {
                        Hide();
                        new CreateAdminForm().ShowDialog();
                        Show();
                    }
                }
            }
        }
    }
}
