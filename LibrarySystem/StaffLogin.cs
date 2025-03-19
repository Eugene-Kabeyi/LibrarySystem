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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace LibrarySystem
{
    public partial class StaffLogin : Form
    {

        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public StaffLogin()
        {
            InitializeComponent();
        }

        public static class StaffSession
        {
            public static int UserId { get; set; }
            public static string FirstName { get; set; }
            public static string LastName { get; set; }
            public static string Username { get; set; }
            public static string Email { get; set; }
            public static byte[] Picture { get; set; }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, firstname, lastname, username, email, picture, password FROM Staff WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString("password");

                            // 🔒 Verify password using BCrypt
                            if (BCrypt.Net.BCrypt.Verify(password, storedPassword))
                            {
                                // ✅ Store staff details in session (except password & gender)
                                StaffSession.UserId = reader.GetInt32("id");
                                StaffSession.FirstName = reader.GetString("firstname");
                                StaffSession.LastName = reader.GetString("lastname");
                                StaffSession.Username = reader.GetString("username");
                                StaffSession.Email = reader.GetString("email");
                                StaffSession.Picture = reader["picture"] as byte[];

                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // ✅ Redirect based on FirstName
                                if (StaffSession.FirstName.ToLower() == "admin")
                                {
                                    AdminPanel adminPanel = new AdminPanel();
                                    adminPanel.Show();

                                }
                                else
                                {
                                    LibrariansPanel librariansPanel = new LibrariansPanel();
                                    librariansPanel.Show();
                                }

                                this.Hide(); // Hide login form after successful login
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

