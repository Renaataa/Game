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
        allGames.DinoChromeGame dino = new allGames.DinoChromeGame();
        allGames.FlappyBirdGame fbird = new allGames.FlappyBirdGame();

        public MenuForm(User user)
        {
            InitializeComponent();
            this.ActiveUserMainForm = user;
            LoadActiveUser();
            UpdateScore();
        }

        private void buttonDino_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(dino);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "DinoChrome";

        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(fbird);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "FlappyBird";
        }

        private void buttonGameExit_Click(object sender, EventArgs e)
        {
            panelGame.Controls.Clear();
            panelMenu.Show();
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

        private void UpdateScore()
        {
            int newScore = dino.Score;
            int newScore2 = fbird.score;

            if (ActiveUserMainForm != null)
            {
                //Game g = DatabeseDC.Games.Single(g => g.Id == 3);
                //ActiveUserMainForm.Results.Single(r => r.Game == g).Result1 

                foreach (Result result in DatabeseDC.Results)
                {
                    if (result.User == ActiveUserMainForm && result.GameID == 3)
                    {
                        if (newScore > result.Result1)
                        {
                            result.Result1 = newScore;
                            DatabeseDC.SubmitChanges();
                        }
                        labelScore.Text = result.Result1.ToString();
                        break;
                    }
                }
            }
        }

    }
}
