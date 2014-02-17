using System;

namespace RPG.Engine.Scripts.Characters.Shared
{
    /// <summary>
    /// A class for the skills
    /// </summary>
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
