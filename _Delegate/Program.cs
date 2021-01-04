using System;
using _Delegate.Services;

namespace _Delegate
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Delegate guarda a referencia para duas funções
            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a,b);
        }
    }
}
