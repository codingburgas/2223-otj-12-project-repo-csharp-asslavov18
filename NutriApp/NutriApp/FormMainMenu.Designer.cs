namespace NutriApp
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnDate = new Button();
            btnAccount = new Button();
            btnProgress = new Button();
            btnFood = new Button();
            btnExercise = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnDate);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnProgress);
            panelMenu.Controls.Add(btnFood);
            panelMenu.Controls.Add(btnExercise);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnDate
            // 
            btnDate.Dock = DockStyle.Top;
            btnDate.FlatAppearance.BorderSize = 0;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.ForeColor = Color.Gainsboro;
            btnDate.Image = Properties.Resources.date_icon_smaller;
            btnDate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDate.Location = new Point(0, 320);
            btnDate.Name = "btnDate";
            btnDate.Padding = new Padding(12, 0, 0, 0);
            btnDate.Size = new Size(220, 60);
            btnDate.TabIndex = 5;
            btnDate.Text = "Date Selector";
            btnDate.TextAlign = ContentAlignment.MiddleLeft;
            btnDate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnDate_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.ForeColor = Color.Gainsboro;
            btnAccount.Image = Properties.Resources.account_smaller;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 260);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(12, 0, 0, 0);
            btnAccount.Size = new Size(220, 60);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "  Manage Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnProgress
            // 
            btnProgress.Dock = DockStyle.Top;
            btnProgress.FlatAppearance.BorderSize = 0;
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.ForeColor = Color.Gainsboro;
            btnProgress.Image = Properties.Resources.smaller_progress;
            btnProgress.ImageAlign = ContentAlignment.MiddleLeft;
            btnProgress.Location = new Point(0, 200);
            btnProgress.Name = "btnProgress";
            btnProgress.Padding = new Padding(12, 0, 0, 0);
            btnProgress.Size = new Size(220, 60);
            btnProgress.TabIndex = 3;
            btnProgress.Text = "  Progress";
            btnProgress.TextAlign = ContentAlignment.MiddleLeft;
            btnProgress.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click;
            // 
            // btnFood
            // 
            btnFood.Dock = DockStyle.Top;
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.ForeColor = Color.Gainsboro;
            btnFood.Image = Properties.Resources.small_burger;
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(0, 140);
            btnFood.Name = "btnFood";
            btnFood.Padding = new Padding(12, 0, 0, 0);
            btnFood.Size = new Size(220, 60);
            btnFood.TabIndex = 2;
            btnFood.Text = "  Consume Food";
            btnFood.TextAlign = ContentAlignment.MiddleLeft;
            btnFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnExercise
            // 
            btnExercise.BackgroundImageLayout = ImageLayout.Center;
            btnExercise.Dock = DockStyle.Top;
            btnExercise.FlatAppearance.BorderSize = 0;
            btnExercise.FlatStyle = FlatStyle.Flat;
            btnExercise.ForeColor = Color.Gainsboro;
            btnExercise.Image = Properties.Resources.dumbell_4_91;
            btnExercise.ImageAlign = ContentAlignment.MiddleLeft;
            btnExercise.Location = new Point(0, 80);
            btnExercise.Name = "btnExercise";
            btnExercise.Padding = new Padding(12, 0, 0, 0);
            btnExercise.Size = new Size(220, 60);
            btnExercise.TabIndex = 1;
            btnExercise.Text = "  Exercise";
            btnExercise.TextAlign = ContentAlignment.MiddleLeft;
            btnExercise.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExercise.UseVisualStyleBackColor = true;
            btnExercise.Click += btnExercise_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(580, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(214, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nutri App";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = " ";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnDate;
        private Button btnAccount;
        private Button btnProgress;
        private Button btnFood;
        private Button btnExercise;
        private Panel panelTitleBar;
        private Label lblTitle;
    }
}