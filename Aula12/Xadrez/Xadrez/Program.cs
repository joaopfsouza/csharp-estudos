using System;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.PutPeca(new Rei(Cor.Branca, tab), new Posicao(0, 0));
            tab.PutPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
            tab.PutPeca(new Rainha(Cor.Branca, tab), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.WriteLine(tab);
        }
    }
}
