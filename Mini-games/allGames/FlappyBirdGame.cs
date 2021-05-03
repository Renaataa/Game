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
    public partial class FlappyBirdGame : UserControl
    {
        public FlappyBirdGame()
        {
            InitializeComponent();
        }
        public static int Id = 2;
        int diff = 0;
        int speed = 0;
        int gravity = 1;
        public int score = 0;
        bool ison = false;
        Random rnd = new Random();
        PictureBox[] pipe = new PictureBox[6];
        PictureBox[] topPipe = new PictureBox[6];
        private void timerEvent(object sender, EventArgs e)
        {
            if (ison == true)
            {
                speed += gravity;
                bird.Top += speed;
                for (int i = 0; i <= 1; i++)
                {
                    pipe[i].Left -= (7 + diff);
                    topPipe[i].Left -= (7 + diff);
                    if (pipe[i].Left < -60)
                    {
                        score++;
                        labelScore.Text = "Score: " + score;
                        topPipe[i].Top = rnd.Next(-400, -200);
                        pipe[i].Top = topPipe[i].Bottom + 150 + (150 / (1 + rnd.Next(diff * 3, diff * 10)));
                        if (i == 1)
                            pipe[1].Left = pipe[0].Left + 400 + rnd.Next(0, 100);
                        else if (i == 0)
                            pipe[0].Left = pipe[1].Left + 400 + rnd.Next(0, 100);
                        topPipe[i].Left = pipe[i].Left;
                    }
                }
                if (score > 0 && score % 5 == 0)
                {
                    diff++;
                    score++;
                }
                if (bird.Bounds.IntersectsWith(pipe[1].Bounds) ||
                    bird.Bounds.IntersectsWith(pipe[0].Bounds) ||
                    bird.Bounds.IntersectsWith(topPipe[0].Bounds) ||
                    bird.Bounds.IntersectsWith(topPipe[1].Bounds) ||
                    bird.Bounds.IntersectsWith(ground1.Bounds) || bird.Top < -25)
                    endGame();
            }

        }
        private void endGame()
        {
            timer1.Stop();
            labelScore.Text += " Game over! Press R to start OR press Esc to exit";
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && ison == true)
            {
                speed -= 8;
            }
            else if (e.KeyCode == Keys.Space && ison == false)
            {
                ison = true;
                resetGame();
            }
            if (e.KeyCode == Keys.R)
            {
                resetGame();
            }
            if (e.KeyCode == Keys.Q)
            {
                this.Visible = false;
                //Dispose(true);
            }
            if (e.KeyCode == Keys.F)
            {
                if (ison == true)
                {
                    timer1.Start();
                    ison = false;
                }
                else if (ison == false)
                {
                    timer1.Start();
                    ison = true;
                }

            }
        }
        private void pipeGen()
        {
            for (int i = 0; i < 2; i++)
            {
                PictureBox temp = new PictureBox();
                this.Controls.Add(temp);
                temp.Width = 60;
                temp.Height = 400;
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.BackColor = Color.Black;
                temp.Top = topPipe[i].Bottom + 200;
                temp.Left = topPipe[i].Left;
                pipe[i] = temp;
                pipe[i].Visible = true;
            }
        }

        private void pipeTopGen()
        {
            for (int i = 0; i < 2; i++)
            {
                PictureBox temp = new PictureBox();
                this.Controls.Add(temp);
                temp.Width = 60;
                temp.Height = 400;
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.BackColor = Color.Red;
                temp.Top = rnd.Next(-300, -100); ;
                temp.Left = i * 400 + 500;
                topPipe[i] = temp;
                topPipe[i].Visible = true;
            }
        }
        private void resetGame()
        {
            diff = 0;
            speed = 0;
            gravity = 1;
            score = 0;
            labelScore.Text = "Score: " + score;
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Remove(topPipe[i]);
                this.Controls.Remove(pipe[i]);
            }
            bird.Left = 135;
            bird.Top = 215;
            pipeTopGen();
            pipeGen();
            timer1.Start();
        }

        private void FlappyBirdGame_Load(object sender, EventArgs e)
        {

        }
    }
}