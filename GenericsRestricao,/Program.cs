using System;
using System.Collections.Generic;
using GenericsRestricao_.Entities;
using GenericsRestricao_.Services;

namespace GenericsRestricao_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Pegar dados antes e depois da virgula

                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0]; //Antes
                double price = double.Parse(vect[1]); //Depois

                list.Add(new Product(name, price));
            }

            CalculationServices calculationServices = new CalculationServices();

            Product max = calculationServices.Max(list);

            Console.WriteLine("Max: " + max);
        }
    }
}
