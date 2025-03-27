using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace book_store_system_gui.Library
{
    class Check
    {
        public static bool CheckAccountAndPassword(string databasePath, string account, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE account = @account AND password = @password"; // Replace 'users' with your table name

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@account", account);
                        command.Parameters.AddWithValue("@password", password);

                        long count = (long)command.ExecuteScalar();

                        return count > 0; // Returns true if a matching record is found, false otherwise.
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle database errors (e.g., log them, throw custom exceptions)
                Console.WriteLine($"SQLite Error: {ex.Message}");
                return false; // Return false on error.
            }
            catch (Exception ex)
            {
                //handles any other exception
                Console.WriteLine($"General Error: {ex.Message}");
                return false;
            }
        }
    }
}
