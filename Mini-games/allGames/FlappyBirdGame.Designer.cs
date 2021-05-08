
namespace Mini_games.allGames
{
    partial class FlappyBirdGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timerEvent);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Yellow;
            this.bird.Location = new System.Drawing.Point(61, 303);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(33, 34);
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Peru;
            this.ground1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground1.Location = new System.Drawing.Point(0, 650);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(900, 50);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            this.ground1.Tag = "Ground";
            // 
            // labelScore
            // 
            this.labelScore.AutoEllipsis = true;
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Peru;
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelScore.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(3, 663);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(101, 24);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: ";
            // 
            // FlappyBirdGame
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground1);
            this.Name = "FlappyBirdGame";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.FlappyBirdGame_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.Label labelScore;
    }
}

