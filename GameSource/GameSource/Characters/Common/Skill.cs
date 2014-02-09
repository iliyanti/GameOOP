namespace Game.Characters.Common
{
    using System;

    public enum SkillType
    {
        Base,
        Area,
        Ultimate
    }

    public class Skill
    {
        private int damage;
        private string name;
        private SkillType type;
        private TimeSpan duration;

        public TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        

        public SkillType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

    }
}
