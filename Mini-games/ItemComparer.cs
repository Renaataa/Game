using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Mini_games
{
    class ItemComparer : IComparer
    {
        public int Column { get; set; }
        public ItemComparer(int colIndex)
        {
            Column = colIndex;
        }
        public int Compare(object x, object y)
        {
            int nx = int.Parse((x as ListViewItem).SubItems[Column].Text);
            int ny = int.Parse((y as ListViewItem).SubItems[Column].Text);
            return ny.CompareTo(nx);
        }
    }

    
}
