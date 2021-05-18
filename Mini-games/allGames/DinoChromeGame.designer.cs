
namespace Mini_games.allGames
{
    partial class DinoChromeGame
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.obstacle = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(12, 5);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(53, 15);
            this.scoreText.TabIndex = 8;
            this.scoreText.Tag = "scoreText";
            this.scoreText.Text = "Score- 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tag = "gameTimer";
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(537, 631);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 30);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(409, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 58);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle";
            // 
            // obstacle
            // 
            this.obstacle.BackColor = System.Drawing.Color.Black;
            this.obstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.obstacle.Location = new System.Drawing.Point(300, 605);
            this.obstacle.Name = "obstacle";
            this.obstacle.Size = new System.Drawing.Size(25, 58);
            this.obstacle.TabIndex = 7;
            this.obstacle.TabStop = false;
            this.obstacle.Tag = "obstacle";
            // 
            // trex
            // 
            this.trex.BackColor = System.Drawing.Color.Transparent;
            this.trex.Image = global::Mini_games.Properties.Resources.trex;
            this.trex.Location = new System.Drawing.Point(39, 595);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(54, 66);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 5;
            this.trex.TabStop = false;
            this.trex.Tag = "trex";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Cursor = System.Windows.Forms.Cursors.Default;
            this.floor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.floor.Location = new System.Drawing.Point(0, 660);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(900, 40);
            this.floor.TabIndex = 4;
            this.floor.TabStop = false;
            this.floor.Tag = "floor";
            // 
            // DinoChromeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.floor);
            this.Name = "DinoChromeGame";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.UserControlDino_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox obstacle;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
