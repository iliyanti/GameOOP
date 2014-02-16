using System;
using System.IO;

namespace RPG.Engine.Scripts.Environment
{
    public class Room
    {
        private const int InitialRows = 50;
        private const int InitialColumns = 80;
        private string[] rooms = { "Data/Graphics/Room1.txt", "Data/Graphics/Room2.txt", "Data/Graphics/Room3.txt" };

        private char[,] matrix;

        public int Columns { get; private set; }

        public int Rows { get; private set; }

        public char[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        public Room()
        {
            this.Rows = InitialRows;
            this.Columns = InitialColumns;
            this.Matrix = new char[InitialRows, InitialColumns];
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

        public void GenerateRoom(string file)
        {
            var reader = new StreamReader(file);

            using (reader)
            {
                for (int r = 0; r < this.Rows; r++)
                {
                    string line = reader.ReadLine();

                    for (int c = 0; c < this.Columns; c++)
                    {
                       this.Matrix[r, c] = line[c];
                    }
                }
            }
        }
    }
}
