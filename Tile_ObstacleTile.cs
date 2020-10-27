using System;

namespace ConsoleApp1
{
    public class Obstacle : Tile
    {
        public Obstacle(int xPos, int yPos) : base(xPos, yPos)
        {
            Console.WriteLine("Im inside the Obstacle Class.");
        }
    }
}
