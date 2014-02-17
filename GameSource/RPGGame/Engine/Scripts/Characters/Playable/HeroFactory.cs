using RPG.Engine.Scripts.Characters.Shared;
using RPG.Engine.Scripts.Environment;

namespace RPG.Engine.Scripts.Characters.Playable
{
    public static class HeroFactory
    {
        public static Hero Create(Room room)
        {
            Coordinate coordinate = room.Empty[RandomGenerator.GiveInteger(0, room.Empty.Count)];

            Hero hero = new Ivan(coordinate.Row, coordinate.Column);

            return hero;
        }
    }
}
