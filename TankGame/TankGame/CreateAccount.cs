using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            frm.Show();
            //this.Hide();
        }
        private void DoneCreateClick(object sender, EventArgs e)
        {
            StartWindow frm = new StartWindow();
            frm.Show();
            //this.Hide();
        }
    }
}
