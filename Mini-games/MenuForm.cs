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
        DatabaseUsersDataContext DatabaseDC = new DatabaseUsersDataContext();
        User ActiveUserMainForm = new User();
        allGames.DinoChromeGame dino = new allGames.DinoChromeGame();
        allGames.FlappyBirdGame fbird = new allGames.FlappyBirdGame();
        int gameId = 0;

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

            Game game = DatabaseDC.Games.Single(name => name.Name == "DinoChrome");
            gameId = game.Id;
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            
            panelGame.Controls.Add(fbird);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "FlappyBird";

            Game game = DatabaseDC.Games.Single(name => name.Name == "FlappyBird");
            gameId = game.Id;
        }

        private void buttonGameExit_Click(object sender, EventArgs e)
        {
            panelGame.Controls.Clear();
            panelMenu.Show();
            UpdateScore();
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

        public void UpdateScore()
        {
            if (ActiveUserMainForm != null)
            {
                if(gameId != 0)
                {
                    Result PreviousResult;
                    int newDinoScore = dino.score;
                    int newFBScore = fbird.score;

                    PreviousResult = DatabaseDC.Results.Single(data => data.GameID == gameId && data.UserID == ActiveUserMainForm.Id);

                    if (gameId == 1 && newDinoScore > PreviousResult.Result1)
                    {
                        PreviousResult.Result1 = newDinoScore;
                        labelDinoScore.Text = PreviousResult.Result1.ToString();
                    }

                    if (gameId == 2 && newFBScore > PreviousResult.Result1)
                    {
                        PreviousResult.Result1 = newFBScore;
                        labelFBScore.Text = PreviousResult.Result1.ToString();
                    }
                    DatabaseDC.SubmitChanges();
                }
                else
                {
                    Result CurrentResult;
                    int gameCount = DatabaseDC.Games.Count();
                    for (int i = 0; i < gameCount; i++)
                    {
                        CurrentResult = DatabaseDC.Results.Single(data => data.GameID == i+1 && data.UserID == ActiveUserMainForm.Id);
                        if (i == 0) labelDinoScore.Text = CurrentResult.Result1.ToString();
                        if (i == 1) labelFBScore.Text = CurrentResult.Result1.ToString();
                    }
                }
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
