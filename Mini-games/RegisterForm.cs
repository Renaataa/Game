using System;
using System.Linq;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class RegisterForm : Form
    {
        DatabaseUsersDataContext DatabaseDC = new DatabaseUsersDataContext();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsUserFormValid())
            {
                User newUser = new User();
                int countOfGames = DatabaseDC.Games.Count();
                newUser.Nickname = textBoxNickname.Text;
                newUser.Password = textBoxPassword.Text;

                DatabaseDC.Users.InsertOnSubmit(newUser);
                DatabaseDC.SubmitChanges();

                for (int i = 0; i < countOfGames; i++)
                {
                    Result newResult = new Result();
                    newResult.GameID = i + 1;
                    newResult.UserID = newUser.Id;
                    DatabaseDC.Results.InsertOnSubmit(newResult);
                }

                DatabaseDC.SubmitChanges();

                MessageBox.Show("Your account was created.");

                textBoxNickname.Text = "";
                textBoxPassword.Text = "";
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
            foreach(User user in DatabaseDC.Users)
            {
                if (user.Nickname == textBoxNickname.Text)
                {
                    MessageBox.Show("This nickname already exists.");
                    return false;
                }
            }

            return true;
        }

        private void logInLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
