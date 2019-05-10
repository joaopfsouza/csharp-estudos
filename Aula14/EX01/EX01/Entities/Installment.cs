using System;
using System.Globalization;

namespace EX01.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }

        public Installment()
        {

        }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate.ToShortDateString()} - {Amount:C}";
        }
    }
}