using JogoTabuleiro;

namespace Xadrez
{
    class Rainha : Peca
    {
        public Rainha(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
