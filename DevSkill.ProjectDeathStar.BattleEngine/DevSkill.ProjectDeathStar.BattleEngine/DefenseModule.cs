﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class DefenseModule
    {
        string Name { get; set; }
        int ShieldEffectFactor { get; set; }
        int ArmorEffectFactor { get; set; }
        int HullEffectFactor { get; set; }

        public DefenseModule(string name, int sheilEffectFactor, int armorEffectFactor,
            int hullEffectFactor)
        {
            Name = name;
        }
       
    }
}