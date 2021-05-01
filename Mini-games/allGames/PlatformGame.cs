using System;
using System.Windows.Forms;

namespace Mini_games.allGames
{
    public partial class PlatformGame : UserControl
    {
        bool moveLeft, moveRight, jump, gameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 4;
        int enemyTwoSpeed = 3;

        public PlatformGame()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.horizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(263, 10);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(317, 109);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Location = new System.Drawing.Point(3, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox2.Location = new System.Drawing.Point(203, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox4.Location = new System.Drawing.Point(349, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 30);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox5.Location = new System.Drawing.Point(3, 294);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(202, 30);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // horizontalPlatform
            // 
            this.horizontalPlatform.BackColor = System.Drawing.Color.SaddleBrown;
            this.horizontalPlatform.Location = new System.Drawing.Point(228, 142);
            this.horizontalPlatform.Name = "horizontalPlatform";
            this.horizontalPlatform.Size = new System.Drawing.Size(221, 30);
            this.horizontalPlatform.TabIndex = 7;
            this.horizontalPlatform.TabStop = false;
            this.horizontalPlatform.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox8.Location = new System.Drawing.Point(3, 63);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(175, 30);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // verticalPlatform
            // 
            this.verticalPlatform.BackColor = System.Drawing.Color.SaddleBrown;
            this.verticalPlatform.Location = new System.Drawing.Point(479, 350);
            this.verticalPlatform.Name = "verticalPlatform";
            this.verticalPlatform.Size = new System.Drawing.Size(76, 30);
            this.verticalPlatform.TabIndex = 9;
            this.verticalPlatform.TabStop = false;
            this.verticalPlatform.Tag = "platform";
            this.verticalPlatform.Click += new System.EventHandler(this.verticalPlatform_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.MidnightBlue;
            this.player.Location = new System.Drawing.Point(27, 465);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 40);
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.DarkGreen;
            this.door.Location = new System.Drawing.Point(3, 3);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(44, 65);
            this.door.TabIndex = 11;
            this.door.TabStop = false;
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.enemyOne.Location = new System.Drawing.Point(166, 257);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(30, 40);
            this.enemyOne.TabIndex = 12;
            this.enemyOne.TabStop = false;
            this.enemyOne.Tag = "enemy";
            this.enemyOne.Click += new System.EventHandler(this.enemyOne_Click);
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.enemyTwo.Location = new System.Drawing.Point(349, 381);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(30, 40);
            this.enemyTwo.TabIndex = 13;
            this.enemyTwo.TabStop = false;
            this.enemyTwo.Tag = "enemy";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox21.Location = new System.Drawing.Point(3, 257);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(25, 25);
            this.pictureBox21.TabIndex = 14;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox22.Location = new System.Drawing.Point(135, 257);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(25, 25);
            this.pictureBox22.TabIndex = 14;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "coin";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox23.Location = new System.Drawing.Point(91, 257);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(25, 25);
            this.pictureBox23.TabIndex = 14;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "coin";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox24.Location = new System.Drawing.Point(50, 257);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(25, 25);
            this.pictureBox24.TabIndex = 14;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coin";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox25.Location = new System.Drawing.Point(180, 257);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(25, 25);
            this.pictureBox25.TabIndex = 14;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "coin";
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox31.Location = new System.Drawing.Point(351, 226);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(25, 25);
            this.pictureBox31.TabIndex = 14;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Tag = "coin";
            this.pictureBox31.Click += new System.EventHandler(this.pictureBox31_Click);
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox34.Location = new System.Drawing.Point(387, 226);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(25, 25);
            this.pictureBox34.TabIndex = 14;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Tag = "coin";
            this.pictureBox34.Click += new System.EventHandler(this.pictureBox34_Click);
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox39.Location = new System.Drawing.Point(203, 381);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(25, 25);
            this.pictureBox39.TabIndex = 14;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Tag = "coin";
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox40.Location = new System.Drawing.Point(334, 381);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(25, 25);
            this.pictureBox40.TabIndex = 14;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Tag = "coin";
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox41.Location = new System.Drawing.Point(285, 381);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(25, 25);
            this.pictureBox41.TabIndex = 14;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Tag = "coin";
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox42.Location = new System.Drawing.Point(244, 381);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(25, 25);
            this.pictureBox42.TabIndex = 14;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.Tag = "coin";
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox43.Location = new System.Drawing.Point(385, 381);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(25, 25);
            this.pictureBox43.TabIndex = 14;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Tag = "coin";
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox44.Location = new System.Drawing.Point(424, 381);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(25, 25);
            this.pictureBox44.TabIndex = 14;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.Tag = "coin";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.PlatformGameTimerEvent);
            // 
            // PlatformGame
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.player);
            this.Controls.Add(this.verticalPlatform);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.horizontalPlatform);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.door);
            this.Name = "PlatformGame";
            this.Size = new System.Drawing.Size(583, 544);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            this.ResumeLayout(false);

        }

        private void PlatformGameTimerEvent(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score + Environment.NewLine + "Collect all the coins" 
                                                + Environment.NewLine + "A, D, W: <-, ->, ^"; ;

            player.Top += jumpSpeed;

            if(moveLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (moveRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jump == true && force < 0)
            {
                jump = false;
            }

            if (jump == true)
            {
                jumpSpeed = -8;
                force--;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach(Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    if(control.Tag != null && control.Tag.ToString() == "platform")
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds))
                        {
                            force = 8;
                            player.Top = control.Top - player.Height;

                            if(control.Name.ToString() == "horizontalPlatform" && moveLeft == false && moveRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }

                        control.BringToFront();
                    }

                    if (control.Tag != null && control.Tag.ToString() == "coin")
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            score++;
                        }
                    }

                    if (control.Tag != null && control.Tag.ToString() == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds))
                        {
                            timer.Stop();
                            gameOver = true;
                            labelScore.Text = "Score: " + score + Environment.NewLine + "You were killed!"
                                                                + Environment.NewLine + "R - reset";
                        }
                    }
                }
            }


            horizontalPlatform.Left -= horizontalSpeed;

            if(horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if(verticalPlatform.Top > 350 || verticalPlatform.Top < 200)
            {
                verticalSpeed = -verticalSpeed;
            }


            enemyOne.Left -= enemyOneSpeed;

            if(enemyOne.Left < pictureBox5.Left || enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemyTwo.Left += enemyTwoSpeed;

            if (enemyTwo.Left < pictureBox2.Left || enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if(player.Top + player.Height > this.ClientSize.Height + 50)
            {
                timer.Stop();
                gameOver = true;
                labelScore.Text = "Score: " + score + Environment.NewLine + "You fell to your death!"
                                                    + Environment.NewLine + "R - reset";
            }

            if(player.Bounds.IntersectsWith(door.Bounds) && score == 13)
            {
                timer.Stop();
                gameOver = true;
                labelScore.Text = "Score: " + score + Environment.NewLine + "Your quest is complete!"
                                                    + Environment.NewLine + "R - reset";
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.W && jump == false)
            {
                jump = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.W && jump == true)
            {
                jump = false;
            }

            if(e.KeyCode == Keys.R && gameOver == true)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            jump = false;
            moveLeft = false;
            moveRight = false;
            gameOver = false;
            score = 0;

            labelScore.Text = "Score: " + score;

            foreach (Control control in this.Controls)
            {
                if(control is PictureBox && control.Visible == false)
                {
                    control.Visible = true;
                }
            }

            player.Left = 27;
            player.Top = 465;

            enemyOne.Left = 166;
            enemyTwo.Left = 349;

            horizontalPlatform.Left = 228;
            verticalPlatform.Top = 350;

            timer.Start();
        }

        private void enemyOne_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void door_Click(object sender, EventArgs e)
        {

        }

        private void verticalPlatform_Click(object sender, EventArgs e)
        {

        }
    }
}
