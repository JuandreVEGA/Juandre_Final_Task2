using System;

namespace ConsoleApp1
{
    public abstract class Character : Tile
    {
        protected int HP;
        protected int MaxHP;
        protected int damage;

        Tile[] vision;        


        Random r = new Random();

        public Character(int xPos, int yPos) : base(xPos, yPos)
        {
            this.x = xPos;
            this.Y = yPos;
        }

        public int Hp { get => HP; set => HP = value; }
        public int Max_hp { get => MaxHP; set => MaxHP = value; }
        public int Damage { get => damage; set => damage = value; }

        public Tile[] Vison { get => vision; set => vision = value; }

        public enum Movement { NoMovement, Up, Down, Left, Right }

        public virtual void Attack(Character target)
        {
            Console.WriteLine("Im inside Attack Method");
            this.CheckRange(null);
            Hero mySUperCoolHero = new Hero(this.X, this.Y, this.HP);
            CheckRange(mySUperCoolHero);
            target.HP -= this.damage;
            IsDead();

            this.vision = new Tile[4];

            //vision[0] = "up";

            //Vison[0] = Movement.Up;
            //this.Vison[1] = down;
            //this.Vison[2] = left;
            //this.Vison[3] = right;

            string[] terrain = new string[4];
            
            terrain[0] = "grass";
            terrain[1] = "dirt";
            terrain[2] = "rock";
            terrain[3] = "water";

        }

        public bool IsDead()
        {
            bool Isdead = false;
            if (this.Hp <= 0)
            {
                Isdead = true;
                Console.WriteLine("Character is Dead");
            }
            return Isdead;
        }

        public virtual bool CheckRange(Character target)
        {
            // is the target within my range                
            bool returnVal = false;
            int[] vision = new int[] { 0, 1, 2, 3 };
            // check to see if there are objects around, if there is find distance to target             

            //if (this.vision[0] = )
            //{
            //    this.vision[0] = (map[this.X, this.Y - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("There is something in the way!");
            //}
            //if (Map[this.X, this.Y + 1] = '.')
            //{
            //    Console.WriteLine("You can move down, its clear.");
            //}
            //else
            //{
            //    Console.WriteLine("There is something in the way!");
            //}
            //if (Map[this.X + 1, this.Y] = '.')
            //{
            //    Console.WriteLine("You can move right, its clear.");
            //}
            //else
            //{
            //    Console.WriteLine("There is something in the way!");
            //}
            //if (Map[this.X - 1, this.Y] = '.')
            //{
            //    Console.WriteLine("You can move left, its clear.");
            //}
            //else
            //{
            //    Console.WriteLine("There is something in the way!");
            //}

            if (vision[0] == 0)
            {

            }
            else if (vision[1] == 1)
            {

            }
            else if (vision[2] == 0)
            {

            }
            else if (vision[3] == 0)
            {

            }
            return returnVal;
        }

        private int DistanceTo(Character target)
        {
            int distance;
            distance = (target.x - x) + (target.Y - y);
            return distance;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Up:
                    Y--;
                    break;
                case Movement.Down:
                    Y++;
                    break;
                case Movement.Left:
                    x--;
                    break;
                case Movement.Right:
                    x++;
                    break;
                default:
                    break;
            }            
        }

        public Movement ReturnMove(Movement move = 0)
        {
            switch (move)
            {
                case Movement.Up:
                    Y--;
                    break;
                case Movement.Down:
                    Y++;
                    break;
                case Movement.Left:
                    x--;
                    break;
                case Movement.Right:
                    x++;
                    break;
                default:
                    break;
            }
            return move;
        }

        public override string ToString()
        {
            return ("Overriding Object");
        }
    }
}
