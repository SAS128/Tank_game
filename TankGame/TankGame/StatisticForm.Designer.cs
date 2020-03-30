using System;
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
            AllGames.Items.Add((AllGames.Items.Count + 1).ToString() + ") Random1 Vs Random2 WIN GameTime: 00:12:24");
            AllGames.Items.Add((AllGames.Items.Count + 1).ToString() + ") Random1 Vs Random4 LOSE GameTime: 00:5:13");


            this.Controls.Add(UserName);
            this.Controls.Add(Win_Lose_Count);
            this.Controls.Add(AllGames);
        }

        Label UserName = new Label();
        Label Win_Lose_Count = new Label();
        ListBox AllGames = new ListBox();

        public static string databaseName = @"Local_User_DB_Tanks.sqlite";
        private static void CreateDB()
        {
            if (File.Exists(databaseName) == false)
            {
                CreateTable();
              
            }
        }
        private static void CreateTable()
        {

            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE StatisticTable (ID int AVTOINCREMENT primary key,[NickNameEnemyPlayer] varchar(21) unique,[IsWin] bit," +
                    "[LenghBattle] datetime); ", conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }

            using (SQLiteConnection connectionUser = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                using (SQLiteCommand commandUser = new SQLiteCommand("create table LocalUserTable(ID int AVTOINCREMENT primary key," +
                    "[NickNamePlayer] varchar(21) unique,[Login] varchar(21) unique," +
                    "[UserIdStatictic] int," +
                    "foreign key([UserIdStatictic]) references StatisticTable(Id) ); ", connectionUser))
                {
                    connectionUser.Open();
                    commandUser.ExecuteNonQuery();
                    connectionUser.Close();
                }

            }

        }
        private static void InsertData_to_StatisticTable(string NickName, bool IsWin, TimeSpan time)
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand($"INSERT INTO StatisticTable (" +
                    $"[NickNameEnemyPlayer],[IsWin],[LenghBattle]) VALUES ('{NickName}',{IsWin},'{time.ToString()}');", conn))//Заменить на передаваемые данные
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        private static void ShowStatistic()
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand("select NickNameEnemyPlayer from StatisticTable", conn))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    //Добавить синхронизацию с классами  
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// LocalUserTable
        /// </summary>
        private static void InsertData_to_LocalUserTable(string NickName, string Login, int StatId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand conmand = new SQLiteCommand($"INSERT INTO LocalUserTable " +
                    $"([NickNamePlayer],[Login],[UserIdStatictic]) " +
                    $"VALUES ('{NickName}','{Login}',{StatId});", conn))//Заменить на передаваемые данные
                {
                    conmand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
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


    



