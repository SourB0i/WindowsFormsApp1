using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mage: Enemy
    {
        public Mage(int x, int y, Tile[,] map ,  Tile.TileType M, int damage, int maxHP,int hp) : base(x, y, map, M,5)
        {
            Damage = damage;
            HP = hp;
            xPos = x;
            YPos = y;
            id = M;
        }

        public override movement ReturnMove(movement move = movement.idle)
        {
            return movement.idle;
        }

        public override bool CheckRange(Character target)
        {
            if (target.XPos == XPos - 1)
            {
                return true; 
            }
            else if (target.XPos == XPos + 1)
            {
                return true;
            }
            else if (target.YPos == YPos - 1)
            {
                return true;
            }
            else if (target.YPos == YPos + 1)
            {
                return true;
            }
            else if (target.XPos == XPos + 1 && target.YPos == YPos + 1)
            {
                return true;
            }
            else if (target.XPos == XPos - 1 && target.YPos == YPos - 1)
            {
                return true;
            }
            else if (target.XPos == XPos + 1 && target.YPos == YPos - 1)
            {
                return true;
            }
            else if (target.XPos == XPos - 1 && target.YPos == YPos + 1)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Mage: "+"\n"+"X Postion: " + XPos + "\n" + "Y Postion: " + yPos + "\n";
        }
    }
}
