using JogoTabuleiro;
using System.Collections.Generic;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        public HashSet<Peca> Pecas { get; set; }
        public HashSet<Peca> Capturadas { get; set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;

            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemovePeca(origem);
            p.IncrementarQtdMovimento();
            Peca pecaCapturada = Tab.RemovePeca(destino);
            Tab.PutPeca(p, destino);

            if(pecaCapturada != null)
            {
                Capturadas.Add(pecaCapturada);
            }

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

        public HashSet<Peca> PecasCapturadasCor(Cor cor)
        {
            HashSet<Peca> conjuntoCapturadasAux = new HashSet<Peca>();
            foreach (Peca peca in Capturadas)
            {
                if(peca.Cor == cor)
                {
                    conjuntoCapturadasAux.Add(peca);
                }
            }
            return conjuntoCapturadasAux;
        }


        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> conjuntoCapturadasAux = new HashSet<Peca>();
            foreach (Peca peca in Capturadas)
            {
                if (peca.Cor == cor)
                {
                    conjuntoCapturadasAux.Add(peca);
                }
            }
            conjuntoCapturadasAux.ExceptWith(PecasCapturadasCor(cor));
            return conjuntoCapturadasAux;
        }


        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tab.PutPeca(peca, new PosicaoXadrez(coluna, linha).ConvertPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {

            ColocarNovaPeca('c', 1, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('c', 2, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('d', 1, new Rei(Cor.Branca, Tab));
            ColocarNovaPeca('d', 2, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('e', 1, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('e', 2, new Torre(Cor.Branca, Tab));


            ColocarNovaPeca('c', 8, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('c', 7, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('d', 8, new Rei(Cor.Preta, Tab));
            ColocarNovaPeca('d', 7, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('e', 8, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('e', 7, new Torre(Cor.Preta, Tab));


        }
    }
}
