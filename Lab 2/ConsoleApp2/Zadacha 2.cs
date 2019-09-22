using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Console.Write("Number count: ");
            int r = Convert.ToInt32(Console.ReadLine());

            int[] sum = new int[arr.Length];
            int t;

            for (int j = 1; j <= r; j++)
            {
                t = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = t;
                Console.Write("Rotated[" + j + "]: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    sum[i] += arr[i];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Sum: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}
