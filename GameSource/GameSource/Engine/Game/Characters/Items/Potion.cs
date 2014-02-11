
namespace Name.Characters.Items
{
    public enum PotionType
    {
        Health = 0,
        Mana = 1,
    }

    public class Potion : Item
    {
        private const ItemRarity potionsRarity = ItemRarity.Common;
        private const ItemSlot potionSlot = ItemSlot.NoSlot;
        private PotionType type;

        public PotionType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        
        public Potion()
        {
            this.Rarity = potionsRarity;
            this.SlotsInInventory = 1;
            this.Slot = potionSlot;
        }
    }
}
