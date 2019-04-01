using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class Planet
    {
        public string name { get; private set; }
        public BattleFormation OffensiveFormation { get; set; }
        public BattleFormation DeffensiveFormation { get; set; }

        private Planet(string name)
        {

        }

        public static Planet CreatePlanet(string name)
        {
            switch(name)
            {
                case "Pendora":
                    return new Planet(name);

                case "Lava":
                    return new Planet(name);

                default:
                    return null;

            }


        }
    }
}
