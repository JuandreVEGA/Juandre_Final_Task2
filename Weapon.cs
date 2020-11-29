using System;

namespace ConsoleApp1
{
    abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;

        public int Damage { get => damage; set => damage = value; }
        public int Range { get => range; set => range = value; }
        public int Durability { get => durability; set => durability = value; }
        public int Cost { get => cost; set => cost = value; }
        public string WeaponType { get => weaponType; set => weaponType = value; }

        public Weapon(string symbol, int x, int y) : base(x, y)
        {
            
        }
    }
}
