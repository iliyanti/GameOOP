namespace Game.Characters.Items
{
    public enum ItemRarity
    {
        Poor = 0,
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 4,
        Legendary = 5
    }
    public enum ItemSlot
    {
        Hat = 0,
        ChestArmour = 1,
        Pants = 2,
        Boots = 3,
        OneHand = 4,
        TwoHand = 5,
        OffHand = 6,
        Ring = 7,
        Amulet = 8,
        Shoulders = 9,
        Gloves = 10,
        Bracers = 11,
        Belt = 12,
        NoSlot = 13
    }
    public class ItemBase
    {
        private string name;
        private ItemSlot slot;

        private ItemRarity rarity;

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

    }
}
