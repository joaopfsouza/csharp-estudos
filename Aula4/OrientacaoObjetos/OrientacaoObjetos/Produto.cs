using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"{Nome} {Preco:C} {Quantidade} {ValorTotalEmEstoque():C}";
        }
    }
}
