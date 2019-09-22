using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,ser;

            Console.WriteLine("Enter first number: ");
            a= Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b =Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            ser =Convert.ToDouble((a + b + c) / 3);

            Console.WriteLine("Ser=" + ser);
            
        }
    }
}
