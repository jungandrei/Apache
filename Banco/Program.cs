using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito incial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                //Contrutor do Sim
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoIncial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Cadastro(numero, titular, depositoIncial);                               
            }
            else
            {
                //Construtor do não
                conta = new Cadastro(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            //Deposito
            Console.Write("Entre com um valor de deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);


            //Saque
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);


        }
    }
}
