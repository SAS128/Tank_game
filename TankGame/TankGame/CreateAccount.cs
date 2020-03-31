using EASendMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankGame
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        private void BackToLoginClick(object sender, EventArgs e)
        {
           
            LogIn frm = new LogIn();
            frm.ShowDialog();
          
        }
        private void DoneCreateClick(object sender, EventArgs e)
        {
            
            StartWindow frm1 = new StartWindow();
            frm1.ShowDialog();
            this.Close();

        }

        private void BackToLogInBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private static void InsertData_to_StatisticTable(string NickName, bool IsWin, TimeSpan time, int StatId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand($"INSERT INTO StatisticTable (" +
                    $"[NickNameEnemyPlayer],[IsWin],[LenghBattle],[UserIdStatictic]) VALUES ('{NickName}',{IsWin},'{time.ToString()}',{StatId});", conn))//Заменить на передаваемые данные
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        private static void InsertData_to_LocalUserTable(string NickName, string Login)
        {
            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                conn.Open();
                using (SQLiteCommand conmand = new SQLiteCommand($"INSERT INTO LocalUserTable " +
                    $"([NickNamePlayer],[Login]) " +
                    $"VALUES ('{NickName}','{Login}');", conn))//Заменить на передаваемые данные
                {
                    conmand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private static void CreateDB()
        {
            if (File.Exists(databaseName) == false)
            {
                CreateTable();

            }
        }
        private static void CreateTable()
        {
            using (SQLiteConnection connectionUser = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                using (SQLiteCommand commandUser = new SQLiteCommand("create table LocalUserTable(ID INTEGER AVTOINCREMENT primary key," +
                    "[NickNamePlayer] varchar(21) unique,[Login] varchar(21) unique," +
                    "[UserIdStatictic] int," +
                    "foreign key([UserIdStatictic]) references StatisticTable(Id) ); ", connectionUser))
                {
                    connectionUser.Open();
                    commandUser.ExecuteNonQuery();
                    connectionUser.Close();
                }

            }


            using (SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
            {
                using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE StatisticTable (ID INTEGER AVTOINCREMENT primary key,"+
                    "[NickNameEnemyPlayer] varchar(21) unique,[IsWin] bit," +
                    "[LenghBattle] datetime,[UserIdStatictic] INTEGER," +
                    "foreign key([UserIdStatictic]) references LocalUserTable(Id) ); ", conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }

         

        }

        private void DoneCreateAccoutBtn_Click(object sender, EventArgs e)
        {
            if (UserEmailTextBox.Text.Length > 10 && UserNicknameTextBox.Text.Length > 0 && UserGetLoginTextBox.Text.Length > 0 && UserPasswordTextBox.Text.Length > 0)
            {
                //    if (IsEmailUseable())
                //    {
                //        if (IsLoginUseable())
                //        {
                //            if (IsNickNameUseable())
                //            {
                                 CreateDB();
                                InsertData_to_LocalUserTable(UserNicknameTextBox.Text.ToString(), UserGetLoginTextBox.Text.ToString());
                                this.Close();
                SendMsgToEmail();
                //            }
                //            else
                //            {
                //                MessageBox.Show("Этот NickName уже используеться игроком", "Ошибка NickName");
                //            }
                //        }
                //        else
                //        {
                //            MessageBox.Show("Этот Login уже используеться игроком", "Ошибка Login");
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Этот email уже используеться игроком","Ошибка email");
                //    }
            }
        }
        private void SendMsgToEmail()
        {
            try
            {
                Task.Factory.StartNew(() =>
                {

                    SmtpMail oMail = new SmtpMail("TryIt");
                    oMail.From = "ITSTEPtestfortest@gmail.com";
                    oMail.To = $"{UserEmailTextBox.Text}";
                    oMail.Subject = "test email from gmail account";
                    oMail.TextBody = "тело моего сообщения";


                    SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                    oServer.User = "ITSTEPtestfortest@gmail.com";
                    oServer.Password = "Test123Test";
                    oServer.Port = 587;
                    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                    SmtpClient oSmtp = new SmtpClient();
                    oSmtp.SendMail(oServer, oMail);
                });
            }
            catch (Exception ep)
            {
                MessageBox.Show("failed to send email with the following error:");
                MessageBox.Show(ep.Message);
            }
        }


        private void SQlMatchTableMain()
        {
            using (SqlConnection conect = new SqlConnection("Data Source=localhost;Initial Catalog=;"))
            {
                conect.Open();
                using (SqlCommand comand = new SqlCommand("SELECT * FROM StaticMatchTable", conect))
                {
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        //reader.GetValue(0),
                        //reader.GetValue(1),
                        //reader.GetValue(2),
                        //reader.GetValue(3),
                        //reader.GetValue(4),
                        //reader.GetValue(5),
                        //reader.GetValue(6)


                    }
                    reader.Close();
                }
            }
        }
        private void SQlUserMain()
        {
            using (SqlConnection conect = new SqlConnection("Data Source=localhost;Initial Catalog=;"))
            {
                conect.Open();
                using (SqlCommand comand = new SqlCommand("SELECT * FROM UserInfo", conect))
                {
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        //reader.GetValue(0),
                        //reader.GetValue(1),
                        //reader.GetValue(2),
                        //reader.GetValue(3),
                        //reader.GetValue(4)
                    }
                    reader.Close();
                }
            }
        }
        private void SQlAllUsersMain()
        {
            using (SqlConnection conect = new SqlConnection("Data Source=localhost;Initial Catalog=;"))
            {
                conect.Open();
                using (SqlCommand comand = new SqlCommand("SELECT * FROM UserTable", conect))
                {
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        //reader.GetValue(0),
                        //reader.GetValue(1),
                        //reader.GetValue(2)
                    }
                    reader.Close();
                }
            }
        }

        private void SQlStatisticMain()
        {
            using (SqlConnection conect = new SqlConnection("Data Source=localhost;Initial Catalog=;"))
            {
                conect.Open();
                using (SqlCommand comand = new SqlCommand("SELECT * FROM AllStatisticsTable", conect))
                {
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        //reader.GetValue(0),
                        //reader.GetValue(1),
                        //reader.GetValue(2),
                        //reader.GetValue(3),
                        //reader.GetValue(4),
                        //reader.GetValue(5),
                        //reader.GetValue(6),
                        //reader.GetValue(7),
                        //reader.GetValue(8)

                    }
                    reader.Close();
                }
            }
        }
    }
}
