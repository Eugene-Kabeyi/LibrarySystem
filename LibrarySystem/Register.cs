using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class Register : Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public Register()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

      
        private void lblToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConmfirmPass.Text) ||
                (!rdBtnMale.Checked && !rdBtnFemale.Checked))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure passwords match
            if (txtPassword.Text != txtConmfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure Terms & Conditions checkbox is checked
            if (!checkBoxTOC.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected gender
            string gender = rdBtnMale.Checked ? "Male" : "Female";

            // Hash the password using BCrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            // Convert image to byte array
          

            // Save user to the database
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                string query = "INSERT INTO User (firstname, lastname, username, password, gender, email) " +
                               "VALUES (@firstname, @lastname, @username, @password, @gender, @email)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@username", txtEmail.Text); // Assuming email is the username
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Store encrypted password
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            UserLogin loginForm = new UserLogin();
                            loginForm.Show();
                            this.Hide(); // Close the signup form

                        }
                        else
                        {
                            MessageBox.Show("Failed to create an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
