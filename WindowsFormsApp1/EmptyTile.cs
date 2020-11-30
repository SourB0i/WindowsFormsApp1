using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class EmptyTile: Tile
    {
        public EmptyTile(int x, int y,TileType S) : base(x,y,S) 
        {
            XPos = x;
            yPos = y;
            id = S;
        }
    }
}
