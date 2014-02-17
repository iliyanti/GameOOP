using System;
using RPG.Engine.Graphics;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;
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
          //  game.Play();
          
            Item item = ItemFactory.CreateItem();

            Console.WriteLine(item);
            Character hero = new Ivan(6,6);

            
        }
    }
}
