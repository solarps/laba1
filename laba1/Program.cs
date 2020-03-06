using System;

namespace Lab1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("result=" + (x - y));
        }
    }
}
