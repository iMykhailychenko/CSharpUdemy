using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = ReadInt("Enter size: ");
            int rows = cols / 2;

            var controller = new Controller(100, cols, rows);
            controller.StartGame();

            Console.ReadLine();
            controller.StopGame();
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
