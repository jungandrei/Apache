using System;

namespace OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001,8,15,13,45,58,278);

            Console.WriteLine(d.Date);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.DayOfYear);

            string d1 = d.ToLongDateString();
            Console.WriteLine(d1); //Data completa

            string s1 = d.ToString("dd-MM-yyy HH:mm:ss");


            //-----------------------

            DateTime y = d.AddDays(1);

            DateTime d2 = new DateTime(2000,8,4);
            DateTime d3 = new DateTime(2000, 7, 31);

            d2.Subtract(d3);


        }
    }
}
