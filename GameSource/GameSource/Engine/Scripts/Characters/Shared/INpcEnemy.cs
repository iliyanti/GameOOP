using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Name.Engine.Scripts.Characters.Player;

namespace Name.Engine.Scripts.Characters.Shared
{
    interface INpcEnemy
    {
        void FindPath(Hero[] heroes);

    }
}
