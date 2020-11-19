using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MetodosAbstratos.Entites.Enums;

namespace MetodosAbstratos.Entites
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
