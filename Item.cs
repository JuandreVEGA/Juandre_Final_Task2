using System;

namespace ConsoleApp1
{
    public abstract class Item : Tile
    {
        public Item(int x, int y) : base(x, y)
        {
            Console.WriteLine("Im inside Item class");
        }

        public abstract override string ToString();
    }
}
