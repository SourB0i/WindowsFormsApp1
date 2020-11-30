using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Item: Tile
    {
        public Item(int x, int y, Tile.TileType I) : base(x,y,I) 
        {

        }

        public abstract override string ToString();

    }
}
