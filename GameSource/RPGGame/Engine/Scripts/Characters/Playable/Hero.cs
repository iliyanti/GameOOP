namespace RPG.Engine.Scripts.Characters.Playable
{
    using Interfaces;
    using Items;
    using Quests;
    using Shared;
    using System.Collections.Generic;

    /// <summary>
    /// A class for the hero
    /// </summary>
    public abstract class Hero : Character, IHero
    {
        private Item chestArmor;

        protected Hero(int homeRow, int homeColumn)
            : base(homeRow, homeColumn)
        {
            this.Quests = new List<Quest>();
        }

        public int Experience { get; set; }
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
            if (this.Path.Count != 0)
            {
                if (this.Path.Peek() == Direction.Up)
                {
                    this.CurrentDirection = Direction.Up;
                    this.LocationRow--;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Right)
                {
                    this.CurrentDirection = Direction.Right;
                    this.LocationColumn++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Down)
                {
                    this.CurrentDirection = Direction.Down;
                    this.LocationRow++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Left)
                {
                    this.CurrentDirection = Direction.Left;
                    this.LocationColumn--;
                    this.Path.Pop();
                }
            }
            else
            {
                
            }
        }

        

        public void Revive()
        {
            this.LocationColumn = this.HomeColumn;
            this.LocationRow = this.HomeRow;
            this.Health = this.TotalHealth;
        }
    }
}
