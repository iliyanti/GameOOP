namespace RPG.Engine.Scripts.Environment
{
    using System;
    using System.IO;

    /// <summary>
    /// A class for the room
    /// </summary>
    public class Room
    {
        /// <summary>
        /// Max rows for the room.
        /// </summary>
        private const int MaxRows = 50;
        /// <summary>
        /// Max columns for the column.
        /// </summary>
        private const int MaxColumns = 80;

        /// <summary>
        /// Gets the total columns
        /// </summary>
        public int TotalColumns { get; private set; }

        /// <summary>
        /// Gets the total rows
        /// </summary>
        public int TotalRows { get; private set; }

        /// <summary>
        /// Matrix to hold the data for the room
        /// </summary>
        private char[,] Matrix { get; set; }

        /// <summary>
        /// Initializes a new instance of the Room class
        /// </summary>
        public Room()
        {
            this.TotalRows = MaxRows;
            this.TotalColumns = MaxColumns;
            this.Matrix = new char[MaxRows, MaxColumns];
        }

        /// <summary>
        /// Validates the column
        /// </summary>
        /// <param name="column">input a column number</param>
        /// <returns></returns>
        private bool ValidateColumn(int column)
        {
            if (column >= 0 && column < MaxColumns)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Validates the row
        /// </summary>
        /// <param name="row">input a row number</param>
        /// <returns></returns>
        private bool ValidateRow(int row)
        {
            if (row >= 0 && row < MaxRows)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Indexer for the Room class
        /// </summary>
        /// <param name="row">input a row number</param>
        /// <param name="column">input a column number</param>
        /// <returns>value in the cell [row, column]</returns>
        public char this[int row, int column]
        {
            get
            {
                if (this.ValidateColumn(column) && this.ValidateRow(row))
                {
                    return this.Matrix[row, column];
                }
                else if (!this.ValidateColumn(column))
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
                if (this.ValidateColumn(column) && this.ValidateRow(row))
                {
                    this.Matrix[row, column] = value;
                }
                else if (!this.ValidateColumn(column))
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of column");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("There is not such kind of row");
                }
            }
        }

        /// <summary>
        /// Generates the room
        /// </summary>
        /// <param name="file">location of the text file</param>
        public void GenerateRoom(string file)
        {
            var reader = new StreamReader(file);

            using (reader)
            {
                for (int r = 0; r < this.TotalRows; r++)
                {
                    string line = reader.ReadLine();

                    for (int c = 0; c < this.TotalColumns; c++)
                    {
                       this.Matrix[r, c] = line[c];
                    }
                }
            }
        }
    }
}
