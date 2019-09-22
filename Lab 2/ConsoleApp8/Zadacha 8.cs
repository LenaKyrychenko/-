using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int mfn = 0, n = 0, maxN = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        n++;
                        if (maxN < n)
                        {
                            mfn = arr[i];
                            maxN = n;
                        }
                    }
                }
                n = 0;
            }
            Console.WriteLine("The Number "+ mfn+ " Is Most Frequent Number");
        }
    }
}
