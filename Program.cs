using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=========GAME STARTED=========");
            Console.WriteLine("===============================");
            GameEngine startGame = new GameEngine();
            startGame.playGame();         

        }
    }
}
