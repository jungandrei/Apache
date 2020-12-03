using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsRestricao_.Services
{
    class CalculationServices
    {
        //Vai achar o máximo em uma lista de inteiros. 
        //Fez uma operação generica do tipo T, que não sei que tipo é, Desde que esse tipo seja uma implementação da interface IComparable
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
