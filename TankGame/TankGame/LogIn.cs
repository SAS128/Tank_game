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
            this.Close();
        }

        private void CreateAccoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateAccount().ShowDialog(this);
            this.Show();
        }
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            StartWindow frm = new StartWindow();
            frm.Show();
            this.Hide();
        }
    }
}
