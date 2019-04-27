using EX01.Entitites;
using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Alex Green", "alex@gmail.com", new DateTime(1985, 03, 15));

            Product product1 = new Product("TV", 1000.00);
            Product product2 = new Product("Mouse", 40.00);

            OrderItem ordemItem1 = new OrderItem(1, product1.Price, product1);
            OrderItem ordemItem2 = new OrderItem(2, product2.Price, product2);

            Order order = new Order("Processing", client);

            order.AddItem(ordemItem1);
            order.AddItem(ordemItem2);

            Console.WriteLine(order);
        }
    }
}
