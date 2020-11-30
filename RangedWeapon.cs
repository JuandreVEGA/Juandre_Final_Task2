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
                this.durability = 4;
                this.Damage = 4;
                this.Cost = 6;
                this.weaponType = "Longbow";
                this.Range = 2;
            }
            else if (type == Types.Rifle)
            {
                this.Durability = 3;
                this.Damage = 5;
                this.Cost = 7;
                this.weaponType = "Rifle";
                this.Range = 3;
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
