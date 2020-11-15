using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lê os dados            
            Console.WriteLine("Entre com os dados do produto: ");            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            //Instaciando já com os dados //Construtor de 2 argumentos
            Produto produto = new Produto(nome, preco);

            Produto produto2 = new Produto();

            Produto produto3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 }; //Nova forma de inicializar valores // Não precisou dos parenteses


            Console.WriteLine("Dados do produto: " + produto);

            //Adiciona os produtos
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + produto);

            //Remove os produtos
            Console.WriteLine();
            Console.Write("Digite um número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + produto);
        }
    }
}
