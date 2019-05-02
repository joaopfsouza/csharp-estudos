using JogoTabuleiro;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab) : base(cor, tab)
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
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna -2);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

           
            posicaoAux.SetPosicao(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            
            posicaoAux.SetPosicao(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

          
            posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

         
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }
            
            posicaoAux.SetPosicao(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            //Esquerda
            posicaoAux.SetPosicao(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }
            //Noroeste
            posicaoAux.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (VerificaMovimento(posicaoAux))
            {
                matrizMovimento[posicaoAux.Linha, posicaoAux.Coluna] = true;
            }

            return matrizMovimento;

        }

        public override string ToString()
        {
            return "C";
        }
    }
}
