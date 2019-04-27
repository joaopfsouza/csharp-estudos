using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayers()
        {

        }

        public TaxPayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalculeTax();

        public override string ToString()
        {
            return $"{Name}: {CalculeTax():C}";
        }

    }
}
