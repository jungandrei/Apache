using System;
using System.Collections.Generic;
using _Comparisom.Entities;

namespace _Comparisom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("TV", 900.00));

            list.Sort();

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}
