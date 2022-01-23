using System;
using System.Collections.Generic;

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

        public void Render(Dictionary<int, int> dots)
        {
            Console.Clear();

            List<string[]> table = GetFileldsList(dots);

            foreach (string[] row in table)
            {
                int length = row.Length;
                for(int i = 0; i < length; i++)
                {
                    if(i == length - 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private List<string[]> GetFileldsList(Dictionary<int, int> dots)
        {
            var value = new List<string[]>(Cols);
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    bool hasCol = dots.TryGetValue(i, out int dotsRow);

                    if (hasCol && dotsRow == j)
                    {
                        value[i][j] = FilledCell;
                    }
                    else
                    {
                        value[i][j] = EmptyCell;
                    }
                }
            }

            return value;
        }
    }
}
