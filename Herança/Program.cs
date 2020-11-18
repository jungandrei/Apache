using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account(1001,"Alex",500.0);
            Account ac2 = new SavingsAccount(1002, "Anna", 500.0,0.01);

            ac1.WithDraw(10.0);
            ac2.WithDraw(10.0);

            Console.WriteLine(ac1.Balance);
            Console.WriteLine(ac2.Balance);
        }
    }
}
