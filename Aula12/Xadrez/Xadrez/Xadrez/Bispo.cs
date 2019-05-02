using JogoTabuleiro;

namespace Xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);

            return (peca == null || peca.Cor != Cor);
        }

        private bool FimMovimento(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);
            return (peca != null && peca.Cor != Cor);
        }

        private bool VerificaMovimento(Posicao posicao)
        {
            return Tab.PosicaoValida(posicao) && PodeMover(posicao);
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matrizMovimento = new bool[Tab.Linhas, Tab.Colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            //NO
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.SetPosicao(posicaoAux.Linha - 1, posicaoAux.Coluna - 1);
            }

            //NE
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.SetPosicao(posicaoAux.Linha - 1, posicaoAux.Coluna + 1);
            }

            //SE
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.SetPosicao(posicaoAux.Linha + 1, posicaoAux.Coluna + 1);
            }

            //SO
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.SetPosicao(posicaoAux.Linha + 1, posicaoAux.Coluna - 1);
            }


            return matrizMovimento;


        }

        public override string ToString()
        {
            return "B";
        }
    }
}