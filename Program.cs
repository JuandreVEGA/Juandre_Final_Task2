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

            string directoryName;
            string[] listOfFiles;
            Console.WriteLine("Enter a folder >> ");
            directoryName = Console.ReadLine();

            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Directory exists, and it contains the following: ");
                listOfFiles = Directory.GetFiles(directoryName);

                for (int x = 0; x < listOfFiles.Length; ++x)
                {
                    Console.WriteLine("{0}", listOfFiles[x]);
                }                
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }

        }
    }
}
