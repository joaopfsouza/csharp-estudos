using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entitites
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }

        public Client(string name, string email, DateTime bithDate)
        {
            Name = name;
            Email = email;
            BithDate = bithDate;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Client: ");
            builder.Append(Name);
            builder.Append($" ({BithDate.ToString("dd/MM/yyyy")}) - ");
            builder.Append(Email);


            return builder.ToString();
        }
    }
}
