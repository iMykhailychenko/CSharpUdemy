using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = ReadInt("Enter size: ");
            int rows = cols / 2;

            var activeDots = new Cell[4];
            activeDots[0] = new Cell(3, 4);
            activeDots[1] = new Cell(4, 4);
            activeDots[2] = new Cell(5, 4);
            activeDots[3] = new Cell(5, 3);

            var field = new PayField(cols, rows, activeDots);
            field.Render();
        }

        static private int ReadInt(string dispalayText = "")
        {
            int value = 0;
            bool isParsed = false;


            while(isParsed != true)
            {
                if (dispalayText != "")
                {
                    Console.WriteLine(dispalayText);
                }
                isParsed = int.TryParse(Console.ReadLine(), out value);
            }

            return value;
        }
    }
}
