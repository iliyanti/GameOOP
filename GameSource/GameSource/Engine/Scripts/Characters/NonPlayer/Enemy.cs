using System;
using System.Collections.Generic;
using Name.Engine.Scripts.Characters.Player;
using Name.Engine.Scripts.Characters.Shared;

namespace Name.Engine.Scripts.Characters.NonPlayer
{
    public class Enemy : BaseStats, IMovable, INpcEnemy
    {
        public Stack<Direction> Path { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void FindPath(Hero[] heroes)
        {
            int distance = 0;
            Hero closestHero;

            foreach (var hero in heroes)
            {
                Queue<Coordinate> data = new Queue<Coordinate>();

              //  data.Enqueue(new Coordinate(this.E));


            }



        }
    }
}
