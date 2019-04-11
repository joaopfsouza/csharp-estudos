using System;
using System.Collections.Generic;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Alunos Curso A?");
            int n = int.Parse(Console.ReadLine());
            HashSet<int> cursoA = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Quantos Alunos Curso B?");
            n = int.Parse(Console.ReadLine());
            HashSet<int> cursoB = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Quantos Alunos Curso C?");
            n = int.Parse(Console.ReadLine());
            HashSet<int> cursoC = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                cursoC.Add(int.Parse(Console.ReadLine()));
            }
            cursoB.UnionWith(cursoC);
            cursoA.UnionWith(cursoB);
            
            Console.WriteLine("Total de Alunos {0}", cursoA.Count);

        }
    }
}
