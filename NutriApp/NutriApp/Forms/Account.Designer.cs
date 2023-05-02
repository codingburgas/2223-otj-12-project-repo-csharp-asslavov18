namespace NutriApp.Forms
{
    partial class Account
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
            label5 = new Label();
            lblBackToLogin = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(755, 41);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 13;
            label5.Text = "Manage Account";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBackToLogin.ForeColor = Color.CornflowerBlue;
            lblBackToLogin.Location = new Point(744, 162);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(185, 29);
            lblBackToLogin.TabIndex = 14;
            lblBackToLogin.Text = "Back to LOGIN";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 650);
            Controls.Add(lblBackToLogin);
            Controls.Add(label5);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblBackToLogin;
    }
}