using System;

namespace Lab1
{
    class Program
    {
        static void Task7()
        {
            Console.WriteLine("Task7");
            Console.WriteLine("Enter first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("result=" + (x * y));
        }
        static void Task13()
        {
            Console.WriteLine("Task13");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("result=" + Math.Pow((x / y), 2));
        }
        static void Task19()
        {
            Console.WriteLine("Task19");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("result=" + Math.Pow((x + y), 3));
        }
        static void Task1()
        {
            Console.WriteLine("Task1");
            Console.WriteLine("Enter first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("result=" + (x + y));
        }
        static void Main(string[] args)
        {
            //int n = 1, k = 6, questionnumber;
            //for (n = 1; n <= 5; ++n)
            //{
            //    questionnumber = (n * k) % 24 + 1;
            //    Console.WriteLine(questionnumber);
            //}
            while (true)
            {
                Console.WriteLine("Numbers of tasks are 1 7 13 19 \n");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Task1();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 13:
                        Task13();
                        break;
                    case 19:
                        Task19();
                        break;
                    default:
                        Console.WriteLine("Incorrect number, try again \n");
                        break;
                }
            }
        }
    }
}

