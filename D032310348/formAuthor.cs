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
    public partial class formAuthor : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public formAuthor()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void formAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.admiralBookstore.Author);
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Author";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Author");

                dataGridViewAuthor.DataSource = dataSet.Tables["Author"];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@AuthorID, @Name, @BirthYear)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", textBoxAuthor.Text);
                    command.Parameters.AddWithValue("@Name", textBoxName.Text);
                    command.Parameters.AddWithValue("@BirthYear", textBoxBirth.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxAuthor.Text) || string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxBirth.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            textBoxAuthor.Clear();
            textBoxName.Clear();
            textBoxBirth.Clear();
        }

        private void btnBookA_Click(object sender, EventArgs e)
        {
            formBookcs fBook = new formBookcs();
            fBook.Show();
            this.Hide();
        }

        private void btnStockA_Click(object sender, EventArgs e)
        {
            formStock fStock = new formStock();
            fStock.Show();
            this.Hide();
        }
    }
}


