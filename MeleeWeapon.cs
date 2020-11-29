using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp1
{
    class MeleeWeapon : Weapon
    {        
        public enum Types { Dagger, Longsword };

        public MeleeWeapon(string enumType, int x, int y) : base(enumType,x, y)
        {
            if (enumType == "Dagger")
            {
                this.durability = 10;
                this.Damage = 3;
                this.Cost = 3;
                this.weaponType = "Dagger";
                enumType = "Dagger";
            }
            else if (enumType == "Longsword")
            {
                this.Durability = 6;
                this.Damage = 4;
                this.Cost = 5;
                this.weaponType = "Longsword";
                enumType = "Longsword";
            }
        }

        public new int Range
        {
            get { return 1; }            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
