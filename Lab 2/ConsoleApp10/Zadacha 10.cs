using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == n)
                    {
                        r++;
                    }
                }
            }
            Console.WriteLine("Pairs by Difference: " + r);
        }
    }
}
