using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar1
{
    class BattleFormation
    {

        public string name { get; private set; }

        public FormationRow[] rows { get; private set; }
        public bool InActive { get; private set; }

        public General GeneralIncharge { get; private set; }


        public BattleFormation(string name)

        {
            this.name = name;
            rows = new FormationRow[6];

        }


        public void SetFormationRow(Ship selctedship,uint amountOfShips,uint Rowposition)
        {
            if (Rowposition < 6)
            {
                rows[Rowposition] = new FormationRow(selctedship, amountOfShips);
            }
            else
                throw new Exception("Invalid Row");

        
        }

        public void ActiveFormation(General assignedGeneral)
        {


            GeneralIncharge = assignedGeneral;
            InActive = true;


        }
       
    }
}
