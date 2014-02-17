using System;
using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;

namespace RPG.GameSystem
{
    public static class Input
    {
        private const ConsoleKey playerOneUp = ConsoleKey.UpArrow;
        private const ConsoleKey playerOneDown = ConsoleKey.DownArrow;
        private const ConsoleKey playerOneLeft = ConsoleKey.LeftArrow;
        private const ConsoleKey playerOneRight = ConsoleKey.RightArrow;
        private const ConsoleKey playerTwoUp = ConsoleKey.W;
        private const ConsoleKey playerTwoDown = ConsoleKey.S;
        private const ConsoleKey playerTwoLeft = ConsoleKey.A;
        private const ConsoleKey playerTwoRight = ConsoleKey.D;
        public static void GetInput(List<Hero> heroes)
        {
            if (Console.KeyAvailable) //do this only if key is pressed
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == playerOneUp)
                {
                }
                else if (userInput.Key == playerOneDown)
                {
                }
                else if (userInput.Key == playerOneLeft)
                {
                }
                else if (userInput.Key == playerOneRight)
                {
                }
                else if (userInput.Key == playerTwoDown)
                {
                }
                else if (userInput.Key == playerTwoLeft)
                {
                }
                else if (userInput.Key == playerTwoRight)
                {
                }
                else if (userInput.Key == playerTwoUp)
                {
                }
            }

        }

    }
}
