using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Name.Engine.Scripts.Characters.Shared
{
    interface IHero
    {
         int NextLevelExperience { get; set; }

        void CheckHealth();
    }
}
