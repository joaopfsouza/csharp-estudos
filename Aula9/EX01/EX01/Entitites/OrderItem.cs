using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entitites
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Product.Name);
            builder.Append(", ");
            builder.Append($"{Price:C}, ");
            builder.Append($"Quantity: {Quantity}, ");
            builder.Append($"SubTotal: {SubTotal():C}");


            return builder.ToString();
        }
    }
}
