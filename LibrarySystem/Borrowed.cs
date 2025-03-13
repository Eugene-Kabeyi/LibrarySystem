using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Borrowed: Form
    {
       
           public Borrowed()
        {
            InitializeComponent();
        }



        // Fix: Added the missing event handler for DataGridView cell clicks


        // Optional: Handle text changed event for txtBorrower
        private void txtBorrower_TextChanged(object sender, EventArgs e)
        {
            // Example validation logic
        }

        // Example: Borrow Book Button Click Event
        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        // Example: Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        // Example: Delete Record Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBorrowDate_Click(object sender, EventArgs e)
        {

        }

        private void lblBorrower_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvBorrowedBooks_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
