using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Gold: Item
    {
        private int goldDrop;
        public int GoldDrop { get => goldDrop; set => goldDrop = value; }
        Random r = new Random();
        public Gold(int x, int y, Tile.TileType G, int goldDrop) : base(x,y,G) 
        {
            this.goldDrop = goldDrop;
            XPos = x;
            yPos = y;
            id = G;
        }
        public override string ToString()
        {
            return "( " + xPos.ToString() + yPos.ToString() + " ) " + "\n" + goldDrop; 
        }

    }
}
