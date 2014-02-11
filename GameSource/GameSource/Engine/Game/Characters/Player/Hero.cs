﻿using System.Collections.Generic;
using Name.Characters.Common;
using Name.Characters.Items;
using Name.Characters.Quests;

namespace Name.Characters.Player
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