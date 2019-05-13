using InterfacesCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfacesCSharp.Model.Entities
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
            return $"Rectangle Width: {Width.ToString("F2", CultureInfo.InvariantCulture)}\nRectangle Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}\n"
                + base.ToString();
        }
    }
}
