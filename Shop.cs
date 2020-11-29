using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juandre_Final_Task2
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

        //private Weapon RandomWeapon()
        //{           

        //    randomNum = r.Next(0, 4);

        //    if (randomNum == 1)
        //    {
        //        type = "Dagger";
        //    }
        //    else if (randomNum == 2)
        //    {
        //        type = "Longsword";
        //    }
        //    else if (randomNum == 3)
        //    {
        //        type = "LongBow";
        //    }
        //    else
        //    {
        //        type = "Rifle";
        //    }
        //    return type;
        //}

        public void Buy(int num)
        {
            
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + type + xGold;
        }
    }
}
