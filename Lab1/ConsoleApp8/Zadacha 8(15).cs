using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool product=true;

            Console.WriteLine("Enter a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c:");
            c = Convert.ToDouble(Console.ReadLine());

            if (((a < 0) && (b > 0) && (c > 0)) || ((a > 0) && (b < 0) && (c > 0)) || ((a > 0) && (b > 0) && (c < 0)))
                product = false;
            if ((a < 0) && (b < 0) && (c < 0))
                product = false;
            if ((a > 0) && (b > 0) && (c > 0))
                product = true;
            if (((a < 0) && (b < 0) && (c > 0)) || ((a > 0) && (b < 0) && (c < 0)) || ((a < 0) && (b > 0) && (c < 0)))
                product = true;

            if (product == true)
                Console.WriteLine("Product is POSITIVE");
            if (product == false)
                Console.WriteLine("Product is NEGATIVE");
        }
    }
}
