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


class Program
{
    static void Main()
    {
        bool winner = false;
        int guess = 0;
        int counter = 0;
        string theWinner = "";

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

            if (counter % 2 == 0)
            {
                playerNum = 1;
            }
            if (playerNum == 1)
            {
                mark = 'X';
            }

            Console.WriteLine($"Player {playerNum}'s Selection:");
            guess = int.Parse(Console.ReadLine());

            //update the board
            gameBoardArray = UpdateBoard(gameBoardArray, guess, mark);

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
        if (guess == 1)
        {
            gameBoardArray[0, 0] = marker;
        }
        else if (guess == 2)
        {
            gameBoardArray[0, 1] = marker;
        }
        else if (guess == 3)
        {
            gameBoardArray[0, 2] = marker;
        }
        else if (guess == 4)
        {
            gameBoardArray[1, 0] = marker;
        }
        else if (guess == 5)
        {
            gameBoardArray[1, 1] = marker;
        }
        else if (guess == 6)
        {
            gameBoardArray[1, 2] = marker;
        }
        else if (guess == 7)
        {
            gameBoardArray[2, 0] = marker;
        }
        else if (guess == 8)
        {
            gameBoardArray[2, 1] = marker;
        }
        else if (guess == 9)
        {
            gameBoardArray[2, 2] = marker;
        }

        // to check if the move is invalid or not, can likely be more dynamic....
        //what is the correct name for [row,col] --- gameBoardArray
        while (gameBoardArray[,] == 'X' || gameBoardArray[,] == 'O')
        {
            Console.WriteLine("Invalid move. That spot is already taken. Please choose another spot:");
            guess = int.Parse(Console.ReadLine());

            // Update row and col after getting new guess
            if (guess == 1)
            {
                gameBoardArray[0, 0] = marker;
            }
            else if (guess == 2)
            {
                gameBoardArray[0, 1] = marker;
            }
            else if (guess == 3)
            {
                gameBoardArray[0, 2] = marker;
            }
            else if (guess == 4)
            {
                gameBoardArray[1, 0] = marker;
            }
            else if (guess == 5)
            {
                gameBoardArray[1, 1] = marker;
            }
            else if (guess == 6)
            {
                gameBoardArray[1, 2] = marker;
            }
            else if (guess == 7)
            {
                gameBoardArray[2, 0] = marker;
            }
            else if (guess == 8)
            {
                gameBoardArray[2, 1] = marker;
            }
            else if (guess == 9)
            {
                gameBoardArray[2, 2] = marker;
            }
            else
            {
                //need to add somethine here to loop back and check the next input they put in
                Console.WriteLine("Please enter corect input");
                Console.WriteLine("Correct Options:");
            }

            return gameBoardArray;
        }
    }
}

