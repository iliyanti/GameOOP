namespace RPG.Engine.Graphics
{
    using Scripts.Characters.Shared;
    using Scripts.Environment;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class for the graphical engine. It is responsible for printing objects on the screen.
    /// </summary>
    public static class GraphicalEngine
    {
        private const int MaxWindowHeight = 60;
        private const int MaxWindowWidth = 80;

        /// <summary>
        /// Draws a list of characters
        /// </summary>
        /// <param name="characters">input a list of characters</param>
        public static void DrawCharacters(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.SetCursorPosition(character.LocationColumn, character.LocationRow);
                //Console.Write(character.Sprite.ToString());
                Console.Write(character.Sprite);
               // Console.SetCursorPosition(79,59);
            }
        }

        /// <summary>
        /// Draw an Empty space on the characters' existing position
        /// </summary>
        /// <param name="characters">input a list of characters</param>
        public static void DrawEmpty(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.SetCursorPosition(character.LocationColumn, character.LocationRow);
                Console.Write(' ');
            }
        }

        /// <summary>
        /// Clears the screen
        /// </summary>
        public static void ClearScreen()
        {
            Console.Clear();
        }

        /// <summary>
        /// Draws a room
        /// </summary>
        /// <param name="room">input a room to be printed</param>
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

        /// <summary>
        /// Sets the default values of the widow.
        /// </summary>
        public static void PrepareScreen()
        {
            Console.BufferWidth = Console.WindowWidth = MaxWindowWidth;
            Console.BufferHeight = Console.WindowHeight = MaxWindowHeight;
        }
    }
}
