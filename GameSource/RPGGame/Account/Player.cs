﻿using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;

namespace RPG.Account
{
    /// <summary>
    /// Class for the player
    /// </summary>
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
