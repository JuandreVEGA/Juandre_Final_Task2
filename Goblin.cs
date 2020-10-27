using System;

namespace ConsoleApp1
{
    public class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 1, 10)
        {
            this.X = x;
            this.Y = y;
            this.MaxHP = 10;
            this.Damage = 1;
            Console.WriteLine("Im inside Goblin class");
        }

        //public int returnMove(int x, int y)
        //{
        //    int rand = r.Next(0, 4);            

        //    switch (rand)
        //    {
        //        case 1:
        //            y--;
        //            break;
        //        case 2:
        //            y++;
        //            break;
        //        case 3:
        //            x--;
        //            break;
        //        case 4:
        //            x++;
        //            break;
        //        default:
        //            break;
        //    }            

            //while (CheckRange() = true)
            //{
            //    rand = r.Next(0, 4);
            //}
            //return this.Map(y, x) = "G";
        
    }
}
