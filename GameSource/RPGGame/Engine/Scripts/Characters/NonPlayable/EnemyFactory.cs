using RPG.Engine.Scripts.Characters.Shared;
using RPG.Engine.Scripts.Environment;

namespace RPG.Engine.Scripts.Characters.NonPlayable
{
    public static  class EnemyFactory
    {
        public static Enemy Create(Room room)
        {
            Coordinate coordinate = room.Empty[RandomGenerator.GiveInteger(0, room.Empty.Count)];
            Enemy enemy = new AnimalDog(coordinate.Row, coordinate.Column);

            return enemy;
        }
    }
}
