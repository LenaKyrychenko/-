using System;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum1 = 0, sum2 = 0;
            int index = 0;
            bool b = false;

            for (int i = 0; i < arr.Length; i++)
            {
                sum1 = 0;
                sum2 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += arr[j];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum2 += arr[j];
                }
                if (sum1 == sum2)
                {
                    index = i;
                    b = true;
                    break;
                }
            }

            if (b == true)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
