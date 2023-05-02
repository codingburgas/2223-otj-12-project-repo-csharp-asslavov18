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
            //string query = "SELECT * FROM Users WHERE username = 'anton1'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            //DataTable schemaTable = reader.GetSchemaTable();
            DataTable schemaTable = reader.GetSchemaTable();
            txtGridData.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtGridData.AppendText(reader.GetString(0)+" consumed FoodID = ");
                    txtGridData.AppendText(reader.GetInt32(2).ToString() + " on ");
                    txtGridData.AppendText(reader.GetDateTime(1).ToString().Substring(9));
                    
                    txtGridData.AppendText(" Servings: "+reader.GetInt32(3).ToString());
                    txtGridData.AppendText(" Calories gained: "+reader.GetInt32(4).ToString()+"\n");
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            

            con.Close();
        }
    }
}
