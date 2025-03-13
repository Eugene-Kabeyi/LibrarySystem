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

namespace LibrarySystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            DatabaseHelper dbHelper = new DatabaseHelper();

            MySqlConnection conn = dbHelper.GetConnection();

            if (conn != null)
            {
                // Your database operations here
                dbHelper.CloseConnection();  // Close connection after operations
            }

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
