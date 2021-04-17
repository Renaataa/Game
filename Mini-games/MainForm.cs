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
    public partial class MainForm : Form
    {
        DatabaseUsersDataContext DatabeseDC = new DatabaseUsersDataContext();
        User ActiveUserMainForm = new User();
        public MainForm(User user)
        {
            InitializeComponent();
            this.ActiveUserMainForm = user;
            LoadActiveUser();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadActiveUser()
        {   
            if(ActiveUserMainForm != null)
            {
                textBoxNickname.Text = ActiveUserMainForm.Nickname.ToString();
                textBoxPassword.Text = ActiveUserMainForm.Password.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
