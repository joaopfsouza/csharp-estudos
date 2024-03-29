﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EXFIXACAO02.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double width, double height, string color) : base(color)
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
