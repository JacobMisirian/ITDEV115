using System;
using System.Text;

namespace JumbleGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Info().ToString());
            var jumble = new JumbleUI();

            jumble.DisplayWelcome();
            jumble.Play();
        }
    }
}
