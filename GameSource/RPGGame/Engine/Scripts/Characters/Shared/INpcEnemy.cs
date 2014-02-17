using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;

namespace RPG.Engine.Scripts.Characters.Shared
{
    interface INpcEnemy
    {
      
        void CalcPath(IEnumerable<Hero> heroes);


    }
}