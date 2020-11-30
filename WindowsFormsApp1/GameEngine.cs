using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GameEngine
    {
        private Map Map;
        private Tile[] ItemArray;

        private Shop shopGE;
        public Map map { get => Map; set => Map = value; } 
        internal Tile[] ItemArray1 { get => ItemArray; set => ItemArray = value; }
        public Shop ShopGE { get => shopGE; set => shopGE = value; }

        public GameEngine()
        {               //minHeight, maxHeight, minWidth, maxWidth, numEnemies
            map = new Map(18, 20, 18, 20, 5, 5);
            ShopGE = new Shop(map.MapHero);
            //ItemArray = new Tile[5];
            //map.Create(ItemArray[5].id);
        }

        public void EnemyAttack() 
        {

        }

        public void MoveEnemies() 
        {

        }


    }
}
