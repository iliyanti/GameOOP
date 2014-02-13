using System.Collections.Generic;
using Name.Engine.Scripts.Characters.Items;
using Name.Engine.Scripts.Characters.Quests;
using Name.Engine.Scripts.Characters.Shared;

namespace Name.Engine.Scripts.Characters.Player
{
    public class Hero: BaseStats
    {
        private List<Item> inventory;
        private Item shouldersItem;
        private List<Quest> quests;

        public List<Quest> Quests
        {
            get { return this.quests; }
            set { this.quests = value; }
        }
        
        public Item ShouldersItem
        {
            get { return shouldersItem; }
            set { shouldersItem = value; }
        }

        
        public List<Item> Inventory
        {
            get { return this.inventory; }
            set { this.inventory = value; }
        }

        
    }
}
