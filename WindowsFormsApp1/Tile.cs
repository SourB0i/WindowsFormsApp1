using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    abstract class Tile
    {
        protected int xPos;
        protected int yPos;
        
        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }

        public TileType id;
        public enum TileType { Hero, Enemy, Gold, Weapen, emptyTile, Obstacle, mage, goblin, item, leader, meleeWeapon,rangeWeapon}

        public Tile(int x, int y, TileType idTile) 
        {
            id = idTile;
            XPos = x;
            yPos = y;
        }
    }
}
