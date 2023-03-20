namespace NutriApp
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random(); 
        }
        //Methods


        //Selects a random color for the button theme
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        //When a button is pressed the background becomes the random color
        //And the text becomes white
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }








        private void btnExercise_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}