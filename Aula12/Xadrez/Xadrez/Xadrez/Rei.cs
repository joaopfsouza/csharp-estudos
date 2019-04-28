using JogoTabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
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
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
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

            return matrizMovimento;


        }

        public override string ToString()
        {
            return "R";
        }
    }
}
