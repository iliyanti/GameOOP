using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Items
{
    public class ChestArmor : Armor
    {
        public ChestArmor(string name, ItemRarity itemRarity, int slots, int armorValue) : base(name, itemRarity, slots, armorValue)
        {

        }
    }
}
