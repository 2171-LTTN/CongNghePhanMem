using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCNPM.Models;

namespace ProjectCNPM
{
    public partial class ResetPass : Form
    {
        private string userEmail;

        public ResetPass(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string newPassword = txb_NewPassword.Text;
            string confirmPassword = txb_ConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu mới.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            using (var db = new DBContext())
            {
                var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.email == userEmail);
                if (taiKhoan == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản với email này.");
                    return;
                }

                taiKhoan.password = newPassword; // Nếu muốn có thể mã hóa trước khi lưu
                db.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close(); // Đóng form hoặc chuyển hướng nếu cần
            }
        }
    }
}
