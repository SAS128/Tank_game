using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankGame
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        private void CreateAccountClick(object sender, EventArgs e)
        {
            CreateAccount frm = new CreateAccount();
            frm.Show();
            //this.Hide();
        }
        private void EnterClick(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length>0 && LoginTextBox.Text.Length>0)
            {
                //if (IsUserInServerDB() == true)
                //{
                /////////Обращение к серверной базе данных и поиск сущесвования игрока по логину
                    StartWindow frm1 = new StartWindow();
                    frm1.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Этот пользователь не найден!","Ошибка!");
                //}
            }
          
           
        }

        private void CreateAccoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateAccount().ShowDialog(this);
            this.Show();
        }

      
    }
}
