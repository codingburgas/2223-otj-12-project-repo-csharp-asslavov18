namespace NutriApp.Forms
{
    partial class FormRegister
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            checkBoxShowPas = new CheckBox();
            btnRegister = new Button();
            btnClear = new Button();
            label5 = new Label();
            lblBackToLogin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(572, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 33);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(111, 133);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(111, 156);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(111, 227);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(232, 29);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(111, 204);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Location = new Point(111, 296);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '•';
            txtComPassword.Size = new Size(232, 29);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(111, 273);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBoxShowPas
            // 
            checkBoxShowPas.AutoSize = true;
            checkBoxShowPas.Cursor = Cursors.Hand;
            checkBoxShowPas.FlatStyle = FlatStyle.Flat;
            checkBoxShowPas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPas.Location = new Point(206, 339);
            checkBoxShowPas.Name = "checkBoxShowPas";
            checkBoxShowPas.Size = new Size(138, 24);
            checkBoxShowPas.TabIndex = 7;
            checkBoxShowPas.Text = "Show Password";
            checkBoxShowPas.UseVisualStyleBackColor = true;
            checkBoxShowPas.CheckedChanged += checkBoxShowPas_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CornflowerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(110, 401);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(233, 46);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.CornflowerBlue;
            btnClear.Location = new Point(111, 476);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(233, 46);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(758, 190);
            label5.Name = "label5";
            label5.Size = new Size(255, 25);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account";
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBackToLogin.ForeColor = Color.CornflowerBlue;
            lblBackToLogin.Location = new Point(798, 227);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(167, 25);
            lblBackToLogin.TabIndex = 11;
            lblBackToLogin.Text = "Back to LOGIN";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 750);
            Controls.Add(lblBackToLogin);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(checkBoxShowPas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(5);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox checkBoxShowPas;
        private Button btnRegister;
        private Button btnClear;
        private Label label5;
        private Label lblBackToLogin;
    }
}