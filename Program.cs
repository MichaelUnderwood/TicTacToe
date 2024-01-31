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
        WelcomeUser();

    }

    static void WelcomeUser()
    {
        Console.WriteLine("Welcome to Byte Brigade's Tic-Tac-Toe of Destiny.");
    }

    static char[,] GameBoardArray()
    {
        // 
        return new char[3, 3];
    }

    static void AskPlayerForChoice(char[,] gameBoardArray)
    {
        //stuff
    }

    static void NotifyWinner()
    {
        Console.WriteLine("Congrats!");
    }
}
