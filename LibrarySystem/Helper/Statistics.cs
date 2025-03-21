using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Helper
{
    public class Statistics
    {
        private string connectionString = "server=127.0.0.1;user=root;password=root;database=library;"; // Use your actual MySQL connection string

        // Generic method to execute scalar queries
        private int ExecuteScalarQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }

        // Get total number of users
        public int GetTotalUsers()
        {
            string query = "SELECT COUNT(*) FROM User";
            return ExecuteScalarQuery(query);
        }

        // Get total number of staff excluding "Admin"
        public int GetTotalStaff()
        {
            string query = "SELECT COUNT(*) FROM Staff WHERE LOWER(firstname) <> 'admin'";
            return ExecuteScalarQuery(query);
        }




        // Get total number of books
        public int GetTotalBooks()
        {
            string query = "SELECT COUNT(*) FROM Books";
            return ExecuteScalarQuery(query);
        }

        // Get total number of requested books for a specific user
        public int GetTotalRequestedBooks(string userEmail)
        {
            string query = "SELECT COUNT(*) FROM Request WHERE user_email = @UserEmail";
            return ExecuteScalarQuery(query, new MySqlParameter("@UserEmail", userEmail));
        }

        // Get total number of borrowed books for a specific user
        public int GetTotalBorrowedBooks(string userEmail)
        {
            string query = "SELECT COUNT(*) FROM Borrowed WHERE user_email = @UserEmail AND status = 'Borrowed'";
            return ExecuteScalarQuery(query, new MySqlParameter("@UserEmail", userEmail));
        }

        // ✅ Get total number of borrowed books for all users
        public int GetTotalBorrowedBooksAll()
        {
            string query = "SELECT COUNT(*) FROM Borrowed WHERE status = 'Borrowed'";
            return ExecuteScalarQuery(query);
        }

        // ✅ Get total number of requested books for all users
        public int GetTotalRequestedBooksAll()
        {
            string query = "SELECT COUNT(*) FROM Request";
            return ExecuteScalarQuery(query);
        }

        // Calculate overdue fine for a specific user (100 Ksh per day per book)
        public int CalculateFine(string userEmail)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT SUM(DATEDIFF(NOW(), return_date) * 100) 
                        FROM Borrowed 
                        WHERE user_email = @UserEmail 
                        AND status = 'Borrowed' 
                        AND return_date < NOW()";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserEmail", userEmail);
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculating fine: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }
    }
}
