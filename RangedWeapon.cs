using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RangedWeapon : Weapon
    {
        public enum Types { Rifle, Longbow};       

        public RangedWeapon(Types type, int x, int y) : base("W",x, y)
        {
            if (type == Types.Longbow)
            {
                this.durability = 10;
                this.Damage = 3;
                this.Cost = 3;
                this.weaponType = "Longbow";

            }
            else if (type == Types.Rifle)
            {
                this.Durability = 6;
                this.Damage = 4;
                this.Cost = 5;
                this.weaponType = "Rifle";
                ;
            }
        }

        public override int Range
        {
            get { return base.Range; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
