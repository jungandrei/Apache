using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido divisão por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato errado! " + e.Message);
            }
        }
    }
}
