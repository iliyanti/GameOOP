using System;

namespace RPG.Engine.Scripts.Environment
{
    public class Room
    {
        private const int InitialRows = 80;
        private const int InitialColumns = 80;

        private char[,] matrix;
        private  int row ;
        private  int column;

        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                this.row = value;
            }
        }

        public char[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        public Room()
        {
            this.Matrix = new char[InitialRows,InitialColumns];
        }

        private bool CheckColumn(int column)
        {
            if (column >= 0 && column < InitialColumns)
            {
                return true;
            }

            return false;
        }

        private bool CheckRow(int row)
        {
            if (row >= 0 && row < InitialRows)
            {
                return true;
            }

            return false;
        }

        public char this[int row, int column]
        {
            get
            {
                if (this.CheckColumn(column) && this.CheckRow(row))
                {
                    return this.Matrix[row, column];
                }
                else if (!this.CheckColumn(column))
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of column");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of row");
                }
            }

            set
            {
                if (this.CheckColumn(column) && this.CheckRow(row))
                {
                    this.Matrix[row, column] = value;
                }
                else if (!this.CheckColumn(column))
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of column");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of row");
                }
            }
        }
    }
}
