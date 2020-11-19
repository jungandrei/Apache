using System;
using System.Collections.Generic;
using System.Text;

namespace Abstratas.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }  //Taxa

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance = Balance - 2.0;
        }
    }
}
