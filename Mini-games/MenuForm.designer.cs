
namespace Mini_games
{
    partial class MenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.buttonDino = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelScoreFB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.buttonGameExit = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(3, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(214, 32);
            this.label.TabIndex = 0;
            this.label.Text = "Choose a game";
            // 
            // buttonDino
            // 
            this.buttonDino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDino.Location = new System.Drawing.Point(204, 87);
            this.buttonDino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDino.Name = "buttonDino";
            this.buttonDino.Size = new System.Drawing.Size(176, 39);
            this.buttonDino.TabIndex = 1;
            this.buttonDino.Text = "DinoChrom";
            this.buttonDino.UseVisualStyleBackColor = true;
            this.buttonDino.Click += new System.EventHandler(this.buttonDino_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.labelScoreFB);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.buttonFB);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.labelScore);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textBoxPassword);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.textBoxNickname);
            this.panelMenu.Controls.Add(this.Label1);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.label);
            this.panelMenu.Controls.Add(this.buttonDino);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(841, 359);
            this.panelMenu.TabIndex = 2;
            // 
            // labelScoreFB
            // 
            this.labelScoreFB.AutoSize = true;
            this.labelScoreFB.Location = new System.Drawing.Point(57, 159);
            this.labelScoreFB.Name = "labelScoreFB";
            this.labelScoreFB.Size = new System.Drawing.Size(16, 17);
            this.labelScoreFB.TabIndex = 22;
            this.labelScoreFB.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Score:";
            // 
            // buttonFB
            // 
            this.buttonFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFB.Location = new System.Drawing.Point(204, 145);
            this.buttonFB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFB.Name = "buttonFB";
            this.buttonFB.Size = new System.Drawing.Size(176, 39);
            this.buttonFB.TabIndex = 20;
            this.buttonFB.Text = "FlappyBird";
            this.buttonFB.UseVisualStyleBackColor = true;
            this.buttonFB.Click += new System.EventHandler(this.buttonFB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(57, 101);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 17);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Active user:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(649, 63);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(181, 22);
            this.textBoxPassword.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(649, 28);
            this.textBoxNickname.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(181, 22);
            this.textBoxNickname.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(573, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 17);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Nickname";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(748, 319);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 39);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.buttonGameExit);
            this.panelGame.Location = new System.Drawing.Point(12, 15);
            this.panelGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(841, 685);
            this.panelGame.TabIndex = 3;
            // 
            // buttonGameExit
            // 
            this.buttonGameExit.Location = new System.Drawing.Point(748, 645);
            this.buttonGameExit.Name = "buttonGameExit";
            this.buttonGameExit.Size = new System.Drawing.Size(89, 37);
            this.buttonGameExit.TabIndex = 0;
            this.buttonGameExit.Text = "Exit";
            this.buttonGameExit.UseVisualStyleBackColor = true;
            this.buttonGameExit.Click += new System.EventHandler(this.buttonGameExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 713);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelGame);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuForm";
            this.ShowInTaskbar = false;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2Closing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2Closed_1);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonDino;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonFB;
        private System.Windows.Forms.Label labelScoreFB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGameExit;
    }
}