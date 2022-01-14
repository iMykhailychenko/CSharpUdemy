using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            Console.WriteLine("Enter fibonacci length");
            int fibonacciLength = MinValueValidate(2);
            Console.Clear();

            int[] fibonacci = new int[fibonacciLength];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for(int i = 0; i < fibonacci.Length - 1; i++)
            {
                if (i != 0)
                    fibonacci[i + 1] = fibonacci[i] + fibonacci[i - 1];

                Console.Write($"{fibonacci[i]} ");
            }

            Console.WriteLine($"{fibonacci[fibonacci.Length - 1]} ");
        }

        static int MinValueValidate(int min)
        {
            int value = 0;
            while(value < min)
            {
                Console.WriteLine($"Min value {min}");
                value = ReadLineAndParse();
            }

            return value;
        }

        static int ReadLineAndParse()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
