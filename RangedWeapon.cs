using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RangedWeapon
    {
        public enum Types { Rifle, Longbow};

        public override int Range()
        {
            return base.Range;
        }        

        public RangedWeapon(string enumType, int x, int y)
        {

        }
    }
}
