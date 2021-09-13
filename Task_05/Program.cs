using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения катетов, каждое с новой строки:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение гипотенузы: " + Math.Sqrt(x*x + y*y));
        }
    }
}
