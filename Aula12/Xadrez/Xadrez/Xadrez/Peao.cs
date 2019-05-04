using JogoTabuleiro;

namespace Xadrez
{
    class Peao : Peca
    {
        public PartidaDeXadrez Partida { get; set; }

        public Peao(Cor cor, Tabuleiro tab, PartidaDeXadrez partida) : base(cor, tab)
        {
            Partida = partida;
        }

        private bool ExisteAdversario(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);
            return peca != null && peca.Cor != Cor;
        }

        private bool Livre(Posicao posicao)
        {
            return Tab.GetPeca(posicao) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matrizMovimento = new bool[Tab.Linhas, Tab.Colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(posicaoAux) && Livre(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }
                //
                posicaoAux.SetPosicao(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.PosicaoValida(posicaoAux) && Livre(posicaoAux) && QtdMovimento == 0)
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }
                //
                posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(posicaoAux) && ExisteAdversario(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }
                //
                posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(posicaoAux) && ExisteAdversario(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(esquerda) && ExisteAdversario(esquerda) && Tab.GetPeca(esquerda) == Partida.VuneravelEnPassant)
                    {
                        matrizMovimento[esquerda.Linha - 1, esquerda.Coluna] = true;
                    }
                }

                if (Posicao.Linha == 3)
                {
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(direita) && ExisteAdversario(direita) && Tab.GetPeca(direita) == Partida.VuneravelEnPassant)
                    {
                        matrizMovimento[direita.Linha - 1, direita.Coluna] = true;
                    }
                }
            }
            else
            {
                posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(posicaoAux) && Livre(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }

                posicaoAux.SetPosicao(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.PosicaoValida(posicaoAux) && Livre(posicaoAux) && QtdMovimento == 0)
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }

                //
                posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(posicaoAux) && ExisteAdversario(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }

                posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(posicaoAux) && ExisteAdversario(posicaoAux))
                {
                    matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(esquerda) && ExisteAdversario(esquerda) && Tab.GetPeca(esquerda) == Partida.VuneravelEnPassant)
                    {
                        matrizMovimento[esquerda.Linha + 1, esquerda.Coluna] = true;
                    }
                }

                if (Posicao.Linha == 4)
                {
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(direita) && ExisteAdversario(direita) && Tab.GetPeca(direita) == Partida.VuneravelEnPassant)
                    {
                        matrizMovimento[direita.Linha + 1, direita.Coluna] = true;
                    }
                }

            }

            return matrizMovimento;

        }

        public override string ToString()
        {
            return "P";
        }
    }
}
