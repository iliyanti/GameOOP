using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.Items
{
    public class Gun: Item
    {
        private int damage;

        public Gun(string name, ItemRarity itemRarity, int slots, int damage) : base(name, itemRarity, slots)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }
        
    }
}
