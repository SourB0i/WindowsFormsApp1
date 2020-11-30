using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Enemy:Character
    {

        protected Random r = new Random();
        public Enemy(int x, int y, Tile[,] map ,TileType E, int hp) : base(x,y ,map,E) 
        {
            //damage = 2;
        
        }

        public override string ToString()
        {
            return  "( " + xPos.ToString() + yPos.ToString() + " ) "+ "\n" + damage.ToString();
        }
    }
}
