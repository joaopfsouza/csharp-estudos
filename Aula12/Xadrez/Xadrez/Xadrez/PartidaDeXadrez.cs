using JogoTabuleiro;
using System;
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
        public bool xeque { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            xeque = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
        }

        public Peca ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemovePeca(origem);
            p.IncrementarQtdMovimento();
            Peca pecaCapturada = Tab.RemovePeca(destino);
            Tab.PutPeca(p, destino);

            if (pecaCapturada != null)
            {
                Capturadas.Add(pecaCapturada);
            }

            return pecaCapturada;
        }

        private void DesfazMovimento(Posicao origem, Posicao destino, Peca capturada)
        {
            Peca p = Tab.RemovePeca(destino);
            p.DecrementarQtdMovimento();

            if (capturada != null)
            {
                Tab.PutPeca(capturada, destino);
                Capturadas.Remove(capturada);
            }

            Tab.PutPeca(p, origem);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {

            Peca capturada = ExecutaMovimento(origem, destino);

            if (EstaEmCheque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, capturada);
                throw new TabuleiroException($"Você não pode se por em cheque!!!");
            }
            else if (EstaEmCheque(Adversario(JogadorAtual)))
            {
                xeque = true;

            }
            else
            {
                xeque = false;
            }

            if (TesteXequemate(Adversario(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {
                Turno++;
                MudaJogador();
            }
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
            if (!Tab.GetPeca(origem).MovimentoPossivel(destino))
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
                if (peca.Cor == cor)
                {
                    conjuntoCapturadasAux.Add(peca);
                }
            }
            return conjuntoCapturadasAux;
        }


        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> conjuntoEmJogoAux = new HashSet<Peca>();
            foreach (Peca peca in Pecas)
            {
                if (peca.Cor == cor)
                {
                    conjuntoEmJogoAux.Add(peca);
                }
            }
            conjuntoEmJogoAux.ExceptWith(PecasCapturadasCor(cor));
            return conjuntoEmJogoAux;
        }

        public bool TesteXequemate(Cor cor)
        {
            if (!EstaEmCheque(cor))
            {
                return false;
            }

            foreach (Peca peca in PecasEmJogo(cor))
            {
                bool[,] aux = peca.MovimentosPossiveis();

                for (int i = 0; i < Tab.Linhas; i++)
                {
                    for (int j = 0; j < Tab.Colunas; j++)
                    {
                        if (aux[i, j])
                        {
                            Posicao origem = peca.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmCheque(cor);
                            DesfazMovimento(origem, destino, pecaCapturada);

                            if (!testeXeque)
                            {
                                return false;
                            }
                        }

                    }
                }
            }
            return true;

        }

        public bool EstaEmCheque(Cor cor)
        {
            Peca reiPosicao = Rei(cor);

            if (reiPosicao == null)
            {
                throw new TabuleiroException($"Não tem a o rei da cor {cor.ToString()}");
            }

            foreach (Peca peca in PecasEmJogo(Adversario(cor)))
            {
                bool[,] aux = peca.MovimentosPossiveis();

                if (aux[reiPosicao.Posicao.Linha, reiPosicao.Posicao.Coluna] == true)
                {
                    return true;
                }
            }

            return false;
        }

        private Cor Adversario(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca Rei(Cor cor)
        {
            foreach (var peca in PecasEmJogo(cor))
            {
                if (peca is Rei)
                {
                    return peca;
                }

            }

            return null;
        }


        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tab.PutPeca(peca, new PosicaoXadrez(coluna, linha).ConvertPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {

            //ColocarNovaPeca('c', 1, new Torre(Cor.Branca, Tab));
            //ColocarNovaPeca('c', 2, new Torre(Cor.Branca, Tab));
            //ColocarNovaPeca('d', 1, new Rei(Cor.Branca, Tab));
            //ColocarNovaPeca('d', 2, new Torre(Cor.Branca, Tab));
            //ColocarNovaPeca('e', 1, new Torre(Cor.Branca, Tab));
            //ColocarNovaPeca('e', 2, new Torre(Cor.Branca, Tab));


            //ColocarNovaPeca('c', 8, new Torre(Cor.Preta, Tab));
            //ColocarNovaPeca('c', 7, new Torre(Cor.Preta, Tab));
            //ColocarNovaPeca('d', 8, new Rei(Cor.Preta, Tab));
            //ColocarNovaPeca('d', 7, new Torre(Cor.Preta, Tab));
            //ColocarNovaPeca('e', 8, new Torre(Cor.Preta, Tab));
            //ColocarNovaPeca('e', 7, new Torre(Cor.Preta, Tab));


            ColocarNovaPeca('c', 1, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('d', 1, new Rei(Cor.Branca, Tab));
            ColocarNovaPeca('h', 7, new Torre(Cor.Branca, Tab));

            ColocarNovaPeca('b', 8, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('a', 8, new Rei(Cor.Preta, Tab));


        }
    }
}
