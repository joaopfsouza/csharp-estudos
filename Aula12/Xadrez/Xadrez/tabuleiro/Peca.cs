namespace JogoTabuleiro
{
    public class Peca
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

        public void IncrementarQtdMovimento()
        {
            QtdMovimento++;
        }
    }


}
