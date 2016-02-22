// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class FarmerGameUI
    {
        private FarmerGame game = new FarmerGame();

        public void Play()
        {
            displayGameState();
            while (processChoice(promptForMove("\nEnter the direction to go: "), promptForItem("Enter the item: ")))
                displayGameState();
        }

        private bool processChoice(Direction direction, Item item)
        {
            bool cont = false;

            game.Move(direction, item);
            Console.Clear();

            if (game.DetermineWin())
                gameWon();
            else if (game.DetermineLoss())
                gameOver();
            else
                cont = true;

            return cont;
        }

        private void gameOver()
        {
            Console.WriteLine("You lose :(");
            if (game.ChickenAteGrain())
                Console.WriteLine("Chicken ate the grain!");
            else if (game.FoxAteChicken())
                Console.WriteLine("Fox ate chicken!");
            playAgain();

        }

        private void gameWon()
        {
            Console.WriteLine("You won!");
            playAgain();
        }

        private void playAgain()
        {
            Console.WriteLine("Do you want to play again y/n ? ");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    game = new FarmerGame();
                    Play();
                    break;
            }
        }

        private void displayGameState()
        {
            displayNorthBank();
            displayRiver();
            displaySouthBank();
        }

        private void displayNorthBank()
        {
            colorWriteLine("North bank.", ConsoleColor.Red);
            foreach (Item item in game.NorthBank)
                colorWrite(item.ToString() + "  ", ConsoleColor.Red);
        }

        private void displaySouthBank()
        {
            colorWriteLine("South bank.", ConsoleColor.Green);
            foreach (Item item in game.SouthBank)
                colorWrite(item.ToString() + "  ", ConsoleColor.Green);
        }

        private void displayRiver()
        {
            colorWriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", ConsoleColor.Blue);
        }

        private void colorWriteLine(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }

        private void colorWrite(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = oldColor;
        }

        private Item promptForItem(string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "chicken":
                        return Item.Chicken;
                    case "fox":
                        return Item.Fox;
                    case "grain":
                        return Item.Grain;
                    case "":
                        return Item.Nothing;
                }
            }
        }

        private Direction promptForMove(string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "north":
                        return Direction.North;
                    case "south":
                        return Direction.South;
                }
            }
        }
    }
}
