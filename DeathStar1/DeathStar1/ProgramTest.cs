using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class ProgramTest
    {
        public static void Main(string[] args)
        {
            var battleship = BattleShip.CreateBattleship("Raven");
            var canon = Weapon.CreateWeapon("Canon", WeaponType.Large);
            battleship.InstallWeapon(canon, 1);

            var formation = new BattleFormation("Formation Test");
            formation.SetFormationRow(battleship, 1000, 1);

            var battleship2 = BattleShip.CreateBattleship("Dominex");
            var laser = Weapon.CreateWeapon("Laser", WeaponType.Large);
            battleship2.InstallWeapon(laser, 2);

            var formation2 = new BattleFormation("formation test2");
            formation2.SetFormationRow(battleship2, 2000, 2);


            var attackingGeneral = new General();
            var attackingPlanet = Planet.CreatePlanet("Pendora");
            attackingPlanet.OffensiveFormation = formation;
            attackingPlanet.OffensiveFormation.ActiveFormation(attackingGeneral);


            var defensiveGeneral = new General();
            var defensivePlanet = Planet.CreatePlanet("Lava");
            defensivePlanet.DeffensiveFormation = formation2;
            defensivePlanet.DeffensiveFormation.ActiveFormation(defensiveGeneral);
            


        }


    }
}
