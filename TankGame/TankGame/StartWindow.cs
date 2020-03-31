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

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticForm stat = new StatisticForm();

            stat.ShowDialog();
            this.Show();
        }

        private void AuthorsBtn_Click(object sender, EventArgs e)
        {
            Label authorsLabel = new Label();
            authorsLabel.Text = "Developed by best group in STEP academy - SPV 18o-1:\n" +
                "-Korneychuk Matvey\n-Shevchenko Alexandr\n-Zaharov Alexandr\n-Chernienko Maxim" +
                "\n-Barabash Dmitry" + "\n-Ocheretianyi Pavel\n-Ganjuk Egor\n-Chernish Nikolay" +
                "\n-Troshchylo Tatyana\n-Kisil` Yuriy\n" +
                "▅███████ ]▄▄▄▄▄▄▄\n" +
                 "█████████▅▄▃\n" +
                 "Il███████████████████]\n" +
                 "◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤";

            authorsLabel.ForeColor = Color.White;
            authorsLabel.Size = new Size(500, 400);
            authorsLabel.Location = new Point(20, 20);
            GameInfoPanel.Controls.Add(authorsLabel);
            GameInfoPanel.Visible = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
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
        private void SettingBtnClick(object sender, EventArgs e)
        {
            GameInfoPanel.Controls.Clear();
            Label SettingsLable = new Label();
            SettingsLable.Text = "Game settings";
            SettingsLable.Font = new Font("Helvetika", 16);
            SettingsLable.ForeColor = Color.White;
            SettingsLable.Size = new Size(200, 30);
            SettingsLable.Location = new Point(250, 10);
            Label ControlBarLable = new Label();
            ControlBarLable.Text = "Controls settings";
            ControlBarLable.ForeColor = Color.White;
            ControlBarLable.Size = new Size(200, 30);
            ControlBarLable.Location = new Point(30, 50);
            Label upLable = new Label();
            upLable.Text = "Up";
            upLable.ForeColor = Color.White;
            upLable.Size = new Size(50, 30);
            upLable.Location = new Point(30, 90);
            Label downLable = new Label();
            downLable.Text = "Down";
            downLable.ForeColor = Color.White;
            downLable.Size = new Size(50, 30);
            downLable.Location = new Point(150, 90);
            Label leftLable = new Label();
            leftLable.Text = "Left";
            leftLable.ForeColor = Color.White;
            leftLable.Size = new Size(50, 30);
            leftLable.Location = new Point(30, 130);
            Label rightLable = new Label();
            rightLable.Text = "Right";
            rightLable.ForeColor = Color.White;
            rightLable.Size = new Size(50, 30);
            rightLable.Location = new Point(150, 130);
            TextBox upTextBox = new TextBox();
            upTextBox.ForeColor = Color.Black;
            upTextBox.Size = new Size(30, 30);
            upTextBox.Location = new Point(70, 90);
            TextBox downTextBox = new TextBox();
            downTextBox.ForeColor = Color.Black;
            downTextBox.Size = new Size(30, 30);
            downTextBox.Location = new Point(190, 90);
            TextBox rightTextBox = new TextBox();
            rightTextBox.ForeColor = Color.Black;
            rightTextBox.Size = new Size(30, 30);
            rightTextBox.Location = new Point(70, 130);
            TextBox leftTextBox = new TextBox();
            leftTextBox.ForeColor = Color.Black;
            leftTextBox.Size = new Size(30, 30);
            leftTextBox.Location = new Point(190, 130);

            Label ApplicationSizeLabel = new Label();
            ApplicationSizeLabel.Text = "Application size";
            ApplicationSizeLabel.ForeColor = Color.White;
            ApplicationSizeLabel.Size = new Size(200, 30);
            ApplicationSizeLabel.Location = new Point(30, 170);

            TextBox ApplicationSizeWidthTextBox = new TextBox();
            ApplicationSizeWidthTextBox.ForeColor = Color.Black;
            ApplicationSizeWidthTextBox.Size = new Size(70, 30);
            ApplicationSizeWidthTextBox.Location = new Point(30, 250);
            TextBox ApplicationSizeHeighTextBox = new TextBox();
            ApplicationSizeHeighTextBox.ForeColor = Color.Black;
            ApplicationSizeHeighTextBox.Size = new Size(70, 30);
            ApplicationSizeHeighTextBox.Location = new Point(130, 250);
            Label WidthLabel = new Label();
            WidthLabel.Text = "Width:";
            WidthLabel.ForeColor = Color.White;
            WidthLabel.Size = new Size(50, 30);
            WidthLabel.Location = new Point(30, 210);

            Label HeightLabel = new Label();
            HeightLabel.Text = "Height:";
            HeightLabel.ForeColor = Color.White;
            HeightLabel.Size = new Size(50, 30);
            HeightLabel.Location = new Point(30, 210);

            GameInfoPanel.Controls.Add(SettingsLable);
            GameInfoPanel.Controls.Add(ControlBarLable);
            GameInfoPanel.Controls.Add(upLable);
            GameInfoPanel.Controls.Add(downLable);
            GameInfoPanel.Controls.Add(leftLable);
            GameInfoPanel.Controls.Add(rightLable);
            GameInfoPanel.Controls.Add(WidthLabel);
            GameInfoPanel.Controls.Add(HeightLabel);
            GameInfoPanel.Controls.Add(upTextBox);
            GameInfoPanel.Controls.Add(downTextBox);
            GameInfoPanel.Controls.Add(rightTextBox);
            GameInfoPanel.Controls.Add(leftTextBox);
        }
    }
}
