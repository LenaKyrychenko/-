using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            String b;
            String c;
            a = Console.ReadLine();
            b = Console.ReadLine();

            int[,] arr = new int[a.Length, b.Length];

            int newStrLength = 0, m2 = 0;

            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            arr[i, j] = 1;
                        }
                        else
                        {
                            arr[i, j] = arr[i - 1, j - 1] + 1;
                        }
                        if (arr[i, j] > newStrLength)
                        {
                            newStrLength = arr[i, j];
                            m2 = i;
                        }
                    }
                }
            }

            c = a.Substring(m2 + 1 - newStrLength, newStrLength); 
            if (c[0] == ' ')
            {
                c = c.Remove(0, 1); 
            }
            if (c[c.Length - 1] == ' ')
            {
                c = c.Remove(c.Length - 1, 1);
            }
           

            string[] words = c.Split(new char[] { ' ' });

            Console.WriteLine("Result:" + words.Length);
        }
    }
}
