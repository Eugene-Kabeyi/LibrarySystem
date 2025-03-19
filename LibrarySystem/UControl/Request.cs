using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static LibrarySystem.StaffLogin;
using static LibrarySystem.UserLogin;

namespace LibrarySystem.UControl
{
    public partial class Request : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        private int selectedBookId = -1; // Store selected book ID

        public Request()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            selectedBookId = -1; // Reset selected book
        }


        private void Request_Load(object sender, EventArgs e)
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

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is clicked
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];

                selectedBookId = Convert.ToInt32(row.Cells["id"].Value); // Store ID
                txtISBN.Text = row.Cells["isbn"].Value?.ToString();
                txtTitle.Text = row.Cells["title"].Value?.ToString();
                txtAuthor.Text = row.Cells["author"].Value?.ToString();
                txtPublisher.Text = row.Cells["publisher"].Value?.ToString();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim(); // Get search input and remove spaces

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


        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to request!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();

                // 1. Check if the book is available
                string checkQuery = "SELECT number_of_books FROM Books WHERE id = @BookId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@BookId", selectedBookId);
                    int availableBooks = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (availableBooks <= 0)
                    {
                        MessageBox.Show("This book is currently out of stock!", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 2. Check if the book has already been requested (and is not rejected)
                string requestCheckQuery = "SELECT COUNT(*) FROM Request WHERE user_email = @UserEmail AND book_id = @BookId AND status <> 'Rejected'";
                using (MySqlCommand requestCheckCmd = new MySqlCommand(requestCheckQuery, conn))
                {
                    requestCheckCmd.Parameters.AddWithValue("@UserEmail", UserSession.Email);
                    requestCheckCmd.Parameters.AddWithValue("@BookId", selectedBookId);

                    int existingRequest = Convert.ToInt32(requestCheckCmd.ExecuteScalar());

                    if (existingRequest > 0)
                    {
                        MessageBox.Show("You have already requested this book and the request is either pending or has been approved.",
                                        "Duplicate Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3. Insert request into the Request table
                string insertQuery = "INSERT INTO Request (user_email, book_id, request_date, status) VALUES (@UserEmail, @BookId, NOW(), 'Pending')";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@UserEmail", UserSession.Email);
                    insertCmd.Parameters.AddWithValue("@BookId", selectedBookId);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Reset input fields
                    }
                    else
                    {
                        MessageBox.Show("Request failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




    }
}
