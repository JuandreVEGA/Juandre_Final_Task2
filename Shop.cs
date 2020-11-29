using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        int[] weaponArray = new int[3];
        private Random r = new Random();
        private string Character;

        int randomNum;
        string type;
        int xGold;

        public Shop(string Character)
        {

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

        public void Buy(int num)
        {
            
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + type + xGold;
        }
    }
}
