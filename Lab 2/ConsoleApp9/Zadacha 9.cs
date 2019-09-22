using System;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the letters: ");
            char[] str = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int[] num = Enumerable.Range(0, 28).ToArray();
            char[] letter = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (str[i] == letter[j])
                    {
                        Console.WriteLine(str[i] + " -> " + num[j]);
                    }
                }
            }
        }
    }
}
