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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            DatabaseHelper dbHelper = new DatabaseHelper();
            MySqlConnection conn = dbHelper.GetConnection();

            if(conn == null)
            {
                dbHelper.CloseConnection();
            }
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
    }
}
