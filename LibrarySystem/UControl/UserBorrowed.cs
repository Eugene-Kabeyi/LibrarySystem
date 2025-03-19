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
    public partial class UserBorrowed : UserControl
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        public UserBorrowed()
        {
            InitializeComponent();
        }
        


        private void grpBookDetails_Enter(object sender, EventArgs e)
        {

        }

        private void UserBorrowed_Load(object sender, EventArgs e)
        {

        }
    }
}
