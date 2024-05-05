using Microsoft.Data.SqlClient;

namespace apotek_app
{
    public partial class SignInForm : Form
    {

        private readonly Connection connect = new();

        public SignInForm()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void signin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connect.GetSqlConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM mst_user WHERE username=@username AND password=@password", connection);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.ExecuteNonQuery();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    this.Hide();
                    ListTransaction listTransaction = new(dataReader[1].ToString().ToUpper());
                    listTransaction.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            this.Hide();
            register.ShowDialog();
        }
    }
}
