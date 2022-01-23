using System;
using System.Collections.Generic;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadInt("Enter size: ");
            PayField field = new PayField(size, size / 2);

            Dictionary<int, int> activePoints = new Dictionary<int, int>() { { 1, 1 } };
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
