using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Character : Tile
    {
        protected int hP;
        protected int maxHP;
        protected int damage;
        protected Tile[,] visionArray;
        private int goldPurse;
        Weapon weaponEquip;
        public enum movement { idle, Up, Down, Left, Right };
        public int HP { get => hP; set => hP = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int Damage { get => damage; set => damage = value; }
        public Tile[,] VisionArray { get => visionArray; set => visionArray = value; }
        public int GoldPurse { get => goldPurse; set => goldPurse = value; }
        public Weapon WeaponEquip { get => weaponEquip; set => weaponEquip = value; }

        public Character(int x, int y, Tile[,] Map, TileType C) : base(x, y, C)
        {
            visionArray = Map;
        }

        public virtual void Attack(Character target)
        {
            target.damage -= hP;
        }

        public bool IsDead()
        {
            bool Dead;
            if (hP <= 0)
            {
                Dead = true;
            }
            else
            {
                Dead = false;
            }
            return Dead;
        }

        public virtual bool CheckRange(Character target)
        {
            bool range;
            if (DistanceTo(target) == 1)
            {
                range = true;
            }
            else
            {
                range = false;
            }
            return range;
        }
        private int DistanceTo(Character target)
        {
            if (Math.Abs(target.XPos - target.YPos) == 1 && Math.Abs(target.XPos - target.YPos) == 1)
            {
                return 1;
            }
            return -1;
        }

        public void Move(movement move)
        {
            //Character Chara = new Character(xPos,yPos, visionArray, id));
            int pX = xPos;
            int pY = yPos;

            switch (move)
            {
                case movement.idle:
                    // Does not move
                    break;
                case movement.Up:
                    YPos = YPos - 1;
                    break;
                case movement.Down:
                    YPos = YPos + 1;
                    break;
                case movement.Left:
                    XPos = XPos - 1;
                    break;
                case movement.Right:
                    XPos = XPos + 1;
                    break;
                default:
                    break;
            }
            if (visionArray[yPos,XPos].id == TileType.Gold)
            {
                goldPurse = goldPurse + 20;
            }

            visionArray[yPos, xPos] = this;
            visionArray[pY, pX] =  new EmptyTile(pX,pY, TileType.emptyTile);
        }

        public abstract movement ReturnMove(movement move = 0);


        public abstract override string ToString();

        public void pickUp(Item type)
        {

            if (type.id == Tile.TileType.Gold)
            {
                goldPurse = goldPurse + 1;
            }
        }


    }
}
