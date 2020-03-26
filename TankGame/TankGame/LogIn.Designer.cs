using System.Windows.Forms;
namespace TankGame
{
    partial class LogIn
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.CreateAccoutBtn = new System.Windows.Forms.Button();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.EnterBtn.ForeColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(30, 170);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(190, 30);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += EnterBtn_Click;
            // 
            // CreateAccoutBtn
            // 
            this.CreateAccoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.CreateAccoutBtn.ForeColor = System.Drawing.Color.White;
            this.CreateAccoutBtn.Location = new System.Drawing.Point(30, 200);
            this.CreateAccoutBtn.Name = "CreateAccoutBtn";
            this.CreateAccoutBtn.Size = new System.Drawing.Size(190, 30);
            this.CreateAccoutBtn.TabIndex = 1;
            this.CreateAccoutBtn.Text = "Create Account";
            this.CreateAccoutBtn.UseVisualStyleBackColor = false;
            this.CreateAccoutBtn.Click += new System.EventHandler(this.CreateAccoutBtn_Click);
            // 
            // LogInLabel
            // 
            this.LogInLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.LogInLabel.ForeColor = System.Drawing.Color.White;
            this.LogInLabel.Location = new System.Drawing.Point(85, 10);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(100, 50);
            this.LogInLabel.TabIndex = 2;
            this.LogInLabel.Text = "LogIn";
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.ForeColor = System.Drawing.Color.White;
            this.UserLoginLabel.Location = new System.Drawing.Point(30, 70);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(50, 30);
            this.UserLoginLabel.TabIndex = 3;
            this.UserLoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(30, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 30);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.LoginTextBox.Location = new System.Drawing.Point(120, 70);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(120, 120);
            this.PasswordTextBox.MaxLength = 24;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.CreateAccoutBtn);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.UserLoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        Button EnterBtn;
        Button CreateAccoutBtn;

        Label LogInLabel;
        Label UserLoginLabel;
        Label PasswordLabel;

        TextBox LoginTextBox;
        TextBox PasswordTextBox;
        #endregion
    }
}

