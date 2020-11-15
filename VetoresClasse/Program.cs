using System;
using System.Globalization;

namespace VetoresClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Produtos é Tipo do vetor
            Produtos[] vetor = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produtos { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vetor[i].Preco;
            }

            double media = soma / n;

            
        }
    }
}
