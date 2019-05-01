using System;

namespace JogoTabuleiro
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
