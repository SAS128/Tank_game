using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Configuration;

namespace TankGame.DB_Classes
{
    class UserTable
    {
        public int ID { get; set; }
        public int LoginId { get; set; }
        public int PasswordId { get; set; }

        public UserTable Insert(int LoginId, int PasswordId)
        {
            UserTable usertable = new UserTable();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO UserTable(LoginId,PasswordId) VALUES(@lid,@pid)", connection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@lid", LoginId));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@pid", PasswordId));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM UserTable ORDER BY ID DESC LIMIT 1";

                    usertable = new UserTable()
                    {
                        LoginId = LoginId,
                        PasswordId = PasswordId,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return usertable;
        }

        public List<UserTable> ReadAll()
        {
            List<UserTable> usertable = new List<UserTable>();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserTable", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            usertable.Add(new UserTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                LoginId = sqlitedatareader.GetInt32(1),
                                PasswordId = sqlitedatareader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            return usertable;
        }

        public UserTable ReadByID()
        {
            UserTable usertable = new UserTable();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserTable", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            usertable = new UserTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                LoginId = sqlitedatareader.GetInt32(1),
                                PasswordId = sqlitedatareader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return usertable;
        }
    }
}