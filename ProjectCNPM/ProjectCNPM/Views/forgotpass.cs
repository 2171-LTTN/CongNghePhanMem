using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCNPM.Models;

namespace ProjectCNPM
{
    public partial class ForgotPass : Form
    {
        private string generatedOTP = "";
        private DateTime otpGeneratedTime;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Subtract(otpGeneratedTime).TotalMinutes > 5)
            {
                MessageBox.Show("Mã OTP đã hết hạn. Vui lòng yêu cầu gửi lại mã mới.");
                return;
            }

            // Kiểm tra nếu OTP nhập vào khớp với OTP đã gửi
            if (tb_OTPCode.Text == generatedOTP)
            {
                MessageBox.Show("Mã OTP đúng! Bạn có thể tiếp tục.");

                // Tiếp tục chuyển đến form đổi mật khẩu
                ResetPass f = new ResetPass(tb_Email.Text);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác. Vui lòng thử lại.");
            }
            
        }

        private void btn_GuiMaOTP_Click(object sender, EventArgs e)
        {
            // Kiểm tra email textbox có đang trống ? 
            string email = tb_Email.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email!");
                return;
            }

            // Kiểm tra email có tồn tại trong CSDL ? 
            using (var db = new DBContext())
            {
                var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.email == email);
                if (taiKhoan == null)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống.");
                    return;
                }

                // Tạo OTP ngẫu nhiên (6 chữ số) và lưu thời điểm tạo
                Random random = new Random();
                generatedOTP = random.Next(100000, 999999).ToString();
                otpGeneratedTime = DateTime.Now;

                // Gửi OTP
                SendOTPEmail(email, generatedOTP);
                MessageBox.Show("Mã OTP đã được gửi tới email của bạn.");
            }
        }


        private void SendOTPEmail(string email, string otpCode)
        {
            email = tb_Email.Text;
            try
            {
                // Cấu hình SMTP của Gmail
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("adcuimia@gmail.com", "eonj anbq bllw zmqi"), // Email của người gửi và App Password in Gmail
                    EnableSsl = true,
                };

                // Tạo email để gửi
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("adcuimia@gmail.com"), 
                    Subject = "Mã OTP của bạn",
                    Body = "Mã OTP: " + otpCode,  // Nội dung của email
                    IsBodyHtml = false,  // Không sử dụng HTML cho nội dung
                };

                mailMessage.To.Add(email);  // Địa chỉ email người nhận

                // Gửi email
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email: " + ex.Message);
            }
        }

    }
}
