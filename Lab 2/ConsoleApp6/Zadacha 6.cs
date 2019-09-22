using System;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int msee = 0, n = 0, maxN = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        n++;
                        if (maxN < n)
                        {
                            msee = arr[i];
                            maxN = n;
                        }
                    }
                    else
                    {
                        j = arr.Length;
                    }
                }
                n = 0;
            }
            for (int i = 0; i < maxN + 1; i++)
            {
                Console.Write(msee + " ");
            }
        }
    }
}
