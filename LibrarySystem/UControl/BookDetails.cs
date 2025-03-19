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
    public partial class BookDetails : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";

        public BookDetails()
        {
            InitializeComponent();
            LoadBooks();
        }
        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtNoBooks.Clear();
        }
        
        private int selectedBookId = -1; // Store selected book ID
        private void LoadBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, isbn, title, author, publisher, number_of_books FROM Books"; // Corrected column names

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewBooks.DataSource = dt;
                }
            }

            // Ensure DataGridView column names match the query
            if (dataGridViewBooks.Columns.Count > 0)
            {
                dataGridViewBooks.Columns["id"].HeaderText = "ID";
                dataGridViewBooks.Columns["isbn"].HeaderText = "ISBN";
                dataGridViewBooks.Columns["title"].HeaderText = "Title";
                dataGridViewBooks.Columns["author"].HeaderText = "Author";
                dataGridViewBooks.Columns["publisher"].HeaderText = "Publisher";
                dataGridViewBooks.Columns["number_of_books"].HeaderText = "Available Books";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadBooks();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId > 0) // Ensure a book is selected
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(mySqlConn))
                    {
                        conn.Open();
                        string query = "DELETE FROM Books WHERE ID = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedBookId); // ✅ Use ID for deletion
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks(); // Refresh DataGridView
                                ClearFields(); // Reset input fields
                                btnEdit.Visible = false; // Hide Edit button
                                btnSave.Visible = false; // Hide Save button
                            }
                            else
                            {
                                MessageBox.Show("Error deleting book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BookDetails_Load(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedBookId > 0) // Ensure a book is selected
            {
                btnSave.Visible = true;  // Show the Save button
                btnSave.Text = "Update"; // Change Save button text to Update
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is actually clicked
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];

                selectedBookId = Convert.ToInt32(row.Cells["id"].Value); // Ensure column names match DB
                txtISBN.Text = row.Cells["isbn"].Value?.ToString() ?? "";
                txtTitle.Text = row.Cells["title"].Value?.ToString() ?? "";
                txtAuthor.Text = row.Cells["author"].Value?.ToString() ?? "";
                txtPublisher.Text = row.Cells["publisher"].Value?.ToString() ?? "";
                txtNoBooks.Text = row.Cells["number_of_books"].Value?.ToString() ?? "";

                btnEdit.Visible = true;  // Show Edit button
                btnSave.Visible = true;  // Enable Save button
                btnSave.Text = "Update"; // Change text to "Update"
                btnSave.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the fields then click SAVE");
            btnSave.Visible = true;
            btnEdit.Visible = false;    
            btnAdd.Visible = false;
            btnClear.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate that no fields are empty
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtNoBooks.Text))
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                MySqlCommand cmd;

                if (btnEdit.Visible && selectedBookId > 0) // Update existing record
                {
                    string query = "UPDATE Books SET ISBN = @isbn, Title = @title, Author = @author, Publisher = @publisher, number_of_books = @noBooks WHERE ID = @id";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedBookId); // ✅ Fixed
                }
                else // Insert new record
                {
                    string query = "INSERT INTO Books (ISBN, Title, Author, Publisher, number_of_books) VALUES (@isbn, @title, @author, @publisher, @noBooks)";
                    cmd = new MySqlCommand(query, conn);
                }

                // Add parameters
                cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@noBooks", int.Parse(txtNoBooks.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(btnEdit.Visible ? "Book updated successfully!" : "New book added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks(); // Refresh DataGridView after operation
                    btnEdit.Visible = false; // Hide Edit button again
                    btnSave.Text = "Save"; // Reset button text
                    btnSave.Visible = false;
                    btnAdd.Visible = true;
                    btnClear.Visible = true;
                    btnDelete.Visible = true;
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error saving book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
