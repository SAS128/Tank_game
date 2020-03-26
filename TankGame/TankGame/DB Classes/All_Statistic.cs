using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
namespace TankGame.DB_Classes
{
    class All_Statistic
    {
        public int ID { get; set; }
        public int KillCount { get; set; }
        public int DeathCount { get; set; }
        public int VictoryCount { get; set; }
        public int LooseCount { get; set; }
        public int AllCountBattle { get; set; }
        public int ShortBattleCount { get; set; }
        public int LongBattleCount { get; set; }
        public int User_Statistic { get; set; }

        public All_Statistic Insert(int KillCount, int DeathCount, int VictoryCount, int LooseCount,int AllCountBattle, int ShortBattleCount, int LongBattleCount, int User_Statistic)
        {
            All_Statistic all_statistic = new All_Statistic();
            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO All_Statistic(KillCount,DeathCount,VictoryCount,LooseCount,AllCountBattle,ShortBattleCount,LongBattleCount,User_Statistic) VALUES(@kc,@dc,@vc,@lc,@acb,@sbc,@lbc,@us)", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@kc", KillCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@dc", DeathCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@vc", VictoryCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@lc", LooseCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@acb", AllCountBattle));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@sbc", ShortBattleCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@lbc", LongBattleCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@us", User_Statistic));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM All_Statistic ORDER BY ID DESC LIMIT 1";
                    all_statistic = new All_Statistic()
                    {
                       KillCount = KillCount,
                       DeathCount = DeathCount,
                       VictoryCount = VictoryCount,
                       LooseCount = LooseCount,
                       AllCountBattle = AllCountBattle,
                       ShortBattleCount = ShortBattleCount,
                       LongBattleCount = LongBattleCount,
                       User_Statistic = User_Statistic,
                       ID = (int)sqlitecommand.ExecuteScalar()
                   };
                }
            }
            return all_statistic;
        }

        public List<All_Statistic> ReadAll()
        {
            List<All_Statistic> all_statistic = new List<All_Statistic>();

            using(SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using(SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM All_Statistic", sqliteconnection))
                {
                    using(SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while(sqlitedatareader.Read())
                        {
                            all_statistic.Add(new All_Statistic()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                KillCount = sqlitedatareader.GetInt32(1),
                                DeathCount = sqlitedatareader.GetInt32(2),
                                VictoryCount = sqlitedatareader.GetInt32(3),
                                LooseCount = sqlitedatareader.GetInt32(4),
                                AllCountBattle = sqlitedatareader.GetInt32(5),
                                ShortBattleCount = sqlitedatareader.GetInt32(6),
                                LongBattleCount = sqlitedatareader.GetInt32(7),
                                User_Statistic= sqlitedatareader.GetInt32(8)
                            });
                        }
                    }
                }
            }
            return all_statistic;
        }

        public All_Statistic ReadByID(int id)
        {
            All_Statistic all_statistic = new All_Statistic();

            using (SQLiteConnection sqliteconnection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                sqliteconnection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM All_Statistic WHERE ID = @id", sqliteconnection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            all_statistic = new All_Statistic()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                KillCount = sqlitedatareader.GetInt32(1),
                                DeathCount = sqlitedatareader.GetInt32(2),
                                VictoryCount = sqlitedatareader.GetInt32(3),
                                LooseCount = sqlitedatareader.GetInt32(4),
                                AllCountBattle = sqlitedatareader.GetInt32(5),
                                ShortBattleCount = sqlitedatareader.GetInt32(6),
                                LongBattleCount = sqlitedatareader.GetInt32(7),
                                User_Statistic = sqlitedatareader.GetInt32(8)
                            };
                        }
                    }
                }
            }
            return all_statistic;
        }
    }
}