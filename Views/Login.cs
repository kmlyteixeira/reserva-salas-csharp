using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using reserva_salas_csharp.Controllers;

namespace reserva_salas_csharp.Views
{
    public class Login : Form
    {
        private Label userLabel;
        private Label passwordLabel;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private LinkLabel updatePassword;

        public Login()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            this.userLabel = new Label();
            this.passwordLabel = new Label();
            this.userTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.loginButton = new Button();
            this.SuspendLayout();

            // userLabel
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(267, 100);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(43, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Usuário";

            // passwordLabel
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(269, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Senha";

            // userTextBox
            this.userTextBox.Location = new System.Drawing.Point(269, 120);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(211, 20);
            this.userTextBox.TabIndex = 2;

            // passwordTextBox
            this.passwordTextBox.Location = new System.Drawing.Point(269, 180);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(211, 20);
            this.passwordTextBox.TabIndex = 3;

            // loginButton
            this.loginButton.Location = new System.Drawing.Point(337, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Entrar";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler((sender, e) => this.handleLoginClick(this.userTextBox.Text, this.passwordTextBox.Text));

            // Login
            this.Size = new Size(750, 600);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.updatePassword);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Show();
        }

        private void handleUpdatePasswordClick(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("UPDATE PASS IS RUNNING!!!!");
        }

        private void handleLoginClick(string user, string password)
        {
           if (Controllers.Usuario.Login(user, password) == true)
           {
                this.Hide();
                //new Home();
           }
           else
           {
                MessageBox.Show("Usuário ou senha incorretos");
           }
        }
    }
}