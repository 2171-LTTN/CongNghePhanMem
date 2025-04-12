namespace ProjectCNPM.Views
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
            // ReaderMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnTimKiemSach);
            this.Controls.Add(this.btnLichSuMuon);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Name = "ReaderMenu";
            this.Text = "Menu Độc giả";
            this.ResumeLayout(false);

        }
    }
}
