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
using static LibrarySystem.StaffLogin;

namespace LibrarySystem.UControl
{
    public partial class LibDash : UserControl
    {
        Statistics statistics = new Statistics();
        public LibDash()
        {
            InitializeComponent();
            LoadStats();
            DisplayRecentBooks();
        }

        private void LoadStats()
        {
            userName.Text = StaffSession.FirstName;
            try
            {
                lblBooks.Text = $"{statistics.GetTotalBooks()}";
                lblBorrowed.Text = $"{statistics.GetTotalBorrowedBooksAll()}";
                lblRequested.Text = $"{statistics.GetTotalRequestedBooksAll()}";
                lblUsers.Text = $"{statistics.GetTotalUsers()}";

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


        private void LibDash_Load(object sender, EventArgs e)
        {

        }
    }
}
