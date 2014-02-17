using System;
using System.Collections.Generic;
using RPG.Engine.Graphics;
using RPG.Engine.Scripts.Characters.NonPlayable;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Environment;

namespace RPG.Tests
{
    public static class TestPathFinding
    {
        public static void Main()
        {
            Room room = RoomFactory.Create();

            Hero hero1 = HeroFactory.Create(room);
            Hero hero2 = HeroFactory.Create(room);
            Enemy enemy = EnemyFactory.Create(room);

            List<Hero> heroes = new List<Hero>();
            heroes.Add(hero1);
            heroes.Add(hero2);
            //GraphicalEngine.PrepareScreen();
            Console.WriteLine(room[hero1.LocationRow, hero1.LocationColumn] + " " + hero1.LocationRow + " " + hero1.LocationColumn);
            Console.WriteLine(room[hero2.LocationRow, hero2.LocationColumn] + " " + hero2.LocationRow + " " + hero2.LocationColumn);
            Console.WriteLine(room[enemy.LocationRow, enemy.LocationColumn] + " " + enemy.LocationRow + " " + enemy.LocationColumn);

            //  Console.WriteLine(room[enemy.LocationRow, enemy.LocationColumn]);
            // for (int row = 0; row < room.TotalRows; row++)
            // {
            //     for (int column = 0; column < room.TotalColumns; column++)
            //     {
            //         Console.Write(room[row,column]);
            //     }
            // }

            enemy.CalcPath(heroes, room);
        }
    }
}
