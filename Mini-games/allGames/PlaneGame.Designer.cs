
namespace Mini_games.allGames
{
    partial class PlaneGame
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
            this.innerRing = new System.Windows.Forms.PictureBox();
            this.outerRing = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tale = new System.Windows.Forms.PictureBox();
            this.plane = new System.Windows.Forms.PictureBox();
            this.tale2 = new System.Windows.Forms.PictureBox();
            this.wings = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outerRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // innerRing
            // 
            this.innerRing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.innerRing.BackColor = System.Drawing.Color.Transparent;
            this.innerRing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerRing.Location = new System.Drawing.Point(293, 78);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(336, 340);
            this.innerRing.TabIndex = 0;
            this.innerRing.TabStop = false;
            // 
            // outerRing
            // 
            this.outerRing.BackColor = System.Drawing.Color.Gold;
            this.outerRing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerRing.Location = new System.Drawing.Point(279, 59);
            this.outerRing.Name = "outerRing";
            this.outerRing.Size = new System.Drawing.Size(363, 379);
            this.outerRing.TabIndex = 0;
            this.outerRing.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // tale
            // 
            this.tale.BackColor = System.Drawing.Color.Maroon;
            this.tale.Location = new System.Drawing.Point(395, 273);
            this.tale.Name = "tale";
            this.tale.Size = new System.Drawing.Size(18, 50);
            this.tale.TabIndex = 6;
            this.tale.TabStop = false;
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.Color.Maroon;
            this.plane.Location = new System.Drawing.Point(389, 262);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(33, 41);
            this.plane.TabIndex = 6;
            this.plane.TabStop = false;
            // 
            // tale2
            // 
            this.tale2.BackColor = System.Drawing.Color.Maroon;
            this.tale2.Location = new System.Drawing.Point(389, 318);
            this.tale2.Name = "tale2";
            this.tale2.Size = new System.Drawing.Size(33, 18);
            this.tale2.TabIndex = 7;
            this.tale2.TabStop = false;
            // 
            // wings
            // 
            this.wings.BackColor = System.Drawing.Color.Maroon;
            this.wings.Location = new System.Drawing.Point(357, 271);
            this.wings.Name = "wings";
            this.wings.Size = new System.Drawing.Size(96, 18);
            this.wings.TabIndex = 8;
            this.wings.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(36, 13);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.tack);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 67);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-55, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 67);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(-55, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 67);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(-27, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 101);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(-38, 305);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 67);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(672, 399);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(143, 67);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(710, 371);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(143, 67);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(751, 177);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(143, 67);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(685, 144);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(143, 67);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(710, 104);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(143, 67);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Orange;
            this.pictureBox11.Location = new System.Drawing.Point(685, -23);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(143, 67);
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(16, 152);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 50);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            // 
            // PlaneGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.wings);
            this.Controls.Add(this.tale2);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.tale);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.innerRing);
            this.Controls.Add(this.outerRing);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PlaneGame";
            this.Size = new System.Drawing.Size(800, 500);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outerRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox innerRing;
        private System.Windows.Forms.PictureBox outerRing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox tale;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.PictureBox tale2;
        private System.Windows.Forms.PictureBox wings;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}

