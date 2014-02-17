namespace RPG.GameSystem.CustomExceptions
{
    using System;

    /// <summary>
    /// Exception for invalid number of players
    /// </summary>
    public class InvalidNumberOfPlayers : Exception
    {
        private const string text = "Value for players is incorrect.";
        public InvalidNumberOfPlayers() :
            base(text)
        {
        }
    }
}
