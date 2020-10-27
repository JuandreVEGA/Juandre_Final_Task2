using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.IO;

namespace ConsoleApp1
{
   public class GameEngine
    {
        private int map;        

        //private Enemy[] atkUnits = new Enemy[2];
        //private int counter = 1;       

        public int Map { get => map; set => map = value; }

        public GameEngine()
        {
                      
        }

        //public bool MovePlayer(Movement move)
        //{

        //}

        public void playGame()
        {
            Map map = new Map(1, 15, 1, 15, 5);
            map.Create();
        }

        public void Save()
        {
            string directoryName;
            directoryName = "D:/2020/GADE6111/EXAM PROJECT/ConsoleApp1/";
            string[] listOfFiles;
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

            FileStream outFile = new FileStream("SaveMap.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            const string FILENAME = "Map.cs";

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            int counter = 1;
            string name;
            Console.WriteLine("Displaying all of Map text");
            name = reader.ReadLine();

            while (name != null)
            {
                Console.WriteLine(" " + counter + " " + name);
                name = reader.ReadLine();
                writer.WriteLine(name);
                ++counter;
            }
            reader.Close();
            inFile.Close();
            writer.Close();
            outFile.Close();
        }

        public void Load()
        {


        }

        public override string ToString()
        {
            return ("Hello");
        }       
    }
}
