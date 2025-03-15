using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace LibrarySystem
{
    public partial class StaffLogin : Form
    {


        private DatabaseHelper dbHelper = new DatabaseHelper(); // Using the existing DatabaseHelper class

        public StaffLogin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void StaffLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get user input from text boxes.
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Fetch all user records using your DatabaseHelper.
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable usersTable = dbHelper.GetAllStaff();

            // Use DataTable.Select to find a matching user.
            DataRow[] foundUser = usersTable.Select($"Username = '{username}' AND Password = '{password}'");

            if (foundUser.Length > 0)
            {
                // Get the first (and only) matching row.
                DataRow user = foundUser[0];

                // Retrieve individual fields.
                string firstName = user["FirstName"].ToString();
                string lastName = user["LastName"].ToString();
                string fullName = $"{firstName} {lastName}";
                string email = user["Email"].ToString();
                string phoneNumber = user["PhoneNumber"].ToString();

                // Retrieve the picture (if it exists).
                Image profilePicture = null;
                if (user["Picture"] != DBNull.Value)
                {
                    byte[] pictureData = (byte[])user["Picture"];
                    if (pictureData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(pictureData))
                        {
                            profilePicture = Image.FromStream(ms);
                        }
                    }
                }

                // Open the appropriate panel based on username.
                if (username.ToLower() == "admin")
                {
                    AdminPanel adminPanel = new AdminPanel();
                    // Optionally, pass user details to AdminPanel.
                    adminPanel.SetUserDetails(fullName, email, phoneNumber, profilePicture);
                    adminPanel.Show();
                }
                else
                {
                    LibrariansPanel librariansPanel = new LibrariansPanel();
                    // Optionally, pass user details to LibrariansPanel.
                    librariansPanel.SetUserDetails(fullName, email, phoneNumber, profilePicture);
                    librariansPanel.Show();
                }

                this.Hide(); // Hide the login form.
            }
            else
            {
                MessageBox.Show("Invalid username or password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}

