﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dexterum
{
    /// <summary>
    /// Класс представляющий собой лист персонажа.
    /// </summary>
    public class CharacterStats //every character shoud have them
    {
        //Fluff
        public string Name { get; set; } = "Mr Default";
        public string Species { get; set; } = "Human";
        public string Gender { get; set; } = "Male";
        public string Description { get; set; } = "Dull looking guy with brown hair and brown eyes";
        /// <summary>
        /// Reaction Bonus or penalty for character looks and talks and other.
        /// </summary>
        public int CharizmaBonus { get; set; } = 0;
        //core stats
        public int Strenght { get { return 10; } }
        public int ModStrenght { get; set; } = 0;

        public int StrenghtCost { get { return 10; } }
        public int Dexterity { get { return 10; } }
        public int ModDexterity { get; set; } = 0;

        public int DexterityCost { get { return 20; } }
        public int Health { get { return 10; } }
        public int ModHealth { get; set; } = 0;
        public int HealthCost { get { return 10; } }
        public int Intelligence { get { return 10; } }
        public int ModIntelligence { get; set; } = 0;
        public int IntelligenceCost { get { return 20; } }
        //Secondary stats
        //HP
        public int BaseHP { get { return this.Strenght; } }
        public int ModHP { get; set; } = 0;
        public int ModHPCost { get { return 2; } }
        //FP
        public int BaseFP { get { return this.Health; } }
        public int ModFP { get; set; } = 0;
        public int ModFPCost { get { return 3; } }
        //WillnPerception
        public int BaseWill { get { return this.Intelligence; } }
        public int ModWill { get; set; } = 0;
        public int ModWillCost { get { return 5; } }
        public int BasePerception { get { return this.Intelligence; } }
        public int ModPerception { get; set; } = 0;
        public int ModPerceptionCost { get { return 5; } }
        //Speed
        public double BaseSpeed { get { return 0.25*(this.Dexterity + this.Health); } }
        public double ModSpeed { get; set; } = 0;
        public int ModSpeedCost { get { return 20; } }
        //moves
        public int BaseMove { get { return (int)Math.Floor(this.BaseSpeed + this.ModSpeed); } }
        public int ModMove { get; set; } = 0;
        public int BaseMoveCost { get { return 5; } }

        //thirdly stats
        public double BaseDamageSW { get { return 3.5 + this.Strenght-10; } }
        public double BaseDamageThr { get { return this.BaseDamageSW - 2; } }
        public int ModDamage { get; set; } = 0;
        public int ModDamageCost { get { return 5; } }
        public int BasicLift { get { return (int)Math.Floor((this.Strenght+this.LiftStrenght * this.Strenght+this.LiftStrenght) * 0.2); } }
        public int LiftStrenght { get; set; } = 0;
        public int LiftStrenghtCost { get { return 5; } }


        //Advantages
        object[] Advantages { get; set; } = { };

        //Disadvantages
        object[] Disadvantages { get; set; } = { };

        //Skills
        object[] Skills { get; set; } = { };

        //PointCost
        public int PointCost { get { return Logic.Method_CharacterPointCalc(this); } }

        //Gear
        public object[] Gear { get; set; } = { };


    }
    /// <summary>
    /// Бибоиотека методов
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// Метод подсчитывающий цену персонажа в очках
        /// </summary>
        /// <param name="input">Лист персонажа</param>
        /// <returns></returns>
        public static int Method_CharacterPointCalc(CharacterStats input)
        {
            int CPWorth = input.ModStrenght * input.StrenghtCost +
                          input.ModDexterity * input.DexterityCost +
                          input.ModHealth * input.HealthCost +
                          input.ModIntelligence * input.IntelligenceCost+
                          input.ModHP * input.ModHPCost+
                          input.ModFP*input.ModFPCost+
                          (int)(input.ModSpeed*input.ModSpeedCost)+
                          input.ModMove*input.BaseMoveCost+
                          input.ModWill*input.ModWillCost+
                          input.ModPerception*input.ModPerceptionCost+
                          input.ModDamage*input.ModDamageCost+
                          input.LiftStrenght*input.LiftStrenghtCost;
            return CPWorth;
        }
    }
    
}
