using System;
using MySql.Data.MySqlClient;  // MySQL data library for database connection
using System.Windows.Forms;  // For displaying message boxes
using System.Data;  // For handling DataTables

namespace LibrarySystem  // Namespace of your project
{
    public class DatabaseHelper
    {
        // Connection string for MySQL database
        private string mySqlConn = "server=127.0.0.1;user=root;password=root;database=library;";
        private MySqlConnection connection;  // MySQL connection object

        // Constructor: Initializes the database connection
        public DatabaseHelper()
        {
            connection = new MySqlConnection(mySqlConn);
        }

        /// <summary>
        /// Opens a database connection and returns the connection object.
        /// </summary>
        /// <returns>MySqlConnection object if successful, otherwise null.</returns>
        public MySqlConnection GetConnection()
        {
            try
            {
                connection.Open();  // Open connection
                MessageBox.Show("Successful Connection");  // Notify user
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);  // Show error if connection fails
                return null;
            }
        }

        /// <summary>
        /// Fetches data from a specified table and returns it as a DataTable.
        /// This eliminates redundant code in fetching Users and Staff.
        /// </summary>
        /// <param name="tableName">Name of the table to fetch data from.</param>
        /// <returns>DataTable containing the fetched records.</returns>
        private DataTable GetDataTable(string tableName)
        {
            DataTable dataTable = new DataTable();  // Table to store fetched data

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mySqlConn))  // Establish new connection
                {
                    conn.Open();  // Open the connection
                    string query = $"SELECT * FROM {tableName}";  // Query to get all records

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))  // Create command
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))  // Adapter to fetch data
                        {
                            adapter.Fill(dataTable);  // Fill the table with data
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data from {tableName}: " + ex.Message);  // Show error if fetching fails
            }

            return dataTable;  // Return fetched data
        }

        public void SaveUserData(
       string tableName, int userId, string name, string email, string phone,
       string address, Image image)
        {
            string query = $@"
        INSERT INTO {tableName} (id, name, email, phone, address, picture)
        VALUES (@id, @name, @email, @phone, @address, @picture)
        ON DUPLICATE KEY UPDATE 
            name = @name, email = @email, phone = @phone, 
            address = @address, picture = @picture;";

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);

                // 🛠 Handle Image: Check if NULL before converting
                byte[] imageData = null;
                if (image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageData = ms.ToArray();
                    }
                }

                // ✅ Prevent Truncation (Set Parameter Size)
                MySqlParameter pictureParam = new MySqlParameter("@picture", MySqlDbType.LongBlob);
                pictureParam.Value = (object)imageData ?? DBNull.Value; // Handle NULL properly
                cmd.Parameters.Add(pictureParam);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public (string name, string email, string phone, string address, Image picture)
         GetData(string tableName, int userId)
        {
            string query = $"SELECT name, email, phone, address, picture FROM {tableName} WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(mySqlConn))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string email = reader["email"].ToString();
                        string phone = reader["phone"].ToString();
                        string address = reader["address"].ToString();

                        Image picture = null;
                        if (reader["picture"] != DBNull.Value)
                        {
                            picture = ByteArrayToImage((byte[])reader["picture"]); // Convert Byte Array to Image
                        }

                        return (name, email, phone, address, picture);
                    }
                }
            }

            return (null, null, null, null, null); // Return empty data if no record is found
        }

        // 🔹 Helper function: Convert Byte Array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        /// <summary>
        /// Retrieves all users from the Users table.
        /// </summary>
        /// <returns>DataTable containing all user records.</returns>
        public DataTable GetAllUsers()
        {
            return GetDataTable("Users");  // Fetch users using the common method
        }

        /// <summary>
        /// Retrieves all staff members from the Staff table.
        /// </summary>
        /// <returns>DataTable containing all staff records.</returns>
        public DataTable GetAllStaff()
        {
            return GetDataTable("Staff");  // Fetch staff using the common method
        }

        /// <summary>
        /// Closes the database connection if it is open.
        /// </summary>
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)  // Check if connection is open
            {
                connection.Close();  // Close connection
            }
        }
    }
}
