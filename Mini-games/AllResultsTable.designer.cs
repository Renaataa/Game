
namespace Mini_games
{
    partial class AllResultsTable
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game:";
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Items.AddRange(new object[] {
            "DinoChrome",
            "FlappyBird"});
            this.comboBoxGames.Location = new System.Drawing.Point(106, 95);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(228, 24);
            this.comboBoxGames.TabIndex = 3;
            this.comboBoxGames.SelectedIndexChanged += new System.EventHandler(this.comboBoxGames_SelectedIndexChanged);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(241, 168);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(128, 260);
            this.listBoxResults.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score";
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 16;
            this.listBoxUser.Location = new System.Drawing.Point(64, 168);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(128, 260);
            this.listBoxUser.TabIndex = 18;
            // 
            // AllResultsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.comboBoxGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "AllResultsTable";
            this.Size = new System.Drawing.Size(841, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxUser;
    }
}
