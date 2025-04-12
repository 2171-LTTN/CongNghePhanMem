using System.Windows.Forms;

namespace ProjectCNPM.Views
{
    partial class ReaderInfo : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameVal = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBirthVal = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressVal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin tài khoản";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(480, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Controls.Add(this.lblNameVal);
            this.groupBoxInfo.Controls.Add(this.lblBirthDate);
            this.groupBoxInfo.Controls.Add(this.lblBirthVal);
            this.groupBoxInfo.Controls.Add(this.lblAddress);
            this.groupBoxInfo.Controls.Add(this.lblAddressVal);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Controls.Add(this.lblPhoneVal);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(25, 60);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(470, 200);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin cá nhân";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên";
            // 
            // lblNameVal
            // 
            this.lblNameVal.AutoSize = true;
            this.lblNameVal.Location = new System.Drawing.Point(150, 30);
            this.lblNameVal.Name = "lblNameVal";
            this.lblNameVal.Size = new System.Drawing.Size(123, 23);
            this.lblNameVal.TabIndex = 1;
            this.lblNameVal.Text = "Nguyễn Văn A";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(20, 60);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(100, 23);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Ngày sinh";
            // 
            // lblBirthVal
            // 
            this.lblBirthVal.AutoSize = true;
            this.lblBirthVal.Location = new System.Drawing.Point(150, 60);
            this.lblBirthVal.Name = "lblBirthVal";
            this.lblBirthVal.Size = new System.Drawing.Size(106, 23);
            this.lblBirthVal.TabIndex = 3;
            this.lblBirthVal.Text = "01/01/2000";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(20, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblAddressVal
            // 
            this.lblAddressVal.AutoSize = true;
            this.lblAddressVal.Location = new System.Drawing.Point(150, 90);
            this.lblAddressVal.Name = "lblAddressVal";
            this.lblAddressVal.Size = new System.Drawing.Size(212, 23);
            this.lblAddressVal.TabIndex = 5;
            this.lblAddressVal.Text = "123 Đường ABC, TP.HCM";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblPhoneVal
            // 
            this.lblPhoneVal.AutoSize = true;
            this.lblPhoneVal.Location = new System.Drawing.Point(150, 120);
            this.lblPhoneVal.Name = "lblPhoneVal";
            this.lblPhoneVal.Size = new System.Drawing.Size(147, 23);
            this.lblPhoneVal.TabIndex = 7;
            this.lblPhoneVal.Text = "+84 912 345 678";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(180, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "✎ Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ReaderInfo
            // 
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReaderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblName, lblNameVal;
        private System.Windows.Forms.Label lblBirthDate, lblBirthVal;
        private System.Windows.Forms.Label lblAddress, lblAddressVal;
        private System.Windows.Forms.Label lblPhone, lblPhoneVal;
        private System.Windows.Forms.Button btnUpdate;
    }
}
