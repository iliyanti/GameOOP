using System;
using Name.Engine.Scripts.Characters.Player;
using Name.Engine.Scripts.Characters.Shared;

namespace Name.Engine.Scripts.Characters.Enemy
{
    public class Enemy : BaseStats, IMovable
    {
        public void Move(Hero[] heroes)
        {
            foreach (var hero in heroes)
            {
                
            }
        }
    }
}
