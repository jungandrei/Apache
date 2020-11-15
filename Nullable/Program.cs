using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            //GetValueOrDefault Pega o valor do X, ou então, se o valor não existir. Pega o valor padrão
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Vai dizer se dentro da variável X, existe ou não valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            //Value Pega o valor da variável. Não aceita valores nulos
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x é null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é null");
            }

        }
    }
}
