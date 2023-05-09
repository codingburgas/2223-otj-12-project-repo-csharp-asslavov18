namespace NutriApp.Forms
{
    partial class Progress
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
            components = new System.ComponentModel.Container();
            label5 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDate = new TextBox();
            label2 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            txtGridData = new RichTextBox();
            btnShowData = new Button();
            lblCurrentDateProg = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(750, 27);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 14;
            label5.Text = "Manage Progress";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 123);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 15;
            label1.Text = "Select Date:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(436, 122);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(178, 26);
            txtDate.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(474, 93);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 18;
            label2.Text = "YYYY-MM-DD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // txtGridData
            // 
            txtGridData.Location = new Point(238, 215);
            txtGridData.Name = "txtGridData";
            txtGridData.Size = new Size(742, 232);
            txtGridData.TabIndex = 21;
            txtGridData.Text = "";
            // 
            // btnShowData
            // 
            btnShowData.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowData.Location = new Point(1068, 115);
            btnShowData.Name = "btnShowData";
            btnShowData.Size = new Size(105, 45);
            btnShowData.TabIndex = 30;
            btnShowData.Text = "Show Data";
            btnShowData.UseVisualStyleBackColor = true;
            btnShowData.Click += btnShowData_Click;
            // 
            // lblCurrentDateProg
            // 
            lblCurrentDateProg.AutoSize = true;
            lblCurrentDateProg.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentDateProg.Location = new Point(1240, 515);
            lblCurrentDateProg.Name = "lblCurrentDateProg";
            lblCurrentDateProg.Size = new Size(41, 20);
            lblCurrentDateProg.TabIndex = 33;
            lblCurrentDateProg.Text = "date";
            lblCurrentDateProg.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1106, 515);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 32;
            label12.Text = "Current Date:";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // Progress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 651);
            Controls.Add(lblCurrentDateProg);
            Controls.Add(label12);
            Controls.Add(btnShowData);
            Controls.Add(txtGridData);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Progress";
            Text = "Progress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDate;
        private Label label2;
        private ContextMenuStrip contextMenuStrip2;
        private RichTextBox txtGridData;
        private Button btnShowData;
        private Label lblCurrentDateProg;
        private Label label12;
    }
}