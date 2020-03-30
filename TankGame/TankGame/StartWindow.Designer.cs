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
            this.GameInfoPanel.Location = new System.Drawing.Point(150, 8);
            this.GameInfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GameInfoPanel.Name = "GameInfoPanel";
            this.GameInfoPanel.Size = new System.Drawing.Size(432, 348);
            this.GameInfoPanel.TabIndex = 0;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLabel.ForeColor = System.Drawing.Color.White;
            this.GreetingLabel.Location = new System.Drawing.Point(22, 8);
            this.GreetingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(112, 47);
            this.GreetingLabel.TabIndex = 1;
            // 
            // EnterGameBtn
            // 
            this.EnterGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.EnterGameBtn.ForeColor = System.Drawing.Color.White;
            this.EnterGameBtn.Location = new System.Drawing.Point(22, 57);
            this.EnterGameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterGameBtn.Name = "EnterGameBtn";
            this.EnterGameBtn.Size = new System.Drawing.Size(112, 41);
            this.EnterGameBtn.TabIndex = 2;
            this.EnterGameBtn.Text = "Start";
            this.EnterGameBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Location = new System.Drawing.Point(22, 98);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(112, 41);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.StatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.StatisticsBtn.Location = new System.Drawing.Point(22, 138);
            this.StatisticsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(112, 41);
            this.StatisticsBtn.TabIndex = 4;
            this.StatisticsBtn.Text = "Statistics";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            this.StatisticsBtn.Click += new System.EventHandler(this.StatisticsBtn_Click);
            // 
            // AuthorsBtn
            // 
            this.AuthorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.AuthorsBtn.ForeColor = System.Drawing.Color.White;
            this.AuthorsBtn.Location = new System.Drawing.Point(22, 179);
            this.AuthorsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorsBtn.Name = "AuthorsBtn";
            this.AuthorsBtn.Size = new System.Drawing.Size(112, 41);
            this.AuthorsBtn.TabIndex = 5;
            this.AuthorsBtn.Text = "Authors";
            this.AuthorsBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(22, 219);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(112, 41);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TankGame.Resource1.foreground;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.GameInfoPanel);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.EnterGameBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.StatisticsBtn);
            this.Controls.Add(this.AuthorsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.ResumeLayout(false);

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