using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class MenuForm : Form
    {
        DatabaseUsersDataContext DatabeseDC = new DatabaseUsersDataContext();
        User ActiveUserMainForm = new User();
        allGames.UserControlDino dino = new allGames.UserControlDino();

        public MenuForm(User user)
        {
            InitializeComponent();
            this.ActiveUserMainForm = user;
            LoadActiveUser();
        }

        private void buttonDino_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            dino.AutoScroll = false;
            panelGame.Controls.Add(dino);
            dino.Show();

            this.Text = "DinoChrome";

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            if (!dino.Visible)
            {
                panelMenu.Show();
                this.Text = "Games";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure you want to quit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if(dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form2Closing_1);
            this.FormClosed += new FormClosedEventHandler(Form2Closed_1);
        }

        private void Form2Closing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2Closed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadActiveUser()
        {
            if (ActiveUserMainForm != null)
            {
                textBoxNickname.Text = ActiveUserMainForm.Nickname.ToString();
                textBoxPassword.Text = ActiveUserMainForm.Password.ToString();
            }
        }
    }
}
