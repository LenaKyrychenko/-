using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            n--;
            int[] arr = Enumerable.Range(2, n).ToArray();
            int i, j;

            for (j = 2; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    if (arr[i] != j && arr[i] % j == 0)
                    {
                        arr[i] = 0;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
