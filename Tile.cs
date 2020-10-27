using System;

namespace ConsoleApp1
{
    public abstract partial class Tile
    {
        protected int x;
        protected int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Tile(int x, int y)
        {
            Console.WriteLine("Im inside the Tile Class.");
            this.x = x;
            this.y = y;
        }
        public enum TileType { Hero, Enemy, Gold, Weapon };
    }
}
