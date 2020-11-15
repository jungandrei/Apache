using System;

namespace CondicaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            //Se o preco for menor que 20. Roda o "?". se não roda ":"
        }
    }
}
