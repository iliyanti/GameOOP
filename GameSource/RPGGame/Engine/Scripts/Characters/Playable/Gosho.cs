namespace RPG.Engine.Scripts.Characters.Playable
{
    public class Gosho : Hero
    {
        private const char Symbol = 'G';
        public Gosho(int homeRow, int homeColumn) : base(homeRow, homeColumn)
        {
            this.Sprite = Symbol;
        }
    }
}
