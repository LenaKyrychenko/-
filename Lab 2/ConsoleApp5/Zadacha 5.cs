using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array1: ");
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            Console.Write("Enter array2: ");
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int n;

            if (arr1.Length < arr2.Length)
            {
                n = arr1.Length;
            }
            else if (arr2.Length < arr1.Length)
            {
                n = arr2.Length;
            }
            else
            {
                n = arr1.Length;
            }


            for (int i = 0; i < n; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    break;
                }
                if (arr2[i] > arr1[i])
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    break;
                }
                if (i == n - 1 && arr1[i] == arr2[i])
                {
                    if (arr1.Length < arr2.Length)
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                        }
                        Console.WriteLine();
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        break;
                    }
                    if (arr2.Length < arr1.Length)
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        Console.WriteLine();
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                        }
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr1[j]);
                        }
                        Console.WriteLine();
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        break;
                    }
                }
            }
        }
    }
}
