using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool result;

            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            if ((n > 20) && (n % 2 == 1))
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }
        }
    }
}
