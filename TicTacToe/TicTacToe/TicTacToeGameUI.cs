// Written by Jacob Misirian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGameUI
    {
        private TicTacToeBoard board;
        private const string ROW_SEPERATOR = "------------------------------------------------";
        private SquareType currentTurn = SquareType.X;

        public void MainMethod()
        {
            board = new TicTacToeBoard();
            Console.WriteLine("Hello! To play tic tac toe, when it is your turn, enter the index of where you want to play (0-8)");
            Console.Read();

            while (!board.IsFull() && !board.IsWinner(SquareType.X) && !board.IsWinner(SquareType.O))
            {
                DisplayBoardGrid();

                Console.WriteLine("It is {0} turn.", currentTurn);
                int move = promptForInt("Enter your index: ");
                if (board.IsLegalMove(move))
                    board.MakeMove(move, currentTurn);
                else
                {
                    Console.WriteLine("Illegal Move! Press enter!");
                    Console.Read();
                    continue;
                }
                // Swap the turn
                currentTurn = currentTurn == SquareType.X ? SquareType.O : SquareType.X;
            }

            DisplayBoardGrid();

            if (board.IsFull())
                Console.WriteLine("Tie! Board is full!");
            else if (board.IsWinner(SquareType.X))
                AccounceWinner(SquareType.X);
            else if (board.IsWinner(SquareType.O))
                AccounceWinner(SquareType.O);
            else
                Console.WriteLine("Something has gone wrong!");
        }

        public void DisplayBoardGrid()
        {
            Console.Clear();
            for (int i = 0; i < board.Squares.Length - 1; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(ROW_SEPERATOR);
                Console.WriteLine("|\t{0}\t|\t{1}\t|\t{2}\t|", getSquareValue(i), getSquareValue(++i), getSquareValue(++i));
            }
            Console.WriteLine(ROW_SEPERATOR);
        }

        public void AccounceWinner(SquareType squareType)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("The winner is: " + squareType);
        }

        private int promptForInt(string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter a valid Int32!");
                }
            }
        }

        private string getSquareValue(int index)
        {
            SquareType squareType = board.Squares[index];
            return squareType != SquareType.Empty ? squareType.ToString() : " ";
        }
    }
}
