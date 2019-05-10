using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Services
{
    class PayPalTaxService : IPaymentTaxService
    {
        public double SimpleTax { get; }
        public double FeeTax { get; set; }

        public PayPalTaxService(double simpleTax, double feeTax)
        {
            SimpleTax = simpleTax / 100.00;
            FeeTax = feeTax / 100.00;
        }

        public double CalculateAmoutWithTax(double amount, int mounth)
        {
            return amount * (1 + SimpleTax * mounth) *(1+ FeeTax);
        }
    }
}
