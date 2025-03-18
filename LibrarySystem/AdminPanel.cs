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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static LibrarySystem.StaffLogin;

namespace LibrarySystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            LoadDash();
        }
        private void LoadDash()
        {
            if (StaffSession.UserId == 0 &&
        string.IsNullOrEmpty(StaffSession.FirstName) &&
        string.IsNullOrEmpty(StaffSession.LastName) &&
        string.IsNullOrEmpty(StaffSession.Username) &&
        string.IsNullOrEmpty(StaffSession.Email))
            {
                MessageBox.Show("Session expired. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Redirect to StartPage
                StartupPage startPage = new StartupPage();
                startPage.Show();

                // Close homepage
                this.Close();
            }
            LoadUserControl(new UControl.Dashboard());  // Load Dashboard UserControl
            lblUsername.Text = StaffSession.FirstName;
            // Load Profile Picture
            if (StaffSession.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(StaffSession.Picture))
                {
                    picAdmin.Image = Image.FromStream(ms);
                }
            }
        }
        public static class AdminSession
        {
            public static string FullName;
            public static string Email;
            public static string PhoneNumber;
            public static Image ProfilePicture;
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

        private void pnlContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
