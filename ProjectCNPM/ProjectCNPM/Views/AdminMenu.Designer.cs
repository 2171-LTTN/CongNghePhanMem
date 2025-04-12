namespace ProjectCNPM.Views
{
    partial class AdminMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageReaders;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;

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
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageReaders = new System.Windows.Forms.Button();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THƯ VIỆN - MENU CHÍNH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(150, 80);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(300, 40);
            this.btnManageBooks.TabIndex = 1;
            this.btnManageBooks.Text = "📘 Quản lý sách";
            // 
            // btnManageReaders
            // 
            this.btnManageReaders.Location = new System.Drawing.Point(150, 130);
            this.btnManageReaders.Name = "btnManageReaders";
            this.btnManageReaders.Size = new System.Drawing.Size(300, 40);
            this.btnManageReaders.TabIndex = 2;
            this.btnManageReaders.Text = "👤 Quản lý độc giả";
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.Location = new System.Drawing.Point(150, 180);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Size = new System.Drawing.Size(300, 40);
            this.btnBorrowReturn.TabIndex = 3;
            this.btnBorrowReturn.Text = "📥 Mượn / Trả sách";
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(150, 230);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(300, 40);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "🧑‍💼 Quản lý nhân viên";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(150, 280);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(300, 40);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "📊 Thống kê - Báo cáo";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(150, 330);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(300, 40);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "⚙️ Cài đặt hệ thống";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "❌ Thoát";
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageReaders);
            this.Controls.Add(this.btnBorrowReturn);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện - Menu chính";
            this.ResumeLayout(false);

        }
    }
}
