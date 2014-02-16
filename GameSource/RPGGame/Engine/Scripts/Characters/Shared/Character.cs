namespace RPG.Engine.Scripts.Characters.Shared
{
   

    public class Character
    {
        private int health;
        private int baseArmour;
        private Direction direction;
        private int level;
        private string sprite;
        private int baseDamage;
        private int totalHealth;

        public int TotalHealth
        {
            get { return this.totalHealth; }
            set { this.totalHealth = value; }
        }
        

        public int BaseDamage
        {
            get { return baseDamage; }
            set { baseDamage = value; }
        }

        public int HomeRow { get; set; }

        public int HomeColumn { get; set; }

        public int LocationRow { get; set; }

        public int LocationColumn { get; set; }


        public string Sprite
        {
            get { return sprite; }
            set { sprite = value; }
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

        public int BaseArmour
        {
            get { return this.baseArmour; }
            set { this.baseArmour = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
