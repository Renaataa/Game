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
using System.Media;

namespace Mini_games
{
    public partial class MenuForm : Form
    {
        DatabaseUsersDataContext DatabaseDC = new DatabaseUsersDataContext();
        User ActiveUserMainForm = new User();
        allGames.DinoChromeGame dino = new allGames.DinoChromeGame();
        allGames.FlappyBirdGame fbird = new allGames.FlappyBirdGame();
        allGames.PlatformGame.PlatformMenu platformMenu = new allGames.PlatformGame.PlatformMenu();
        allGames.PlatformGameLevel1 platformL1 = new allGames.PlatformGameLevel1();
        allGames.PlatformGameLevel2 platformL2 = new allGames.PlatformGameLevel2();
        allGames.TanksGame tanks = new allGames.TanksGame();
        allGames.PlaneGame plane = new allGames.PlaneGame();
        AllResultsTable table = new AllResultsTable();
        Game currentGame;

        public MenuForm(User user)
        {
            InitializeComponent();
            this.ActiveUserMainForm = user;
            LoadActiveUser();
            UpdateScore();
        }

        private void LoadActiveUser()
        {
            if (ActiveUserMainForm != null)
            {
                lableNickname.Text = ActiveUserMainForm.Nickname.ToString();
                //textBoxPassword.Text = ActiveUserMainForm.Password.ToString();
            }
        }

        private void buttonDino_Click(object sender, EventArgs e)
        {
            
            dino.Show();
            panelMenu.Hide();
            panelGame.Controls.Add(dino);
            panelGame.Focus();
            panelGame.Controls.Add(buttonExit);
            dino.Notify += RecordNewScore;

            this.Text = "DinoChrome";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "DinoChrome");
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\level.wav";
            sp.PlayLooping();
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            
            panelGame.Controls.Add(fbird);
            panelGame.Controls.Add(buttonGameExit);
            fbird.ScoreUpdate += RecordNewScore;

            this.Text = "FlappyBird";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "FlappyBird");
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\level.wav";
            sp.PlayLooping();
        }

        private void buttonPlatform_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(platformMenu);
            panelGame.Controls.Add(buttonGameExit);
            platformMenu.LoadLevel += LoadLevel;
            platformMenu.CurrentLevel += CurrentLevel;

            platformMenu.disableButtons();

            this.Text = "Platform Menu";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "Platform");
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\level.wav";
            sp.PlayLooping();

        }

        private void buttonTanks_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(tanks);
            panelGame.Controls.Add(buttonGameExit);
            tanks.ScoreUpdate += RecordNewScore;

            this.Text = "Tanks";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "Tanks");
            SoundPlayer sp1 = new SoundPlayer();
            sp1.SoundLocation = @".\level.wav";
            sp1.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();

            panelGame.Controls.Add(plane);
            panelGame.Focus();
            panelGame.Controls.Add(buttonGameExit);
            plane.ScoreUpdate += RecordNewScore;

            this.Text = "Plane";

            currentGame = DatabaseDC.Games.Single(name => name.Name == "Plane");
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\level.wav";
            sp.PlayLooping();
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
            DialogResult dialog = System.Windows.Forms.MessageBox.Show(
                "Are you sure you want to quit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if(dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form2Closing_1);
            this.FormClosed += new FormClosedEventHandler(Form2Closed_1);

        }

        private void Form2Closing_1(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form2Closed_1(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void UpdateScore()
        {   
            if (ActiveUserMainForm != null && currentGame == null)
            {
                Result CurrentResult;
                int gameCount = DatabaseDC.Games.Count();
                for (int i = 0; i < gameCount; i++)
                {
                    CurrentResult = DatabaseDC.Results.Single(data => data.GameID == i+1 && data.UserID == ActiveUserMainForm.Id);
                    if (i == 0) labelDinoScore.Text = CurrentResult.Result1.ToString();
                    if (i == 1) labelFBScore.Text = CurrentResult.Result1.ToString();
                    if (i == 2) labelTanksScore.Text = CurrentResult.Result1.ToString();
                    if (i == 3) labelPlaneScore.Text = CurrentResult.Result1.ToString();
                    if (i == 4) labelPlatformScore.Text = CurrentResult.Result1.ToString();
                }
            }
        }

        public void RecordNewScore(int score)
        {
            if (ActiveUserMainForm != null && currentGame != null)
            {
                Level CurrentLevel;
                Result PreviousResult;
                CurrentLevel = DatabaseDC.Levels.Single(data => data.GameID == 5 && data.UserID == ActiveUserMainForm.Id);
                PreviousResult = DatabaseDC.Results.Single(data => data.GameID == currentGame.Id && data.UserID == ActiveUserMainForm.Id);

                if (currentGame.Id == 5)
                {
                    PreviousResult.Result1 += score;
                    labelPlatformScore.Text = PreviousResult.Result1.ToString();
                }
                else if (score > PreviousResult.Result1)
                {
                    PreviousResult.Result1 = score;

                    if (currentGame.Id == 1) labelDinoScore.Text = PreviousResult.Result1.ToString();
                    if (currentGame.Id == 2) labelFBScore.Text = PreviousResult.Result1.ToString();
                    if (currentGame.Id == 3) labelTanksScore.Text = PreviousResult.Result1.ToString();
                    if (currentGame.Id == 4) labelPlaneScore.Text = PreviousResult.Result1.ToString();
                }

                DatabaseDC.SubmitChanges();
            }
        }

        private void UpdateLevel(int level)
        {
            Level PreviousLevel;
            PreviousLevel = DatabaseDC.Levels.Single(data => data.GameID == 5 && data.UserID == ActiveUserMainForm.Id);
            PreviousLevel.Level1 = level;
            DatabaseDC.SubmitChanges();
        }

        private void LoadLevel(int level)
        {
            if(level == 1)
            {
                panelGame.Controls.Clear();
                panelGame.Controls.Add(platformL1);
                platformL1.ScoreUpdate += RecordNewScore;
                platformL1.LevelUpdate += UpdateLevel;
                this.Text = "PlatformL1";
            }
            if (level == 2)
            {
                panelGame.Controls.Clear();
                panelGame.Controls.Add(platformL2);
                platformL2.ScoreUpdate += RecordNewScore;
                this.Text = "PlatformL2";
            }
        }

        public Level CurrentLevel()
        {
            Level CurrentLevel;
            CurrentLevel = DatabaseDC.Levels.Single(data => data.GameID == 5 && data.UserID == ActiveUserMainForm.Id);

            return CurrentLevel;
        }

        private void MenuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && (String.Compare(this.Text, "PlatformL1") == 0 || String.Compare(this.Text, "PlatformL2") == 0))
            {
                panelGame.Controls.Clear();
                panelGame.Controls.Add(platformMenu);
                platformMenu.LoadLevel += LoadLevel;
                platformMenu.CurrentLevel += CurrentLevel;
                
                platformMenu.disableButtons();

                this.Text = "Platform Menu";
            }
            else if (e.KeyCode == Keys.Escape)
            {
                panelGame.Controls.Clear();
                panelMenu.Show();
                UpdateScore();
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @".\bgm1.wav";
                sp.PlayLooping();
            }

            if (!panelMenu.Visible && String.Compare(this.Text, "PlatformL1") == 0 && e.KeyCode == Keys.N && platformL1.win)
            {
                panelGame.Controls.Clear();
                panelGame.Controls.Add(platformL2);

                this.Text = "PlatformL2";
            }
        }

        private void buttonClickExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void starter(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\bgm1.wav";
            sp.PlayLooping();
        }
    }
}
