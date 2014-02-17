using System;
using System.Collections.Generic;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;

namespace RPG.GameSystem.Controls
{
    public static class Input
    {
        private const ConsoleKey PlayerOneUp = ConsoleKey.UpArrow;
        private const ConsoleKey PlayerOneDown = ConsoleKey.DownArrow;
        private const ConsoleKey PlayerOneLeft = ConsoleKey.LeftArrow;
        private const ConsoleKey PlayerOneRight = ConsoleKey.RightArrow;
        private const ConsoleKey PlayerTwoUp = ConsoleKey.W;
        private const ConsoleKey PlayerTwoDown = ConsoleKey.S;
        private const ConsoleKey PlayerTwoLeft = ConsoleKey.A;
        private const ConsoleKey PlayerTwoRight = ConsoleKey.D;

        public static void GetInput(List<Hero> heroes)
        {
            if (Console.KeyAvailable) //do this only if key is pressed
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == PlayerOneUp)
                {
                    heroes[0].AddToPath(Direction.Up);
                }
                else if (userInput.Key == PlayerOneDown)
                {
                    heroes[0].AddToPath(Direction.Down);
                }
                else if (userInput.Key == PlayerOneLeft)
                {
                    heroes[0].AddToPath(Direction.Left);
                }
                else if (userInput.Key == PlayerOneRight)
                {
                    heroes[0].AddToPath(Direction.Right);
                }
                else if (userInput.Key == PlayerTwoDown && heroes.Count == 2)
                {
                    heroes[1].AddToPath(Direction.Down);
                }
                else if (userInput.Key == PlayerTwoLeft && heroes.Count == 2)
                {
                    heroes[1].AddToPath(Direction.Left);
                }
                else if (userInput.Key == PlayerTwoRight && heroes.Count == 2)
                {
                    heroes[1].AddToPath(Direction.Right);
                }
                else if (userInput.Key == PlayerTwoUp && heroes.Count == 2)
                {
                    heroes[1].AddToPath(Direction.Up);
                }
            }
        }
    }
}
