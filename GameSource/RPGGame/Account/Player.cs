using System.Collections.Generic;
using RPGGame.Engine.Scripts.Characters.Playable;

namespace RPGGame.Account
{
    public class Player
    {
        public string Name { get; set; }

        public List<Hero> ExisitngHeroes { get; set; }

        public Hero CurrentHero { get; set; }


        public Player(string name)
        {
            this.Name = name;
        }
    }
}
