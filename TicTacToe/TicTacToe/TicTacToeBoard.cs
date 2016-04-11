// Written by Jacob Misirian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeBoard
    {
        public const int NUM_SQUARES = 9;
        public SquareType[] Squares { get { return squares; } }

        private SquareType[] squares = new SquareType[NUM_SQUARES];

        public TicTacToeBoard()
        {
            for (int i = 0; i < squares.Length; i++)
                squares[i] = SquareType.Empty;
        }

        public bool IsFull()
        {
            foreach (SquareType square in squares)
                if (square == SquareType.Empty)
                    return false;
            return true;
        }

        public bool IsLegalMove(int index)
        {
            if (index < 0 || index >= NUM_SQUARES)
                return false;
            return squares[index] == SquareType.Empty;
        }

        public bool IsWinner(SquareType squareType)
        {
            // Check horizontal
            for (int i = 0; i < NUM_SQUARES; i += 3)
                if (squares[i] == squareType && squares[i + 1] == squareType && squares[i + 2] == squareType)
                    return true;
            // Check vertical
            for (int i = 0; i < 3; i++)
                if (squares[i] == squareType && squares[i + 3] == squareType && squares[i + 6] == squareType)
                    return true;
            // Check diagonal
            if ((squares[0] == squareType && squares[4] == squareType && squares[8] == squareType) || (squares[2] == squareType && squares[4] == squareType && squares[6] == squareType))
                return true;
            // else
            return false;
        }

        public void MakeMove(int index, SquareType squareType)
        {
            squares[index] = squareType;
        }

        public void Reset()
        {
            for (int i = 0; i < squares.Length; i++)
                squares[i] = SquareType.Empty;
        }
    }

    public enum SquareType
    {
        Empty,
        X,
        O
    }
}
