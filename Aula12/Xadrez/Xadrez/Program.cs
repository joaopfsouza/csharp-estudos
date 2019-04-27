using System;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro p = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(p);

            Console.WriteLine(p);
        }
    }
}
