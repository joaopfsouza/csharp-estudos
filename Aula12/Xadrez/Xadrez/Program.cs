using System;
using JogoTabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {


            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                try
                {
                    Console.Clear();

                    Tela.ImprimirPartida(partida);


                    Console.Write("Origem: ");
                    Posicao origem = Tela.ReadPosicaoXadrez().ConvertPosicao();
                    partida.ValidarPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.Tab.GetPeca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.ReadPosicaoXadrez().ConvertPosicao();
                    partida.ValidarPosicaoDeDestino(origem, destino);

                    partida.RealizaJogada(origem, destino);
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
        }

        private static void PosXadrez()
        {
            PosicaoXadrez pos = new PosicaoXadrez('h', 8);


            Console.WriteLine(pos.ConvertPosicao());
        }


        private static void TabuleiroInicial()
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.PutPeca(new Rei(Cor.Branca, tab), new Posicao(0, 0));
                tab.PutPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
                tab.PutPeca(new Rainha(Cor.Branca, tab), new Posicao(0, 3));

                tab.PutPeca(new Rei(Cor.Preta, tab), new Posicao(5, 0));
                tab.PutPeca(new Torre(Cor.Preta, tab), new Posicao(6, 3));
                tab.PutPeca(new Rainha(Cor.Preta, tab), new Posicao(7, 3));

                Tela.ImprimirTabuleiro(tab);


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);

            }
        }
    }
}
