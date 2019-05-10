using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public IList<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Installments:\n");

            foreach (Installment installment in Installments)
            {
                builder.AppendLine(installment.ToString());
            }

            return builder.ToString();
        }
    }
}
