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
using static LibrarySystem.UserLogin;

namespace LibrarySystem.UControl
{
    public partial class UserBorrowed : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public UserBorrowed()
        {
            InitializeComponent();
            LoadUserBorrowedBooks();
        }

        private void LoadUserBorrowedBooks(string searchText = "")
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();

                string query = "SELECT b.borrow_id AS 'ID', " +
                               "b.user_email AS 'Borrower Email', " +
                               "bk.title AS 'Book Title', " +
                               "b.borrow_date AS 'Borrow Date', " +
                               "b.return_date AS 'Return Due Date', " +
                               "b.actual_return_date AS 'Actual Return Date', " +
                               "b.status AS 'Status' " +
                               "FROM Borrowed b " +
                               "JOIN Books bk ON b.book_id = bk.id " +
                               "WHERE b.user_email = @UserEmail";

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query += " AND (b.borrow_id LIKE @SearchText " +
                             "OR b.user_email LIKE @SearchText " +
                             "OR bk.title LIKE @SearchText " +
                             "OR b.borrow_date LIKE @SearchText " +
                             "OR b.return_date LIKE @SearchText " +
                             "OR b.actual_return_date LIKE @SearchText " +
                             "OR b.status LIKE @SearchText)";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserEmail", UserSession.Email);
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewBooks.DataSource = dt;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUserBorrowedBooks(textBox1.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadUserBorrowedBooks();
        }
        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];

                txtBorrowerEmail.Text = row.Cells["Borrower Email"].Value?.ToString();
                txtBookTitle.Text = row.Cells["Book Title"].Value?.ToString();
                txtBorrowDate.Text = row.Cells["Borrow Date"].Value?.ToString();
                txtReturnDate.Text = row.Cells["Return Due Date"].Value?.ToString();
                txtoverdueDays.Text = CalculateOverdueDays(row.Cells["Return Due Date"].Value?.ToString());
            }
        }

        // Function to calculate overdue days
        private string CalculateOverdueDays(string returnDateStr)
        {
            if (DateTime.TryParse(returnDateStr, out DateTime returnDate))
            {
                int overdueDays = (DateTime.Now - returnDate).Days;
                return overdueDays > 0 ? overdueDays.ToString() : "0";
            }
            return "0";
        }


        private void grpBookDetails_Enter(object sender, EventArgs e)
        {

        }

        private void UserBorrowed_Load(object sender, EventArgs e)
        {

        }
    }
}
