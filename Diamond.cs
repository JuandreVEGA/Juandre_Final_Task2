using System;

namespace ConsoleApp1
{
    public class Diamond : Item
    {
        public Diamond(int x, int y) : base(x, y)
        {
            Console.WriteLine("Im inside Diamond class");
        }

        public override string ToString()
        {
            return ("X is " + X + "\nY is " + Y);
        }
    }
}
