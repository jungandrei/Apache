using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MetodosAbstratos.Entites.Enums;

namespace MetodosAbstratos.Entites
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
