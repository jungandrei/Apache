using System;
using System.Collections.Generic;
using System.Text;

namespace Abstratas.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }  //Limite de emprestimo

        public BusinessAccount()
        {

        }

        //BASE - Pegando os atributos do construtor pai

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (LoanLimit <= amount)
            {
                Balance = Balance + amount;
            }
        }
    }
}
