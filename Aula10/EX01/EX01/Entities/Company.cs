using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    class Company : TaxPayers
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double CalculeTax()
        {
            if (NumberEmployees < 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
