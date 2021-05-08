
namespace Mini_games.allGames
{
    partial class TanksGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanksGame));
            this.tankTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOver = new System.Windows.Forms.Label();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ourTank = new System.Windows.Forms.PictureBox();
            this.b_1 = new System.Windows.Forms.PictureBox();
            this.en_1 = new System.Windows.Forms.PictureBox();
            this.en_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // tankTimer
            // 
            this.tankTimer.Enabled = true;
            this.tankTimer.Interval = 30;
            this.tankTimer.Tick += new System.EventHandler(this.tankTimer_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(310, 10);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(13, 13);
            this.labelScore.TabIndex = 12;
            this.labelScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Score:";
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Location = new System.Drawing.Point(233, 133);
            this.labelOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(186, 26);
            this.labelOver.TabIndex = 14;
            this.labelOver.Text = "Game Over!\r\nPress R to start OR press Esc to exit";
            this.labelOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(419, 201);
            this.enemy2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(79, 54);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(542, 87);
            this.enemy1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(79, 54);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox6.Location = new System.Drawing.Point(563, 145);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 44);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox5.Location = new System.Drawing.Point(382, 33);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 44);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox4.Location = new System.Drawing.Point(372, 275);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 44);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox3.Location = new System.Drawing.Point(33, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 44);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox2.Location = new System.Drawing.Point(102, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox1.Location = new System.Drawing.Point(236, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // ourTank
            // 
            this.ourTank.Image = ((System.Drawing.Image)(resources.GetObject("ourTank.Image")));
            this.ourTank.Location = new System.Drawing.Point(25, 133);
            this.ourTank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ourTank.Name = "ourTank";
            this.ourTank.Size = new System.Drawing.Size(74, 40);
            this.ourTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ourTank.TabIndex = 0;
            this.ourTank.TabStop = false;
            // 
            // b_1
            // 
            this.b_1.Image = global::Mini_games.Properties.Resources.bullet;
            this.b_1.Location = new System.Drawing.Point(85, 140);
            this.b_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(28, 23);
            this.b_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_1.TabIndex = 9;
            this.b_1.TabStop = false;
            // 
            // en_1
            // 
            this.en_1.Image = ((System.Drawing.Image)(resources.GetObject("en_1.Image")));
            this.en_1.Location = new System.Drawing.Point(520, 103);
            this.en_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.en_1.Name = "en_1";
            this.en_1.Size = new System.Drawing.Size(24, 15);
            this.en_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en_1.TabIndex = 10;
            this.en_1.TabStop = false;
            // 
            // en_2
            // 
            this.en_2.Image = ((System.Drawing.Image)(resources.GetObject("en_2.Image")));
            this.en_2.Location = new System.Drawing.Point(397, 217);
            this.en_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.en_2.Name = "en_2";
            this.en_2.Size = new System.Drawing.Size(24, 15);
            this.en_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en_2.TabIndex = 11;
            this.en_2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox7.Location = new System.Drawing.Point(709, 254);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 44);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "block";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox8.Location = new System.Drawing.Point(784, 133);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 44);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Mini_games.Properties.Resources.block_min;
            this.pictureBox9.Location = new System.Drawing.Point(839, 10);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 44);
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "block";
            // 
            // TanksGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.labelOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ourTank);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.en_1);
            this.Controls.Add(this.en_2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TanksGame";
            this.Size = new System.Drawing.Size(900, 350);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TanksGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TanksGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ourTank;
        private System.Windows.Forms.Timer tankTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox b_1;
        private System.Windows.Forms.PictureBox en_1;
        private System.Windows.Forms.PictureBox en_2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
