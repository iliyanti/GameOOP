using System;
using System.Collections.Generic;
using RPG.Engine;
using RPG.Engine.Graphics;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.NonPlayable;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;

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
            game.AskForNumberOfPlayers();
            game.GenerateHeroes();
            game.Play();

            //Item item = ItemFactory.Create();
            //
            //Console.WriteLine(item);
            //Character hero = new Ivan(6, 6);
            //
            //Character fd = new AnimalDog(6, 6);
            //
            //List<Character> data = new List<Character>();
            //
            //data.Add(fd);
        }
    }
}
