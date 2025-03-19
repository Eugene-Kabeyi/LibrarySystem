using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibrarySystem.UControl
{
    public partial class UserBooklist : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public UserBooklist()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void UserBooklist_Load(object sender, EventArgs e)
        {

        }
        private void LoadBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, isbn, title, author, publisher, number_of_books FROM Books";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewBooks.DataSource = dt;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtNoBooks.Clear();
            textBox1.Clear(); // Also clear search box
            LoadBooks();
        }
        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is clicked
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];

                txtISBN.Text = row.Cells["isbn"].Value?.ToString();
                txtTitle.Text = row.Cells["title"].Value?.ToString();
                txtAuthor.Text = row.Cells["author"].Value?.ToString();
                txtPublisher.Text = row.Cells["publisher"].Value?.ToString();
                txtNoBooks.Text = row.Cells["number_of_books"].Value?.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim(); // Get search input and remove spaces

            if (string.IsNullOrEmpty(searchText))
            {
                LoadBooks(); // If search is empty, reload all books
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, isbn, title, author, publisher, number_of_books " +
                               "FROM Books " +
                               "WHERE isbn LIKE @search OR " +
                               "title LIKE @search OR " +
                               "author LIKE @search OR " +
                               "publisher LIKE @search";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewBooks.DataSource = dt;
                    }
                }
            }
        }
    }
}
