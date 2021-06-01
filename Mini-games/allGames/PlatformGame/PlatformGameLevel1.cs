using System;
using System.Windows.Forms;
using WMPLib;

namespace Mini_games.allGames
{
    public partial class PlatformGameLevel1 : UserControl
    {
        //WindowsMediaPlayer bg = new WindowsMediaPlayer();
        bool moveLeft, moveRight, jump, gameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 4;
        int enemyTwoSpeed = 3;

        public bool win = false;

        public delegate void ScoreHandler(int data);
        public event ScoreHandler ScoreUpdate;
        public event ScoreHandler LevelUpdate;

        public PlatformGameLevel1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Location = new System.Drawing.Point(3, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox2.Location = new System.Drawing.Point(270, 420);
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
            this.verticalPlatform.Location = new System.Drawing.Point(542, 345);
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
            this.player.Location = new System.Drawing.Point(27, 411);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 40);
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
            this.enemyTwo.Location = new System.Drawing.Point(416, 380);
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
            this.pictureBox39.Location = new System.Drawing.Point(270, 380);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(25, 25);
            this.pictureBox39.TabIndex = 14;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Tag = "coin";
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox40.Location = new System.Drawing.Point(401, 380);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(25, 25);
            this.pictureBox40.TabIndex = 14;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Tag = "coin";
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox41.Location = new System.Drawing.Point(352, 380);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(25, 25);
            this.pictureBox41.TabIndex = 14;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Tag = "coin";
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox42.Location = new System.Drawing.Point(311, 380);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(25, 25);
            this.pictureBox42.TabIndex = 14;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.Tag = "coin";
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox43.Location = new System.Drawing.Point(452, 380);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(25, 25);
            this.pictureBox43.TabIndex = 14;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Tag = "coin";
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox44.Location = new System.Drawing.Point(491, 380);
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
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox6.Location = new System.Drawing.Point(651, 252);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 30);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox14.Location = new System.Drawing.Point(651, 221);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(25, 25);
            this.pictureBox14.TabIndex = 17;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox15.Location = new System.Drawing.Point(695, 221);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(25, 25);
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox16.Location = new System.Drawing.Point(739, 221);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(25, 25);
            this.pictureBox16.TabIndex = 17;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox17.Location = new System.Drawing.Point(785, 221);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 25);
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox18.Location = new System.Drawing.Point(826, 221);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 25);
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(534, 3);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(317, 109);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScore.UseCompatibleTextRendering = true;
            // 
            // PlatformGameLevel1
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox6);
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
            this.Name = "PlatformGameLevel1";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.PlatformGameLevel1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
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
                            WindowsMediaPlayer pl1 = new WindowsMediaPlayer();
                            pl1.URL = @".\jump (2).wav";
                            pl1.controls.play();

                            score++;
                        }
                    }

                    if (control.Tag != null && control.Tag.ToString() == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds))
                        {
                            timer.Stop();
                            gameOver = true;
                            WindowsMediaPlayer pl3 = new WindowsMediaPlayer();
                            pl3.URL = @".\ko.wav";
                            pl3.controls.play();
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

            if(verticalPlatform.Top > 345 || verticalPlatform.Top < 252)
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
                WindowsMediaPlayer pl3 = new WindowsMediaPlayer();
                pl3.URL = @".\ko.wav";
                pl3.controls.play();
                labelScore.Text = "Score: " + score + Environment.NewLine + "You fell to your death!"
                                                    + Environment.NewLine + "R - reset";
            }

            if(player.Bounds.IntersectsWith(door.Bounds) && score == 18)
            {
                timer.Stop();
                gameOver = true;
                win = true;
                if (ScoreUpdate != null) ScoreUpdate(score);
                if (LevelUpdate != null) LevelUpdate(2);
                labelScore.Text = "Score: " + score + Environment.NewLine + "Your quest is complete!"
                                                    + Environment.NewLine + "R - reset"
                                                    + Environment.NewLine + "N - next level"; ;
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
                WindowsMediaPlayer pl1 = new WindowsMediaPlayer();
                pl1.URL = @".\mario_jump3.wav";
                pl1.controls.play();

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
            win = false;
            score = 0;

            WindowsMediaPlayer bg = new WindowsMediaPlayer();
            bg.URL = @".\level.wav";
            if (bg.playState == WMPPlayState.wmppsStopped)
            {
                bg.controls.play();
            }
            
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
            enemyTwo.Left = 416;

            horizontalPlatform.Left = 228;
            verticalPlatform.Top = 345;

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

        private void PlatformGameLevel1_Load(object sender, EventArgs e)
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
