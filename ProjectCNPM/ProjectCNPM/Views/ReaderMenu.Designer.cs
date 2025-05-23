﻿namespace ProjectCNPM.Views
{
    partial class ReaderMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.Button btnLichSuMuon;
        private System.Windows.Forms.Button btnThongTinCaNhan;

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
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.btnLichSuMuon = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(20, 70);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(250, 50);
            this.btnTimKiemSach.TabIndex = 1;
            this.btnTimKiemSach.Text = "Tìm kiếm sách";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            // 
            // btnLichSuMuon
            // 
            this.btnLichSuMuon.Location = new System.Drawing.Point(20, 130);
            this.btnLichSuMuon.Name = "btnLichSuMuon";
            this.btnLichSuMuon.Size = new System.Drawing.Size(250, 50);
            this.btnLichSuMuon.TabIndex = 2;
            this.btnLichSuMuon.Text = "Lịch sử mượn sách";
            this.btnLichSuMuon.UseVisualStyleBackColor = true;
            this.btnLichSuMuon.Click += new System.EventHandler(this.btnLichSuMuon_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(20, 190);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(250, 50);
            this.btnThongTinCaNhan.TabIndex = 3;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(258, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đặt Lịch Mượn Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Đánh Giá Hệ Thống";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReaderMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTimKiemSach);
            this.Controls.Add(this.btnLichSuMuon);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Name = "ReaderMenu";
            this.Text = "Menu Độc giả";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
