﻿namespace GameLoop
{
    using System;

    public struct GameTime
    {
        public GameTime(TimeSpan elapsedTime, TimeSpan totalTime)
            : this()
        {
            this.ElapsedTime = elapsedTime;
            this.TotalTime = totalTime;
        }

        /// <summary>
        /// The amount of elapsed game time since the last update.
        /// </summary>
        public TimeSpan ElapsedTime { get; private set; }


        /// <summary>
        /// The amount of game time since the start of the game.
        /// </summary>
        public TimeSpan TotalTime  { get; private set; }
    }
}