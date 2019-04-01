using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class Weapon
    {
        public string name { get; private set;}
        public string pictureUrl { get; private set; }
        public uint KineticDamage { get; private set; }
        public uint ThermalDamage { get; private set; }
        public uint ExplosiveDamage { get; private set; }
        public uint ElectromagneticDamage { get; private set; }


        public WeaponType type { get; private set; }


        private Weapon(string name,string pictureUrl,uint kineticDamage,uint thermalDamage,
            uint explosiveDamage,uint electromagneticDamage,WeaponType type)
        {

        }

        public static Weapon CreateWeapon(string name,WeaponType type)
        {

            switch (name)
            {
                case "Canon":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 0, 10, 0, 20, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 0, 20, 0, 40, type);
                    else return null;

                case "Laser":

                    return new Weapon(name, "", 8000, 7000, 5000, 3000,type);

                default :
                   return null;
            }

        }


    }
}
