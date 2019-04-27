using System;
using System.Collections.Generic;
using System.Text;

namespace EXFIXACAO02.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
