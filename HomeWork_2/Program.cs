using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadInt("Enter size: ");
            PayField field = new PayField(size, size / 2);

            int[][] activePoints = new int[4][];
            activePoints[0] = new int[] { 3, 4 };
            activePoints[1] = new int[] { 4, 4 };
            activePoints[2] = new int[] { 5, 4 };
            activePoints[3] = new int[] { 5, 3 };

            field.Render(activePoints);
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
