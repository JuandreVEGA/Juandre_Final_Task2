using System;

namespace ConsoleApp1
{
    public class EmptyTile : Tile
    {
        public EmptyTile(int xPos, int yPos) : base(xPos, yPos)
        {
            Console.WriteLine("Im inside the Empty Class.");
        }
    }
}
