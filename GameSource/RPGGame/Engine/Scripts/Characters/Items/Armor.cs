using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Items
{
    public abstract class Armor : Item
    {
        private int armorValue;

        protected Armor(string name, ItemRarity itemRarity, int slots, int armorValue) : base(name, itemRarity, slots)
        {
            this.armorValue = armorValue;
        }

        public int ArmorValue
        {
            get { return this.armorValue; }
            set { this.armorValue = value; }
        }
        
    }
}
