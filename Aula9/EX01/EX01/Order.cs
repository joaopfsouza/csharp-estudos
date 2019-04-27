using EX01.Entitites;
using EX01.Entitites.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX01
{
    class Order
    {

        private OrderStatus orderStatus;

        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Moment = DateTime.Now;
            Items = new List<OrderItem>();
        }
        public Order(string orderStatus, Client client) : this()
        {
            OrderStatus = orderStatus;
            Client = client;
        }

        public void ChangeOrderStatus(string orderStatus)
        {

        }

        public string OrderStatus
        {
            get { return orderStatus.ToString(); }
            set
            {
                orderStatus = Enum.Parse<OrderStatus>(value);
            }
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Order Summary".ToUpper());
            builder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            builder.AppendLine($"Order status: {OrderStatus.ToString()}");
            builder.AppendLine(Client.ToString());
            builder.AppendLine("Order Items");

            foreach (var item in Items)
            {
                builder.AppendLine(item.ToString());
            }

            builder.AppendLine($"Total prime: {Total():C}");


            return builder.ToString();
        }
    }
}
