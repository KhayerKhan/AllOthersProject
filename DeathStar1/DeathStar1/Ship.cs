using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class Ship
    {
        public string name { get; protected set; }
        public string url { get; protected set; }
        public uint sheild { get; protected set; }
        public uint armor { get; protected set; }
        public uint hull { get; protected set; }
        public uint range { get; protected set; }

        public Weapon[] weaponSlots { get; protected set; }
        public EngineeringModule[]  engineeringSlots { get; protected set; }
        public DefenseModule[] defenseModules { get; protected set; }

    }
}
