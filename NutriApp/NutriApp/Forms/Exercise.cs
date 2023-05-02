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

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "1" + "','" + txtPushUp.Text + "','" + (Int32.Parse(txtPushUp.Text) * 7).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtPushUp.Clear();
                
            }

            if (txtPullUp.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "2" + "','" + txtPullUp.Text + "','" + (Int32.Parse(txtPullUp.Text) * 9).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtPullUp.Clear();
            }

            if (txtBenchPress.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "3" + "','" + txtBenchPress.Text + "','" + (Int32.Parse(txtBenchPress.Text) * 10).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtBenchPress.Clear();
            }

            if (txtSquat.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "4" + "','" + txtSquat.Text + "','" + (Int32.Parse(txtSquat.Text) * 12).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtSquat.Clear();
            }

            if (txtShoulderPress.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "5" + "','" + txtShoulderPress.Text + "','" + (Int32.Parse(txtShoulderPress.Text) * 8).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtShoulderPress.Clear();
            }

            if (txtBiceps.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "6" + "','" + txtBiceps.Text + "','" + (Int32.Parse(txtBiceps.Text) * 8).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtBiceps.Clear();
            }

            if (txtTriceps.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "7" + "','" + txtTriceps.Text + "','" + (Int32.Parse(txtTriceps.Text) * 9).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtTriceps.Clear();
            }

            if (txtSpider.Text.Length > 0)
            {

                string query = "INSERT INTO UserExcercises VALUES ('" + user + "','" + date + "','"
              + "8" + "','" + txtSpider.Text + "','" + (Int32.Parse(txtSpider.Text) * 9).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtSpider.Clear();
            }

            MessageBox.Show("Successful data insertion, Exercise data has been stored", "Good Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            con.Close();
        }

    }
}
