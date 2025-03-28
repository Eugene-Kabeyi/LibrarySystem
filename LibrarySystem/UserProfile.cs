﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static LibrarySystem.UserLogin;

namespace LibrarySystem
{
    public partial class UserProfile: Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public UserProfile()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            txtFname.Text = UserSession.FirstName;
            txtLname.Text = UserSession.LastName;
            txtEmail.Text = UserSession.Email;
            
            // Load Profile Picture
            if (UserSession.Picture != null)
            {
                using (MemoryStream ms = new MemoryStream(UserSession.Picture))
                {
                    user_pic.Image = Image.FromStream(ms);
                }
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
          
        }
        private void btnPic_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter to allow only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string imagePath = openFileDialog.FileName;

                // Display the image in the PictureBox
                user_pic.Image = Image.FromFile(imagePath);

                // Resize the image to fit the PictureBox (optional)
                user_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnEdit_Click(object? sender, EventArgs e)
        {
            txtFname.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtLname.ReadOnly = false;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            uploadPic.Visible = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;

            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    conn.Open(); // Open connection first

                    // Ensure email exists before proceeding
                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Email is required for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "UPDATE User SET firstname=@firstname, lastname=@lastname, picture=@picture WHERE email=@email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                        cmd.Parameters.AddWithValue("@picture", imageBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text); // Using email instead of username

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff details updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            btnSave.Visible = false;
                            btnEdit.Visible = true;
                            uploadPic.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Update failed! No matching email found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
