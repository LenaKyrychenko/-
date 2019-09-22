using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool result;

            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            if((n%9==0)||(n%11==0)||(n%13==0))
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
