using System;
using System.Globalization;

namespace Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circulo = Calculadora.Circunferência(raio);

            double volume = Calculadora.Volume(raio);            
        }
        
    }
}
