using System;
using System.Collections.Generic;
using System.Text;
using InterfaceVSHerança.Model.Enums;

namespace InterfaceVSHerança.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        //Foi feito assim para que possa existir outros shapes que não precisam de color
        public Color Color { get; set; }

        public abstract double Area();
    }
}
