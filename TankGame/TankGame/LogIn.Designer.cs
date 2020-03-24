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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.Text = "LogIn";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#D5D18A");

            EnterBtn = new Button();
            EnterBtn.Text = "Enter";
            EnterBtn.Size = new System.Drawing.Size(190, 30);
            EnterBtn.Location = new System.Drawing.Point(30,170);
            EnterBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#283227");
            EnterBtn.ForeColor = System.Drawing.Color.White;
            EnterBtn.Click += EnterClick;

            CreateAccoutBtn = new Button();
            CreateAccoutBtn.Text = "Create Account";
            CreateAccoutBtn.Size = new System.Drawing.Size(190, 30);
            CreateAccoutBtn.Location = new System.Drawing.Point(30, 200);
            CreateAccoutBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#8F945C");
            CreateAccoutBtn.ForeColor = System.Drawing.Color.White;
            CreateAccoutBtn.Click += CreateAccountClick;

            LogInLabel = new Label();
            LogInLabel.ForeColor = System.Drawing.Color.White;
            LogInLabel.Text = "LogIn";
            LogInLabel.Font=new System.Drawing.Font("Helvetica",18);
            LogInLabel.Size = new System.Drawing.Size(100, 50);
            LogInLabel.Location = new System.Drawing.Point(85, 10);


            UserLoginLabel = new Label();
            UserLoginLabel.ForeColor = System.Drawing.Color.White;
            UserLoginLabel.Text = "Login:";
            UserLoginLabel.Size = new System.Drawing.Size(50, 30);
            UserLoginLabel.Location = new System.Drawing.Point(30, 70);


            PasswordLabel = new Label();
            PasswordLabel.ForeColor = System.Drawing.Color.White;
            PasswordLabel.Text = "Password:";
            PasswordLabel.Size = new System.Drawing.Size(60, 30);
            PasswordLabel.Location = new System.Drawing.Point(30, 120);

            LoginTextBox = new TextBox();
            LoginTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#283227");
            LoginTextBox.Multiline = false;
            LoginTextBox.Size = new System.Drawing.Size(100, 30);
            LoginTextBox.Location = new System.Drawing.Point(120, 70);


            PasswordTextBox = new TextBox();
            PasswordTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#283227");
            PasswordTextBox.Multiline =false;
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 24;
            PasswordTextBox.Size = new System.Drawing.Size(100, 30);
            PasswordTextBox.Location = new System.Drawing.Point(120, 120);

            this.Controls.Add(EnterBtn);
            this.Controls.Add(CreateAccoutBtn);

            this.Controls.Add(LogInLabel);
            this.Controls.Add(UserLoginLabel);
            this.Controls.Add(PasswordLabel);

            this.Controls.Add(LoginTextBox);
            this.Controls.Add(PasswordTextBox);
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

