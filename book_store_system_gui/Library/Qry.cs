using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    class Qry
    {
        public static void AddBook() { }
        public static bool AddAccountAndPassword(string account, string password, string DBpath)
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source{DBpath};Version=3;"))
                {
                    connection.Open();
                    string insertSql = "INSERT INTO Accounts (Account, Password) VALUES (@Account, @Password);";
                    using (var command = new SQLiteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@Account", account);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }
                }
                return true; // Successfully added the account
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
                return false; // Failed to add the account
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return false;
            }

        }

        public bool UpdateAccountAndPassword(string account, string newPassword, string DBpath)// will need more user infomation
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={DBpath};Version=3;"))
                {
                    connection.Open();
                    string updateSql = "UPDATE Accounts SET Password = @Password WHERE Account = @Account;";
                    using (var command = new SQLiteCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@Account", account);
                        command.Parameters.AddWithValue("@Password", newPassword);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return false;
            }
        }
        public bool Remo(string account, string DBpath)
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source=DBpath;Version=3;"))
                {
                    connection.Open();
                    string deleteSql = "DELETE FROM Accounts WHERE Account = @Account;";
                    using (var command = new SQLiteCommand(deleteSql, connection))
                    {
                        command.Parameters.AddWithValue("@Account", account);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return false;
            }
        }

    }
}
