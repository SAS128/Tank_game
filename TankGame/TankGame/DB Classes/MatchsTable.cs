using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.DB_Classes
{
    class MatchsTable
    {
        public int ID { get; set; }

        public string NameBattle { get; set; }

        public int StaticMatchID { get; set; }

        public MatchsTable Insert(int StaticMatchID, string NameBattle)
        {
            MatchsTable res = new MatchsTable();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO MatchsTable(NameBattle,StaticMatchID,LongBattleCount,User_Statistic) VALUES(@kc,@dc)", connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@kc", StaticMatchID));
                    cmd.Parameters.Add(new SQLiteParameter("@dc", NameBattle));
                   

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT ID FROM MatchsTable ORDER BY ID DESC LIMIT 1";


                    res = new MatchsTable()
                    {
                        StaticMatchID = StaticMatchID,
                        NameBattle = NameBattle,
                        ID = (int)cmd.ExecuteScalar()
                    };
                }
            }
            return res;
        }

        public List<MatchsTable> ReadAll()
        {
            List<MatchsTable> res = new List<MatchsTable>();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM MatchsTable", connection))
                {
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            res.Add(new MatchsTable() { ID = r.GetInt32(0), NameBattle = r.GetString(1) , StaticMatchID = r.GetInt32(2) });
                        }
                    }
                }
            }
            return res;
        }

        public MatchsTable ReadByID(int id)
        {
            MatchsTable  res = new MatchsTable();

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.AppSettings.Get("Path")))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM MatchsTable WHERE ID = @id", connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            res = new MatchsTable() { ID = r.GetInt32(0), NameBattle = r.GetString(1), StaticMatchID = r.GetInt32(2) };
                        }
                    }
                }
            }
            return res;
        }
    }
}
