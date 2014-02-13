using System;
using System.Windows.Forms;
using Name.Engine;

namespace Name
{
    static class Name
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
            
        }
    }
}
