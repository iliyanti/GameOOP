﻿namespace RPG.Engine.Scripts.Characters.Shared
{
    interface IHero
    {
         int NextLevelExperience { get; set; }

        void CheckHealth();
    }
}
