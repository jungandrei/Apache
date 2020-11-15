using System;
using System.Globalization;

namespace First
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Método da Classe Triangulo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }


    }
}
