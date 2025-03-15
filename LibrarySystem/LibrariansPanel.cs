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

namespace LibrarySystem
{
    public partial class LibrariansPanel : Form
    {
        public LibrariansPanel()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void LibrariansPanel_Load(object sender, EventArgs e)
        {

        }
        public static class LibrarianSession
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
        private void picLibrarian_Click(object sender, EventArgs e)
        {
            // Open Librarian Profile
            LibrarianProfile profilePage = new LibrarianProfile();
            profilePage.Show();
        }
      


    }
}
