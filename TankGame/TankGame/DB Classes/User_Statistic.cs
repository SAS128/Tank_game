using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.DB_Classes
{
    class User_Statistic
    {
        public int ID { get; set; }

        public int KillCount { get; set; }

        public int DeathCount { get; set; }

        public int VictoryCount { get; set; }

        public int LooseCount { get; set; }

        public int AllCountBattle { get; set; }

        public int ShortBattleCount { get; set; }

        public int LongBattleCount { get; set; }

        public int UserNameId { get; set; }


        public User_Statistic Insert(int KillCount, int DeathCount, int VictoryCount, int LooseCount, int AllCountBattle, int ShortBattleCount, int LongBattleCount, int UserNameId)
        {
            User_Statistic user_statistic = new User_Statistic();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("INSERT INTO User_Statistic(KillCount,DeathCount,VictoryCount,LooseCount,AllCountBattle,ShortBattleCount,LongBattleCount,UserNameId) VALUES(@kc,@dc,@vc,@lc,@acb,@sbc,@lbc,@unid)", connection))
                {
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@kc", KillCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@dc", DeathCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@vc", VictoryCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@lc", LooseCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@acb", AllCountBattle));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@sbc", ShortBattleCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@lbc", LongBattleCount));
                    sqlitecommand.Parameters.Add(new SQLiteParameter("@unid", UserNameId));
                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.CommandText = "SELECT ID FROM User_Statistic ORDER BY ID DESC LIMIT 1";

                    user_statistic = new User_Statistic()
                    {
                        KillCount = KillCount,
                        DeathCount = DeathCount,
                        VictoryCount = VictoryCount,
                        LooseCount = LooseCount,
                        AllCountBattle = AllCountBattle,
                        ShortBattleCount = ShortBattleCount,
                        LongBattleCount = LongBattleCount,
                        UserNameId = UserNameId,
                        ID = (int)sqlitecommand.ExecuteScalar()
                    };
                }
            }
            return user_statistic;
        }

        public List<User_Statistic> ReadAll()
        {
            List<User_Statistic> user_statistic = new List<User_Statistic>();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Statistic", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_statistic.Add(new User_Statistic()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                KillCount = sqlitedatareader.GetInt32(1),
                                DeathCount = sqlitedatareader.GetInt32(2),
                                VictoryCount = sqlitedatareader.GetInt32(3),
                                LooseCount = sqlitedatareader.GetInt32(4),
                                AllCountBattle = sqlitedatareader.GetInt32(5),
                                ShortBattleCount = sqlitedatareader.GetInt32(6),
                                LongBattleCount = sqlitedatareader.GetInt32(7),
                                UserNameId = sqlitedatareader.GetInt32(8)
                            });
                        }
                    }
                }
            }
            return user_statistic;
        }

        public User_Statistic ReadByID()
        {
            User_Statistic user_statistic = new User_Statistic();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand sqlitecommand = new SQLiteCommand("SELECT * FROM User_Statistic", connection))
                {
                    using (SQLiteDataReader sqlitedatareader = sqlitecommand.ExecuteReader())
                    {
                        while (sqlitedatareader.Read())
                        {
                            user_statistic = new User_Statistic()
                            {
                                ID = sqlitedatareader.GetInt32(0),
                                KillCount = sqlitedatareader.GetInt32(1),
                                DeathCount = sqlitedatareader.GetInt32(2),
                                VictoryCount = sqlitedatareader.GetInt32(3),
                                LooseCount = sqlitedatareader.GetInt32(4),
                                AllCountBattle = sqlitedatareader.GetInt32(5),
                                ShortBattleCount = sqlitedatareader.GetInt32(6),
                                LongBattleCount = sqlitedatareader.GetInt32(7),
                                UserNameId = sqlitedatareader.GetInt32(8)
                            };
                        }
                    }
                }
            }
            return user_statistic;
        }
    }
}