using System;
using System.Collections.Generic;
using System.Text;
using InterfaceVSHerança.Model.Enums;

namespace InterfaceVSHerança.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
