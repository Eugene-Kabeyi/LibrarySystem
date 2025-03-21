using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.UControl;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{

    public partial class UserLogin : Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public UserLogin()
        {
            InitializeComponent();

        }
        public static class UserSession
        {
            public static int UserId { get; set; }
            public static string FirstName { get; set; }
            public static string LastName { get; set; }
            public static string Username { get; set; }
            public static string Email { get; set; }
            public static string Gender { get; set; }
            public static byte[] Picture { get; set; } // Stores profile picture as a byte array
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartupPage startup = new StartupPage();
            startup.Show();
            this.Hide();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide(); // Hide login form
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, firstname, lastname, username, email, gender, picture, password FROM User WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read()) // If user exists
                        {
                            string storedHashedPassword = reader["password"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword)) // Password matches
                            {
                                // ✅ Store user data in UserSession
                                UserSession.UserId = reader.GetInt32("id");
                                UserSession.FirstName = reader.GetString("firstname");
                                UserSession.LastName = reader.GetString("lastname");
                                UserSession.Email = reader.GetString("email");
                                UserSession.Picture = reader["picture"] as byte[]; // Handle picture as byte array

                                reader.Close();

                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // ✅ Open Home Page
                                Homepage homeForm = new Homepage();
                                homeForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password. Please try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email not found. Please register first!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}
