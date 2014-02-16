using System;
using RPG.Engine.Graphics;
using RPGGame.Engine;

namespace RPG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            GraphicalEngine.PrepareScreen();
            Game game = new Game();

            game.GenerateRooms();
            game.Play();
          


        }
    }
}
