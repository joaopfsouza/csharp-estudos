using System;
using System.Collections.Generic;
using System.Text;

namespace EXFIXACAO02.Entities
{
    abstract class Shape
    {
        private Color _color;
        
        public Shape()
        {

        }

        public Shape(string color)
        {
            Color = color;
        }

        public string Color
        {
            get { return _color.ToString(); }
            set { _color = Enum.Parse<Color>(value); }
        }


        public abstract double Area();

        public override string ToString()
        {
            return $"Cor: {Color} Área: {Area():F2}";
        }
    }
}
