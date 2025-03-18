using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystem.AdminPanel;

namespace LibrarySystem
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = AdminSession.FullName;
            txtEmail.Text = AdminSession.Email;
            txtContact.Text = AdminSession.PhoneNumber;

            // Set profile picture
            if (AdminSession.ProfilePicture != null)
            {
                user_pic.Image = AdminSession.ProfilePicture;
            }
        }

        private void contact_Click(object sender, EventArgs e)
        {

        }
    }
}
