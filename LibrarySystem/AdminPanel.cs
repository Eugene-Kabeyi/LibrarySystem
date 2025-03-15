using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibrarySystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public static class AdminSession
        {
            public static string FullName;
            public static string Email;
            public static string PhoneNumber;
            public static Image ProfilePicture;
        }

        public void SetUserDetails(string fullName, string email, string phoneNumber, Image profilePicture)
        {
            AdminSession.FullName = fullName;
            AdminSession.Email = email;
            AdminSession.PhoneNumber = phoneNumber;
            AdminSession.ProfilePicture = profilePicture;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            AdminProfile profilePage = new AdminProfile();
            profilePage.Show();

        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void LoadUserControl(UserControl control)
        {
            pnlContent.Controls.Clear(); // Remove existing content
            control.Dock = DockStyle.Fill; // Fill the panel
            pnlContent.Controls.Add(control); // Add the new control
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Dashboard());  // Load Dashboard UserControl
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

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Confirm before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Open the startup form (LoginForm)
                StartupPage startup = new StartupPage();
                startup.Show();

                // Close the current form
                this.Close();
            }
        }

    }
}
