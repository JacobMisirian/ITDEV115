using System;

namespace JumbleGame
{
    public class JumbleUI
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome. A random jumbled word will be displayed to you." +
                "\nYou must try and guess this word to pass.");
        }

        public void Play()
        {
            int tries = 0;
            Jumble game = new Jumble();
            game.GenerateRandomHiddenWord();
            game.ScrambleCurrentHiddenWord();

            while (!game.CompareString(TakeAGuess(game.CurrentScrambledWord + "\nEnter a guess: ")))
                tries++;

            Console.WriteLine("Correct! It took you " + tries + " tries to find that.");
            playAgain();
        }

        private void playAgain()
        {
            Console.WriteLine("Would you like to play again? y/n");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "y":
                    Play();
                    break;
                case "n":
                    return;
                default:
                    Console.WriteLine("Enter either y or n!");
                    playAgain();
                    break;
            }
        }

        public string TakeAGuess(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}

