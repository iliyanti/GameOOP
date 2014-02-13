using System;
using System.Collections.Generic;
using Name.Engine.Scripts.Characters.Player;

namespace Name.Engine.Scripts.Characters.Shared
{
    interface INpcEnemy
    {
        Stack<Direction> Path { get; set; }
        void CalcPath(IEnumerable<Hero> heroes);


    }
}
