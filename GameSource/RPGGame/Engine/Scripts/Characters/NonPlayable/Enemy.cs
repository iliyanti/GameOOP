using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.Engine.Scripts.Characters.NonPlayable
{
    public class Enemy : Character, INpcEnemy
    {
        /// <summary>
        /// Initializes a new instance of the Enemy class.
        /// </summary>
        /// <param name="homeRow"></param>
        /// <param name="homeColumn"></param>
        protected Enemy(int homeRow, int homeColumn)
            : base(homeRow, homeColumn)
        {
        }

        public ~Enemy()
        {

        }

        public void CalcPath(IEnumerable<Hero> heroes)
        {
            int distance = 0;
            Hero closestHero;
            var edges = new List<Coordinate[,]>();

            foreach (var hero in heroes)
            {
                Queue<Coordinate> data = new Queue<Coordinate>();
                data.Enqueue(new Coordinate(this.LocationRow, this.LocationColumn, 0));



            }
        }




        public override void Move()
        {
            if (this.Path.Count != 0)
            {
                if (this.Path.Peek() == Direction.Up)
                {
                    this.LocationRow++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Right)
                {
                    this.LocationColumn++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Down)
                {
                    this.LocationRow--;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Left)
                {
                    this.LocationColumn--;
                    this.Path.Pop();
                }
            }
        }

        public override void CheckHealth()
        {
            throw new System.NotImplementedException();
        }
    }
}
