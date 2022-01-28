using System;

namespace HomeWork_2
{

    public class GameField
    {
        public int Cols { get; private set; }
        public int Rows { get; private set; }
        public Cell[] Dots { get; set; }

        public GameField(int cols, int rows, Cell[] dots)
        {
            Cols = cols;
            Rows = rows;
            Dots = dots;
        }

        public void Render()
        {
            Console.Clear();

            Cell[][] table = GetFileldsList();

            for (int i = 0; i < table.Length; i++)
            {

                Cell[] row = table[i];
                int length = row.Length - 1;

                for(int j = 0; j <= length; j++)
                {
                    row[j].Render(j == length);
                }

            }
        }

        private Cell[][] GetFileldsList()
        {
            Cell[][] list = new Cell[Rows][];

            for(int i = 0; i < Rows; i++)
            {
                Cell[] sublist = new Cell[Cols];

                for (int j = 0; j < Cols; j++)
                {
                    sublist[j] = new Cell(i, j);
                    sublist[j].IsEmpty = !FindDots(i, j);
                }

                list[i] = sublist;
            }

            return list;
        }

        private bool FindDots(int row, int cell)
        {
            for(int i = 0; i < Dots.Length; i++)
            {
                bool hasRow = Dots[i].X == row;
                bool hasCol = Dots[i].Y == cell;

                if (hasRow && hasCol)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
