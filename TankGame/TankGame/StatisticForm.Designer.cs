using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TankGame
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            UserName.Location = new Point(20, 20);
            UserName.Size = new Size(100, 50);
            UserName.Text = "Random1";

            Win_Lose_Count.Location = new Point(130, 20);
            Win_Lose_Count.Size = new Size(150, 50);
            Win_Lose_Count.Text = "Win/Games: 20/100" + Environment.NewLine + "Winrate: 20%";

            AllGames.Location = new Point(130, 80);
            AllGames.Size = new Size(400, 300);
            //AllGames.Items.Add((AllGames.Items.Count + 1).ToString() + ") Random1 Vs Random2 WIN GameTime: 00:12:24");
            //AllGames.Items.Add((AllGames.Items.Count + 1).ToString() + ") Random1 Vs Random4 LOSE GameTime: 00:5:13");
            this.Load += ShowStatistic;

            this.Controls.Add(UserName);
            this.Controls.Add(Win_Lose_Count);
            this.Controls.Add(AllGames);
        }
        string CurrentUser ="User1";
        private void ShowStatistic(object sender, EventArgs e)
        {
            int k = ExistUserLocal("User1");
            
            
            List<StatisticUser> userStat = new List<StatisticUser>();
            if (k>0)
            {
                using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand($"select * from StatisticTable where [UserIdStatictic]={k}", conn))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            userStat.Add(new StatisticUser(reader.GetString(1), DateTime.Parse(reader.GetString(3)).TimeOfDay, reader.GetBoolean(2)));
                        }

                        reader.Close();
                        //Добавить синхронизацию с классами  
                        conn.Close();
                    }
                }

            }
            else
            {
                //информация с сервера
            }
            int tmp = 0;
            foreach(var item in userStat)
            {
                AllGames.Items.Add((AllGames.Items.Count + 1).ToString() +$") {CurrentUser} Vs {item.NickNameEnemy} "+ ((item.IsWin)?"WIN":"LOSE")+$" GameTime: {item.MatchLength}");
                if (item.IsWin == true)
                {
                    tmp++;

                }
            }
            Win_Lose_Count.Text = tmp + "/"+userStat.Count+"  "+Convert.ToInt32(100.0/ Convert.ToDouble(userStat.Count)*Convert.ToDouble(tmp))+"%";



        }

        Label UserName = new Label();
        Label Win_Lose_Count = new Label();
        ListBox AllGames = new ListBox();

        public static string databaseName = @"Local_User_DB_Tanks.sqlite";
     

        
        public static int ExistUserLocal(string Name)
        {
            int isInDB= -1;

            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand comand = new SQLiteCommand($"select ID from LocalUserTable WHERE [Login]='{Name}'", conn))
                {
                    SQLiteDataReader reader = comand.ExecuteReader();
                    reader.Read();
                    if (reader.FieldCount>0)
                    {
                        
                        isInDB = reader.GetInt32(0);
                    }

                    reader.Close();
                    //Добавить синхронизацию с классами  
                    conn.Close();
                }
            }
            return isInDB;
        }

        private static void InsertData_to_StatisticTable(string NickName, bool IsWin, TimeSpan time,int ID)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand($"INSERT INTO StatisticTable (" +
                    $"[NickNameEnemyPlayer],[IsWin],[LenghBattle],[UserIdStatictic]) VALUES ('{NickName}',{IsWin},'{time.ToString()}',{ID});", conn))//Заменить на передаваемые данные
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
       
        /// <summary>
        /// LocalUserTable
        /// </summary>
        /// 

      
        private static void ShowLocal()
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand comand = new SQLiteCommand("select [Login] from LocalUserTable", conn))
                {
                    SQLiteDataReader reader = comand.ExecuteReader();
                    //Добавить синхронизацию с классами  
                    conn.Close();
                }
            }
        }
        #endregion
    }
}


    



