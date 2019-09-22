using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
                Console.WriteLine("Max: " + a);

            if ((b > a) && (b > c))
                Console.WriteLine("Max: " + b);

            if ((c > a) && (c > b))
                Console.WriteLine("Max: " + c);
        }
    }
}
