using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Shop
    {
        Weapon[] weaponArray = new Weapon[3];
        Random r = new Random();
        Character buyer;
        public Shop(Character target)
        {
            buyer = target;
            randomWeapon();
        }

        public void randomWeapon()
        {
            for (int i = 0; i < weaponArray.Length; i++)
            {
                int weaponType= r.Next(0, 2);
                // 0 = Melee and 1 = Range
                if (weaponType == 0 )
                {
                    int meleeType = r.Next(0, 2);

                    weaponArray[i] = new MeleeWeapon(0, 0, Tile.TileType.Weapen, meleeType);
                }
                else
                {
                    int rangeType = r.Next(0, 2);
                    weaponArray[i] = new RangedWeapon(0, 0, Tile.TileType.Weapen, rangeType);
                }

            }
        }

        // Add method void and add paramter int num. make it public method
        // Copy Contents inside for loop above
        //paste
        //change i in weapon array to num

        public bool CanBuy(int num) 
        {
            if (buyer.GoldPurse >= weaponArray[num].Cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void buy(int num) 
        {
            buyer.WeaponEquip = weaponArray[num];
            buyer.GoldPurse = buyer.GoldPurse - weaponArray[num].Cost;
        }

        public string displayWeapon(int num) 
        {
            return "Buy " + weaponArray[num].WeaponString + " " + weaponArray[num].Cost + " Gold";
        }
    }
}
