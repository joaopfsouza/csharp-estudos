using System;
using System.Collections.Generic;
using System.Text;

namespace EXFIXACAO01.Entities
{
    class ImportedProduct : Product
    {
        public double CustomPrice { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customPrice)
            : base(name, price)
        {
            CustomPrice = customPrice;
        }

        public double TotalPrice()
        {
            return Price + CustomPrice;
        }

        public override string PriceTag()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} {TotalPrice():C} ");
            builder.Append($"(Customs fee: {CustomPrice:C})");
            return builder.ToString();
        }
    }
}
