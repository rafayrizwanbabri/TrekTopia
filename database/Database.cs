using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp1
{
    internal class Database
    {
        private readonly string _databaseName;
        public Database()
        {
            string Path = "Data.db";
            _databaseName = $"Data Source={Path}";

            if (!File.Exists(Path))
            {
                CreateDatabase();
            }
        }
        private void CreateDatabase()
        {
            using (var db = new SqliteConnection(_databaseName))
            {
                db.Open();
                string command = "CREATE TABLE IF NOT EXISTS Users(Id INTEGER PRIMARY KEY AUTOINCREMENT,Fullname TEXT NOT NULL, Email TEXT, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL)";
                var createDatabase = new SqliteCommand(command, db);
                createDatabase.ExecuteNonQuery();
            }
        }

        public bool AddUser(string fullname, string email, string username, string password)
        {
            using (var connection = new SqliteConnection(_databaseName))
            {
                connection.Open();
                string commandText = "INSERT INTO Users (Fullname,Email,Username,Password) VALUES (@Fullname, @Email, @Username, @Password)";
                using (var command = new SqliteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Fullname", fullname);
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqliteException e)
                    {
                        // MessageBox.Show(e.Message.ToString());
                        return false;
                    }
                }
            }
        }
        public bool LoginUser(String username, String password)
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    return false;
                }

                using (var connection = new SqliteConnection(_databaseName))
                {
                    connection.Open();
                    string query = "SELECT Password FROM Users WHERE Username=@Username";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            if (result.ToString() == password)
                            {
                                return true;
                            }
                            else
                                return false;
                        }
                        else return false;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");
                return false;
            }
        }
    }
}
