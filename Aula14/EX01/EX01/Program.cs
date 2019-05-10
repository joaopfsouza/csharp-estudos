using System;
using System.Globalization;
using EX01.Entities;
using EX01.Services;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber,contractDate, contractValue);
            ContractProcessingService contractProcessing = new ContractProcessingService(numberInstallments, new PayPalTaxService());

            contractProcessing.CalculateInstallments(contract);

            //Contract contract = new Contract(8028, new DateTime(2018, 06, 25), 600.00);
            //ContractProcessingService contractProcessing = new ContractProcessingService(3, new PayPalTaxService(1, 2));

            //contractProcessing.CalculateInstallments(contract);

            Console.WriteLine(contract);
        }
    }
}
