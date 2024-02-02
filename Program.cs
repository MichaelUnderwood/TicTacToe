using TicTacToe;
// program written by benny boy macmichael, jefferson lambert, michael underwood, nate shaw
// this program gives a user an interface for playing tic tac toe in the console. probably the funnest version yet released.
class Program
{
    static void Main()
    {
        // set up our variables that will be used throughtout the program
        bool winner = false;
        bool tie = false;
        int guess = 0;
        int counter = 0;
        string theWinner = "";
        ToeClass tc = new ToeClass();

        //create the ggame board matrix
        char[,] gameBoardArray =
         {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        Console.WriteLine("Welcome to Byte Brigade's Tic-Tac-Toe of Destiny.");
        // after welcoming the user, a do, while loop. this will take the player number, the mark, anda  boolean and check whose turn it is when marking
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
            // after printing the board inform them whose turn it is
            do
            {
                Console.Write($"Player {playerNum}'s Selection: ");
                string input = Console.ReadLine();

                if (input.All(char.IsDigit))
                {
                    //parse the input because we need to
                    guess = int.Parse(input);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);
            // update board called from the toeclass
            gameBoardArray = UpdateBoard(gameBoardArray, guess, mark);

            theWinner = tc.CheckForWin(gameBoardArray);
            // check for a winner 
            if (theWinner != "no winner")
            {
                winner = true;
            }
            else if (counter == 8) // Check for a tie 
            {
                tie = true;
                break;
            }
            //incremement the counter just like scrum would
            counter += 1;

        } while (!winner);

        tc.PrintBoard(gameBoardArray);
        //logic for games and their results
        if (tie)
        {
            Console.WriteLine("Tie Game!");
        }
        else
        {
            Console.WriteLine($"{theWinner} won the game, come again...or don't.");
        }
    }

    //method to update the board pulling in several things
    static char[,] UpdateBoard(char[,] gameBoardArray, int guess, char marker)
    {
        bool goodMove = false;
        bool validInput = false;
        // giant if else statement gbecause we really like them. very useful for putting the nubmers and the markers on and checking for winners.
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
            // insert comment here
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
                //  input validation and alerting the user
                Console.WriteLine("Invalid move, please only enter a number of a spot that has not already been chosen");
                Console.WriteLine("Selection:");

                do
                {
                    string input = Console.ReadLine();

                    //read in the user's input and do more validation
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

            // the while loop continues
        } while (!goodMove);
        return gameBoardArray;

    }
}
