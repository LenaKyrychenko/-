using System;

namespace Zavd_2
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Person() { name = "No name"; age = 1; }
        public Person(int n) { name = "No name"; age = n; }
        public Person(string m,int n) { name = m; age = n; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            Console.WriteLine(a.Name + " " + a.Age);

            Person b = new Person(8);
            Console.WriteLine(b.Name + " " + b.Age);

            Person c = new Person("Petya",18);
            Console.WriteLine(c.Name + " " + c.Age);
        }
    }
}
