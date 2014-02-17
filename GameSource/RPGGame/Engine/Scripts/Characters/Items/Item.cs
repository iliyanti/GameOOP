using System;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Items
{
    public abstract class Item
    {
        private string name;
        private ItemSlot slot;
        private ItemRarity rarity;
        private int slotsInInventory;

        protected Item(string name, ItemRarity itemRarity, int slots)
        {
            this.Name = name;
            this.SlotsInInventory = slots;
            this.Rarity = itemRarity;
        }
        public int SlotsInInventory
        {
            get { return this.slotsInInventory; }
            set { this.slotsInInventory = value; }
        }

        public ItemRarity Rarity
        {
            get { return this.rarity; }
            set { this.rarity = value; }
        }


        public ItemSlot Slot
        {
            get { return this.slot; }
            set { this.slot = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
