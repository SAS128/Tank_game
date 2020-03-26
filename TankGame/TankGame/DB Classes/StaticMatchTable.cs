using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
namespace TankGame.DB_Classes
{
    class StaticMatchTable
    {
        public int ID { get; set; }
        public DateTime StartBattleTime { get; set; }
        public DateTime EndBattleTime { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int IDWinner { get; set; }

        public StaticMatchTable Insert(DateTime StartBattleTime, DateTime EndBattleTime, int Player1Id, int Player2Id, int IDWinner)
        {
            StaticMatchTable staticmatchtable = new StaticMatchTable();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO StaticMatchTable(StartBattleTime,EndBattleTime,Player1Id,Player2Id,IDWinner) VALUES(@sbt,@ebt,@p1id,@p2id,@idw)", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@sbt", StartBattleTime));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@ebt", EndBattleTime));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@p1id", Player1Id));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@p2id", Player2Id));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@idw", IDWinner));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM StaticMatchTable ORDER BY ID DESC LIMIT 1";
                    staticmatchtable = new StaticMatchTable()
                    {
                        StartBattleTime = StartBattleTime,
                        EndBattleTime = EndBattleTime,
                        Player1Id = Player1Id,
                        Player2Id = Player2Id,
                        IDWinner = IDWinner,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return staticmatchtable;
        }

        public List<StaticMatchTable> ReadAll()
        {
            List<StaticMatchTable> staticmatchtable = new List<StaticMatchTable>();

            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM StaticMatchTable", sqliteconnection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            staticmatchtable.Add(new StaticMatchTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                StartBattleTime = sqlitedatareader.GetDateTime(1),
                                EndBattleTime = sqlitedatareader.GetDateTime(2),
                                Player1Id = sqlitedatareader.GetInt32(3),
                                Player2Id = sqlitedatareader.GetInt32(4),
                                IDWinner = sqlitedatareader.GetInt32(5)
                            });
                        }
                    }
                }
            }
            return staticmatchtable;
        }

        public StaticMatchTable ReadByID(int id)
        {
            StaticMatchTable staticmatchtable = new StaticMatchTable();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM StaticMatchTable WHERE ID = @id", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            staticmatchtable = new StaticMatchTable()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                StartBattleTime = sqlitedatareader.GetDateTime(1),
                                EndBattleTime = sqlitedatareader.GetDateTime(2),
                                Player1Id = sqlitedatareader.GetInt32(3),
                                Player2Id = sqlitedatareader.GetInt32(4),
                                IDWinner = sqlitedatareader.GetInt32(5)
                            };
                        }
                    }
                }
            }
            return staticmatchtable;
        }
    }
}