using System;
using System.Drawing;
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
            this.Text = "StatisticForm";

            UserName.Location=new Point(20, 20);
            UserName.Size=new Size(100, 50);
            UserName.Text = "Random1";

            Win_Lose_Count.Location = new Point(130,20);
            Win_Lose_Count.Size = new Size(150,50);
            Win_Lose_Count.Text = "Win/Games: 20/100"+Environment.NewLine+"Winrate: 20%";

            AllGames.Location = new Point(130, 80);
            AllGames.Size = new Size(400, 300);
            AllGames.Items.Add((AllGames.Items.Count+1).ToString()+") Random1 Vs Random2 WIN GameTime: 00:12:24");
            AllGames.Items.Add((AllGames.Items.Count+1).ToString()+") Random1 Vs Random4 LOSE GameTime: 00:5:13");


            this.Controls.Add(UserName);
            this.Controls.Add(Win_Lose_Count);
            this.Controls.Add(AllGames);
            
        }

        Label UserName = new Label();
        Label Win_Lose_Count = new Label();
        ListBox AllGames = new ListBox();





        #endregion
    }
}