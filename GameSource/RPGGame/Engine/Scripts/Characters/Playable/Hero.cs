using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.Quests;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Playable
{
    /// <summary>
    /// A class for the hero
    /// </summary>
    public abstract class Hero : Character, IHero, IPlayable
    {
        private Item chestArmor;


        public Hero(int homeRow, int homeColumn)
            : base(homeRow, homeColumn)
        {
            this.Quests = new List<Quest>();
            this.Inventory = new List<Item>();
        }

        /// <summary>
        /// Gets and sets the inventory
        /// </summary>
        private List<Item> Inventory { get; set; }

        public int NextLevelExperience { get; set; }

        /// <summary>
        /// Gets and sets the quests
        /// </summary>
        private List<Quest> Quests { get; set; }

        /// <summary>
        /// Gets and sets the chest armor
        /// </summary>
        public Item ChestArmor
        {
            get
            {
                return this.chestArmor;
            }

            set
            {
               // if (value.GetType() is ChestArmor)
               // {
                    this.chestArmor = value;
               // }

            }
        }

        /// <summary>
        /// Method to move the character base on his current path
        /// </summary>
        public override void Move()
        {
            throw new global::System.NotImplementedException();
        }

        /// <summary>
        /// Checks the health of the hero
        /// </summary>
        public override void CheckHealth()
        {
            if (this.Health <= 0)
            {
                this.LocationColumn = this.HomeColumn;
                this.LocationRow = this.HomeRow;
            }
        }

        /// <summary>
        /// Gets the user input an saves it to a path
        /// </summary>
        public void GetUsetInput()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Method to add an item to the inventory
        /// </summary>
        /// <param name="item">input an item</param>
        public void AddItem(Item item)
        {
            this.Inventory.Add(item);
        }
    }
}
