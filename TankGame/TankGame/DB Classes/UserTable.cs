using System.Collections.Generic;
using System.Data.SQLite;
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
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO UserTable(LoginId,PasswordId) VALUES(@lid,@pid)", sqliteconnection))
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

            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserTable", sqliteconnection))
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

            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserTable", sqliteconnection))
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