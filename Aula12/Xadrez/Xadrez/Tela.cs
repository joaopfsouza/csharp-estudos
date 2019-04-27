using System;
using tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if( tab.GetPeca(i,j) != null)
                        Console.Write(tab.GetPeca(i,j) + " ");
                    else
                        Console.Write("- ");
                    
                }
                Console.WriteLine();
            }

        }
    }
}
