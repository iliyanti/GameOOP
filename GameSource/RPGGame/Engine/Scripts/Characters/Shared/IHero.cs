namespace RPG.Engine.Scripts.Characters.Shared
{
    interface IHero
    {
        int Experience { get; set; }

        int NextLevelExperience { get; set; }

        void CheckHealth();
    }
}
