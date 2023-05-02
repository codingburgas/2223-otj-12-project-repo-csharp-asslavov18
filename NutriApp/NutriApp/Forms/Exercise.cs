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
    public partial class Exercise : Form
    {
        public static Exercise ExerciseFormInstance;
        public Label lblCurrentDate;
        public Exercise()
        {
            InitializeComponent();
            ExerciseFormInstance = this;

            lblCurrentDateEx.Text = FormMainMenu.FormMainMenuInstance.currentDate;
            
            //this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}
    }
}
