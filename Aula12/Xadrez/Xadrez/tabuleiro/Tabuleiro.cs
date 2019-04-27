namespace JogoTabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;

            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public void PutPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe peça nessa posição!!");
            }

            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return GetPeca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Coluna >= Linhas || posicao.Coluna >= Colunas || posicao.Linha < 0 || posicao.Coluna < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }


    }
}