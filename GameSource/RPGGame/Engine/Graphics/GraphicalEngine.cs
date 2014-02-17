using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Shared;
using RPG.Engine.Scripts.Environment;

namespace RPG.Engine.Graphics
{
    public static class GraphicalEngine
    {
        public static void Draw(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.SetCursorPosition(character.LocationColumn, character.LocationRow);
                Console.Write(character.Sprite);
            }
           
        }

        public static void DrawEmpty(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.SetCursorPosition(character.LocationColumn, character.LocationRow);
                Console.Write(" ");
            }
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void DrawRoom(Room room)
        {
            for (int row = 0; row < room.TotalRows; row++)
            {
                for (int column = 0; column < room.TotalColumns; column++)
                {
                    Console.Write(room[row,column]);
                }
            }

            Console.WriteLine();
        }


        public static void PrepareScreen()
        {
            Console.BufferWidth = Console.WindowWidth = 80;
            Console.BufferHeight = Console.WindowHeight = 60;
        }
    }
}
