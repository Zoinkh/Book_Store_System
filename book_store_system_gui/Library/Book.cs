using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    internal class Book
    {
        private string author, title, publisher, edition,isbn;
        private DateTime publicDate;
        private string connectionString;
        public void AddBook(string author, string title, string publisher, string edition, string isbn, string publicDate)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertSql = @"
                INSERT OR REPLACE INTO Books (Author, Title, Publisher, Edition, ISBN, PublicDate)
                VALUES (@Author, @Title, @Publisher, @Edition, @ISBN, @PublicDate);";

                using (var command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Publisher", publisher);
                    command.Parameters.AddWithValue("@Edition", edition);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@PublicDate", publicDate);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBook(string isbn, string author, string title, string publisher, string edition, string publicDate)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateSql = @"
                UPDATE Books
                SET Author = @Author, Title = @Title, Publisher = @Publisher, Edition = @Edition, PublicDate = @PublicDate
                WHERE ISBN = @ISBN;";

                using (var command = new SQLiteCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Publisher", publisher);
                    command.Parameters.AddWithValue("@Edition", edition);
                    command.Parameters.AddWithValue("@PublicDate", publicDate);
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveBook(string isbn)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteSql = @"
                DELETE FROM Books
                WHERE ISBN = @ISBN;";

                using (var command = new SQLiteCommand(deleteSql, connection))
                {
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static void PopulateListView(ListView listView)
        {
            listView.Items.Clear(); // Clear existing items
            string connectionString = "Database";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT Author, Title, Publisher, Edition, ISBN, PublicDate;"; // Don't show password for security

                using (var command = new SQLiteCommand(selectSql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(reader["Author"].ToString());
                        item.SubItems.Add(reader["Publisher"].ToString());
                        item.SubItems.Add(reader["Edidtion"].ToString());
                        item.SubItems.Add(reader["ISBN"].ToString());
                        item.SubItems.Add(reader["PublicDate"].ToString());
                        listView.Items.Add(item);
                    }
                }
            }
        }


    }
}
