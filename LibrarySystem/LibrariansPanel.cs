using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static LibrarySystem.AdminPanel;
using static LibrarySystem.StaffLogin;
using static LibrarySystem.UserLogin;

namespace LibrarySystem
{
    public partial class LibrariansPanel : Form
    {
        public LibrariansPanel()
        {
            InitializeComponent();
            LoadLibDash();
        }
        private void LoadLibDash()
        {
            LoadUserControl(new UControl.LibDash());
            lblUsername.Text = StaffSession.FirstName;
            // Load Profile Picture
            if (StaffSession.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(StaffSession.Picture))
                {
                    picLibrarian.Image = Image.FromStream(ms);
                }
            }
        }
        private void LoadUserControl(UserControl control)
        {
            pnlContent.Controls.Clear(); // Remove existing content
            control.Dock = DockStyle.Fill; // Fill the panel
            pnlContent.Controls.Add(control); // Add the new control
        }
        private void btnLibDash_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.LibDash());  // Load Dashboard UserControl
        }
        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Librarians());  // Load Librarians UserControl
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Members());  // Load Members UserControl
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.BookDetails());  // Load BookDetails UserControl
        }

        private void btnRequestedBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Approval());  // Load Approval UserControl
        }

        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Borrowed());  // Load Borrowed UserControl
        }
        private void picLibrarian_Click(object sender, EventArgs e)
        {
            // Open Librarian Profile
            LibrarianProfile profilePage = new LibrarianProfile();
            profilePage.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Confirm before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StaffSession.UserId = 0;
                StaffSession.FirstName = null;
                StaffSession.LastName = null;
                StaffSession.Username = null;
                StaffSession.Email = null;
                StaffSession.Picture = null;

                // Open the startup form (LoginForm)
                StartupPage startup = new StartupPage();
                startup.Show();
                // Close the current form
                //
                this.Close();

            }
        }

        private void LibrariansPanel_Load(object sender, EventArgs e)
        {

        }
   
       

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
