using System.Drawing;
using System.Windows.Forms;
namespace TankGame
{
    partial class StartWindow
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
            this.GameInfoPanel = new System.Windows.Forms.Panel();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.EnterGameBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.StatisticsBtn = new System.Windows.Forms.Button();
            this.AuthorsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameInfoPanel
            // 
            this.GameInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.GameInfoPanel.ForeColor = System.Drawing.Color.White;
            this.GameInfoPanel.Location = new System.Drawing.Point(200, 10);
            this.GameInfoPanel.Name = "GameInfoPanel";
            this.GameInfoPanel.Size = new System.Drawing.Size(576, 428);
            GameInfoPanel.Visible = false;
            this.GameInfoPanel.TabIndex = 0;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLabel.ForeColor = System.Drawing.Color.White;
            this.GreetingLabel.Location = new System.Drawing.Point(30, 10);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(150, 58);
            this.GreetingLabel.TabIndex = 1;
            // 
            // EnterGameBtn
            // 
            this.EnterGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.EnterGameBtn.ForeColor = System.Drawing.Color.White;
            this.EnterGameBtn.Location = new System.Drawing.Point(30, 70);
            this.EnterGameBtn.Name = "EnterGameBtn";
            this.EnterGameBtn.Size = new System.Drawing.Size(150, 50);
            this.EnterGameBtn.TabIndex = 2;
            this.EnterGameBtn.Text = "Start";
            this.EnterGameBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Location = new System.Drawing.Point(30, 120);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(150, 50);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.StatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.StatisticsBtn.Location = new System.Drawing.Point(30, 170);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(150, 50);
            this.StatisticsBtn.TabIndex = 4;
            this.StatisticsBtn.Text = "Statistics";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            // 
            // AuthorsBtn
            // 
            this.AuthorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.AuthorsBtn.ForeColor = System.Drawing.Color.White;
            this.AuthorsBtn.Location = new System.Drawing.Point(30, 220);
            this.AuthorsBtn.Name = "AuthorsBtn";
            this.AuthorsBtn.Size = new System.Drawing.Size(150, 50);
            this.AuthorsBtn.TabIndex = 5;
            this.AuthorsBtn.Text = "Authors";
            this.AuthorsBtn.UseVisualStyleBackColor = false;
            this.AuthorsBtn.Click += AuthorsBtnClick;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(30, 270);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(150, 50);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += ExitBtnClk;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TankGame.Resource1.foreground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameInfoPanel);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.EnterGameBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.StatisticsBtn);
            this.Controls.Add(this.AuthorsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.ResumeLayout(false);

        }

        private void AuthorsBtn_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        Panel GameInfoPanel;

        Label GreetingLabel;

        Button EnterGameBtn;
        Button SettingsBtn;
        Button StatisticsBtn;
        Button AuthorsBtn;
        Button ExitBtn;
        #endregion
    }
}