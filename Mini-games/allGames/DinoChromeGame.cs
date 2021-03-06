using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games.allGames
{
    public partial class DinoChromeGame : UserControl
    {
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();

        public delegate void ScoreHandler(int score);
        public event ScoreHandler Notify;

        public DinoChromeGame()
        {
            InitializeComponent();
            resetGame();
        }

        private void gameEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            scoreText.Text = "Score: " + score;

            if (jumping && force < 0)
                jumping = false;

            if (jumping)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
                jumpSpeed = 15;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        if (Notify != null) Notify(score);
                        trex.Image = Properties.Resources.trex_dead;
                        scoreText.Text += "  Press R to start OR press Esc to exit";
                    }
                }
            }

            if (trex.Top >= 380 && !jumping)
            {
                force = 12;
                trex.Top = floor.Top - trex.Height;
                jumpSpeed = 0;
            }

            if (score >= 10)
                obstacleSpeed = 15;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
                jumping = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                resetGame();

            if (jumping)
                jumping = false;
        }

        private void resetGame()
        {
            force = 12;
            trex.Top = floor.Top - trex.Height;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + score;
            trex.Image = Properties.Resources.trex;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    int position = rnd.Next(1000, 1500);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            gameTimer.Start();
        }

        private void UserControlDino_Load(object sender, EventArgs e)
        {

        }
    }
}
