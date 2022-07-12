using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dexterum
{
    public class Mechanics
    {
        public class Dice
        {
            public double rawNumbers { get; set; }
            public int dices { get { return Convert.ToInt32(Math.Floor(rawNumbers / 3.5)); } }
            public int addToDices { get { return Convert.ToInt32(rawNumbers - (dices * 3.5)); } }
            public string Text
            {
                get
                { return dices + "d6+" + addToDices; }
            }
        }
        public class Attack
        {            
            public string Name { get; set; } = "Stab";
            public double AttackBonusDamage { get; set; } = 0;
            public double AttackArmorDevisor { get; set; } = 1;
            public UInt32 StrenghtReq { get; set; } = 8;
            public UInt16 Cooldown { get; set; } = 0;
            public bool IsTwohanded { get; set; } = false;
            public int reach { get; set; } = 1;
            public int parry { get; set; } = 0;
        }
    }
}
