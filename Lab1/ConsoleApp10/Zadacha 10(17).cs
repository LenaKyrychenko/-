using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact=1;

            Console.WriteLine("Enter n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
                fact = fact * i;

            Console.WriteLine("Factorial: " + fact);

        }
    }
}
