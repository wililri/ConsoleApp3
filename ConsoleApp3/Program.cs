using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y");

            double y = Convert.ToDouble(Console.ReadLine());

            double r = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);

            Console.WriteLine("Результат = {0:f2}",r);
        }
    }
}
