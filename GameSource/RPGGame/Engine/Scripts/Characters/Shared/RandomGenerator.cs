namespace RPG.Engine.Scripts.Characters.Shared
{
    using System;
    /// <summary>
    /// A class for the random generator
    /// </summary>
    public static class RandomGenerator
    {
        /// <summary>
        /// random 
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Generates a random percent
        /// </summary>
        /// <returns>a random integer</returns>
        public static double GivePercent()
        {
            double number = random.Next(0, 101);

            return number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public static int GiveInteger(int bottom, int top)
        {
            int number = random.Next(0, 101);
            return number;
        }
    }
}
