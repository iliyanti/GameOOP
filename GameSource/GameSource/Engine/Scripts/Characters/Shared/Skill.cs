using System;

namespace Name.Engine.Scripts.Characters.Shared
{
    public enum SkillType
    {
        Base,
        Area,
        Ultimate
    }

    public enum SkillRange
    {
        Melee,
        Range
    }

    public class Skill
    {
        private int damage;
        private string name;
        private SkillType type;
        private TimeSpan duration;
        private SkillRange range;

        public SkillRange Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

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
