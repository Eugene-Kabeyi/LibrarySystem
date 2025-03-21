using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static LibrarySystem.StaffLogin;

namespace LibrarySystem
{
    public partial class LibrarianProfile : Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public LibrarianProfile()
        {
            InitializeComponent();
            LoadStaffDetails();
        }
        private void LoadStaffDetails()
        {
            txtName.Text = StaffSession.FirstName + " " + StaffSession.LastName;
            txtEmail.Text = StaffSession.Email;
            txtUsername.Text = StaffSession.Username; // Assuming Username is used as contact info

            if (StaffSession.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(StaffSession.Picture))
                {
                    user_pic.Image = Image.FromStream(ms);
                }
            }
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                user_pic.Image = Image.FromFile(openFileDialog.FileName);

                // Convert image to byte array
                using (MemoryStream ms = new MemoryStream())
                {
                    user_pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    StaffSession.Picture = ms.ToArray(); // Store in session for later use
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtUsername.ReadOnly = false;
            btnSave.Visible = true; // Show Save button
            btnEdit.Visible = false; // Hide Edit button
            uploadPic.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Email and Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = null;
            if (user_pic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    user_pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Staff SET email = @Email, picture = @Picture WHERE username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);  // Now using username instead of id
                        cmd.Parameters.AddWithValue("@Picture", imageBytes ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Update session details
                            StaffSession.Email = txtEmail.Text;

                            btnEdit.Visible = true;
                            btnSave.Visible = false;
                            txtEmail.ReadOnly = true;
                            txtUsername.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Update failed! No changes were made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void LibrarianProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
