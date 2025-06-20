using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D032310348
{
    public partial class formStock : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public formStock()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void formStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.admiralBookstore.Stock);
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Stock";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Stock");

                dataGridViewStock.DataSource = dataSet.Tables["Stock"];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxStock.Text))
            {
                string query = "DELETE FROM Stock WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", textBoxStock.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please enter a StockID to delete.");
            }
        }

        private void ClearInputs()
        {
            textBoxStock.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxQuantity.Clear();
        }

        private void btnAuthorS_Click(object sender, EventArgs e)
        {
            formAuthor fAuthor = new formAuthor();
            fAuthor.Show();
            this.Hide();
        }

        private void btnBookS_Click(object sender, EventArgs e)
        {
            formBookcs fBook = new formBookcs();
            fBook.Show();
            this.Hide();
        }
    }
}
