namespace RPG.Engine.Scripts.Characters.Items
{
    using Shared;

    /// <summary>
    /// A class for the item
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// A name for the item
        /// </summary>
        private string name;

        /// <summary>
        /// 
        /// </summary>
        private ItemSlot slot;

        private char sprite;

        public char Sprite
        {
            get { return this.sprite; }
            set { this.sprite = value; }
        }
        

        /// <summary>
        /// Slots that it takes in the inventory
        /// </summary>
        private int slotsInInventory;

        /// <summary>
        /// Initializes a new instance of the Item class
        /// </summary>
        /// <param name="name">input string as a name</param>
        /// <param name="itemRarity">input the rarity of the item</param>
        /// <param name="slots">input the number of slots the item takes in the inventory</param>
        protected Item(string name, ItemRarity itemRarity, int slots)
        {
            this.Name = name;
            this.SlotsInInventory = slots;
            this.Rarity = itemRarity;
        }

        /// <summary>
        /// Gets the slots in the inventory
        /// </summary>
        public int SlotsInInventory
        {
            get { return this.slotsInInventory; }
            private set { this.slotsInInventory = value; }
        }

        /// <summary>
        /// Gets the item rarity
        /// </summary>
        public ItemRarity Rarity { get; private set; }


        public ItemSlot Slot
        {
            get { return this.slot; }
            set { this.slot = value; }
        }

        /// <summary>
        /// Gets the name of the item
        /// </summary>
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        /// <summary>
        /// For testing
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
