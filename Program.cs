/* Michael & Nate
 * 1) Program.cs: 
• Welcome the user to the game 
    WelcomeUser
• Create a game board array to store the players’ choices
    GameBoardArray
• Ask each player in turn for their choice and update the game board array
    AskPlayerForChoice
• Print the board by calling the method in the supporting class
    PrintBoard (calls a method in the supporting class)
• Check for a winner by calling the method in the supporting class, and notify the players
when a win has occurred and which player won the game
    CheckForWinner (calls a method in the supporting class)
    NotifyWinner*/
using TicTacToe;

class Program
{
    static void Main()
    {
        bool winner = false;
        int guess = 0;
        int counter = 0;
        string theWinner = "";
        ToeClass tc = new ToeClass();

        //create game board
        char[,] gameBoardArray =
         {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        //start of game
        Console.WriteLine("Welcome to Byte Brigade's Tic-Tac-Toe of Destiny.");

        do
        {
            int playerNum = 2;
            char mark = 'O';
            bool validInput = false;

            if (counter % 2 == 0)
            {
                playerNum = 1;
            }
            if (playerNum == 1)
            {
                mark = 'X';
            }

            tc.PrintBoard(gameBoardArray);

           
            
            do
            {
                Console.Write($"Player {playerNum}'s Selection: ");
                string input = Console.ReadLine();

                if (input.All(char.IsDigit))
                {
                    guess = int.Parse(input);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);

            //update the board
            gameBoardArray = UpdateBoard(gameBoardArray, guess, mark);

            theWinner = tc.CheckForWin(gameBoardArray);

            if (theWinner != "no winner")
            {
                winner = true;
            }

            counter += 1;

        } while (!winner);

        Console.WriteLine($"{theWinner} wone the game, come again sometime");
    }

    static char[,] UpdateBoard(char[,] gameBoardArray, int guess, char marker)
    {
        bool goodMove = false;
        bool validInput = false;
        do
        {
            if (guess == 1 && gameBoardArray[0, 0] == '1')
            {
                gameBoardArray[0, 0] = marker;
                goodMove = true;
            }
            else if (guess == 2 && gameBoardArray[0, 1] == '2')
            {
                gameBoardArray[0, 1] = marker;
                goodMove = true;
            }
            else if (guess == 3 && gameBoardArray[0, 2] == '3')
            {
                gameBoardArray[0, 2] = marker;
                goodMove = true;
            }
            else if (guess == 4 && gameBoardArray[1, 0] == '4')
            {
                gameBoardArray[1, 0] = marker;
                goodMove = true;
            }
            else if (guess == 5 && gameBoardArray[1, 1] == '5')
            {
                gameBoardArray[1, 1] = marker;
                goodMove = true;
            }
            else if (guess == 6 && gameBoardArray[1, 2] == '6')
            {
                gameBoardArray[1, 2] = marker;
                goodMove = true;
            }
            else if (guess == 7 && gameBoardArray[2, 0] == '7')
            {
                gameBoardArray[2, 0] = marker;
                goodMove = true;
            }
            else if (guess == 8 && gameBoardArray[2, 1] == '8')
            {
                gameBoardArray[2, 1] = marker;
                goodMove = true;
            }
            else if (guess == 9 && gameBoardArray[2, 2] == '9')
            {
                gameBoardArray[2, 2] = marker;
                goodMove = true;
            }
            else
            {
                Console.WriteLine("Invalid move, please only enter a number of a spot that has not already been chosen");
                Console.WriteLine("Selection:");
                
                do
                {
                    
                    string input = Console.ReadLine();

                    if (input.All(char.IsDigit))
                    {
                        guess = int.Parse(input);
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                } while (!validInput);

            }
        } while (!goodMove);
        return gameBoardArray;
        
    }
}

