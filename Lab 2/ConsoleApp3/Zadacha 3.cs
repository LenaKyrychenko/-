using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arrS = new int[arr.Length / 2];
            int[] arrZ = new int[arr.Length / 2];
            int[] Sum = new int[arr.Length / 2];
            int[] a1 = new int[arr.Length / 4];
            int[] a2 = new int[arr.Length / 4];

            Array.Copy(arr, 0, a1, 0, arr.Length / 4);
            Array.Copy(arr, arr.Length - arr.Length / 4, a2, 0, arr.Length / 4);

            Array.Reverse(a1);
            Array.Reverse(a2);

            Array.Copy(a1, 0, arrZ, 0, arr.Length / 4);
            Array.Copy(a2, 0, arrZ, arr.Length / 4, arr.Length / 4);

            Array.Copy(arr, arr.Length / 4, arrS, 0, arr.Length / 2);

            Console.Write("Sum: ");
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Sum[i] = arrS[i] + arrZ[i];
                Console.Write(Sum[i] + " ");
            }
        }
    }
}
