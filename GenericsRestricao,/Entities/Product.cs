using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsRestricao_.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + "," + Price.ToString("F");
        }

        //Comparar um produto com outro produto
        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Argumento não é do tipo Product");
            }

            //Comparação do preco do produto que veio como parametro com o preco
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
