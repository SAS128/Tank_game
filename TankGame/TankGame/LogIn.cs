﻿using System;
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
            this.Hide();
        }
    }
}
