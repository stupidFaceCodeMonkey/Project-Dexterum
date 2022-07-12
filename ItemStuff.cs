using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dexterum
{
    public class ItemStuff
    {
        public class GameItemBasic
        {
            public string Name { get; set; } = "Default item";
            public string Description { get; set; } = "Look like brick";
            public double Mass { get; set; } = 1;
            public double Price { get; set; } = 1;
            public string ItemCategory { get; set; } = "Basic";
        }
        public class GameItemWeaponMelee : GameItemBasic
        {
            public GameItemWeaponMelee() { ItemCategory = "Weapons"; }
            public Mechanics.Attack[] attacks { get; set; }
            public int skillbonus { get; set; } = 0;
            public int qualityBonus { get; set; } = 0;
            public string UsedSkill { get; set; } = "Brawling";
            public int UsedSkillValue { set; get; }
            public int SkillChance { get { return UsedSkillValue + skillbonus; } }
        }
    }
}
