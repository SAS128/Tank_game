namespace TankGame
{
    partial class Form1
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
        }

        #endregion
    }

    //private static void CreateDB()
    //{
    //    SQLiteConnection.CreateFile(databaseName);
    //    Console.WriteLine(File.Exists(databaseName) ? "База данных создана" : "Возникла ошиюка при создании базы данных");
    //}
    //public static string databaseName = @"G:\Проекты\CreateDataBase_Console\CreateDataBase_Console\bin\Debug\Local_User_DB_Tanks.db";
    //public void CreateBd()
    //{
       
   
   
//    private static void CreateTable()
//    {
//        SQLiteConnection connection =
//        new SQLiteConnection(string.Format("Data Source={0};", databaseName));
//        SQLiteCommand command =
//            new SQLiteCommand("CREATE TABLE StatisticTable (ID int identity primary key," +
//            "[NickNameEnemyPlayer] varchar(21) unique,[IsWin] bit," +
//            "[IsLose] bit,[LenghBattle] datetime); ", connection);
//        connection.Open();
//        command.ExecuteNonQuery();
//        connection.Close();


//        SQLiteConnection connectionUser =
//        new SQLiteConnection(string.Format("Data Source={0};", databaseName));
//        SQLiteCommand commandUser =
//            new SQLiteCommand("create table LocalUserTable(ID int identity primary key," +
//            "[NickNamePlayer] varchar(21) unique,[Login] varchar(21) unique," +
//            "[UserIdStatictic] int,[LenghBattle] datetime," +
//            "constraint FK_LocalUser_to_Statistic foreign key([UserIdStatictic]) references StatisticTable(Id) ); ", connectionUser);
//        connectionUser.Open();
//        commandUser.ExecuteNonQuery();
//        connectionUser.Close();

//    }
//}

    //}
//}

 

}

