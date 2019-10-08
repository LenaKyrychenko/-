using System;

namespace Lab_3
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Pesho.Name = "Pesho";
            Pesho.Age = 18;

            Person Gosho = new Person();
            Gosho.Name = "Gosho";
            Gosho.Age = 26;

            Person Stamat = new Person();
            Stamat.Name = "Stamat";
            Stamat.Age = 15;

            Console.WriteLine(Pesho.Name +" "+ Pesho.Age);
            Console.WriteLine(Gosho.Name + " " + Gosho.Age);
            Console.WriteLine(Stamat.Name + " " + Stamat.Age);



        }
    }
}
