using System;
using System.Collections.Generic;
using Abstratas.Entities;

namespace Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASSE GENÉRICA É ACCOUNT

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            //Percorri a lista e somei todos os balances dela
            foreach (Account acc in list)
            {
                sum = sum + acc.Balance;
            }

            //Métodos executando de forma polimorfica
            foreach (Account acc in list)
            {
                acc.WithDraw(10.0);
            }
        }
    }
}
