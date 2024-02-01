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
        }

        public string CheckForWin(char[,] Board)
        {
            //This will return a string that says either "no winner"
            //Or just "Player 1" if X is the winner
            //Or just "Player 2" if O is the winner
            //And the main program will take that string and handle it accordingly
            return "";
        }
    }
}

