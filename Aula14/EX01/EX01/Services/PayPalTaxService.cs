using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Services
{
    class PayPalTaxService : IPaymentTaxService
    {

        private const double feePercentage = 0.02;
        private const double monthlyInterest = 0.01;

        public double Interest(double amount, int mounths)
        {
            return amount * mounths * monthlyInterest;
        }

        public double PaymentFee(double amount)
        {
            return amount * feePercentage;
        }
    }
}
