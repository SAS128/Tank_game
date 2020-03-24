﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public List<All_Statistic> ReadAll()
        {
            List<All_Statistic> res = new List<All_Statistic>();

            using(SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using(SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM All_Statistic", connection))
                {
                    using(SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while(r.Read())
                        {
                            res.Add(new All_Statistic() { ID = r.GetInt32(0), KillCount = r.GetInt32(1), DeathCount = r.GetInt32(2), VictoryCount = r.GetInt32(3), LooseCount = r.GetInt32(4), AllCountBattle = r.GetInt32(5), ShortBattleCount = r.GetInt32(6), LongBattleCount = r.GetInt32(7), User_Statistic= r.GetInt32(8) });
                        }
                    }
                }
            }
            return res;
        }

        public All_Statistic ReadByID()
        {
            All_Statistic res = new All_Statistic();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM All_Statistic", connection))
                {
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            res = new All_Statistic() { ID = r.GetInt32(0), KillCount = r.GetInt32(1), DeathCount = r.GetInt32(2), VictoryCount = r.GetInt32(3), LooseCount = r.GetInt32(4), AllCountBattle = r.GetInt32(5), ShortBattleCount = r.GetInt32(6), LongBattleCount = r.GetInt32(7), User_Statistic = r.GetInt32(8) };
                        }
                    }
                }
            }
            return res;
        }
    }
}
