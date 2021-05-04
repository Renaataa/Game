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
    public partial class PlaneGame : UserControl
    {
        bool up, down, left, right;
        Random rnd = new Random();
        public int score = 0;
        int fly = 0;
        MouseEventArgs me;

        public PlaneGame()
        {
            InitializeComponent();
        }

        private void tick(object sender, EventArgs e)
        {
            //pictureBox12.Top = MousePosition.Y;
            //pictureBox12.Left = MousePosition.X;
            if (outerRing.Width >= 200)
            {
                outerRing.Left = rnd.Next(0, 700);
                outerRing.Top = rnd.Next(50, 300);
                outerRing.Width = 3;
                outerRing.Height = 3;
                innerRing.Height = 2;
                innerRing.Width = 2;
                if (plane.Left > innerRing.Left && plane.Right < innerRing.Right)
                {
                    score++;
                }
            }
            else
            {
                outerRing.Width++;
                outerRing.Height++;
                if (innerRing.Right < outerRing.Right - (outerRing.Width / 10))
                {
                    innerRing.Height++;
                    innerRing.Width++;
                }
                innerRing.Left = outerRing.Left + (outerRing.Width / 10);
                innerRing.Top = outerRing.Top + (outerRing.Height / 10);
            }
            labelScore.Text = "Score: " + score;
            
            if (up == true)
            {
                outerRing.Top += 2;
            }
            if (down == true)
            {
                outerRing.Top -= 2;
            }
            if (left == true)
            {
                outerRing.Left += 2;
            }
            if (right == true)
            {
                outerRing.Left -= 2;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
        }


        private void tack(object sender, EventArgs e)
        {
            if (fly % 2 == 0)
            {
                plane.Top++;
                wings.Top++;
                tale.Top++;
                tale2.Top++;
            }
            else
            {
                plane.Top--;
                wings.Top--;
                tale.Top--;
                tale2.Top--;
            }
            fly++;
        }

        private void PlaneGame_Load(object sender, EventArgs e)
        {

        }
    }
}
