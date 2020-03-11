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
            double x;
            double y;
            bool correct;
            do {
                Console.WriteLine("Enter first number");
                correct = Double.TryParse(Console.ReadLine(), out x);
                if (correct == false) Console.WriteLine("Incorrect number(try again)");
            } while (correct == false);

            do
            {
                Console.WriteLine("Enter second number");
                correct = Double.TryParse(Console.ReadLine(),out y);
                if (correct == false) Console.WriteLine("Incorrect number(try again)");
            } while (correct == false);

            Console.WriteLine("result=" + task(x, y));
            Console.ReadLine();
        }
    }
}
