using System;
using System.Collections.Generic;
using EX01.Entities;
using System.Text;

namespace EX01.Services
{
    class ContractProcessingService
    {
        private IPaymentTaxService _paymentTaxService;

        public int NumberInstallment { get; }

        public ContractProcessingService(int numberInstallment, IPaymentTaxService paymentTaxService)
        {

            NumberInstallment = numberInstallment;
            _paymentTaxService = paymentTaxService;

        }

        public void CalculateInstallments(Contract contract)
        {
            double amountBase = contract.TotalValue / NumberInstallment;
            double amountCalculate = 0;
            DateTime dateCalculate = new DateTime();

            for (int month = 1; month <= NumberInstallment; month++)
            {
                amountCalculate = _paymentTaxService.CalculateAmoutWithTax(amountBase, month);
                dateCalculate = contract.Date.AddMonths(month);

                contract.Installments.Add(new Installment(dateCalculate, amountCalculate));
            }
        }
    }
}
