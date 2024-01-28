using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            double a, b, c;

            Console.WriteLine("Введите длину первой стороны треугольника:");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника:");

            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны треугольника:");

            c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 

            Console.WriteLine("Площадь треугольника: {0:f2}",+ area );
        }
    }
}
