using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Map
    {
        private Tile[,] mapArray;
        private Enemy[] enemyArray;
        private int width;
        private int height;
        private Tile[] item;
        int GoldMap;
        Hero mapHero;
        Gold goldInMap;
        Leader leaderInMap;
        MeleeWeapon meleeWeaponMap;
        Random r;

        public Tile[,] MapArray { get => mapArray; set => mapArray = value; }
        public Enemy[] EnemyArray { get => enemyArray; set => enemyArray = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        internal Hero MapHero { get => mapHero; set => mapHero = value; }
        internal Tile[] Item { get => item; set => item = value; }
        internal Gold GoldInMap { get => goldInMap; set => goldInMap = value; }
        public int GoldMap1 { get => GoldMap; set => GoldMap = value; }
        internal Leader LeaderInMap { get => leaderInMap; set => leaderInMap = value; }
        internal MeleeWeapon MeleeWeaponMap { get => meleeWeaponMap; set => meleeWeaponMap = value; }

        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int numEnemies, int GoldDrop) 
        {
            r = new Random();
            Height = r.Next(minHeight, maxHeight);
            Width = r.Next(minWidth,maxWidth);
            MapArray = new Tile [Height, Width];
            

            createEmptyMap();

            EnemyArray = new Enemy [numEnemies];
            mapHero = (Hero)Create(Tile.TileType.Hero);           
            mapArray[mapHero.YPos, mapHero.XPos] = mapHero;
            //WeaponInMap = (Weapon)Create(Tile.TileType.Weapen);
            //mapArray[WeaponInMap.YPos, WeaponInMap.XPos] = WeaponInMap;


            meleeWeaponMap = (MeleeWeapon)Create(Tile.TileType.meleeWeapon);
            mapArray[meleeWeaponMap.YPos, meleeWeaponMap.XPos] = meleeWeaponMap;
            goldInMap = (Gold)Create(Tile.TileType.Gold);
            mapArray[goldInMap.YPos, goldInMap.XPos] = goldInMap;

            for (int i = 0; i < numEnemies; i++)
            {
               int rando = r.Next(0,2);
                if (rando == 0)
                {
                   // goblinInMap = (Goblin)Create(Tile.TileType.goblin);
                    EnemyArray[i] = (Goblin)Create(Tile.TileType.goblin);
                }
                else
                {
                   // MageInMap = (Mage)Create(Tile.TileType.mage);
                    EnemyArray[i] = (Mage)Create(Tile.TileType.mage);
                }
                mapArray[enemyArray[i].YPos, enemyArray[i].XPos] = enemyArray[i];
            }     
            
            leaderInMap = (Leader)Create(Tile.TileType.leader);
            mapArray[leaderInMap.YPos, leaderInMap.XPos] = leaderInMap;
        }

        public void createEmptyMap()// Creates map with code does nto display.
        {
            for (int Y = 0; Y < height; Y++)
            {
                for (int X = 0; X < width; X++)
                {
                    if (X == 0|| Y == 0 || X == width -1 || Y == height -1)
                    {
                        mapArray[Y, X] = new Obstacle(X, Y, Tile.TileType.Obstacle);
                    }
                    else
                    {
                        mapArray[Y, X] = new EmptyTile(X, Y, Tile.TileType.emptyTile);
                    }                    
                }
            }
        }
        public Tile Create(Tile.TileType type)// This creates a Unique X and Y loction for every object for the map
        {
            int UniqueY = r.Next(1, Height - 1);
            int UniqueX = r.Next(1, Width - 1);
            Tile ReturnType = null;
            r = new Random();

            while (mapArray[UniqueY, UniqueX].id != Tile.TileType.emptyTile)
            {
                UniqueY = r.Next(1, Height - 1);
                UniqueX = r.Next(1, Width - 1);
            }

            if (type == Tile.TileType.Hero)
            {
                ReturnType = new Hero(UniqueX, UniqueY, mapArray, Hero.TileType.Hero);
            }
            else if (type == Tile.TileType.goblin)
            {
                ReturnType = new Goblin(UniqueX, UniqueY, mapArray, Goblin.TileType.goblin, 1, 10, 10);               
            }
            else if (type == Tile.TileType.Gold)
            {   
                ReturnType = new Gold(UniqueX, UniqueY, Gold.TileType.Gold, GoldMap1);
            }
            else if (type == Tile.TileType.mage)
            {
                ReturnType = new Mage(UniqueX, UniqueY, mapArray, Mage.TileType.mage, 1, 10, 10);
            }
            else if (type == Tile.TileType.leader)
            {
                ReturnType = new Leader(UniqueX, UniqueY, mapArray, Leader.TileType.leader, 20,2);
            }
            else if (type == Tile.TileType.meleeWeapon)
            {
                int ranM = r.Next(0, 2);
                ReturnType = new MeleeWeapon(UniqueX, UniqueY, Leader.TileType.leader,ranM);
            }
            else
            {
                ReturnType = null;
            }
            return ReturnType;
        }

        /// /////////////////////////////////////////////////////

        public bool MovePlayer() 
        {
            return true;
            // i(xpos == item || ypos == item )
           // {
                // Player picks up item 
                // Item array increases 
            //}
        }

        //public void MapDisply()
        //{
        //    for (int h  = 0; h < Height; h++)
        //    {
        //        for (int w = 0; w < Width; w++)
        //        {
                   
        //        }
        //    }
        //}

        //public Item GetItemAtPosition(int x, int y) 
        //{
        //    Item itemFound;
        //    // Searching through an array requires afor loop!!!!
        //    // Currenlty you are not checking if something is there.
        //    for (int i = 0; i < GameEngineInMap.ItemArray1.Length; i++)
        //    {
        //        if (GameEngineInMap.ItemArray1[i].XPos == x || GameEngineInMap.ItemArray1[i].XPos == x)
        //        {
        //            itemFound = GameEngineInMap.ItemArray1[];
        //        }
        //    }
        //    return itemFound;
        //}
    }

}
