using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class BattleShip :Ship
    {
        private BattleShip(string name,string url,uint sheild,uint armor,uint hull,uint range,
            uint weaponSlot,uint engineeringSlot,uint defenseSlot)
        {

        }



        public void InstallWeapon(Weapon weapon,uint slot)
        {
            if (weapon.type == WeaponType.Large)
            {
                if (slot < this.weaponSlots.Length)
                {
                    this.weaponSlots[slot] = weapon;
                }
                else
                    throw new Exception("Invalid slot");
            }
            else
                throw new Exception("Invlalid weapon");

        }



        


        public static BattleShip CreateBattleship(string shipname)
        {

            switch(shipname)
            {
                case "Reven":
                    return new BattleShip(shipname, "", 7000, 8000, 5000, 3, 8, 4, 5);
                case "Dominix":
                    return new BattleShip(shipname, "", 8000, 7000, 5000, 3, 7, 5, 5);

                case "Scorpion":
                    return new BattleShip(shipname, "", 7000, 7000, 6000, 3, 8, 3, 6);
                case "Widow":
                    return new BattleShip(shipname, "", 9000, 7000, 4000, 3, 8, 5, 4);
                case "Rokh":
                    return new BattleShip(shipname, "", 7000, 8000, 5000, 3, 7, 4, 6);
                default:
                   return null;

            }



        }
    }
}
