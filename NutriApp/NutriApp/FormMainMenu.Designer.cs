namespace NutriApp
{
    public partial class FormMainMenu
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
            panelDesktopPane = new Panel();
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
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 338);
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
            btnDate.Location = new Point(0, 277);
            btnDate.Margin = new Padding(3, 2, 3, 2);
            btnDate.Name = "btnDate";
            btnDate.Padding = new Padding(10, 0, 0, 0);
            btnDate.Size = new Size(192, 52);
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
            btnAccount.Location = new Point(0, 221);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 0, 0);
            btnAccount.Size = new Size(192, 56);
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
            btnProgress.Location = new Point(0, 167);
            btnProgress.Margin = new Padding(3, 2, 3, 2);
            btnProgress.Name = "btnProgress";
            btnProgress.Padding = new Padding(10, 0, 0, 0);
            btnProgress.Size = new Size(192, 54);
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
            btnFood.Location = new Point(0, 113);
            btnFood.Margin = new Padding(3, 2, 3, 2);
            btnFood.Name = "btnFood";
            btnFood.Padding = new Padding(10, 0, 0, 0);
            btnFood.Size = new Size(192, 54);
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
            btnExercise.Location = new Point(0, 60);
            btnExercise.Margin = new Padding(3, 2, 3, 2);
            btnExercise.Name = "btnExercise";
            btnExercise.Padding = new Padding(10, 0, 0, 0);
            btnExercise.Size = new Size(192, 53);
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
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(192, 60);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(508, 60);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(187, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nutri App";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(192, 60);
            panelDesktopPane.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(508, 278);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
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
        private Panel panelDesktopPane;
    }
}