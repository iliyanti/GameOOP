namespace Name.Engine.Scripts.Characters.Shared
{
    public struct Coordinate
    {
        public int Row;
        public int Column;

        public int DistanceFromOrigin;

        public Coordinate(int row, int column, int distance)
        {
            this.Column = column;
            this.Row = row;
            this.DistanceFromOrigin = distance;
        }
    }
}
