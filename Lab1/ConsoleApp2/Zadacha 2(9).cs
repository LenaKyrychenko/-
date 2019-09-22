using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, S;

            Console.WriteLine("Enter first side: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the hide: ");
            h = Convert.ToDouble(Console.ReadLine());

            S = Convert.ToDouble(((a + b) / 2) * h);

            Console.WriteLine("Area:" + S);
        }
    }
}
