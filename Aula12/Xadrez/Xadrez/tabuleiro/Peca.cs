namespace JogoTabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Cor = cor;
            Tab = tab;
            Posicao = null;
            QtdMovimento = 0;
        }

        public bool ExisteMovimentoPossiveis()
        {
            bool[,] matrizAux = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (matrizAux[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void IncrementarQtdMovimento()
        {
            QtdMovimento++;
        }

        public void DecrementarQtdMovimento()
        {
            QtdMovimento--;
        }

        public bool PodeMoverPara(Posicao posicao)
        {
            return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }


}
