using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceVSHerança.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangulo color = "
                   + Color
                   + ", width = "
                   + Width.ToString("F")
                   + ", height = "
                   + Height.ToString("F")
                   + ", area = "
                   + Area().ToString("F");
        }
    }
}
