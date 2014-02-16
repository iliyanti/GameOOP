using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.Quests;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Playable
{
    public class Hero: Character, IMovable, IHero, IPlayable
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


        public void Move()
        {
            throw new global::System.NotImplementedException();
        }

        public int NextLevelExperience { get; set; }

        public void CheckHealth()
        {
            if (this.Health >= 0)
            {
              
            }
        }

        public void GetUsetInput()
        {
            throw new System.NotImplementedException();
        }
    }
}
