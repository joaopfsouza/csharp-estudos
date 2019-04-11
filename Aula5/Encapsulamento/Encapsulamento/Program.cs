using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }

        private static void Produto()
        {
            Produto p = new Produto("TV", 900.00, 190);
            //Produto p = new Produto("TV", 900.00);

            Console.WriteLine(p);

            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            p.RemoverProdutos(3);
            Console.WriteLine(p);
        }
    }
}
