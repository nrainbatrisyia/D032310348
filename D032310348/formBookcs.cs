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
    public partial class formBookcs : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public formBookcs()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void formBookcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.admiralBookstore.Book);
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\LabTest2\\D032310348\\D032310348\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Book";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Book");

                dataGridViewBook.DataSource = dataSet.Tables["Book"];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Book SET Title = @Title, Publisher = @Publisher, PublishDate = @PublishDate WHERE [ISBN-13] = @ISBN-13";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN-13", textBoxISBN.Text);
                    command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                    command.Parameters.AddWithValue("@Publisher", textBoxPublisher.Text);
                    command.Parameters.AddWithValue("@PublishDate", dateTimePickerPublish.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    //connection.//Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxISBN.Text) || string.IsNullOrEmpty(textBoxTitle.Text) ||
                string.IsNullOrEmpty(textBoxPublisher.Text) || dateTimePickerPublish.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxPublisher.Clear();
        }

        private void btnAuthorB_Click(object sender, EventArgs e)
        {
            formAuthor fAuthor = new formAuthor();
            fAuthor.Show();
            this.Hide();
        }

        private void btnStockB_Click(object sender, EventArgs e)
        {
            formStock fStock = new formStock();
            fStock.Show();
            this.Hide();
        }
    }
}
