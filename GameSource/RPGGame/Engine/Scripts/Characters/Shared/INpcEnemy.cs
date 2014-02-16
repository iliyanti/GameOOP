using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;

namespace RPG.Engine.Scripts.Characters.Shared
{
    interface INpcEnemy
    {
        Stack<Direction> Path { get; set; }
        void CalcPath(IEnumerable<Hero> heroes);


    }
}
