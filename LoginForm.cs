using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public class LoginForm : Form
    {
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button loginButton;

        public LoginForm()
        {
            Text = "Login";
            Width = 300;
            Height = 200;

            Label userLabel = new Label { Text = "Username", Top = 20, Left = 20 };
            usernameBox = new TextBox { Top = 40, Left = 20, Width = 200 };

            Label passLabel = new Label { Text = "Password", Top = 70, Left = 20 };
            passwordBox = new TextBox { Top = 90, Left = 20, Width = 200, PasswordChar = '*' };

            loginButton = new Button { Text = "Login", Top = 130, Left = 20 };
            loginButton.Click += LoginButton_Click;

            Controls.Add(userLabel);
            Controls.Add(usernameBox);
            Controls.Add(passLabel);
            Controls.Add(passwordBox);
            Controls.Add(loginButton);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "admin" && passwordBox.Text == "password")
            {
                Hide();
                Application.Run(new MainMenuForm());
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}