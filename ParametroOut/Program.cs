using System;

namespace ParametroOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;
            Calculadora.Triplicar(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
