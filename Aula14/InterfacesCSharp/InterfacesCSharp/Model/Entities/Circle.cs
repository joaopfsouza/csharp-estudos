using InterfacesCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfacesCSharp.Model.Entities
{
    class Circle : AbstractShape
    {

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle Raidius: {Radius.ToString("F2", CultureInfo.InvariantCulture)}\n"
                + base.ToString();
        }
    }
}
