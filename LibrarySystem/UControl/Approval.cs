﻿using System;
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
            txtRequestDate.Clear();
        }

        // Load Only Pending Requests
        private void LoadRequests()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT r.request_id, r.book_id, r.user_email, b.title, r.request_date, r.status " +
                               "FROM Request r " +
                               "JOIN Books b ON r.book_id = b.id " +
                               "WHERE r.status = 'Pending'";

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

        // Handle DataGridView Row Selection
        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is actually clicked
            {
                DataGridViewRow row = dgvBorrowedBooks.Rows[e.RowIndex];

                // Check if "book_id" exists in DataGridView
                if (dgvBorrowedBooks.Rows.Count > 0 && dgvBorrowedBooks.Columns.Contains("book_id"))
                {
                    object cellValue = row.Cells["book_id"].Value;

                    if (cellValue != null && cellValue != DBNull.Value) // Ensure the cell is not empty
                    {
                        selectedBookId = Convert.ToInt32(cellValue);
                    }
                    else
                    {
                        MessageBox.Show("Book ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No data available in the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtEmail.Text = row.Cells["user_email"].Value.ToString();
                txtRequestDate.Text = row.Cells["request_date"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();    

            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvBorrowedBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBorrowedBooks.CurrentRow;

            // Ensure required columns exist
            string[] requiredColumns = { "request_id", "user_email", "title" };
            foreach (string col in requiredColumns)
            {
                if (!dgvBorrowedBooks.Columns.Contains(col))
                {
                    MessageBox.Show($"Missing column: {col}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int requestId = Convert.ToInt32(selectedRow.Cells["request_id"].Value);
            string userEmail = selectedRow.Cells["user_email"].Value.ToString();
            string bookTitle = selectedRow.Cells["title"].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction()) // Start transaction
                {
                    try
                    {
                        // Get Book ID and check availability
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
                                reader.Close(); // Close reader properly
                            }
                        }

                        // Validate book availability
                        if (bookId == -1)
                        {
                            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        if (availableBooks <= 0)
                        {
                            MessageBox.Show("This book is currently out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        // Approve the request
                        string updateRequestQuery = "UPDATE Request SET status = 'Approved' WHERE request_id = @RequestId";
                        using (MySqlCommand updateRequestCmd = new MySqlCommand(updateRequestQuery, conn, transaction))
                        {
                            updateRequestCmd.Parameters.AddWithValue("@RequestId", requestId);
                            updateRequestCmd.ExecuteNonQuery();
                        }

                        // Insert into Borrowed table
                        string insertBorrowedQuery = "INSERT INTO Borrowed (user_email, book_id, borrow_date, return_date, status) " +
                                                     "VALUES (@UserEmail, @BookId, NOW(), DATE_ADD(NOW(), INTERVAL 14 DAY), 'Borrowed')";
                        using (MySqlCommand insertBorrowedCmd = new MySqlCommand(insertBorrowedQuery, conn, transaction))
                        {
                            insertBorrowedCmd.Parameters.AddWithValue("@UserEmail", userEmail);
                            insertBorrowedCmd.Parameters.AddWithValue("@BookId", bookId);
                            insertBorrowedCmd.ExecuteNonQuery();
                        }

                        // Update book quantity
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
        }



        private void grBxBorrowed_Enter(object sender, EventArgs e)
        {

        }

        private void Approval_Load(object sender, EventArgs e)
        {

        }
    }
}
