using System;

namespace Zavd_2
{
    class Box
    {
        public double l { get; set; }
        public double w { get; set; }
        public double h { get; set; }

        public Box(double L, double W, double H)
        {
            if (L <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative");
                Environment.Exit(0);
            }
            else
            {
                l = L;
            }

            if (W <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative");
                Environment.Exit(0);
            }
            else
            {
                w = W;
            }

            if (H <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative");
                Environment.Exit(0);
            }
            else
            {
                h = H;
            }

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double l, w, h, sa, lsa, v;

            Console.Write("Length: ");
            l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            w = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            h = Convert.ToDouble(Console.ReadLine());

            Box b = new Box(l, w, h);

           
            sa = (2 * b.l * b.w) + (2 * b.l * b.h) + (2 * b.w * b.h);
            Console.WriteLine("Surface Area - " + sa);

            lsa = (2 * b.l * b.h) + (2 * b.w * b.h);
            Console.WriteLine("Lateral Surface Area - " + lsa);

            v = b.l * b.w * b.h;
            Console.WriteLine("Volume - " + v);
        }
    }
}
