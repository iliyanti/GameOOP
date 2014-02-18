namespace RPG.Engine.Scripts.Characters.NonPlayable
{
    using System;
    using System.Collections.Generic;
    using Items;
    using Playable;
    using Shared;
    using Environment;
    using Interfaces;

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
            this.LootItem = ItemFactory.Create();
        }

        /// <summary>
        /// Gets the experience that the enemy awards
        /// </summary>
        public int Experience { get; private set; }

        /// <summary>
        /// Loot item that is dropped on the ground
        /// </summary>
        public Item LootItem { get; private set; }


        public void CalcPath(IEnumerable<Hero> heroes, Room room)
        {
            int distance = 0;
            Hero closestHero;

            foreach (var hero in heroes)
            {
                var data = new Queue<Coordinate>();
                data.Enqueue(new Coordinate(this.LocationRow, this.LocationColumn, 0));
            }
        }

        public override void Move()
        {
            if (this.Path.Count != 0)
            {
                if (this.Path.Peek() == Direction.Up)
                {
                    this.LocationRow--;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Right)
                {
                    this.LocationColumn++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Down)
                {
                    this.LocationRow++;
                    this.Path.Pop();
                }
                else if (this.Path.Peek() == Direction.Left)
                {
                    this.LocationColumn--;
                    this.Path.Pop();
                }
            }
        }

       
    }
}
