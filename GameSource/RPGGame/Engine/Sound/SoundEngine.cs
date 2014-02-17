namespace RPG.Engine.Sound
{
    using GameSystem.ExceptionLogging;
    using Graphics;
    using System;
    using System.Media;

    /// <summary>
    /// A class to handle the the Sound
    /// </summary>
    public static class SoundEngine
    {
        private const string LogMessage = "Failed to load media file!";

        /// <summary>
        /// A method to play a sound
        /// </summary>
        /// <param name="file"></param>
        public static void PlaySound(string file)
        {
            try
            {
                var soundPlayer = new SoundPlayer(file);

                using (soundPlayer)
                {
                    soundPlayer.PlaySync();
                }
            }
            catch (Exception e)
            {
                LoggerEngine.Log(e);
                GraphicalEngine.ClearScreen();
                Console.WriteLine(LogMessage);
                Environment.Exit(0);
            }
        }
    }
}
