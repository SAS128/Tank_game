using System.Windows.Forms;
namespace TankGame
{
    partial class CreateAccount
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
            this.DoneCreateAccoutBtn = new System.Windows.Forms.Button();
            this.BackToLogInBtn = new System.Windows.Forms.Button();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.UserGetLoginLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserNicknameLabel = new System.Windows.Forms.Label();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.UserGetLoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNicknameTextBox = new System.Windows.Forms.TextBox();
            this.UserEmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoneCreateAccoutBtn
            // 
            this.DoneCreateAccoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.DoneCreateAccoutBtn.ForeColor = System.Drawing.Color.White;
            this.DoneCreateAccoutBtn.Location = new System.Drawing.Point(152, 212);
            this.DoneCreateAccoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoneCreateAccoutBtn.Name = "DoneCreateAccoutBtn";
            this.DoneCreateAccoutBtn.Size = new System.Drawing.Size(47, 24);
            this.DoneCreateAccoutBtn.TabIndex = 1;
            this.DoneCreateAccoutBtn.Text = "Done";
            this.DoneCreateAccoutBtn.UseVisualStyleBackColor = false;
            this.DoneCreateAccoutBtn.Click += DoneCreateClick;
            // 
            // BackToLogInBtn
            // 
            this.BackToLogInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.BackToLogInBtn.ForeColor = System.Drawing.Color.White;
            this.BackToLogInBtn.Location = new System.Drawing.Point(25, 212);
            this.BackToLogInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackToLogInBtn.Name = "BackToLogInBtn";
            this.BackToLogInBtn.Size = new System.Drawing.Size(43, 24);
            this.BackToLogInBtn.TabIndex = 0;
            this.BackToLogInBtn.Text = "Back";
            this.BackToLogInBtn.UseVisualStyleBackColor = false;
            this.BackToLogInBtn.Click += new System.EventHandler(this.BackToLogInBtn_Click);
            // 
            // CreateLabel
            // 
            this.CreateLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.CreateLabel.ForeColor = System.Drawing.Color.White;
            this.CreateLabel.Location = new System.Drawing.Point(27, 7);
            this.CreateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(191, 41);
            this.CreateLabel.TabIndex = 2;
            this.CreateLabel.Text = "Create Account";
           
            // 
            // UserGetLoginLabel
            // 
            this.UserGetLoginLabel.ForeColor = System.Drawing.Color.White;
            this.UserGetLoginLabel.Location = new System.Drawing.Point(22, 57);
            this.UserGetLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserGetLoginLabel.Name = "UserGetLoginLabel";
            this.UserGetLoginLabel.Size = new System.Drawing.Size(38, 24);
            this.UserGetLoginLabel.TabIndex = 3;
            this.UserGetLoginLabel.Text = "Login:";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.UserPasswordLabel.Location = new System.Drawing.Point(22, 98);
            this.UserPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(63, 24);
            this.UserPasswordLabel.TabIndex = 4;
            this.UserPasswordLabel.Text = "Password:";
            // 
            // UserNicknameLabel
            // 
            this.UserNicknameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNicknameLabel.Location = new System.Drawing.Point(22, 138);
            this.UserNicknameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNicknameLabel.Name = "UserNicknameLabel";
            this.UserNicknameLabel.Size = new System.Drawing.Size(63, 24);
            this.UserNicknameLabel.TabIndex = 5;
            this.UserNicknameLabel.Text = "Nickname:";
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.ForeColor = System.Drawing.Color.White;
            this.UserEmailLabel.Location = new System.Drawing.Point(22, 179);
            this.UserEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(45, 24);
            this.UserEmailLabel.TabIndex = 6;
            this.UserEmailLabel.Text = "E-mail:";
            // 
            // UserGetLoginTextBox
            // 
            this.UserGetLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.UserGetLoginTextBox.Location = new System.Drawing.Point(124, 57);
            this.UserGetLoginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserGetLoginTextBox.Name = "UserGetLoginTextBox";
            this.UserGetLoginTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserGetLoginTextBox.TabIndex = 7;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.UserPasswordTextBox.Location = new System.Drawing.Point(124, 98);
            this.UserPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserPasswordTextBox.MaxLength = 24;
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.PasswordChar = '*';
            this.UserPasswordTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserPasswordTextBox.TabIndex = 8;
            // 
            // UserNicknameTextBox
            // 
            this.UserNicknameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.UserNicknameTextBox.Location = new System.Drawing.Point(124, 138);
            this.UserNicknameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNicknameTextBox.Name = "UserNicknameTextBox";
            this.UserNicknameTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserNicknameTextBox.TabIndex = 9;
            // 
            // UserEmailTextBox
            // 
            this.UserEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.UserEmailTextBox.Location = new System.Drawing.Point(124, 179);
            this.UserEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserEmailTextBox.Name = "UserEmailTextBox";
            this.UserEmailTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserEmailTextBox.TabIndex = 10;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(208, 246);
            this.Controls.Add(this.BackToLogInBtn);
            this.Controls.Add(this.DoneCreateAccoutBtn);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.UserGetLoginLabel);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserNicknameLabel);
            this.Controls.Add(this.UserEmailLabel);
            this.Controls.Add(this.UserGetLoginTextBox);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserNicknameTextBox);
            this.Controls.Add(this.UserEmailTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(304, 292);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        Button BackToLogInBtn;
        Button DoneCreateAccoutBtn;

        Label CreateLabel;
        Label UserGetLoginLabel;
        Label UserPasswordLabel;
        Label UserNicknameLabel;
        Label UserEmailLabel;

        TextBox UserGetLoginTextBox;
        TextBox UserPasswordTextBox;
        TextBox UserNicknameTextBox;
        TextBox UserEmailTextBox;
        #endregion
    }
}