using JogoTabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public PartidaDeXadrez Partida { get; set; }

        public Rei(Cor cor, Tabuleiro tab, PartidaDeXadrez partida) : base(cor, tab)
        {
            Partida = partida;
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);

            return peca == null || peca.Cor != Cor;
        }


        private bool VerificaMovimento(Posicao posicao)
        {
            return Tab.PosicaoValida(posicao) && PodeMover(posicao);
        }

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.QtdMovimento == 0;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matrizMovimento = new bool[Tab.Linhas, Tab.Colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            //Acima
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Nordeste
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Direito
            posicaoAux.SetPosicao(Posicao.Linha, Posicao.Coluna + 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Sudeste
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Abaixo
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }
            //Sudoeste
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Esquerda
            posicaoAux.SetPosicao(Posicao.Linha, Posicao.Coluna - 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }
            //Noroeste
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            // #jogada especial roque pequeno
            if (QtdMovimento == 0 && !Partida.Xeque)
            {
                Posicao posicaoTorre = new Posicao(Posicao.Linha, Posicao.Coluna + 3);

                if (TesteTorreParaRoque(posicaoTorre))
                {
                    Posicao posicaoCasa1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao posicaoCasa2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (Tab.GetPeca(posicaoCasa1) == null && Tab.GetPeca(posicaoCasa2) == null)
                    {
                        matrizMovimento[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                // #jogada especial roque grande
                posicaoTorre.SetPosicao(Posicao.Linha, Posicao.Coluna - 4);

                if (TesteTorreParaRoque(posicaoTorre))
                {
                    Posicao posicaoCasa1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao posicaoCasa2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao posicaoCasa3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tab.GetPeca(posicaoCasa1) == null && Tab.GetPeca(posicaoCasa2) == null && Tab.GetPeca(posicaoCasa3) == null)
                    {
                        matrizMovimento[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return matrizMovimento;


        }

        public override string ToString()
        {
            return "R";
        }
    }
}
