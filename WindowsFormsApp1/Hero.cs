using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hero : Character
    {

        public Hero(int x, int y, Tile[,] map, TileType C1) : base(x, y, map, C1)
        {
            hP = 100;
            damage = 2;
            xPos = x;
            YPos = y;
            id = C1;
        }
        public override movement ReturnMove(movement move)
        {
            int direction = (int)move;
            // enum Move(up , down, left ,right)
            //             1,   2 ,   3,  4
            if (direction == 1)
            {
                // Move UP 
                if (visionArray[yPos - 1, xPos].id == TileType.emptyTile)
                {
                    return move;
                }
                else
                {
                    if (visionArray[yPos - 1, xPos].id == TileType.Gold)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
            }
            else if (direction == 2)
            {
                // Move Down
                if (visionArray[yPos + 1, xPos].id == TileType.emptyTile)
                {
                    return move;
                }
                else
                {
                    if (visionArray[yPos + 1, xPos].id == TileType.Gold)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.idle;
                    }
                }
            }
            else if (direction == 3)
            {
                // Move Left
                if (visionArray[yPos, xPos - 1].id == TileType.emptyTile)
                {
                    return move;
                }
                else
                {
                    if (visionArray[yPos, xPos - 1].id == TileType.Gold)
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
                // Move Left
                if (visionArray[yPos, xPos + 1].id == TileType.emptyTile)
                {
                    return move;
                }
                else
                {
                    if (visionArray[yPos, xPos + 1].id == TileType.Gold)
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
            if (WeaponEquip != null)
            {
                return "Hero" + "\n" + "X Postion: " + XPos + "\n" + "Y Postion: " + yPos + "\n" +
                " HP:" + hP.ToString() + "\n" + "Damage:" + damage.ToString() + "\n" + "Weapon: " + WeaponEquip.ToString() +"\n" + GoldPurse.ToString();
            }
            else
            {
                return "Hero" + "\n" + "X Postion: " + XPos + "\n" + "Y Postion: " + yPos + "\n" +
                " HP:" + hP.ToString() + "\n" + "Damage:" + damage.ToString() + "\n" + GoldPurse.ToString(); ;
            }
        }

        public bool MovePlayer(movement type)
        {
            //bool SpaceOpen = false;
            //int direction = (int)type;
            //if (true)
            //{
            //    if (visionArray[direction].id == TileType.emptyTile)
            //    {
            //        SpaceOpen = true;
            //    }
            //}
            //return SpaceOpen;
            return false;
        }

        //public void CreateHero(int x, int y) 
        //{

        //}
    }
}
