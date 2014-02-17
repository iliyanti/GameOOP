namespace RPG.Engine.Scripts.Characters.Items
{
    using Shared;

    /// <summary>
    /// A class to create items
    /// </summary>
    public static class ItemFactory
    {
        private const string chest = "Chest Armor";
        private const string potion = "Health Potion";
        private const string rifle = "Rifle";

        /// <summary>
        /// Method to create an item
        /// </summary>
        /// <returns></returns>
        public static Item Create()
        {
            double chance = RandomGenerator.GivePercent();

            Item item = null;
            if (chance < 30)
            {
                item = new ChestArmor(chest, CalcRarity(), 6, CalcArmor());
            }
            else if (chance >= 30 && chance <= 70)
            {
                item = new Potion(potion, ItemRarity.Common, 1);
            }
            else if (chance > 70)
            {
                item = new Gun(rifle, CalcRarity(), 4, CalcDamage());
            }

            return item;
        }

        /// <summary>
        /// Method to calculate the rarity of the item
        /// </summary>
        /// <returns></returns>
        private static ItemRarity CalcRarity()
        {
            var rarity = (ItemRarity)RandomGenerator.GiveInteger(0, 6);
            return rarity;
        }

        /// <summary>
        /// Method to calculate the armor of the item
        /// </summary>
        /// <returns></returns>
        private static int CalcArmor()
        {
            int value = RandomGenerator.GiveInteger(100, 1000);
            return value;
        }

        /// <summary>
        /// Method to calculate the damage of the weapon
        /// </summary>
        /// <returns></returns>
        private static int CalcDamage()
        {
            int value = RandomGenerator.GiveInteger(0, 100);
            return value;
        }
    }
}
