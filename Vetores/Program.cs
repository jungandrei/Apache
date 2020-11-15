using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade do meu vetor
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vetor[i];
            }

            double media = soma / n;

            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
