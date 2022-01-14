using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstHomeWork();
            //SecondHomeWork();
            ThirdHomeWork();
        }

        static void ThirdHomeWork()
        {
            // Запросить у пользователя: фамилию, имя, возраст, вес, рост.

            // Высчитать ИМТ(индекс массы тела) по формуле ИМТ = вес(кг) / (рост(м) * рост(м))

            // Сформировать единую строку, в следующем формате:

            // Your profile:
            // Full Name: фамилия, имя
            // Age: возраст
            // Weight: вес
            // Height: рост
            // Body Mass Index: ИМТ

            // Вывести сформированную строку на консоль.


            Console.Write("фамилия - ");
            string surname = Console.ReadLine();

            Console.Write("имя - ");
            string name = Console.ReadLine();

            Console.Write("возраст - ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("вес - ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("рост - ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / height * height;

            Console.WriteLine(
                $"Your profile:" +
                $"{Environment.NewLine}Full Name: {surname}, {name}" +
                $"{Environment.NewLine}Age: {age}" +
                $"{Environment.NewLine}Weight: {weight}" +
                $"{Environment.NewLine}Height: {height}" +
                $"{Environment.NewLine}Body Mass Index: {bmi}");
        }

        static void SecondHomeWork()
        {
            Console.WriteLine("Enter first length");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second length");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second length");
            double c = double.Parse(Console.ReadLine());

            double p = a * b * c;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"{square:f2}");            
        }

        static void FirstHomeWork()
        {
            //1.Запросить имя пользователя. Вывести Hello, [имя пользователя].
            Console.Write("Enter your name: ");
            Console.WriteLine($"Hello, {Console.ReadLine()}");

            //2.Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
            //Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5.Вывести значения после обмена.
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter secont number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"first: {number1}, second: {number2}");
            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"After switch, first: {number1}, second: {number2}");

            //3.Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.
            Console.WriteLine("Enter long number: ");
            string longNumber = Console.ReadLine();
            Console.WriteLine($"в числе {longNumber} - {longNumber.Length} цифры");
        }
    }
}
