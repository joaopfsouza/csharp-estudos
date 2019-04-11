using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] linhasColunas = InputDimensaoMatriz();

            int[,] matrizJogo = PreencheMatriz(linhasColunas);

            int acheNumero = int.Parse(Console.ReadLine());
            AchePosicaoNumero(acheNumero, matrizJogo);
            
            PrintMatriz(matrizJogo);

        }

        private static void AchePosicaoNumero(int acheNumero, int[,] matrizAuxiliar)
        {
            for (int i = 0; i < matrizAuxiliar.GetLength(0); i++)
            {
                for (int j = 0; j < matrizAuxiliar.GetLength(1); j++)
                {
                    if (matrizAuxiliar[i, j] == acheNumero)
                    {
                        Console.WriteLine("Posição {0},{1}:", i, j);
                        MostraVizinhos(matrizAuxiliar, i, j);

                    }
                }
            }
        }

        private static void MostraVizinhos(int[,] matrizAuxiliar, int posicaoLinha, int posicaoColuna)
        {
            if ((posicaoColuna - 1) >= 0)
                Console.WriteLine("Left: {0}", matrizAuxiliar[posicaoLinha, posicaoColuna - 1]);
            if ((posicaoColuna + 1) < matrizAuxiliar.GetLength(1))
                Console.WriteLine("Right: {0}", matrizAuxiliar[posicaoLinha, posicaoColuna + 1]);
            if ((posicaoLinha - 1) >= 0)
                Console.WriteLine("Top: {0}", matrizAuxiliar[posicaoLinha - 1, posicaoColuna]);
            if ((posicaoLinha + 1) < matrizAuxiliar.GetLength(0))
                Console.WriteLine("Down: {0}", matrizAuxiliar[posicaoLinha + 1, posicaoColuna]);
        }

        private static void PrintMatriz(int[,] matrizAuxiliar)
        {
            for (int i = 0; i < matrizAuxiliar.GetLength(0); i++)
            {
                for (int j = 0; j < matrizAuxiliar.GetLength(1); j++)
                {
                    Console.Write("\t{0}\t", matrizAuxiliar[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static int[,] PreencheMatriz(int[] linhasColunas)
        {
            int[,] matrizAuxiliar = new int[linhasColunas[0], linhasColunas[1]];
            int[] linhaEntrada = new int[linhasColunas[1]];

            Console.WriteLine("Digite as linhas e colunas:");

            for (int i = 0; i < matrizAuxiliar.GetLength(0); i++)
            {
                linhaEntrada = InputLinhasMatriz(matrizAuxiliar.GetLength(1));

                for (int j = 0; j < matrizAuxiliar.GetLength(1); j++)
                {
                    matrizAuxiliar[i, j] = linhaEntrada[j];
                }
            }

            return matrizAuxiliar;
        }

        private static int[] InputLinhasMatriz(int numeroElementos)
        {
            string[] linhaDigitada = Console.ReadLine().Split(' ');
            int[] elementosLinha = new int[numeroElementos];

            for (int i = 0; i < numeroElementos; i++)
            {
                elementosLinha[i] = int.Parse(linhaDigitada[i]);
            }
            return elementosLinha;
        }

        private static int[] InputDimensaoMatriz()
        {
            Console.WriteLine("Dimensão de Matriz:");
            string[] dimensoesMatriz = Console.ReadLine().Split(' ');
            return new int[] { int.Parse(dimensoesMatriz[0]), int.Parse(dimensoesMatriz[1]) };

        }


    }
}
