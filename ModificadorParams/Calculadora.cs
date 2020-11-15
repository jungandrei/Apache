using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorParams
{
    class Calculadora
    {
        //Função soma que recebe um vetor de numeros
        public static int Sum(params int[] numeros)
        {
            int sum = 0;

            //i é menor que a quantidade de numeros existente
            for (int i = 0; i < numeros.Length; i++)
            {
                sum = sum + numeros[i];
            }
            return sum;
        }
    }
}
