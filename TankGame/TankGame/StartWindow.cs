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
            private void SettingBtnClick(object sender, EventArgs e)
        {
            GameInfoPanel.Controls.Clear();
            Label SettingsLable = new Label();
            SettingsLable.Text = "Game settings";
            SettingsLable.Font = new Font("Helvetika", 16);
            SettingsLable.ForeColor = Color.White;
            SettingsLable.Size = new Size(200,30);
            SettingsLable.Location = new Point(250,10);
            Label ControlBarLable = new Label();
            ControlBarLable.Text = "Controls settings";
            ControlBarLable.ForeColor = Color.White;
            ControlBarLable.Size = new Size(200,30);
            ControlBarLable.Location = new Point(30,50);
            Label upLable = new Label();
            upLable.Text = "Up";
            upLable.ForeColor = Color.White;
            upLable.Size = new Size(30, 30);
            upLable.Location = new Point(30,90);
            Label downLable = new Label();
            downLable.Text = "Down";
            downLable.ForeColor = Color.White;
            downLable.Size = new Size(50, 30);
            downLable.Location = new Point(150, 90);
            Label leftLable = new Label();
            leftLable.Text = "Left";
            leftLable.ForeColor = Color.White;
            leftLable.Size = new Size(50, 30);
            leftLable.Location = new Point(30,130);
            Label rightLable = new Label();
            rightLable.Text = "Right";
            rightLable.ForeColor = Color.White;
            rightLable.Size = new Size(50, 30);
            rightLable.Location = new Point(150,130);

            TextBox UpTextBox = new TextBox();
            UpTextBox.ForeColor = Color.Black;
            UpTextBox.Size = new Size(30, 30);
            UpTextBox.Location = new Point(70, 90);
            UpTextBox.Multiline = false;
            UpTextBox.MaximumSize = 1;
             TextBox DownTextBox = new TextBox();
            DownTextBox.ForeColor = Color.Black;
            DownTextBox.Size = new Size(30, 30);
            DownTextBox.Location = new Point(190, 90);
            DownTextBox.Multiline = false;
            DownTextBox.MaximumSize = 1;
            TextBox LeftTextBox = new TextBox();
            LeftTextBox.ForeColor = Color.Black;
            LeftTextBox.Size = new Size(30, 30);
            LeftTextBox.Location = new Point(70, 130);
            LeftTextBox.Multiline = false;
            LeftTextBox.MaximumSize = 1;
            TextBox RightTextBox = new TextBox();
            RightTextBox.ForeColor = Color.Black;
            RightTextBox.Size = new Size(30, 30);
            RightTextBox.Location = new Point(190, 130);
            RightTextBox.Multiline = false;
            RightTextBox.MaximumSize = 1;

            Label ApplicationSizeLabel = new Label();
            ApplicationSizeLabel.Text = "Application size";
            ApplicationSizeLabel.ForeColor = Color.White;
            ApplicationSizeLabel.Size = new Size(200, 30);
            ApplicationSizeLabel.Location = new Point(30, 170);
            TextBox ApplicationSizeWidthTextBox = new TextBox();
            ApplicationSizeWidthTextBox.ForeColor = Color.Black;
            ApplicationSizeWidthTextBox.Size = new Size(70,30);
            ApplicationSizeWidthTextBox.Location = new Point(30, 250);
            ApplicationSizeWidthTextBox.Multiline = false;
            ApplicationSizeWidthTextBox.MaximumSize = 4;
            TextBox ApplicationSizeHeighTextBox = new TextBox();
            ApplicationSizeHeighTextBox.ForeColor = Color.Black;
            ApplicationSizeHeighTextBox.Size = new Size(70, 30);
            ApplicationSizeHeighTextBox.Location = new Point(130, 250);
            ApplicationSizeHeighTextBox.Multiline = false;
            ApplicationSizeHeighTextBox.MaximumSize = 4;
            Label WidthLabel = new Label();
            WidthLabel.Text = "Width:";
            WidthLabel.ForeColor = Color.White;
            WidthLabel.Size = new Size(70, 30);
            WidthLabel.Location = new Point(30, 210);

            Label HeigthLabel = new Label();
            HeigthLabel.Text = "Heigth:";
            HeigthLabel.ForeColor = Color.White;
            HeigthLabel.Size = new Size(70, 30);
            HeigthLabel.Location = new Point(130, 210);

            GameInfoPanel.Controls.Add(SettingsLable);
            GameInfoPanel.Controls.Add(ControlBarLable);
            GameInfoPanel.Controls.Add(upLable);
            GameInfoPanel.Controls.Add(downLable);
            GameInfoPanel.Controls.Add(leftLable);
            GameInfoPanel.Controls.Add(rightLable);
            GameInfoPanel.Controls.Add(ApplicationSizeLabel);
            GameInfoPanel.Controls.Add(ApplicationSizeWidthTextBox);
            GameInfoPanel.Controls.Add(ApplicationSizeHeighTextBox);
            GameInfoPanel.Controls.Add(SettingsLable);
            GameInfoPanel.Controls.Add(UpTextBox);
            GameInfoPanel.Controls.Add(DownTextBox);
            GameInfoPanel.Controls.Add(LeftTextBox);
            GameInfoPanel.Controls.Add(RightTextBox);
            GameInfoPanel.Controls.Add(WidthLabel);
            GameInfoPanel.Controls.Add(HeigthLabel);
            GameInfoPanel.Visible = true; 
        }
    }
}
