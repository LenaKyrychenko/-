using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, n, k; 
            double nDig;

            Console.WriteLine("Enter number:");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter n:");
            n = Convert.ToDouble(Console.ReadLine());

            k = Math.Pow(10, n - 1);

            nDig = ((num / k) % 10);
            nDig = Math.Floor(nDig);

            
                Console.WriteLine("nDigit is  " + nDig);
            
        }
    }
}
