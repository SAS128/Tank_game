using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
namespace TankGame.DB_Classes
{
    class User_Pass
    {
        public int ID { get; set; }
        public string Password { get; set; }

        public User_Pass Insert(string Password)
        {
            User_Pass user_pass = new User_Pass();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO User_Pass(Password) VALUES(@p)", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@p", Password));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM User_Pass ORDER BY ID DESC LIMIT 1";
                    user_pass = new User_Pass()
                    {
                        Password = Password,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return user_pass;
        }

        public List<User_Pass> ReadAll()
        {
            List<User_Pass> user_pass = new List<User_Pass>();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Pass", sqliteconnection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_pass.Add(new User_Pass()
                            {
                                Password = sqlitedatareader.GetString(0)
                            });
                        }
                    }
                }
            }
            return user_pass;
        }

        public User_Pass ReadByID(int id)
        {
            User_Pass user_pass = new User_Pass();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Pass WHERE ID = @id", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_pass = new User_Pass()
                            {
                                Password = sqlitedatareader.GetString(0)
                            };
                        }
                    }
                }
            }
            return user_pass;
        }
    }
}