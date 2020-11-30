using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MeleeWeapon : Weapon
    {
        public enum Types { daggar, longsword }
        public override string ToString()
        {
            return "";
        }

        //public override int range;
        public MeleeWeapon(int x, int y, Tile.TileType MW, int ranW) : base(x, y, MW)
        { 
            range = 1;
            chooseWeapon(ranW);
        }

        public void chooseWeapon(int choose)
        {
            
            switch (choose)
            {
                case 0:
                    WeaponString = "Dagger";
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    break;

                case 1:
                    WeaponString = "Longsword";
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    break;
                default:
                    break;
            }
        }
    }
}
