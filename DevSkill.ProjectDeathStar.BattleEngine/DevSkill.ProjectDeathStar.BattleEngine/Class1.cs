using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    class Class1
    {

        public static void Main(string[] args)
        {
            var battleship = Battleship.CreateBattleship("Raven");
            var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Large);
            battleship.InstallWeapon(cannon, 1);

            var formation = new BattleFormation("Test formation");
            formation.SetFormationRow(battleship, 1000, 1);


            var battleship2 = Battleship.CreateBattleship("Dominix");
            var laser = Weapon.CreateWeapon("Laser", WeaponType.Large);
            battleship2.InstallWeapon(laser, 2);

            var formation2 = new BattleFormation("Test formation");
            formation.SetFormationRow(battleship, 1000, 1);

            General attackingGeneral = new General();
            var attackingPlanet = Planet.CreatePlanet("Pandora");
            attackingPlanet.OffensiveFormation = formation;
            attackingPlanet.OffensiveFormation.ActivateFormation(attackingGeneral);


            General defensiveGeneral = new General();
            var defensivePlanet = Planet.CreatePlanet("Desert");
            defensivePlanet.DefensiveFormation = formation2;
            defensivePlanet.DefensiveFormation.ActivateFormation(defensiveGeneral);


            var result = BattleSimulator.CalculateBattleResult(attackingPlanet, defensivePlanet);

        }


    }
}
