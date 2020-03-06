using System;

namespace Lab1
{
    class Program
    {
        static double task(double x, double y)
        {
            double razn = x - y;
            return razn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("result=" + task(x,y));
            Console.ReadLine();
        }
    }
}
