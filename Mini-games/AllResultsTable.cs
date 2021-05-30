using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Collections;
using System.Windows.Data;

namespace Mini_games
{
    public partial class AllResultsTable : UserControl
    {
        DatabaseUsersDataContext DatabaseUsers = new DatabaseUsersDataContext();
        public AllResultsTable()
        {
            InitializeComponent();
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewResults.Items.Clear();

            string selectI = this.comboBoxGames.SelectedItem.ToString();
            int colI = columnScore.Index;

            switch (selectI)
            {
                case "All Results":
                    listViewResults.Items.Clear();
                    int max;
                    foreach (User u in DatabaseUsers.Users)
                    {
                        int currID = u.Id;
                        max = 0;
                        foreach (Result r in DatabaseUsers.Results)
                        {
                            if (r.UserID == currID)
                            {
                                max += r.Result1;
                            }
                        }
                        DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                        String[] row = { u.Nickname, max.ToString() };
                        ListViewItem item = new ListViewItem(row);
                        listViewResults.Items.Add(item);
                        this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
                    }
                    break;
                case "DinoChrome":

                    foreach (Result r in DatabaseUsers.Results)
                    {
                        foreach (User u in DatabaseUsers.Users)
                        {
                            if (u.Id == r.UserID && r.GameID == 1)
                            {
                                DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                                String[] row = { u.Nickname, r.Result1.ToString() };
                                ListViewItem item = new ListViewItem(row);
                                listViewResults.Items.Add(item);
                                this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
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
                                DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                                String[] row = { u.Nickname, r.Result1.ToString() };
                                ListViewItem item = new ListViewItem(row);
                                listViewResults.Items.Add(item);
                                this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
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
                                DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                                String[] row = { u.Nickname, r.Result1.ToString() };
                                ListViewItem item = new ListViewItem(row);
                                listViewResults.Items.Add(item);
                                this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
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
                                DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                                String[] row = { u.Nickname, r.Result1.ToString() };
                                ListViewItem item = new ListViewItem(row);
                                listViewResults.Items.Add(item);
                                this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
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
                                DatabaseUsers.Refresh(RefreshMode.OverwriteCurrentValues, DatabaseUsers.Results);
                                String[] row = { u.Nickname, r.Result1.ToString() };
                                ListViewItem item = new ListViewItem(row);
                                listViewResults.Items.Add(item);
                                this.listViewResults.ListViewItemSorter = new ItemComparer(colI);
                            }
                        }
                    }
                    break;
            }
        } 
    }
}
