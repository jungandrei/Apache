using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratos.Entites.Enums;

namespace MetodosAbstratos.Entites
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)    //base para o "color" para a superclasse
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
