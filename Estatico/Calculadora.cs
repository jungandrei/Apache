using System;
using System.Collections.Generic;
using System.Text;

namespace Estatico
{
    class Calculadora
    {
        public static double Pi = 2.0;
                
        public static double Circunferência(double r)
        {
            return 2.0 * Pi * r;
        }
                
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
