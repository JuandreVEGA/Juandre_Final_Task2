using System;

namespace ConsoleApp1
{
    public class Map
    {
        int width, height;
        Tile[,] randomMap;        
        int heroX, heroY;
        int[,] enemy;
        Random r = new Random();

        int maxHeight, maxWidth;

        char[,] newMap;

        string output = "";

        int numEnemies;

        
        public int NumEnemies { get => numEnemies; set => numEnemies = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public char[,] NewMap { get => newMap; set => newMap = value; }
        public int MaxHeight { get => maxHeight; set => maxHeight = value; }
        public int MaxWidth { get => maxWidth; set => maxWidth = value; }

        enum Movement { UP, DOWN, LEFT, RIGHT };

        public Map(int min_width, int max_width, int min_height, int max_height, int numEnemies)
        {
            this.MaxHeight = max_height;
            this.MaxWidth = max_width;
            this.Width = 20; //r.Next(min_width, max_width);
            this.Height = 20; //r.Next(min_height, max_height);
            this.NumEnemies = numEnemies;
            this.newMap = new char[this.MaxHeight, this.MaxWidth];

            // Tile newmap = new Tile();

            // if (GetType(Tile) == Obstacle)
            // string[,] newmap;
            // newmap = new string[finheight, finwidth];

            Create();
            UpdateVision();
        }

        public void Create()
        {            
            int heroX, heroY, presentX, presentY;
            Random r = new Random();
            
            // TAKE THIS OUT BEFORE COMPLETEING THE GAME            

            InitialiseMap();

            heroX = r.Next(0, this.MaxWidth);
            heroY = r.Next(0, this.MaxHeight);

            int[] xcordsHero = new int[1];
            int[] ycordsHero = new int[1];
            int z = 0;
            xcordsHero[z] = heroX;
            ycordsHero[z] = heroY;

            while (newMap[heroY, heroX] == 'X')
            {
                heroX = r.Next(0, this.MaxWidth);
                heroY = r.Next(0, this.MaxHeight);                
            }

            newMap[heroY, heroX] = 'H';

            bool roundpass = false;
            int highScore = 0;
            int[] xcordsP = new int[NumEnemies];
            int[] ycordsP = new int[NumEnemies];

            if (roundpass == false)
            {
                for (int i = 0; i < NumEnemies; i++)
                {
                    presentX = r.Next(0, this.MaxWidth);
                    presentY = r.Next(0, this.MaxHeight);

                    while (newMap[presentY, presentX] == 'X')
                    {
                        presentY = r.Next(0, this.MaxWidth);
                        presentX = r.Next(0, this.MaxHeight);
                    }

                    newMap[presentY, presentX] = 'G';

                    xcordsP[i] = presentX;
                    ycordsP[i] = presentY;

                    if (heroY == presentY && heroX == presentX)
                    {
                        highScore++;
                    }
                }
                roundpass = true;
            }

            UpdateVision();

            Console.WriteLine("Which Direction do you want to move? ");
            string move = Console.ReadLine();
            bool stop = false;
            while (!stop)
            {
                newMap[heroY, heroX] = '.';

                switch (move)
                {
                    case "up":
                        heroY--;
                        break;
                    case "down":
                        heroY++;
                        break;
                    case "left":
                        heroX--;
                        break;
                    case "right":
                        heroX++;
                        break;
                }

                newMap[heroY, heroX] = 'H';          

                UpdateVision();

                if (newMap[heroY - 1, heroX] == '.')
                {
                    Console.WriteLine("You can move up, its clear.");
                }
                else
                {
                    Console.WriteLine("There is something above the hero!");
                }
                if (newMap[heroY + 1, heroX] == '.')
                {
                    Console.WriteLine("You can move down, its clear.");
                }
                else
                {
                    Console.WriteLine("There is something below the hero!");
                }
                if (newMap[heroY, heroX + 1] == '.')
                {
                    Console.WriteLine("You can move right, its clear.");
                }
                else
                {
                    Console.WriteLine("There is something to the right of the hero!");
                }
                if (newMap[heroY, heroX - 1] == '.')
                {
                    Console.WriteLine("You can move left, its clear.");
                }
                else
                {
                    Console.WriteLine("There is something to the left of the hero!");
                }

                Console.WriteLine("Keep Moving?");
                string answer;
                answer = Console.ReadLine();
                if (answer == "no")
                {
                    stop = true;
                }
                else
                {
                    Console.WriteLine("Which Direction do you want to move? ");
                    move = Console.ReadLine();
                }               
            }           
        }

        public void UpdateVision()
        {            
            for (int y = 0; y < this.MaxHeight; y++)
            {
                for (int x = 0; x < this.MaxWidth; x++)
                {
                    output += "" + this.newMap[y, x] + "";
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }

        //private Tile Create(Tile.TileType)
        //{
        //    int randX = r.Next(0, 5);
        //    int randY = r.Next(0, 5);

        //    if (Tile.TileType = "Enemy")
        //    {
        //        Goblin Goblin = new Goblin(randX, randY);
        //    }
        //    else if (Tile.TileType = 'Hero')
        //    {
        //        Hero Hero = new Hero(randX, randY, 10);
        //    }
        //}

        //public void SetValues(int maxWidth, int maxHeight)
        //{
        //    width = r.Next(0, maxWidth);
        //    height = r.Next(0, maxHeight);
        //    Map = new char[height, width];
        //    InitialiseMap();
        //}

        private void InitialiseMap()
        {
            for (int y = 0; y < this.MaxHeight; y++)
            {
                for (int x = 0; x < this.MaxWidth; x++)
                {
                    if (y == 0 || y == this.MaxHeight - 1 || x == 0 || x == this.MaxWidth - 1)
                    {
                        newMap[y, x] = 'X';
                    }
                    else newMap[y, x] = '.';
                }
            }            
        }
    }
}
