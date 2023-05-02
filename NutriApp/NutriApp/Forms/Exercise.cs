using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dbNutriApp;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string user = FormMainMenu.FormMainMenuInstance.currentUser;
            string date = FormMainMenu.FormMainMenuInstance.currentDate;
            if (txtPushUp.Text.Length > 0)
            {

                //string query = "INSERT INTO UserExcercises VALUES ( 'admin','2023-05-23','1','2','20')";

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "1" + "','" + txtPushUp.Text + "','" + (Int32.Parse(txtPushUp.Text) * 7).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtPushUp.Clear();
                con.Close();
            }
            



            //con.Close();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}
    }
}
