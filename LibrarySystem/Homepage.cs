using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static LibrarySystem.StaffLogin;
using static LibrarySystem.UserLogin;

namespace LibrarySystem
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            LoadHome();
        }
        private void LoadUserControl(UserControl control)
        {
            pnlContent.Controls.Clear(); // Remove existing content
            control.Dock = DockStyle.Fill; // Fill the panel
            pnlContent.Controls.Add(control); // Add the new control
        }

        private void LoadHome()
        {
            if (UserSession.UserId == 0 &&
        string.IsNullOrEmpty(UserSession.FirstName) &&
        string.IsNullOrEmpty(UserSession.LastName) &&
        string.IsNullOrEmpty(UserSession.Username) &&
        string.IsNullOrEmpty(UserSession.Email))
            {
                MessageBox.Show("Session expired. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Redirect to StartPage
                StartupPage startPage = new StartupPage();
                startPage.Show();

                // Close homepage
                this.Close();
            }
            LoadUserControl(new UControl.Home());
            lblFname.Text = UserSession.FirstName;
            // Load Profile Picture
            if (UserSession.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(UserSession.Picture))
                {
                    picUser.Image = Image.FromStream(ms);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Home());  // Load Dashboard UserControl
        }

        private void btnBooklist_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.UserBooklist());  // Load Dashboard UserControl
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Request());  // Load Dashboard UserControl
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UControl.Borrowed());  // Load Dashboard UserControl
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Confirm before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.UserId = 0;
                UserSession.FirstName = null;
                UserSession.LastName = null;
                UserSession.Username = null;
                UserSession.Email = null;
                UserSession.Picture = null;

                // Open the startup form (LoginForm)
                StartupPage startup = new StartupPage();
                startup.Show();
                // Close the current form
                //
                this.Close();

            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void picUser_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
        }
    }
}
