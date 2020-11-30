using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Leader : Enemy
    {
        private Tile target;
        public Tile Target { get => target; set => target = value; }
        Random r;

        public Leader(int x, int y ,Tile[,] map, Tile.TileType L, int hp, int dam) : base(x,y,map,L, hp) 
        {
            xPos = x;
            YPos = y;
            hP = hp;
            damage = dam;
        }

        //Fixed to work with player
        public override movement ReturnMove(movement move)
        {
            int direction = (int)move;
            // enum Move(up , down, left ,right)
            //             1,   2 ,   3,  4
            bool path = false;
            while (path == false)
            {
                if (direction == 1)
                {
                    // Move UP 
                    if (visionArray[yPos - 1, xPos].id == TileType.emptyTile && visionArray[yPos - 1, xPos].id != TileType.Obstacle)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return movement.idle;
                    }
                }
                else if (direction == 2)
                {
                    // Move Down
                    if (visionArray[yPos + 1, xPos].id == TileType.emptyTile)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return movement.idle;
                    }
                }
                else if (direction == 3)
                {
                    // Move Left
                    if (visionArray[yPos, xPos - 1].id == TileType.emptyTile)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return movement.idle;
                    }
                }
                else
                {
                    // Move Left
                    if (visionArray[yPos, xPos + 1].id == TileType.emptyTile)
                    {
                        path = true;
                        return move;
                    }
                    else
                    {
                        path = false;
                        return movement.idle;
                    }
                }               
            }
            return move;
        }
        public override string ToString()
        {
            return "Leader: " + "\n" + "X Postion: " + XPos + "\n" + "Y Postion: " + yPos + "\n" + "Damage: " + damage +"\n"+ "HP: " + HP;
        }
    }
}
