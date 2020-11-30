using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y, Tile[,] map, TileType G, int damage, int hp, int maxHp) : base(x, y, map, G, 10)
        {
            Damage = damage;
            HP = hp;
           xPos = x;
            YPos = y;
            id = G;
        }
        public override movement ReturnMove(movement move)
        {
            int direction = (int)move;
            // enum Move(up , down, left ,right)
            //             1,   2 ,   3,  4

            int rando = r.Next(0, 4);
            if (rando == direction)
            {
                // Move UP 
                if (YPos == 0)
                {
                    return movement.idle;
                }
                else
                {
                    if (visionArray[yPos - 1, xPos].id == TileType.emptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
            }
            else if (rando == direction)
            {
                // Move Down
                //visionArray.GetLength(0) - 1
                if (YPos == visionArray.GetLength(0) - 1)// Why Get lenght ... We want that row or colomun 2D array X, Y AXIS by making it equal that getLneght it cant go out 
                {
                    return movement.idle;
                }
                else
                {
                    if (visionArray[yPos + 1, xPos].id == TileType.emptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
               
            }
            else if (rando == direction)
            {
                // Move left
            
                if (XPos == 0)
                {
                    return movement.idle;
                }
                else
                {
                    if (visionArray[yPos, xPos - 1].id == TileType.emptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
            }
            else
            {
                // Move Right
                //visionArray.GetLength(1) - 1
                if (XPos == visionArray.GetLength(1) - 1)
                {
                    return movement.idle;
                }
                else
                {
                    if (visionArray[yPos, xPos + 1].id == TileType.emptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
            }
        }

        public override string ToString()
        {
            return "Goblin: "+"\n"+"X Postion: " + XPos + "\n" + "Y Postion: " + yPos + "\n";
        }
    }
}
