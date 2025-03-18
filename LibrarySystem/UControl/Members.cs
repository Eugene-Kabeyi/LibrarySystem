using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibrarySystem.UControl
{
    public partial class Members : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public Members()
        {
            InitializeComponent();
            LoadUsers(); // Load users into the DataGridView on startup
        }
        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, firstname, lastname, username, gender, email, picture FROM User";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridUsers.DataSource = dt;
            }
        }

        private void ResetFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            pictureBox1.Image = null;
            btnSave.Visible = false; // Disable save button until Edit is clicked
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];
                txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                txtLastname.Text = row.Cells["lastname"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();

                btnSave.Enabled = false; // Disable Save until Edit is clicked
            }
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true; // Enable the Save button when Edit is clicked
            btnSave.Enabled = true;
            btnEdit.Visible = false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
        
            btnEdit.Visible = true;
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageBytes = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                string query = "UPDATE User SET firstname=@firstname, lastname=@lastname, email=@email, picture=@picture WHERE username=@username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@picture", imageBytes ?? (object)DBNull.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff details updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers(); // Refresh table
                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //  Search User
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Enter any tex to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            {
                conn.Open();
                string query = "SELECT id, firstname, lastname, username, email FROM User WHERE firstname LIKE @search OR lastname LIKE @search OR username LIKE @search OR email LIKE @search";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridUsers.DataSource = dt;
                }
            }
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please select a staff member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(mySqlConn))
                {
                    string query = "DELETE FROM User WHERE username=@username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Refresh table
                            ResetFields();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
