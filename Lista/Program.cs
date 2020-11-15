using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();

            List<string> Lista2 = new List<string> { "Andrei", "Paola" };

            List<string> Lista3 = new List<string>();

            Lista3.Add("Maria");
            Lista3.Add("João");
            Lista3.Insert(1, "Marco");

            foreach (string obj in Lista3)
            {
                Console.WriteLine(obj);
            }

            //Conta quantos itens tem na lista
            Console.WriteLine(Lista3.Count);

            //Dado o string x eu vou querer, então, a condição que o primeiro carácter de x seja 'A'
            string s1 = Lista3.Find(x => x[0] == 'A'); 
            Console.WriteLine("First 'A': " + s1);

            //Posição do elemento que começa com A
            int posicao1 = Lista3.FindIndex(x => x[0] == 'A');
            Console.WriteLine(posicao1);

            //Filtrou todos os elementos que tem 5 caracter
            List<string> guardarList = Lista3.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string obj in guardarList)
            {
                Console.WriteLine(obj);
            }

            Lista3.Remove("João");
        }
    }
}
