using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.Forms
{
    public partial class Date : Form
    {
        public static Date DateFormInstance;
        public Label lblDate;
        public Date()
        {
            InitializeComponent();
            lblCurrentDate.Text = FormMainMenu.FormMainMenuInstance.currentDate;
            lblDate = lblCurrentDate;
            DateFormInstance = this;
            //Exercise.ExerciseFormInstance.lblCurrentDate= lblDate;
            //lblCurrentDate.Text = DateTime.Now.ToString();


        }

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            lblCurrentDate.Text = txtChangeDate.Text;
            FormMainMenu.FormMainMenuInstance.currentDate=txtChangeDate.Text;
            txtChangeDate.Clear();
        }
    }
}
