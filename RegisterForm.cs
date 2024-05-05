using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_app
{
    public partial class RegisterForm : Form
    {
        private static readonly Connection connect = new();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connect.GetSqlConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO mst_user (username, password) VALUES (@username, @password)", connection);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.ExecuteNonQuery();
               
                MessageBox.Show("Register Successfully");
                connection.Close();

                goToSignIn();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            goToSignIn();
        }

        private void goToSignIn() 
        {
            SignInForm signIn = new SignInForm();

            this.Hide();
            signIn.ShowDialog();
        }
    }
}
