using System;
using System.Collections.Generic;
using System.Text;

namespace ExResolvido.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price.ToString("C2")}";
        }
    }
}
