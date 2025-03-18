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
    public partial class LibrarianSignUp : Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";

        public LibrarianSignUp()
        {
            InitializeComponent();
        }

        private void LibrarianSignUp_Load(object sender, EventArgs e)
        {

        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPass.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                (!rdBtnMale.Checked && !rdBtnFemale.Checked))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = rdBtnMale.Checked ? "Male" : "Female";

            // **Hash the password**
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

           

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                string query = "INSERT INTO Staff (firstname, lastname, username, password, gender, email) " +
                               "VALUES (@firstname, @lastname, @username, @password, @gender, @email)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Storing hashed password
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtFirstname.Clear();
                            txtLastname.Clear();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtConfirmPass.Clear();
                            txtEmail.Clear();

                            // Reset radio buttons
                            rdBtnMale.Checked = false;
                            rdBtnFemale.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
