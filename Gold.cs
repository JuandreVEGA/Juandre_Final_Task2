using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Gold : Item
    {
        private int goldAmount;
        Random r = new Random();
        
        public int GoldAmount { get => goldAmount; set => goldAmount = value; }

        public Gold(int x, int y) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            goldAmount = r.Next(1, 5);
        }

        public override string ToString()
        {
            return ("Gold Added");
        }
    }
}
