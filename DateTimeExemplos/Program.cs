using System;
using System.Globalization;

namespace DateTimeExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horario Atual
            DateTime d1 = DateTime.Now;

            //Data Hoje
            DateTime d2 = DateTime.Today;

            //Horario de agora só que no GMT
            DateTime d3 = DateTime.UtcNow;


            //----------------PARSEaaa---------------

            DateTime d4 = DateTime.Parse("2000-08-15");

            DateTime d5 = DateTime.ParseExact(d1.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d5);      
        }
    }
}
