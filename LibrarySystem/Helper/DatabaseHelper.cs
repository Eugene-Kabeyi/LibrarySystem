using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LibrarySystem  // Replace with your project's namespace
{
    public class DatabaseHelper
    {
        private string mySqlConn = "server=127.0.0.1;user=root;password=;database=library;";
        private MySqlConnection connection;

        public DatabaseHelper()
        {
            connection = new MySqlConnection(mySqlConn);
        }

        // Method to open connection
        public MySqlConnection GetConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Successful Connection");
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        // Method to close connection
        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
