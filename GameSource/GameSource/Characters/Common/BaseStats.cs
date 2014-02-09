namespace Game.Characters.Common
{
    public enum Direction
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
        Still = 5
    }

    public class BaseStats
    {
        private int health;
        private int mana;
        private int armour;
        private Direction currentDirection;
        private int level;
        private int experience;

        public int Experience
        {
            get { return this.experience; }
            set { this.experience = value; }
        }
        
        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        

        public Direction CurrentDirection
        {
            get { return this.currentDirection; }
            set { this.currentDirection = value; }
        }

        public int Armour
        {
            get { return this.armour; }
            set { this.armour = value; }
        }

        public int Mana
        {
            get { return this.mana; }
            set { this.mana = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
