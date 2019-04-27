using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    class Individual : TaxPayers
    {
        public double HealthSpending { get; set; } = 0.0;

        public Individual(string name, double annualIncome, double healthSpending)
            : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double CalculeTax()
        {
            if (AnnualIncome < 2000.00)
            {
                return (AnnualIncome * 0.15 - HealthSpending * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25 - HealthSpending * 0.5);
            }
        }
    }
}
