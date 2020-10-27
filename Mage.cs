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

        //public override Movement ReturnMove(Movement.Up)
        //{
        //    return base.ReturnMove(move);
        //}

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }          
    }
}
