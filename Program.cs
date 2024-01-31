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
        string guess = "";
        int counter = 0;
        string theWinner = "";

        //create game board
        char[,] gameBoardArray = new char[3, 3];



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
            //call the Print board method from other class
            //PrintBoard();

            Console.WriteLine($"Player {playerNum}'s Selection:");
            guess = Console.ReadLine();


            //check if valid input


            //update the board
            gameBoardArray = UpdateBoard(gameBoardArray, guess, mark);

            //check if there is a winner
            //need to assign theWinner(string) with what they return with here




            counter += 1;

        } while (!winner);


        Console.WriteLine($"{theWinner} wone the game, come again sometime");




    }

    static char[,] UpdateBoard(char[,] gameBoardArray, string guess, char marker)
    {
        if (guess == "top left")
        {
            gameBoardArray[0, 0] = marker;
        }
        else if (guess == "top middle")
        {
            gameBoardArray[0, 1] = marker;
        }
        else if (guess == "top right")
        {
            gameBoardArray[0, 2] = marker;
        }
        if (guess == "left middle")
        {
            gameBoardArray[1, 0] = marker;
        }
        else if (guess == "middle")
        {
            gameBoardArray[1, 1] = marker;
        }
        else if (guess == "right middle")
        {
            gameBoardArray[1, 2] = marker;
        }
        if (guess == "bottom left")
        {
            gameBoardArray[2, 0] = marker;
        }
        else if (guess == "bottom middle")
        {
            gameBoardArray[2, 1] = marker;
        }
        else if (guess == "bottom right")
        {
            gameBoardArray[2, 2] = marker;
        }

        return gameBoardArray;
    }






}
