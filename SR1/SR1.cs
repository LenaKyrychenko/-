using System;

namespace SR1
{ 
        class Computer
    {
        public SystemBlock SB { get; set; }
        public Monitor MON { get; set; }
        public Clava CL { get; set; }
        public Mice MICE { get; set; }
        public Computer(SystemBlock s, Monitor m, Clava c, Mice mi)
        {
            SB = s;
            MON = m;
            CL = c;
            MICE = mi;
        }

        public class SystemBlock 
        {
            public string Vyd { get; set; }
            public string Cdpr { get; set; }
            public int Taktch { get; set; }
            public int Obsyag { get; set; }
            public int Zina { get; set; }

            public SystemBlock(string v, int t, int o, string cd, int z) { Vyd = v; Taktch = t; Obsyag = o; Cdpr = cd; Zina = z; }
        }

        public class Monitor
        {
            public int Diag { get; set; }
            public int Rozd { get; set; }
            public int Zina { get; set; }

            public Monitor(int d, int r, int z) { Diag = d; Rozd = r; Zina = z; }
        }

        public class Clava
        {
            public string Vyd { get; set; }
            public int Clav { get; set; }
            public int Zina { get; set; }

            public Clava(string v, int c, int z) { Vyd = v; Clav = c; Zina = z; }
        }

        public class Mice
        {
            public string Vyd { get; set; }
            public int Cnop { get; set; }
            public int Zina { get; set; }

            public Mice(string v, int c, int z) { Vyd = v; Cnop = c; Zina = z; }
        }

        public int price(int z1, int z2, int z3, int z4)
        {
            return z1 + z2 + z3 + z4;
        }

    }

   

    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            Computer[] comp = new Computer[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Computer number {i+1}");
                Console.WriteLine("SystBlock:");
                Console.Write("Vyd: ");
                string vb = Console.ReadLine();
                Console.Write("Taktova chastota: ");
                int t = Convert.ToInt32(Console.ReadLine());
                Console.Write("Obsyag vinchestera: ");
                int o = Convert.ToInt32(Console.ReadLine());
                Console.Write("CD-pruvid: ");
                string cd = Console.ReadLine();
                Console.Write("Zina: ");
                int zb = Convert.ToInt32(Console.ReadLine());
                Computer.SystemBlock sb = new Computer.SystemBlock(vb, t, o, cd, zb);

                Console.WriteLine("Monitor:");
                Console.Write("Diagonal`: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("Rozdilna zdatnist`: ");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zina: ");
                int zmon = Convert.ToInt32(Console.ReadLine());
                Computer.Monitor mon = new Computer.Monitor(d, r, zmon);

                Console.WriteLine("Clava:");
                Console.Write("Vyd: ");
                string vcl = Console.ReadLine();
                Console.Write("K-t` klavish: ");
                int clav = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zina: ");
                int zcl = Convert.ToInt32(Console.ReadLine());
                Computer.Clava cl = new Computer.Clava(vcl, clav, zcl);

                Console.WriteLine("Mice:");
                Console.Write("Vyd: ");
                string vm = Console.ReadLine();
                Console.Write("K-t` cnopok: ");
                int cnop = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zina: ");
                int zmice = Convert.ToInt32(Console.ReadLine());
                Computer.Mice mice = new Computer.Mice(vm, cnop, zmice);

                comp[i] = new Computer(sb,mon,cl,mice);
            }

            for (int i = 0; i < N; i++)
                Console.WriteLine($"Zina {i+1} comp= " + comp[i].price(comp[i].SB.Zina, comp[i].MON.Zina,comp[i].CL.Zina,comp[i].MICE.Zina));


        }
    }
}
