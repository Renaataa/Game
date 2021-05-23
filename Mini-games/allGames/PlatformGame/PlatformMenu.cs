using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games.allGames.PlatformGame
{
    public partial class PlatformMenu : UserControl
    {
        DatabaseUsersDataContext DatabaseDC = new DatabaseUsersDataContext();

        public delegate void ChoiceHandler(int level);
        public delegate Level Handler();
        public event ChoiceHandler LoadLevel;
        public event Handler CurrentLevel;

        public PlatformMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadLevel != null) LoadLevel(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoadLevel != null) LoadLevel(2);
        }

        public void disableButtons()
        {
            Level currentLevel;
            button2.Enabled = true;

            if (CurrentLevel != null)
            {
                currentLevel = CurrentLevel();
                if (currentLevel.Level1 < 2)
                {
                    button2.Enabled = false;
                }
            }
        }

        private void PlatformMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
