using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apotek_app
{
    public partial class Transaction : Form
    {
        private readonly string username;
        private readonly string invoiceFormatted;
        private readonly DateTime dateTime;

        private static SqlCommand command;

        private readonly Connection connect = new();
        int priceValue, totalPrice, amounts, moneyChanges, qty = 0;
        string product, code_Product;

        List<TransactionDetail> details = [];

        public Transaction(string username, string invoiceFormatted, DateTime dateTime)
        {
            InitializeComponent();
            this.username = username;
            this.invoiceFormatted = invoiceFormatted;
            this.dateTime = dateTime;

            operatorName.Text = username;
            noFaktur.Text = invoiceFormatted;

            string date = dateTime.ToString("D");
            dateFaktur.Text = date;

            saveTransaction.Enabled = false;
            addProduct.Enabled = false;
            cancelProduct.Enabled = false;

            FillComboBox();

            ColumnsToDataGridView();
        }

        private void codeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = connect.GetSqlConnection();

            try
            {
                connection.Open();
                command = new SqlCommand("SELECT * FROM mst_product WHERE code = @selectedCode", connection);
                command.Parameters.AddWithValue("@selectedCode", codeProduct.Text);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    code_Product = dataReader.GetString(1);
                    product = dataReader.GetString(2);
                    string price = dataReader.GetDecimal(3).ToString();
                    priceValue = int.Parse(price.Replace(",00", ""));

                    productName.Text = product;
                    productPrice.Text = priceValue.ToString();
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void quantity_TextChanged(object sender, EventArgs e)
        {
            qty = int.Parse(quantity.Text != "" ? quantity.Text : "0");
            subTotal.Text = (qty * priceValue).ToString();

            addProduct.Enabled = true;
            cancelProduct.Enabled = true;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            TransactionDetail newDetails = new TransactionDetail
            {
                Id = details.Count + 1,
                Code_Product = code_Product,
                Product_Name = product,
                Quantity = qty,
                Sub_Total = (qty * priceValue)
            };

            details.Add(newDetails);

            totalPrice += newDetails.Sub_Total;
            total.Text = totalPrice.ToString();

            viewProduct.Rows.Add(newDetails.Id, newDetails.Code_Product, newDetails.Product_Name, newDetails.Quantity, newDetails.Sub_Total);

            HandleReset();
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            amounts = string.IsNullOrEmpty(amount.Text) ? 0 : int.Parse(amount.Text);
            moneyChanges = amounts - totalPrice;
            moneyChange.Text = (moneyChanges >= 0 ? moneyChanges : 0).ToString();

            if(moneyChanges < 0) 
            { 
                saveTransaction.Enabled = false;
            }
            else
            {
                saveTransaction.Enabled = true;
            }
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            HandleReset();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTransaction_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connect.GetSqlConnection();
            try
            {
                connection.Open();
                command = new SqlCommand("SELECT id FROM mst_user WHERE username=@username", connection);
                command.Parameters.AddWithValue("@username", username);
                int operatorID = Convert.ToInt32(command.ExecuteScalar());

                for (int i = 0; i < details.Count; i++)
                {
                    TransactionDetail detail = details[i];

                    SqlCommand productCommand = new SqlCommand("SELECT id FROM mst_product WHERE code=@productCode", connection);
                    productCommand.Parameters.AddWithValue("@productCode", detail.Code_Product);
                    int productID = Convert.ToInt32(productCommand.ExecuteScalar());

                    detail.Product_ID = productID;
                }

                Transactions transactions = new Transactions
                {
                    Transaction_Date = dateTime,
                    Invoice_Number = invoiceFormatted,
                    Operator_Id = operatorID
                };

                save(transactions, details);
                MessageBox.Show("Data Berhasil Ditambahkan");

                ListTransaction listTransactionPage = new ListTransaction(username);
                this.Hide();
                listTransactionPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void FillComboBox()
        {
            SqlConnection connection = connect.GetSqlConnection();

            try
            {
                connection.Open();
                codeProduct.Items.Clear();
                command = new SqlCommand("SELECT * FROM mst_product", connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string code = dataReader.GetString(1);
                    codeProduct.Items.Add(code);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ColumnsToDataGridView()
        {
            viewProduct.Columns.Add("Id", "No");
            viewProduct.Columns.Add("CodeProduct", "BarangID");
            viewProduct.Columns.Add("ProductName", "Nama");
            viewProduct.Columns.Add("Quantity", "JmlBeli");
            viewProduct.Columns.Add("SubTotal", "SubTotal");

            foreach (DataGridViewColumn column in viewProduct.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void HandleReset()
        {
            codeProduct.SelectedIndex = -1;
            productName.Text = "";
            productPrice.Text = "";
            quantity.Text = "";
            subTotal.Text = "";
            addProduct.Enabled = false;
            cancelProduct.Enabled = false;
        }

        private void save(Transactions transaction, List<TransactionDetail> transactionDetails)
        {
            SqlConnection connection = null;
            try
            {
                connection = connect.GetSqlConnection();
                connection.Open();

                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO trx_transaction (transaction_date, invoice_number, operator_id) VALUES (@transactionDate, @invoiceNumber, @operatorID); SELECT SCOPE_IDENTITY();", connection, trans);
                        command.Parameters.AddWithValue("@transactionDate", transaction.Transaction_Date);
                        command.Parameters.AddWithValue("@invoiceNumber", transaction.Invoice_Number);
                        command.Parameters.AddWithValue("@operatorID", transaction.Operator_Id);
                        int transactionID = Convert.ToInt32(command.ExecuteScalar());

                        foreach (TransactionDetail data in transactionDetails)
                        {
                            SqlCommand detailCommand = new SqlCommand("INSERT INTO trx_transaction_detail (transaction_id, product_id, quantity, sub_total) VALUES (@transactionID, @productID, @quantity, @subTotal)", connection, trans);
                            detailCommand.Parameters.AddWithValue("@transactionID", transactionID);
                            detailCommand.Parameters.AddWithValue("@productID", data.Product_ID);
                            detailCommand.Parameters.AddWithValue("@quantity", data.Quantity);
                            detailCommand.Parameters.AddWithValue("@subTotal", data.Sub_Total);
                            detailCommand.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
