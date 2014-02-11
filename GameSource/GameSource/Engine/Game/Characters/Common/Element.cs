namespace Name.Characters.Common
{
    public struct Element
    {
        public int Row;
        public int Column;
        public string Symbol;

        public Element(int row, int column, string symbol)
        {
            this.Row = row;
            this.Column = column;
            this.Symbol = symbol;
        }
    }
}
