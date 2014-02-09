using System.Collections.Generic;
using Game.Characters.Common;
using Game.Characters.Items;
using Game.Characters.Quests;

namespace Game.Characters.Player
{
    public class PlayerBase: BaseStats
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
