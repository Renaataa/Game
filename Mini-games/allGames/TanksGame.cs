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
    public partial class TanksGame : UserControl
    {
        public TanksGame()
        {
            InitializeComponent();
            labelOver.Visible = false;
            resetGame();
        }

        bool up, down, right;
        Random rnd = new Random();
        public int score;

        private void resetGame()
        {
            labelOver.Visible = false;
            score = 0;
            ourTank.Location = new Point(33, 164);
            labelScore.Text = score.ToString();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    int position = rnd.Next(35, 172);
                    x.Left = 200 + (x.Left + position);
                }
            }

            enemy1.Location = new Point(723, 107);
            en_1.Left = enemy1.Left - 5;

            enemy2.Location = new Point(559, 247);
            en_2.Left = enemy2.Left - 5;

            tankTimer.Start();
        }

        void gameResult()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "block")
                {
                    if(ourTank.Bounds.IntersectsWith(x.Bounds)
                        || ourTank.Bounds.IntersectsWith(en_1.Bounds)
                        || ourTank.Bounds.IntersectsWith(en_2.Bounds)
                        || ourTank.Bounds.IntersectsWith(enemy1.Bounds)
                        || ourTank.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        labelOver.Visible = true;
                        tankTimer.Stop();
                    }
                }
            }
        }

        void bulletMove()
        {
            b_1.Left += 20;
            if(b_1.Left > 400)
            {
                b_1.Left = ourTank.Left;
                b_1.Top = ourTank.Top + 10;
                b_1.Image = Properties.Resources.bullet;
            }
            en_1.Left -= 10;
            if(en_1.Left < 10)
            {
                en_1.Image = Properties.Resources.bullet_en;
                en_1.Left = enemy1.Left;
                en_1.Top = enemy1.Top + 8;
            }
            en_2.Left -= 10;
            if(en_2.Left < 10)
            {
                en_2.Image = Properties.Resources.bullet_en;
                en_2.Left = enemy2.Left;
                en_2.Top = enemy2.Top + 8;
            }
        }

        void enemysMove()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "enemy")
                {
                    x.Left -= 5;
                    if(x.Left < 10)
                    {
                        int i;
                        i = rnd.Next(50, 600);
                        x.Location = new Point(1200, i);
                    }

                    if(b_1.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        labelScore.Text = score.ToString();
                        x.Left = 800;
                    }
                }
            }
        }

        void blockMove()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "block")
                {
                    if(x.Left < -150)
                    {
                        x.Left = 900;
                    }

                    if(right == true)
                    {
                        x.Left -= 5;
                    }

                    if(b_1.Bounds.IntersectsWith(x.Bounds))
                    {
                        b_1.Left = ourTank.Left;
                        b_1.Top = ourTank.Top + 10;
                    }
                }
            }
        }

        void playerMove()
        {
            if(up == true)
            {
                if(ourTank.Top > 20)
                {
                    ourTank.Top -= 5;
                }
            }
            if(down == true)
            {
                if(ourTank.Top < 270)
                {
                    ourTank.Top += 5;
                }
            }
        }

        private void TanksGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
        }

        private void TanksGame_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                up = false;
            }
            if(e.KeyCode == Keys.S)
            {
                down = false;
            }
            if(e.KeyCode == Keys.D)
            {
                right = false;
            }

            if(e.KeyCode == Keys.R)
            {
                resetGame();
            }
        }        

        private void tankTimer_Tick(object sender, EventArgs e)
        {
            playerMove();
            blockMove();
            enemysMove();
            bulletMove();
            gameResult();
        }
    }
}
