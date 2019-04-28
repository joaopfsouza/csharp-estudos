using JogoTabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

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

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();

        }

        public void ValidarPosicaoDeOrigem(Posicao posicao)
        {
            Peca pecaExiste = Tab.GetPeca(posicao);

            if (pecaExiste == null)
            {
                throw new TabuleiroException($"Não existe peça na posição {posicao}");
            }
            else if (JogadorAtual != pecaExiste.Cor)
            {
                throw new TabuleiroException($"A peça de origem não é a do jogar atual !!");
            }
            else if (!pecaExiste.ExisteMovimentoPossiveis())
            {
                throw new TabuleiroException($"Peça sem movimento possível!!");

            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.GetPeca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException($"Posição de destino inválida");
            }

        }

        private void MudaJogador()
        {
            JogadorAtual = (JogadorAtual == Cor.Branca) ? Cor.Preta : Cor.Branca;
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
