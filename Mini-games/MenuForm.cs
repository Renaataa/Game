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
        allGames.PlatformGame platform = new allGames.PlatformGame();
        allGames.TanksGame tanks = new allGames.TanksGame();
        allGames.PlaneGame plane = new allGames.PlaneGame();
        AllResultsTable table = new AllResultsTable();
        Game currentGame;

        public MenuForm(User user)
        {
            InitializeComponent();
            this.ActiveUserMainForm = user;
            LoadActiveUser();
            //UpdateScore();
        }

        private void LoadActiveUser()
        {
            if (ActiveUserMainForm != null)
            {
                textBoxNickname.Text = ActiveUserMainForm.Nickname.ToString();
                textBoxPassword.Text = ActiveUserMainForm.Password.ToString();
            }
        }

        private void buttonDino_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            
            panelGame.Controls.Add(dino);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "DinoChrome";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "DinoChrome");
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            
            panelGame.Controls.Add(fbird);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "FlappyBird";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "FlappyBird");
        }

        private void buttonPlatform_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(platform);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "Platform";
        }

        private void buttonTanks_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(tanks);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "Tanks";

        //    currentGame = DatabaseDC.Games.Single(name => name.Name == "Tanks");
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(table);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "Results";
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

        public void UpdateScore()
        {
            if (ActiveUserMainForm != null)
            {
                if(currentGame != null)
                {
                    Result PreviousResult;
                    int newDinoScore = dino.score;
                    int newFBScore = fbird.score;
                //    int newTanksScore = tanks.score;

                    PreviousResult = DatabaseDC.Results.Single(data => data.GameID == currentGame.Id && data.UserID == ActiveUserMainForm.Id);

                    if (currentGame.Id == 1 && newDinoScore > PreviousResult.Result1)
                    {
                        PreviousResult.Result1 = newDinoScore;
                        labelDinoScore.Text = PreviousResult.Result1.ToString();
                    }

                    if (currentGame.Id == 2 && newFBScore > PreviousResult.Result1)
                    {
                        PreviousResult.Result1 = newFBScore;
                        labelFBScore.Text = PreviousResult.Result1.ToString();
                    }

                //    if (currentGame.Id == 8 && newTanksScore > PreviousResult.Result1)
                //    {
                //        PreviousResult.Result1 = newTanksScore;
                //        labelTanksScore.Text = PreviousResult.Result1.ToString();
                //    }
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

        private void MenuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panelGame.Controls.Clear();
                panelMenu.Show();
                //UpdateScore();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(plane);
            panelGame.Controls.Add(buttonGameExit);

            this.Text = "Plane";
        }
    }
}
