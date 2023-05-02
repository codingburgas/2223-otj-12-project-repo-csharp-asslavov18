namespace NutriApp.Forms
{
    partial class Date
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            lblCurrentDate = new Label();
            txtChangeDate = new TextBox();
            label1 = new Label();
            btnChangeDate = new Button();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(110, 60);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 13;
            label5.Text = "Current Date:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentDate.Location = new Point(244, 60);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(93, 20);
            lblCurrentDate.TabIndex = 14;
            lblCurrentDate.Text = "2023-05-23";
            lblCurrentDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtChangeDate
            // 
            txtChangeDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChangeDate.Location = new Point(244, 112);
            txtChangeDate.Name = "txtChangeDate";
            txtChangeDate.Size = new Size(100, 26);
            txtChangeDate.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 115);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 16;
            label1.Text = "Change Date:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnChangeDate
            // 
            btnChangeDate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeDate.Location = new Point(399, 112);
            btnChangeDate.Name = "btnChangeDate";
            btnChangeDate.Size = new Size(75, 23);
            btnChangeDate.TabIndex = 17;
            btnChangeDate.Text = "OK";
            btnChangeDate.UseVisualStyleBackColor = true;
            btnChangeDate.Click += btnChangeDate_Click;
            // 
            // Date
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeDate);
            Controls.Add(label1);
            Controls.Add(txtChangeDate);
            Controls.Add(lblCurrentDate);
            Controls.Add(label5);
            Name = "Date";
            Text = "Date";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private Label lblCurrentDate;
        private TextBox txtChangeDate;
        private Label label1;
        private Button btnChangeDate;
    }
}