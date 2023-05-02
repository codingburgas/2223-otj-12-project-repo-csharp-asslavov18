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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();

            lblCurrentDateFood.Text = FormMainMenu.FormMainMenuInstance.currentDate;
        }


        private void btnInsertData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dbNutriApp;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string user = FormMainMenu.FormMainMenuInstance.currentUser;
            string date = FormMainMenu.FormMainMenuInstance.currentDate;
            if (txtMusaka.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "1" + "','" + txtMusaka.Text + "','" + (Int32.Parse(txtMusaka.Text) * 450).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtMusaka.Clear();
            }

            if (txtChicken.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "2" + "','" + txtChicken.Text + "','" + (Int32.Parse(txtChicken.Text) * 400).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtChicken.Clear();
            }

            if (txtVeggie.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "3" + "','" + txtVeggie.Text + "','" + (Int32.Parse(txtVeggie.Text) * 380).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtVeggie.Clear();
            }

            if (txtBeef.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "4" + "','" + txtBeef.Text + "','" + (Int32.Parse(txtBeef.Text) * 390).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtBeef.Clear();
            }

            if (txtOmlette.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "5" + "','" + txtOmlette.Text + "','" + (Int32.Parse(txtOmlette.Text) * 420).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtOmlette.Clear();
            }

            if (txtLasagna.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "6" + "','" + txtLasagna.Text + "','" + (Int32.Parse(txtLasagna.Text) * 550).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtLasagna.Clear();
            }

            if (txtYogurt.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "7" + "','" + txtYogurt.Text + "','" + (Int32.Parse(txtYogurt.Text) * 400).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtYogurt.Clear();
            }

            if (txtPasta.Text.Length > 0)
            {

                string query = "INSERT INTO UserFood VALUES ('" + user + "','" + date + "','"
              + "8" + "','" + txtPasta.Text + "','" + (Int32.Parse(txtPasta.Text) * 500).ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                txtPasta.Clear();
            }


            con.Close();
        }
    }
}
