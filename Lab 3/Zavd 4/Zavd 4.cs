using System;

namespace Zavd_4
{
    class Person : IComparable<Person>
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string n, int m) { Name = n; Age = m; }

        public int CompareTo(Person p)
        {
            return Name.CompareTo(p.Name);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string n;
            int m,N;
            Console.WriteLine("N=");
            N = Convert.ToInt32(Console.ReadLine());

            Person[] a = new Person[N];
            

            for (int i = 0; i < N; i++)
            {
                n = Console.ReadLine();
                m = Convert.ToInt32(Console.ReadLine());
                a[i] = new Person(n,m);
            }

            Array.Sort(a);

            foreach(Person p in a)
            {
               if(p.Age>30)
                {
                    Console.WriteLine("{0}  {1}", p.Name, p.Age);
                }
            }
                    
                

        }
    }
}
