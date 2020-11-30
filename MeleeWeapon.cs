using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp1
{
    class MeleeWeapon : Weapon
    {        
        public enum Types { Dagger, Longsword };

        public MeleeWeapon(Types type, int x, int y) : base("W" ,x, y)
        {
            if (type == Types.Dagger)
            {
                this.durability = 10;
                this.Damage = 3;
                this.Cost = 3;
                this.weaponType = "Dagger";                
                
            }
            else if (type == Types.Longsword)
            {
                this.Durability = 6;
                this.Damage = 4;
                this.Cost = 5;
                this.weaponType = "Longsword";
                ;
            }
        }        

        public override int Range
        {
            get { return 1; }            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
