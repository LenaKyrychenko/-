using System;

namespace Zavd_5
{
    class DateModifier
    {
        private string date1;
        private string date2;

        public string Date1
        {
            get
            {
                return date1;
            }
            set
            {
                date1 = value;
            }
        }
        public string Date2
        {
            get
            {
                return date2;
            }
            set
            {
                date2 = value;
            }
        }

        public void DRiz(DateTime n, DateTime m)
        {
            double ch;
          
            ch=(n.Subtract(m)).TotalDays;

            if(ch<0)
            {
                ch = ch * (-1);
            }
            Console.WriteLine(ch);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            DateModifier a = new DateModifier();
            a.Date1 = Console.ReadLine();
            DateTime d1 = new DateTime();
            d1 = Convert.ToDateTime(a.Date1);
            /*Console.WriteLine(d1);*/

            DateModifier b = new DateModifier();
            b.Date2 = Console.ReadLine();
            DateTime d2 = new DateTime();
            d2 = Convert.ToDateTime(b.Date2);
            /*Console.WriteLine(d2);*/
            
            a.DRiz(d1, d2);
            
            
        }
    }
}
