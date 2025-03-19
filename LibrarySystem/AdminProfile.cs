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
using static LibrarySystem.AdminPanel;
using static LibrarySystem.StaffLogin;

namespace LibrarySystem
{
    public partial class AdminProfile : Form
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public AdminProfile()
        {
            InitializeComponent();
            LoadAdminDetails();
            
        }
        private void LoadAdminDetails()
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Email and Contact cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "UPDATE Staff SET email = @Email, username = @Contact, picture = @Picture WHERE id = @UserId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@UserId", StaffSession.UserId);

                    if (StaffSession.Picture != null)
                    {
                        cmd.Parameters.AddWithValue("@Picture", StaffSession.Picture);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Picture", DBNull.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update session details
                        StaffSession.Email = txtEmail.Text;
                        StaffSession.Username = txtUsername.Text;

                        btnEdit.Visible = true;
                        btnSave.Visible = false;
                        txtEmail.ReadOnly = true;
                        txtUsername.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void AdminProfile_Load(object sender, EventArgs e)
        {
          
        }

        private void contact_Click(object sender, EventArgs e)
        {

        }
    }
}
