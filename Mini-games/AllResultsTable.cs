﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_games
{
    public partial class AllResultsTable : UserControl
    {
        DatabaseUsersDataContext DatabaseUsers = new DatabaseUsersDataContext();
        public AllResultsTable()
        {
            InitializeComponent();
            
            listBoxResults.DisplayMember = "User";
        }

        private void LoadUsers()
        {
            listBoxResults.Items.Clear();
            foreach(User u in DatabaseUsers.Users)
            {
                listBoxUser.Items.Add(u);
            }
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            listBoxUser.Items.Clear();

            string selectI = this.comboBoxGames.SelectedItem.ToString();

            switch (selectI)
            {
                case "DinoChrome":
                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 1)
                            {
                                listBoxUser.Items.Add(u.Nickname);
                                listBoxResults.Items.Add(r.Result1);
                            }
                        }
                    }
                    break;
                case "FlappyBird":
                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 2)
                            {
                                listBoxUser.Items.Add(u.Nickname);
                                listBoxResults.Items.Add(r.Result1);
                            }
                        }
                    }
                    break;
                case "Platform":
                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 5)
                            {
                                listBoxUser.Items.Add(u.Nickname);
                                listBoxResults.Items.Add(r.Result1);
                            }
                        }
                    }
                    break;
                case "Plane":
                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 4)
                            {
                                listBoxUser.Items.Add(u.Nickname);
                                listBoxResults.Items.Add(r.Result1);
                            }
                        }
                    }
                    break;
                case "Tanks":
                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 3)
                            {
                                listBoxUser.Items.Add(u.Nickname);
                                listBoxResults.Items.Add(r.Result1);
                            }
                        }
                    }
                    break;
            }
        }

        private void AllResultsTable_Load(object sender, EventArgs e)
        {

        }
    }
}
