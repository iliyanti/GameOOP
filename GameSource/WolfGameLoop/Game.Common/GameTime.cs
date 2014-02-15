namespace GameLoop
{
    using System;
    using System.Diagnostics;

    public class GameTime
    {
        private Stopwatch stopwatch;
        private TimeSpan previousElapsedTime;

        public GameTime()
        {
            stopwatch = Stopwatch.StartNew();
            previousElapsedTime = TimeSpan.Zero;
        }

        /// <summary>
        /// The amount of elapsed game time since the last update.
        /// </summary>
        public TimeSpan ElapsedTime
        {
            get
            {
                TimeSpan time = stopwatch.Elapsed;
                TimeSpan elapsedTime = time - previousElapsedTime;
                previousElapsedTime = time;
                return elapsedTime;
            }
        }

        /// <summary>
        /// The amount of game time since the start of the game.
        /// </summary>
        public TimeSpan TotalTime
        {
            get
            {
                return stopwatch.Elapsed;
            }
        }
    }
}