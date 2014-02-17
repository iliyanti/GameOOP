namespace RPG.Engine.Scripts.Characters.Shared
{
    using System.Collections.Generic;
    using Items;
    using Interfaces;

    /// <summary>
    /// A class for the character
    /// </summary>
    public abstract class Character : IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Character class
        /// </summary>
        /// <param name="homeRow">input a home row number</param>
        /// <param name="homeColumn">input a home column number</param>
        protected Character(int homeRow, int homeColumn)
        {
            this.HomeRow = homeRow;
            this.HomeColumn = homeColumn;
            this.CurrentDirection = Direction.Still;
            this.LocationColumn = homeColumn;
            this.LocationRow = homeRow;
            this.Inventory = new List<Item>();
        }

        /// <summary>
        /// Gets and sets the total health of the character
        /// </summary>
        public int TotalHealth { get; set; }

        /// <summary>
        /// Gets and sets the inventory of the character
        /// </summary>
        protected List<Item> Inventory { get; set; }

        /// <summary>
        /// Symbol for the character
        /// </summary>
        public char Sprite { get; set; }

        /// <summary>
        /// Gets and sets the base damage of the character
        /// </summary>
        public int BaseDamage { get; set; }

        /// <summary>
        /// Gets and sets the home row for the character
        /// </summary>
        public int HomeRow { get; private set; }

        /// <summary>
        /// Gets and sets the home column for the character
        /// </summary>
        public int HomeColumn { get; private set; }

        /// <summary>
        /// Gets and sets the current row of the character
        /// </summary>
        public int LocationRow { get; set; }

        /// <summary>
        /// Gets and sets the current column of the character
        /// </summary>
        public int LocationColumn { get; set; }

        /// <summary>
        /// Gets and sets the current level of the character
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets and sets the current direction of the character
        /// </summary>
        public Direction CurrentDirection { get; set; }

        /// <summary>
        /// Gets and sets the base armor 
        /// </summary>
        public int BaseArmor { get; set; }

        /// <summary>
        /// Gets and sets the current health
        /// </summary>
        public int Health { get; set; }

        protected Stack<Direction> Path { get; set; }

        /// <summary>
        /// Method to move the character
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// Checks if the character is dead.
        /// </summary>
        public abstract void CheckHealth();

        public void AddToPath(Direction direction)
        {
            this.Path.Push(direction);
        }

        public void RemovePath()
        {
            this.Path.Pop();
        }
    }
}
