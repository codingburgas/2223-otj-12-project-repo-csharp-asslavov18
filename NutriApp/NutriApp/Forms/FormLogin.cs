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
using System.Collections;

namespace NutriApp.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dbNutriApp;Integrated Security=True;MultipleActiveResultSets=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Users WHERE username = '" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                new FormMainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            con.Close();
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkBoxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
