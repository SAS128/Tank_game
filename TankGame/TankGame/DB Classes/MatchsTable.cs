using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
namespace TankGame.DB_Classes
{
    class MatchsTable
    {
        public int ID { get; set; }
        public string NameBattle { get; set; }
        public int StaticMatchID { get; set; }

        public MatchsTable Insert(int StaticMatchID, string NameBattle)
        {
            MatchsTable matchstable = new MatchsTable();
            using (SQLiteConnection sqlteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqlteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO MatchsTable(NameBattle,StaticMatchID) VALUES(@nb,@smid)", sqlteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@nb", StaticMatchID));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@smid", NameBattle));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM MatchsTable ORDER BY ID DESC LIMIT 1";
                    matchstable = new MatchsTable()
                    {
                        StaticMatchID = StaticMatchID,
                        NameBattle = NameBattle,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return matchstable;
        }

        public List<MatchsTable> ReadAll()
        {
            List<MatchsTable> matchstable = new List<MatchsTable>();

            using (SQLiteConnection sqlteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqlteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM MatchsTable", sqlteconnection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            matchstable.Add(new MatchsTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                NameBattle = sqlitedatareader.GetString(1) ,
                                StaticMatchID = sqlitedatareader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            return matchstable;
        }

        public MatchsTable ReadByID(int id)
        {
            MatchsTable  matchstable = new MatchsTable();

            using (SQLiteConnection sqlteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqlteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM MatchsTable WHERE ID = @id", sqlteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            matchstable = new MatchsTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                NameBattle = sqlitedatareader.GetString(1),
                                StaticMatchID = sqlitedatareader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return matchstable;
        }
    }
}