using JogoTabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
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
            return (peca != null  && peca.Cor != Cor);
        }

        private bool VerificaMovimento(Posicao posicao)
        {
            return Tab.PosicaoValida(posicao) && PodeMover(posicao);
        }



        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matrizMovimento = new bool[Tab.Linhas, Tab.Colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            //Acima
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.Linha--;
            }

            //Abaixo
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.Linha++;
            }

            //Direita
            posicaoAux.SetPosicao(Posicao.Linha, Posicao.Coluna + 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.Coluna++;
            }

            //Esquerda
            posicaoAux.SetPosicao(Posicao.Linha, Posicao.Coluna - 1);
            while (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
                if (FimMovimento(posicaoAux))
                {
                    break;
                }
                posicaoAux.Coluna--;
            }


            return matrizMovimento;


        }

        public override string ToString()
        {
            return "T";
        }
    }
}