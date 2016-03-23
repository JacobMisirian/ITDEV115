using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FarmerGUI
{
    public partial class Form1 : Form
    {
        private FarmerGame game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new FarmerGame();
        }

        private void Form1_OnItemChecked(object sender, ItemCheckedEventArgs e)
        {
            game.Move(e.Direction, e.Item);
        }

        public event EventHandler<ItemCheckedEventArgs> ItemChecked;
        protected virtual void OnItemChecked(ItemCheckedEventArgs e)
        {
            EventHandler<ItemCheckedEventArgs> handler = ItemChecked;
            if (handler != null)
                handler(this, e);
        }
        private class ItemCheckedEventArgs : EventArgs
        {
            public Item Item { get; set; }
            public Direction Direction { get; set; }
        }
    }
}
