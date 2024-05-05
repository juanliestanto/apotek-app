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

    public partial class ListTransaction : Form
    {
        private static SqlCommand command;

        private readonly Connection connect = new();

        private readonly string username;
        public ListTransaction(string username)
        {
            InitializeComponent();
            this.username = username;

            GridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connect.GetSqlConnection();

            try
            {
                connection.Open();
                command = new SqlCommand("SELECT MAX(CAST(SUBSTRING(invoice_number, 2, LEN(invoice_number) - 1) AS INT)) FROM trx_transaction", connection);
                command.ExecuteNonQuery();
                object result = command.ExecuteScalar();
                int invoiceNumber = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                int countInvoiceNumber = invoiceNumber + 1;
                string invoiceFormatted = "F" + countInvoiceNumber.ToString().PadLeft(4, '0'); ;

                DateTime dateTime = DateTime.Now;

                Transaction transaction = new(username, invoiceFormatted, dateTime);
                this.Hide();
                transaction.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridView()
        {
            SqlConnection connection = connect.GetSqlConnection();
            try
            {
                connection.Open();
                command = new SqlCommand("SELECT t.transaction_date, t.invoice_number, u.username FROM trx_transaction t JOIN mst_user u ON u.id = t.operator_id", connection);
                SqlDataReader dataReader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Transaction Date", typeof(DateTime));
                dataTable.Columns.Add("No Faktur", typeof(string));
                dataTable.Columns.Add("Operator", typeof(string));

                while (dataReader.Read()){
                    dataTable.Rows.Add(dataReader.GetDateTime(0), dataReader.GetString(1), dataReader.GetString(2));
                }

                transactionList.DataSource = dataTable;

                foreach (DataGridViewColumn column in transactionList.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
