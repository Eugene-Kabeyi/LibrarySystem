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
    public partial class Borrowed : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public Borrowed()
        {
            InitializeComponent();
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT b.borrow_id, b.user_email, bk.title, b.borrow_date, b.return_date, b.status " +
                               "FROM Borrowed b " +
                               "JOIN Books bk ON b.book_id = bk.id " +
                               "WHERE b.status = 'Borrowed'";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBorrowedBooks.DataSource = dt;
                }
            }
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBorrowedBooks.Rows[e.RowIndex];

                txtBorrowerEmail.Text = row.Cells["user_email"].Value.ToString();
                txtBookTitle.Text = row.Cells["title"].Value.ToString();
                txtBorrowDate.Text = Convert.ToDateTime(row.Cells["borrow_date"].Value).ToString("yyyy-MM-dd");
                txtReturnDate.Text = Convert.ToDateTime(row.Cells["return_date"].Value).ToString("yyyy-MM-dd");

                // Calculate overdue days
                DateTime returnDate = Convert.ToDateTime(row.Cells["return_date"].Value);
                int overdueDays = (DateTime.Now.Date - returnDate.Date).Days;
                txtoverdueDays.Text = overdueDays > 0 ? overdueDays.ToString() : "0";
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int borrowId = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells["borrow_id"].Value);

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Update Borrowed table: set actual_return_date and status
                    string updateBorrowQuery = "UPDATE Borrowed SET actual_return_date = NOW(), status = 'Returned' WHERE borrow_id = @BorrowId";
                    using (MySqlCommand cmd = new MySqlCommand(updateBorrowQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BorrowId", borrowId);
                        cmd.ExecuteNonQuery();
                    }

                    // Increase book stock
                    string updateBookStockQuery = "UPDATE Books SET number_of_books = number_of_books + 1 " +
                                                  "WHERE id = (SELECT book_id FROM Borrowed WHERE borrow_id = @BorrowId)";
                    using (MySqlCommand cmd = new MySqlCommand(updateBookStockQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BorrowId", borrowId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBorrowedBooks(); // Refresh data grid
                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            txtBorrowerEmail.Clear();
            txtBookTitle.Clear();
            txtBorrowDate.Clear();
            txtReturnDate.Clear();
            txtoverdueDays.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }



        private void grBxBorrowed_Enter(object sender, EventArgs e)
        {

        }
    }
}
