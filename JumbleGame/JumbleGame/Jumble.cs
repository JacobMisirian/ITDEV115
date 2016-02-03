using System;
using System.Text;

namespace JumbleGame
{
    public class Jumble
    {
        public string CurrentHiddenWord { get; private set; }
        public string CurrentScrambledWord { get; private set; }

        private static Random random = new Random();
        private string[] words = new string[] { "computer", "laptop", "class", "code", "program", "programming" };

        public bool CompareString(string str)
        {
            return str == CurrentHiddenWord;
        }

        public void GenerateRandomHiddenWord()
        {
            CurrentHiddenWord = words[random.Next(0, words.Length - 1)];
        }

        public void ScrambleCurrentHiddenWord()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CurrentHiddenWord);
            for (int i = 0; i < sb.Length; ++i)
            {
                int origIndex = (random.Next() % sb.Length);
                int newIndex = (random.Next() % sb.Length);

                Char temp = sb[origIndex];
                sb[origIndex] = sb[newIndex];
                sb[newIndex] = temp;
            }

            CurrentScrambledWord = sb.ToString();
        }

        public void DisplayScrambledWord()
        {
            Console.WriteLine(CurrentScrambledWord);
        }
    }
}

