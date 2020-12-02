using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get => BasicPayment + Tax; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F")
                                     + "\nTax: " + Tax.ToString("F")
                                     + "\nTotal: " + TotalPayment.ToString("F");
        }
    }
}
