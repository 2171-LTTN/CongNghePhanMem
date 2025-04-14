using ProjectCNPM.Helpers;
using ProjectCNPM.Models;
using ProjectCNPM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectCNPM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                using (var context = new DBContext())
                {
                    var user = context.TaiKhoans.FirstOrDefault(u => u.username == username && u.password == password);
                    if (user != null)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        LoginHistoryLogger loginhistorylogger = new LoginHistoryLogger("your_connection_string");
                        loginhistorylogger.LogLoginHistory(username, DateTime.Now, "127.0.0.1");
                        this.Hide();
                        ReaderMenu f = new ReaderMenu();
                        f.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass forgotForm = new ForgotPass();
            forgotForm.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();

            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
