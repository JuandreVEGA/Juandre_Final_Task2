using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            return base.ReturnMove(move);
        }

        public override bool CheckRange(Character target)
        {
            bool check = false;

            if ((target.X == this.x + 1 && target.Y == this.y) || (target.X == this.x - 1 && target.Y == this.y) || (target.X == this.x  && target.Y == this.y + 1) || (target.X == this.x && target.Y == this.y - 1))
            {
                check = true;
            }            
            return check;
        }          
    }
}
