using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.DB_Classes
{
    class UserName
    {
        public int ID { get; set; }
        public string NikName { get; set; }
        public string Mail { get; set; }
        public int UserTableID { get; set; }

        public UserName Insert(int NikName, int Mail, int UserTableID)
        {
            UserName username = new UserName();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO UserName(NikName,Mail,UserTableID) VALUES(@nn,@m,@utid)", connection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@nn", NikName));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@m", Mail));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@utid", UserTableID));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM UserName ORDER BY ID DESC LIMIT 1";

                    username = new UserName()
                    {
                        NikName = NikName,
                        Mail = Mail,
                        UserTableID = UserTableID,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return username;
        }

        public List<UserName> ReadAll()
        {
            List<UserName> username = new List<UserName>();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserName", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            username.Add(new UserName()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                NikName = sqlitedatareader.GetChars(1),
                                Mail = sqlitedatareader.GetChars(2),
                                UserTableID = sqlitedatareader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return username;
        }

        public UserName ReadByID()
        {
            UserName username = new UserName();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM UserName", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            username = new UserName()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                NikName = sqlitedatareader.GetChars(1),
                                Mail = sqlitedatareader.GetChars(2),
                                UserTableID = sqlitedatareader.GetInt32(3)
                            };
                        }
                    }
                }
            }
            return username;
        }
    }
}