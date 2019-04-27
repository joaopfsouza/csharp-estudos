using System;
using JogoTabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.PutPeca(new Rei(Cor.Branca, tab), new Posicao(0, 0));
                tab.PutPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
                tab.PutPeca(new Rainha(Cor.Branca, tab), new Posicao(0, 3));

                Tela.ImprimirTabuleiro(tab);

                Console.WriteLine(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);

            }

        }
    }
}
