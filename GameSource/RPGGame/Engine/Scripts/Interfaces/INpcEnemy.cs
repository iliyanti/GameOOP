using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;

namespace RPG.Engine.Scripts.Interfaces
{
    interface INpcEnemy
    {
        void CalcPath(IEnumerable<Hero> heroes);
    }
}