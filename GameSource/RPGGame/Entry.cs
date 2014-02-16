using System;
using System.Windows.Forms;
using RPGGame.Engine;

namespace RPGGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Game game = new Game();
            game.LoadExisitngPlayers();
            game.AskForNumberOfPlayers();
            game.ShowLoginScreen();
        }
    }
}
