using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    internal class Account
    {
        public string account, password, name, sex, address, email;
        public int age, phone;
        public bool permission;
        private string connectionString;

        public bool AddAccount(string account, string password, string DBpath)
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


        public bool UpdateAccount(string account, string newPassword, string DBpath)// will need more user infomation
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




        public bool RemoveAccount(string account, string DBpath)
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
        public void AddAccount(string account, string password, string name, string sex, string address, string email, int age, string phone)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertSql = @"
                INSERT OR REPLACE INTO Users (Account, Password, Name, Sex, Address, Email, Age, Phone)
                VALUES (@Account, @Password, @Name, @Sex, @Address, @Email, @Age, @Phone);";

                using (var command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Account", account);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Phone", phone);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAccount(string account, string password, string name, string sex, string address, string email, int age, string phone)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateSql = @"
                UPDATE Users
                SET Password = @Password, Name = @Name, Sex = @Sex, Address = @Address, Email = @Email, Age = @Age, Phone = @Phone
                WHERE Account = @Account;";

                using (var command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Account", account);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveAccount(string account)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteSql = @"
                DELETE FROM Users
                WHERE Account = @Account;";

                using (var command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@Account", account);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateListView(ListView listView)
        {
            listView.Items.Clear(); // Clear existing items

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT Account, Name, Sex, Address, Email, Age, Phone FROM Users;"; // Don't show password for security

                using (var command = new SQLiteCommand(selectSql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["Account"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Sex"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Age"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());

                        listView.Items.Add(item);
                    }
                }
            }
        }

    
    }
}
