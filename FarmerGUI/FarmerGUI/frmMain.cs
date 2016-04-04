// Written by Jacob Misirian

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGUI
{
    public partial class frmMain : Form
    {
        private FarmerGame game;
        private const int MOVE_OFFSET = 100;
        public frmMain()
        {
            InitializeComponent();
            game = new FarmerGame();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (calculateTotalChecked() > 1)
            {
                MessageBox.Show("Error! Can only have one item checked!");
                return;
            }
            CheckBox checkedBox = getCheckedControl();
            Item item = (checkedBox == null) ? Item.Farmer : FarmerGame.ToItem(checkedBox.Text);

            if (game.NorthBank.Contains(item))
                game.Move(Direction.South, item);
            else if (game.SouthBank.Contains(item))
                game.Move(Direction.North, item);

            if (item != Item.Farmer)
                moveItem(checkedBox);
            moveFarmer();
            determineOutcome();
            clearChecks();
        }

        private void moveItem(CheckBox checkBox)
        {
            Item item = FarmerGame.ToItem(checkBox.Text);
            if (game.NorthBank.Contains(item))
                checkBox.Location = new Point(checkBox.Location.X, checkBox.Location.Y - MOVE_OFFSET);
            else
                checkBox.Location = new Point(checkBox.Location.X, checkBox.Location.Y + MOVE_OFFSET);
        }

        private void moveFarmer()
        {
            if (game.NorthBank.Contains(Item.Farmer))
                btnMove.Location = new Point(btnMove.Location.X, btnMove.Location.Y - MOVE_OFFSET);
            else
                btnMove.Location = new Point(btnMove.Location.X, btnMove.Location.Y + MOVE_OFFSET);
        }

        private int calculateTotalChecked()
        {
            int total = 0;
            if (cbChicken.Checked)
                total++;
            if (cbFox.Checked)
                total++;
            if (cbGrain.Checked)
                total++;
            return total;
        }

        private CheckBox getCheckedControl()
        {
            if (cbChicken.Checked)
                return cbChicken;
            if (cbFox.Checked)
                return cbFox;
            if (cbGrain.Checked)
                return cbGrain;
            return null;
        }

        private void determineOutcome()
        {
            if (game.DetermineWin())
            {
                MessageBox.Show("You won!");
                reset();
            }
            if (game.DetermineLoss())
            {
                MessageBox.Show("You lost!");
                reset();
            }
        }

        private void reset()
        {
            if (game.SouthBank.Contains(Item.Chicken))
                cbChicken.Location = new Point(cbChicken.Location.X, cbChicken.Location.Y - MOVE_OFFSET);
            if (game.SouthBank.Contains(Item.Fox))
                cbFox.Location = new Point(cbFox.Location.X, cbFox.Location.Y - MOVE_OFFSET);
            if (game.SouthBank.Contains(Item.Grain))
                cbGrain.Location = new Point(cbGrain.Location.X, cbGrain.Location.Y - MOVE_OFFSET);
            if (game.SouthBank.Contains(Item.Farmer))
                btnMove.Location = new Point(btnMove.Location.X, btnMove.Location.Y - MOVE_OFFSET);
        }

        private void clearChecks()
        {
            cbChicken.Checked = false;
            cbFox.Checked = false;
            cbGrain.Checked = false;
        }
    }
}
