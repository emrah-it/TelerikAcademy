using System;
using System.Threading;
class FallingRocks
{
    static void Main()
    {
        FallingRocks startGame = new FallingRocks();
        while (true)
        {
            startGame.StartGame();
        }
    }

    private void StartGame()
    {
        Player gamePlayer = new Player();
        FallingRockEngine fallingRocks = new FallingRockEngine();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                gamePlayer.Move(Console.ReadKey(true).Key);
            }
            gamePlayer.Drow();
            if (!fallingRocks.Drow(gamePlayer.XPlayerPosition(), gamePlayer.YPlayerPosition()))
            {
                Console.ForegroundColor = ConsoleColor.White;
                NewGame();
                return;
            }
            Thread.Sleep(150);
            Console.Clear();
        }
    }
    void NewGame()
    {
        ShowMessege();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey myKey = Console.ReadKey(true).Key;
                if (myKey == ConsoleKey.Y)
                {
                    return;
                }
                else if (myKey == ConsoleKey.N)
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
    private static void ShowMessege()
    {
        string gameOver = "Game Over";
        string text = "Do you want to play again";
        string choos = @"Y/N";
        Console.SetCursorPosition((Console.WindowWidth - gameOver.Length) / 2, Console.WindowHeight / 2);
        Console.WriteLine(gameOver);
        Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, (Console.WindowHeight / 2) + 1);
        Console.Write(text);
        Console.SetCursorPosition(((Console.WindowWidth - choos.Length) / 2), (Console.WindowHeight / 2) + 2);
        Console.WriteLine(choos);
        Console.SetCursorPosition(((Console.WindowWidth - choos.Length) / 2), (Console.WindowHeight / 2) + 3);
    }
}
