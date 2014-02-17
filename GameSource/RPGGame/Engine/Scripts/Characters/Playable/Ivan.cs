namespace RPG.Engine.Scripts.Characters.Playable
{
    public class Ivan : Hero
    {
        private const char Symbol = 'I';
        private const int InitialHealth = 100;
        
        public Ivan(int homeRow, int homeColumn) : base(homeRow, homeColumn)
        {
            this.Sprite = Symbol;
        }
    }
}
