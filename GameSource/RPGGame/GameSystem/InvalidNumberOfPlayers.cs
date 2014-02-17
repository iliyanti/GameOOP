using System;

namespace RPG.GameSystem
{
    public class InvalidNumberOfPlayers : Exception
    {
        private const string text = "Value for players is incorrect.";
        public InvalidNumberOfPlayers() :
            base(text)
        {
            // do somethingS
            // log to a file
        }
    }
}
