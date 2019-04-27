using EX01.Entities;
using System;
using System.Collections.Generic;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> listTax = new List<TaxPayers>();

            listTax.Add(new Individual("Alex", 50000.00, 2000.00));
            listTax.Add(new Company("SoftTech", 400000.00, 25));
            listTax.Add(new Individual("Bob", 120000.00, 1000.00));


            Console.WriteLine("TAXES PAID:");

            double sum = 0;
            foreach (var item in listTax)
            {
                Console.WriteLine(item);
                sum += item.CalculeTax();
            }

            Console.WriteLine($"TOTAL TAXES: {sum:C}");
        }
    }
}
