using System;
namespace HomeWork_2
{
    public class Cell
    {
        private string EmptyCell = " ▫ ";
        private string FilledCell = " ▩ ";

        public int X { get; set; }
        public int Y { get; set; }
        public bool IsEmpty { get; set; }

        public Cell(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public void Render(bool isEnd = false)
        {
            Console.Write(IsEmpty ? EmptyCell : FilledCell);

            if (isEnd)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
