using System;
using System.Collections.Generic;

namespace Assignment1
{
    /// <summary>
    /// Base ball player UI.
    /// </summary>
    public class BaseBallPlayerUI
    {
        private List<BaseBallPlayer> players = new List<BaseBallPlayer>();
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="amoutOfPlayers">Amout of players.</param>
        public void MainMethod(int amoutOfPlayers)
        {
            // Populate list with players from user input;
            for (int i = 0; i < amoutOfPlayers; i++)
                addPlayer();

            // Display all players in list.
            for (int i = 0; i < players.Count; i++)
                DisplayInfo(players[i], i);
        }

        private void addPlayer()
        {
            Console.WriteLine("Player " + players.Count + ":\n");
            BaseBallPlayer player = new BaseBallPlayer();
            player.FirstName = promptForString("First Name: ");
            player.LastName = promptForString("Last Name: ");
            player.Team = promptForString("Team: ");
            player.BattingAvg = promptForDouble("Batting Average: ");

            players.Add(player);
        }

        private double promptForDouble(string prompt = "")
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            double dbl = 0;
            try
            {
                dbl = Convert.ToDouble(input);
            }
            catch
            {
                Console.WriteLine("Input must be a valid double! Try again.");
                return promptForDouble(prompt);
            }

            return dbl;
        }

        private string promptForString(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        /// <summary>
        /// Displays the info.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <param name="playerIndex">Player index.</param>
        public void DisplayInfo(BaseBallPlayer player, int playerIndex)
        {
            string prefix = "[Player] " + playerIndex + "] ";
            Console.WriteLine();
            Console.WriteLine(prefix + " BattingAvg: " + player.BattingAvg);
            Console.WriteLine(prefix + " Name: " + player.FirstName + " " + player.LastName);
            Console.WriteLine(prefix + " Team: " + player.Team);
        }
    }
}

