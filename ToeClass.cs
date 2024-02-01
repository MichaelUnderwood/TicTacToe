using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

/* Ben & Jefferson
2) ToeClass.cs will:
• Receive the “board” array from the driver class
    gameBoardArray[]
• Contain a method that prints the board based on the information passed to it
    PrintBoard
• Contain a method that receives the game board array as input and returns if there is a
winner and who it was \*
    CheckForWinner */

namespace TicTacToe
{
    internal class ToeClass
    {
        public void PrintBoard(char[,] Board)
        {
            //This method doesn't return anything but prints out the board using Console.WriteLine
            //based off what the board is
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // just console.write so that it stays on the same line. added tab delimiter for spacing
                    Console.Write(Board[row, col] + "\t");
                }
                //create new line for next row of matrix woo
                Console.WriteLine();
            }
        }

        public string CheckForWin(char[,] board)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    if (board[row, 0] == 'X')
                    {
                        return "Player 1";
                    }
                    else if (board[row, 0] == 'O')
                    {
                        return "Player 2";
                    }
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    if (board[0, col] == 'X')
                    {
                        return "Player 1";
                    }
                    else if (board[0, col] == 'O')
                    {
                        return "Player 2";
                    }
                }
            }

            // Check diagonals
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                if (board[1, 1] == 'X')
                {
                    return "Player 1";
                }
                else if (board[1, 1] == 'O')
                {
                    return "Player 2";
                }
            }

            // No winner
            return "no winner";
        }
    }
}
}

