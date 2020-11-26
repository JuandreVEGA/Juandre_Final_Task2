using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp1
{
    public class MeleeWeapon : Item
        {
        public string weaponType;
        public enum Types { Dagger, Longsword};

        //public override int Range()
        //{
        //    return 1;
        //}


        public MeleeWeapon(string enumType, int x, int y) : base(x,y)
        {
            if (enumType == "Dagger")
            {
                this.Durability = 10;
                this.Damage = 3;                
                this.Cost = 3;
            }
            else if (enumType == "Longsword")
            {
                this.Durability = 6;
                this.Damage = 4;
                this.Cost = 5;
            }
           
        }   

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
