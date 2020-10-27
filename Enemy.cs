using System;

namespace ConsoleApp1
{
    public abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int x, int y, int damage, int max_hp) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Damage = damage;
            this.Max_hp = max_hp;
        }

        public override string ToString()
        {
            return (Enemy.TileType.Enemy + " at [" + this.x + "," + this.y + "] " + this.Damage + " DMG");
        }
    }
}
