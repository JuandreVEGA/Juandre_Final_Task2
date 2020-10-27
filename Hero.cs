using System;

namespace ConsoleApp1
{
    public class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.HP = hp;
            this.MaxHP = 10;
            this.Damage = 2;
        }
        //public int returnMove(Movement move)
        //{
        //    switch (move)
        //    {
        //        case Movement.Up:
        //            return this.Y--;
        //        case Movement.Down:
        //            return this.Y++;
        //        case Movement.Left:
        //            return this.x--;
        //        case Movement.Right:
        //            return this.x++;
        //    }
        //    //return Map[y, x] = "H";            
        //}

        public override string ToString()
        {
            return ("Hero Stats: " + "\nHP: " + this.Hp + " / " + this.Max_hp + "\nDamage: 2" + "[" + this.x + "," + this.y + "]");
        }
    }
}
