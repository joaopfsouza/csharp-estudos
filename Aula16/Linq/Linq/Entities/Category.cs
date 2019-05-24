using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Tier}";
        }
    }
}
