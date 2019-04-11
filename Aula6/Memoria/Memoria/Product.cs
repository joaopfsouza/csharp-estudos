using System;
using System.Collections.Generic;
using System.Text;

namespace Memoria
{
    class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
