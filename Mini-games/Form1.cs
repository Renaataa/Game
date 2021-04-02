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
    public partial class Form1 : Form
    {
        DatabaseUsersDataContext DatabeseDC = new DatabaseUsersDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsUserFormValid())
            {
                User newUser = new User();
                newUser.Nickname = textBoxNickname.Text;
                newUser.Password = textBoxPassword.Text;

                DatabeseDC.Users.InsertOnSubmit(newUser);
                DatabeseDC.SubmitChanges();

                textBoxNickname.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Write your nickname or/and password.");
            }
        }

        private bool IsUserFormValid()
        {
            if (textBoxNickname.Text.Length == 0)
            {
                return false;
            }
            if (textBoxPassword.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
