using System;
using System.Collections.Generic;
using _Comparisom2.Entities;

namespace _Comparisom2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("TV", 900.00));

            //Passou uma referência para essa função. Não precisou passar os Produtos como argumento.
            //Passou o nome da função. É uma referência para a função "CompareProducts" chamado de Delegate
            //Delegate é um referência pra função com TypeSafety

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); 

            list.Sort(comp); 

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }


        ////FUNÇAO
        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}


    }
}
