using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
namespace TankGame.DB_Classes
{
    class User_Login
    {
        public int ID { get; set; }
        public string Login { get; set; }

        public User_Login Insert(string Login)
        {
            User_Login user_login = new User_Login();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO User_Login(Login) VALUES(@l)", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@l", Login));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM User_Login ORDER BY ID DESC LIMIT 1";
                    user_login = new User_Login()
                    {
                        Login = Login,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return user_login;
        }

        public List<User_Login> ReadAll()
        {
            List<User_Login> user_login = new List<User_Login>();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Login", sqliteconnection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_login.Add(new User_Login()
                            {
                                Login = sqlitedatareader.GetString(0)
                            });
                        }
                    }
                }
            }
            return user_login;
        }

        public User_Login ReadByID(int id)
        {
            User_Login user_login = new User_Login();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Login WHERE ID = @id", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_login = new User_Login()
                            {
                                Login = sqlitedatareader.GetString(0)
                            };
                        }
                    }
                }
            }
            return user_login;
        }
    }
}