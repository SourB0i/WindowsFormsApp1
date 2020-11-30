using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Weapon: Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        private string weaponString;



        public int Damage { get => damage; set => damage = value; }

        public int Durability { get => durability; set => durability = value; }
        public int Cost { get => cost; set => cost = value; }
        public virtual int Range { get => range; set => range = value; }
        public string WeaponString { get => weaponString; set => weaponString = value; }

        // = 0 allow to add in incase nothing is there.
        public Weapon(int x, int y, Tile.TileType Weapon):base(x,y,Weapon)
        {
           
        }

        public override string ToString()
        {
            return weaponString;
        }
    }
}
