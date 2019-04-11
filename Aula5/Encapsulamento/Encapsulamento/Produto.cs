using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

               
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {

            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto()
        {
            Quantidade = 10;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome} {Preco:C} {Quantidade} {ValorTotalEmEstoque():C}";
        }
    }
}
