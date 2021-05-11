using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class LoginForm : Form
    {
        DatabaseUsersDataContext DatabeseDC = new DatabaseUsersDataContext();
        User ActiveUserLoginForm = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (IsUserFormValid())
            {
                this.Hide();
                MenuForm mainForm = new MenuForm(this.ActiveUserLoginForm);
                mainForm.Show();
            }
        }

        private bool IsUserFormValid()
        {
            if (textBoxNickname.Text.Length == 0)
            {
                MessageBox.Show("Nickname can't be empty.");
                return false;
            }
            if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Password can't be empty.");
                return false;
            }
            foreach (User user in DatabeseDC.Users)
            {
                if (user.Nickname == textBoxNickname.Text && user.Password == textBoxPassword.Text)
                {
                    ActiveUserLoginForm = user;
                    return true;
                }
            }

            MessageBox.Show("We don't have this user. Please check your nickname and/or password.");
            return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help you better remember it");
        }

        private void buttonExit_click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
