using System.Collections.Generic;
using RPGGame.Engine.Scripts.Characters.Playable;

namespace RPGGame.Engine.Scripts.Characters.Shared
{
    interface INpcEnemy
    {
        Stack<Direction> Path { get; set; }
        void CalcPath(IEnumerable<Hero> heroes);


    }
}
