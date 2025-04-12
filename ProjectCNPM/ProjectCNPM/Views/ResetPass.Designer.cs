namespace ProjectCNPM
{
    partial class ResetPass
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
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "New password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm password:";
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.Location = new System.Drawing.Point(288, 116);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.Size = new System.Drawing.Size(190, 22);
            this.txb_NewPassword.TabIndex = 2;
            this.txb_NewPassword.UseSystemPasswordChar = true;
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(288, 169);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(190, 22);
            this.txb_ConfirmPassword.TabIndex = 3;
            this.txb_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.Location = new System.Drawing.Point(288, 216);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(119, 29);
            this.btn_ResetPassword.TabIndex = 4;
            this.btn_ResetPassword.Text = "Reset";
            this.btn_ResetPassword.UseVisualStyleBackColor = true;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 333);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPass";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_NewPassword;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Button btn_ResetPassword;
    }
}