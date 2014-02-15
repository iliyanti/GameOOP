namespace RPGGame.Engine.Scripts.Characters.Shared
{
    public enum Direction
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
        Still = 5
    }

    public class Character
    {
        private int health;
        private int mana;
        private int armour;
        private Direction direction;
        private int level;
        private int experience;

        public int HomeRow { get; set; }

        public int HomeColumn { get; set; }

        public int LocationRow { get; set; }

        public int LocationColumn { get; set; }

        public int TotalHealth { get; set; }

        public int TotalMana { get; set; }


        private string sprite;

        public string Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }
        

       

       
        
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
            get { return this.direction; }
            set { this.direction = value; }
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
