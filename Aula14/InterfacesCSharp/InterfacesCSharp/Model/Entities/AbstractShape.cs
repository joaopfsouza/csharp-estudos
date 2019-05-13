using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfacesCSharp.Entities
{
    abstract class AbstractShape : IShape
    {
        
        public Color Color { get; set; }
        public abstract double Area();

        public override string ToString()
        {
            return $"Shape Color: {Color}\nShape Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
