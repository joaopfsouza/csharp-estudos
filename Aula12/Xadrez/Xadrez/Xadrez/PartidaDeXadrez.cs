using JogoTabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno { get; set; }
        private Cor JogadorAtual { get; set; }
        public bool Terminada { get; set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemovePeca(origem);
            p.IncrementarQtdMovimento();
            Peca pecaCapturada = Tab.RemovePeca(destino);
            Tab.PutPeca(p, destino);

        }

        private void ColocarPecas()
        {

            Tab.PutPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 2).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('d', 2).ConvertPosicao());
            Tab.PutPeca(new Rei(Cor.Branca, Tab), new PosicaoXadrez('d', 1).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 2).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 1).ConvertPosicao());



            Tab.PutPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 8).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 7).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('d', 7).ConvertPosicao());
            Tab.PutPeca(new Rei(Cor.Preta, Tab), new PosicaoXadrez('d', 8).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 8).ConvertPosicao());
            Tab.PutPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 7).ConvertPosicao());


        }
    }
}
