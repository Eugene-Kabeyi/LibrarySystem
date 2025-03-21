using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Helper
{
    public class RecentBooks
    {
        private string connectionString = "server=127.0.0.1;user=root;password=root;database=library;";

        // Structure to hold book details
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
        }

        // Get the 4 most recently added books
        public List<Book> GetRecentBooks()
        {
            List<Book> books = new List<Book>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT title, author, publisher FROM Books ORDER BY id DESC LIMIT 4";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Title = reader.GetString("title"),
                                Author = reader.GetString("author"),
                                Publisher = reader.GetString("publisher")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching recent books: " + ex.Message);
            }

            return books;
        }
    }
}
