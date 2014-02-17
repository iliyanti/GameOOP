using System;
using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;
using RPG.Engine.Scripts.Environment;
using RPG.Engine.Scripts.Interfaces;

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
            this.LootItem = ItemFactory.Create();
        }

        /// <summary>
        /// Loot item that is dropped on the ground
        /// </summary>
        public Item LootItem { get; private set; }


        public void CalcPath(IEnumerable<Hero> heroes, Room room)
        {
            int distance = 0;
            Hero closestHero;
            var edges = new List<Coordinate[,]>();

            foreach (var hero in heroes)
            {
                var data = new Queue<Coordinate>();
                data.Enqueue(new Coordinate(this.LocationRow, this.LocationColumn, 0));

                bool[,] marked = new bool[room.TotalRows, room.TotalColumns];
                marked[1, 1] = true;

                Coordinate[,] edgeTo = new Coordinate[room.TotalRows, room.TotalColumns];

                while (data.Count != 0)
                {
                    Coordinate current = data.Dequeue();

                    if (current.Row  == hero.LocationColumn && current.Column == hero.LocationColumn)
                    {
                        break;
                    }
                    //up
                    if (room[current.Row + 1, current.Column] != 1 && marked[current.Row + 1, current.Column] == false)
                    {
                        Console.WriteLine(current.Row + " " + current.Column);
                        data.Enqueue(new Coordinate(current.Row + 1, current.Column, current.DistanceFromOrigin + 1));
                        marked[current.Row + 1, current.Column] = true;
                        edgeTo[current.Row + 1, current.Column] = new Coordinate(current.Row, current.Column, current.DistanceFromOrigin + 1);
                    }

                    //down
                    if (room[current.Row - 1, current.Column] != 1 && marked[current.Row - 1, current.Column] == false)
                    {
                        data.Enqueue(new Coordinate(current.Row - 1, current.Column, current.DistanceFromOrigin + 1));
                        marked[current.Row - 1, current.Column] = true;
                        edgeTo[current.Row - 1, current.Column] = new Coordinate(current.Row, current.Column, current.DistanceFromOrigin + 1);

                    }

                    //right
                    if (room[current.Row, current.Column + 1] != 1 && marked[current.Row, current.Column + 1] == false)
                    {
                        data.Enqueue(new Coordinate(current.Row, current.Column + 1, current.DistanceFromOrigin + 1));
                        marked[current.Row, current.Column + 1] = true;
                        edgeTo[current.Row, current.Column + 1] = new Coordinate(current.Row, current.Column, current.DistanceFromOrigin + 1);

                    }

                    //left
                    if (room[current.Row, current.Column - 1] != 1 && marked[current.Row, current.Column - 1] == false)
                    {
                        data.Enqueue(new Coordinate(current.Row, current.Column - 1, current.DistanceFromOrigin + 1));
                        marked[current.Row, current.Column - 1] = true;
                        edgeTo[current.Row, current.Column - 1] = new Coordinate(current.Row, current.Column, current.DistanceFromOrigin + 1);
                    }
                }
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

        public override void CheckHealth()
        {
            // TODO Show loot
        }

      
    }
}
