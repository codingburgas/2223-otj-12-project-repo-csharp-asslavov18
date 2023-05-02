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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
            lblCurrentDateProg.Text = FormMainMenu.FormMainMenuInstance.currentDate;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dbNutriApp;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string user = FormMainMenu.FormMainMenuInstance.currentUser;
            string date = txtDate.Text;
            string query = "SELECT * FROM UserFood WHERE username = '" + user + "' and date='" + date + "'";
            string query2 = "SELECT * FROM UserExcercises WHERE username = '" + user + "' and date='" + date + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            txtGridData.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtGridData.AppendText(reader.GetString(0)+" consumed FoodID = ");
                    txtGridData.AppendText(reader.GetInt32(2).ToString() + " on ");
                    txtGridData.AppendText(reader.GetDateTime(1).ToString().Substring(0,9));
                    
                    txtGridData.AppendText(" Servings: "+reader.GetInt32(3).ToString());
                    txtGridData.AppendText(" Calories gained: "+reader.GetInt32(4).ToString()+"\n");
                }
            }
            
            
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    txtGridData.AppendText(reader2.GetString(0) + " exercised ExerciseID = ");
                    txtGridData.AppendText(reader2.GetInt32(2).ToString() + " on ");
                    txtGridData.AppendText(reader2.GetDateTime(1).ToString().Substring(0,9));

                    txtGridData.AppendText(" Repetitions: " + reader2.GetInt32(3).ToString());
                    txtGridData.AppendText(" Calories burned: " + reader2.GetInt32(4).ToString() + "\n");
                }
            }
            else if(reader2.HasRows==false && reader.HasRows==false)
            {
                MessageBox.Show("Invalid Date, Please Try Again", "Data Showcase Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDate.Clear();
                txtDate.Focus();
            }
            reader2.Close();
            reader.Close();


            con.Close();
        }
    }
}
