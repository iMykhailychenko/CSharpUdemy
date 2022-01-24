using System;

namespace HomeWork_2
{

    public class PayField
    {
        private string EmptyCell = " . ";
        private string FilledCell = " * ";

        public int Cols { get; private set; }
        public int Rows { get; private set; }

        public PayField(int cols, int rows)
        {
            Cols = cols;
            Rows = rows;
        }

        public void Render(int[][] dots)
        {
            Console.Clear();

            string[][] table = GetFileldsList(dots);

            for (int i = 0; i < table.Length; i++)
            {
                string[] row = table[i];
                int length = row.Length - 1;

                for(int j = 0; j <= length; j++)
                {
                    if(i == length)
                    {
                        Console.WriteLine(row[j]);
                    }
                    else
                    {
                        Console.Write(row[j]);
                    }
                }
            }
        }

        private string[][] GetFileldsList(int[][] dots)
        {
            string[][] list = new string[Rows][];

            for(int i = 0; i < Rows; i++)
            {
                string[] sublist = new string[Cols];

                for(int j = 0; j < Cols; j++)
                {
                    Console.WriteLine(i);
                    bool hasCol = Array.IndexOf(dots[i], i) > -1;
                    bool hasRow = Array.IndexOf(dots[i], j) > -1;

                    if (hasCol && hasRow)
                    {
                        sublist[j] = FilledCell;
                    }
                    else
                    {
                        sublist[j] = EmptyCell;
                    }
                }

                list[i] = sublist;
            }

            return list;
        }
    }
}
