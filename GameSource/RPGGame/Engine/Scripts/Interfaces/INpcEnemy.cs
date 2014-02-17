using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Environment;

namespace RPG.Engine.Scripts.Interfaces
{
    interface INpcEnemy
    {
        void CalcPath(IEnumerable<Hero> heroes, Room room);
    }
}