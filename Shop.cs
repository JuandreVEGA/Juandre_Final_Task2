using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        string[] weaponArray = new string[3];
        private Random r = new Random();
        private string Character;

        int randomNum;
        string type;
        int xGold;

        public int Cost { get; private set; }

        public Shop(Character target)
        {
            for (int i = 0; i < weaponArray.Length; i++)
            {                
                RandomWeapon();
                weaponArray[i] = this.type;
            }           
        }
        private Weapon RandomWeapon()
        {
            randomNum = r.Next(0, 4);
            MeleeWeapon melee;
            RangedWeapon ranged;

            if (randomNum == 1)
            {
                melee = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);
                return melee;
            }
            else if (randomNum == 2)
            {
                melee = new MeleeWeapon(MeleeWeapon.Types.Longsword, 0, 0);
                return melee;
            }
            else if (randomNum == 3)
            {
                ranged = new RangedWeapon(RangedWeapon.Types.Longbow, 0, 0);
                return ranged;
            }
            else
            {
                ranged = new RangedWeapon(RangedWeapon.Types.Rifle, 0, 0);
                return ranged;
            }            
        }

        public bool CanBuy(int num)
        {
            if (this.xGold >= this.Cost)
            {
                return true;
            }
            return false;
        }
        public void Buy(int num)
        {
            this.xGold -= this.Cost;
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + this.type + this.xGold;
        }
    }
}
