using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение напряжения U: ");
            double U = double.Parse(Console.ReadLine());
            Console.Write("Введите значение сщпротивления R: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Сила тока I = U/R = " + (U / R) + ", потребляемая мощность P = U^2/R = " + (U * U / R));
        }
    }
}
