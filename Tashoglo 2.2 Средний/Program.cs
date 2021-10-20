using System;

namespace Tashoglo_2._2_Средний
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = double.Parse(Console.ReadLine());
            if (a == b || b == c || a == c) Console.WriteLine("Имеется");
            else Console.WriteLine("Не имеется");
        }
    }
}
