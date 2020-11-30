using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Obstacle: Tile
    {
        public Obstacle(int x, int y,TileType O) : base(x,y,O) 
        {
            XPos = x;
            yPos = y;
            id = O;
        }
    }
}
