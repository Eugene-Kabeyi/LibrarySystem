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
    public partial class Approval : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        private int selectedBookId = -1;
        public Approval()
        {
            InitializeComponent();
            LoadRequests();
        }
        // Clear Input Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtRequestDate.Clear();
            selectedBookId = -1;
            ReturnDate.Value = DateTime.Today;
        }

        // Load Only Pending Requests
        private void LoadRequests()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT r.request_id, r.user_email, b.title, r.request_date, r.status " +
                               "FROM Request r " +
                               "JOIN Books b ON r.book_id = b.id " +
                               "WHERE r.status = 'Pending'"; // Only load pending requests

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBorrowedBooks.DataSource = dt;
                }
            }
        }
        // Deny Request - Update Status to 'Rejected'
        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || selectedBookId == -1)
            {
                MessageBox.Show("Please select a request to deny.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "UPDATE Request SET status = 'Rejected' WHERE user_email = @UserEmail AND book_id = @BookId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@BookId", selectedBookId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Request has been denied.", "Request Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests(); // Refresh request list
                    }
                    else
                    {
                        MessageBox.Show("Failed to update request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected request details
            int requestId = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells["request_id"].Value);
            string userEmail = dgvBorrowedBooks.SelectedRows[0].Cells["user_email"].Value.ToString();
            string bookTitle = dgvBorrowedBooks.SelectedRows[0].Cells["title"].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();

                MySqlTransaction transaction = conn.BeginTransaction(); // Start a transaction

                try
                {
                    // Get the Book ID and check availability
                    string getBookQuery = "SELECT id, number_of_books FROM Books WHERE title = @Title";
                    int bookId = -1;
                    int availableBooks = 0;

                    using (MySqlCommand getBookCmd = new MySqlCommand(getBookQuery, conn, transaction))
                    {
                        getBookCmd.Parameters.AddWithValue("@Title", bookTitle);
                        using (MySqlDataReader reader = getBookCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookId = reader.GetInt32("id");
                                availableBooks = reader.GetInt32("number_of_books");
                            }
                        }
                    }

                    // Check if the book is available
                    if (availableBooks <= 0)
                    {
                        MessageBox.Show("This book is currently out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback(); // Cancel transaction
                        return;
                    }

                    // Approve the request in the Request table
                    string updateRequestQuery = "UPDATE Request SET status = 'Approved' WHERE request_id = @RequestId";
                    using (MySqlCommand updateRequestCmd = new MySqlCommand(updateRequestQuery, conn, transaction))
                    {
                        updateRequestCmd.Parameters.AddWithValue("@RequestId", requestId);
                        updateRequestCmd.ExecuteNonQuery();
                    }

                    // Insert into Borrowed table
                    string insertBorrowedQuery = "INSERT INTO Borrowed (user_email, book_id, borrow_date, return_date, status) VALUES (@UserEmail, @BookId, NOW(), DATE_ADD(NOW(), INTERVAL 14 DAY), 'Borrowed')";
                    using (MySqlCommand insertBorrowedCmd = new MySqlCommand(insertBorrowedQuery, conn, transaction))
                    {
                        insertBorrowedCmd.Parameters.AddWithValue("@UserEmail", userEmail);
                        insertBorrowedCmd.Parameters.AddWithValue("@BookId", bookId);
                        insertBorrowedCmd.ExecuteNonQuery();
                    }

                    // Decrease number_of_books by 1 in Books table
                    string updateBooksQuery = "UPDATE Books SET number_of_books = number_of_books - 1 WHERE id = @BookId";
                    using (MySqlCommand updateBooksCmd = new MySqlCommand(updateBooksQuery, conn, transaction))
                    {
                        updateBooksCmd.Parameters.AddWithValue("@BookId", bookId);
                        updateBooksCmd.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Commit transaction

                    MessageBox.Show("Request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRequests(); // Refresh the pending requests
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Undo changes if an error occurs
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void grBxBorrowed_Enter(object sender, EventArgs e)
        {

        }

        private void Approval_Load(object sender, EventArgs e)
        {

        }
    }
}
