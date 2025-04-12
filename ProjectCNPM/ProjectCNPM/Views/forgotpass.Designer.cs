namespace ProjectCNPM
{
    partial class ForgotPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_OTPCode = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_GuiMaOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "OTP code:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(259, 71);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(195, 22);
            this.tb_Email.TabIndex = 2;
            // 
            // tb_OTPCode
            // 
            this.tb_OTPCode.Location = new System.Drawing.Point(259, 144);
            this.tb_OTPCode.Name = "tb_OTPCode";
            this.tb_OTPCode.Size = new System.Drawing.Size(195, 22);
            this.tb_OTPCode.TabIndex = 3;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(296, 186);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(102, 30);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_GuiMaOTP
            // 
            this.btn_GuiMaOTP.Location = new System.Drawing.Point(471, 69);
            this.btn_GuiMaOTP.Name = "btn_GuiMaOTP";
            this.btn_GuiMaOTP.Size = new System.Drawing.Size(98, 26);
            this.btn_GuiMaOTP.TabIndex = 6;
            this.btn_GuiMaOTP.Text = "Gửi mã OTP";
            this.btn_GuiMaOTP.UseVisualStyleBackColor = true;
            this.btn_GuiMaOTP.Click += new System.EventHandler(this.btn_GuiMaOTP_Click);
            // 
            // forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 272);
            this.Controls.Add(this.btn_GuiMaOTP);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.tb_OTPCode);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "forgot";
            this.Text = "forgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_OTPCode;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_GuiMaOTP;
    }
}