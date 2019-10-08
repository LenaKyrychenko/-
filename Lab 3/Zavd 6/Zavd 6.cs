using System;

namespace Zavd_6
{
    class Person
    {
        public string name { get; set; }
        public double zarplata { get; set; }
        public string posada { get; set; }
        public string viddil { get; set; }
        public string posht { get; set; }
        public string vik { get; set; }

        public Person(string n, double zarpl, string posd, string vidd, string psht, string vk)
        {
            name = n;
            zarplata = zarpl;
            posada = posd;
            viddil = vidd;
            if (psht == "")
                posht = "n/a";
            else
                posht = psht;
            if (vk == "")
                vik = "-1";
            else
                vik = psht;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість робітників: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Zarplata: ");
                double zarplata = Convert.ToDouble(Console.ReadLine());

                Console.Write("Posada: ");
                string posada = Console.ReadLine();

                Console.Write("Viddil: ");
                string viddil = Console.ReadLine();

                Console.Write("Email: ");
                string posht = Console.ReadLine();

                Console.Write("Vik: ");
                string vik = Console.ReadLine();

                people[i] = new Person(name, zarplata, posada, viddil, posht, vik);
            }

            string vid, topvid = people[0].viddil;
            int k = 0;
            double rez = 0, sal = 0, max = 0;

            for (int i = 0; i < n; i++)
            {
                if (rez > max)
                {
                    max = rez;
                    topvid = people[i - 1].viddil;
                }
                sal = 0;
                k = 0;
                vid = people[i].viddil;
                for (int j = 0; j < n; j++)
                {
                    if (people[j].viddil == vid)
                    {
                        k++;
                        sal += people[j].zarplata;
                        rez = sal / k;
                    }
                }
            }
            Console.WriteLine("Highest Average salary: " + topvid);

            foreach (Person p in people)
            {
                if (p.viddil == topvid)
                {
                    Console.WriteLine(p.name + " " + Math.Round(p.zarplata, 2) + " " + p.posht + " " + p.vik);
                }
            }

        }
    }
}
