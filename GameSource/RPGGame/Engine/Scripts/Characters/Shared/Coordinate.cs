namespace RPG.Engine.Scripts.Characters.Shared
{
    /// <summary>
    /// A Structure for the Depth First Search Algorithm 
    /// </summary>
    public struct Coordinate
    {
        /// <summary>
        /// Row property
        /// </summary>
        public int Row;

        /// <summary>
        /// Column property
        /// </summary>
        public int Column;

        /// <summary>
        /// Distance from origin
        /// </summary>
        public int DistanceFromOrigin;

        /// <summary>
        /// Initializes a new instance of the Coordinate struct
        /// </summary>
        /// <param name="row">input a row number</param>
        /// <param name="column">input a column number</param>
        /// <param name="distance">current distance from the target</param>
        public Coordinate(int row, int column, int distance)
        {
            this.Column = column;
            this.Row = row;
            this.DistanceFromOrigin = distance;
        }
    }
}
