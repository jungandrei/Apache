using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um número n:");

            int n = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[n,n];

            for (int i = 0; i < n; i++) {

                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }


        }
    }
}
