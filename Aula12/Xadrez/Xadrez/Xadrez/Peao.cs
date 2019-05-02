using JogoTabuleiro;

namespace Xadrez
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        private bool ExisteAdversario(Posicao posicao)
        {
            Peca peca = Tab.GetPeca(posicao);
            return posicao != null || peca.Cor != Cor;
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
                posicaoAux.SetPosicao(Posicao.Linha - 1, Posicao.Coluna -1);
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
                
            }

            return matrizMovimento;

        }

        public override string ToString()
        {
            return "P";
        }
    }
}
