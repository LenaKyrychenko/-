using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, ld;

            Console.WriteLine("Enter number:");
            n = Convert.ToDouble(Console.ReadLine());

            ld = Convert.ToDouble(n % 10);

            Console.WriteLine("Last Digit is " + ld);
        }
    }
}
