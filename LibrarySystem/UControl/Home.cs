using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Helper;
using static LibrarySystem.UserLogin;

namespace LibrarySystem.UControl
{
    public partial class Home : UserControl
    {
        Statistics statistics = new Statistics();
        public Home()
        {
            InitializeComponent();
            DisplayRecentBooks();
            LoadUserStatistics(); // Load user-specific statistics on form load
        }
        private void LoadUserStatistics()
        {
            userName.Text = UserSession.FirstName;
            try
            {
                lblRequested.Text = $" {statistics.GetTotalRequestedBooks(UserSession.Email)}";
                lblFine.Text = $"{statistics.CalculateFine(UserSession.Email):N0}";
                lblBorrowed.Text = $"{statistics.GetTotalBorrowedBooks(UserSession.Email)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayRecentBooks()
        {
            RecentBooks recentBooks = new RecentBooks();
            List<RecentBooks.Book> books = recentBooks.GetRecentBooks();

            // Assign book details to labels
            if (books.Count > 0) lblBook1.Text = $"📖 {books[0].Title} - {books[0].Author} ({books[0].Publisher})";
            if (books.Count > 1) lblBook2.Text = $"📖 {books[1].Title} - {books[1].Author} ({books[1].Publisher})";
            if (books.Count > 2) lblBook3.Text = $"📖 {books[2].Title} - {books[2].Author} ({books[2].Publisher})";
            if (books.Count > 3) lblBook4.Text = $"📖 {books[3].Title} - {books[3].Author} ({books[3].Publisher})";
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
