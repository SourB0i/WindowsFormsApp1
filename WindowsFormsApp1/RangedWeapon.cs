using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RangedWeapon: Weapon
    {
        public enum Types { Rifle, Longbow };
        public RangedWeapon(int x, int y,Tile.TileType RW, int ranRW) : base(x, y, RW)
        {
            chooseWeapon(ranRW);
        }

        public void chooseWeapon(int choose)
        {
            switch (choose)
            {
                case 0:
                    WeaponString = "Rifle";
                    durability = 3;
                    damage = 5;
                    range = 3;
                    cost = 7;
                    break;
                case 1:
                    WeaponString = "LongBow";
                    durability = 4;
                    damage = 4;
                    range = 2;
                    cost = 5;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
