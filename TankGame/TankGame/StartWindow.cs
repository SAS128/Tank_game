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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            string nickname = "User";
            GreetingLabel.Text = $"Hello, {nickname}";
        }

        private void ExitBtnClk(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void AuthorsBtnClick(object sender, EventArgs e)
        {
            Label authorsLabel = new Label();
            authorsLabel.Text = "Developed by best group in STEP academy - SPV 18o-1:\n" +
                "-Korneychuk Matvey\n-Shevchenko Alexandr\n-Zaharov Alexandr\n-Chernienko Maxim"+
                "\n-Barabash Dmitry" +"\n-Ocheretianyi Pavel\n-Ganjuk Egor\n-Chernish Nikolay" +
                "\n-Troshchylo Tatyana\n-Kisil` Yuriy"+
                "▅███████ ]▄▄▄▄▄▄▄\n"+ 
                 "█████████▅▄▃\n"+ 
                 "Il███████████████████]\n"+ 
                 "◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤";

            authorsLabel.ForeColor = Color.White;
            authorsLabel.Size = new Size(500, 400);
            authorsLabel.Location = new Point(20, 20);
            GameInfoPanel.Controls.Add(authorsLabel);
            GameInfoPanel.Visible = true;
        }

    }
}
