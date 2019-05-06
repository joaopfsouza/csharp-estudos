using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EX01.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Qtd { get; set; }


        public Product(string name, double value, int qtd)
        {
            Name = name;
            Value = value;
            Qtd = qtd;
        }

        public double Total()
        {
            return Value * Qtd;
        }

        public string ExportCSVTotal()
        {
            return $"{Name},{Total().ToString("F2",CultureInfo.InvariantCulture)}";
        }


        public override string ToString()
        {
            return $"{Name},{Value},{Qtd}";
        }
    }
}
