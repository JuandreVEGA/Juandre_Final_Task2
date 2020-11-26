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
            if (enumType == "Rifle")
            {
                this.Durability = 3;
                this.Damage = 5;
                this.Cost = 7;
                this.Range = 3
            }
            else if (enumType == "Longbow")
            {
                this.Durability = 4;
                this.Damage = 4;
                this.Cost = 6;
                this.Range = 2;
            }
        }
    }
}
