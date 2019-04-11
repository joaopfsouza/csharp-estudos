using System;
using System.Collections.Generic;
using System.Globalization;

namespace Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet();

        }

        private static void HashSet()
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(5);
            a.Add(5);
            a.Add(9);
            a.Add(8);
            a.Add(3);

            b.Add(3);
            b.Add(4);
            b.Add(4);
            b.Add(5);

            Console.WriteLine("Conjunto A");
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto B");

            foreach (int x in b)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto A interseccao B");
            a.IntersectWith(b);
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto A Uniao B");
            a.UnionWith(b);
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto B removido");
            b.Remove(4);

            foreach (int x in b)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto A menos B");

            a.ExceptWith(b);
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            if (b.Contains(n))
                Console.WriteLine("Tem");
            else
                Console.WriteLine("Não Tem");
        }

        private static void ExercicioFixacaoMatriz()
        {
            Console.WriteLine("Dimensão da matriz quadrada");
            int dimensaoMatrizQuadrada = int.Parse(Console.ReadLine());

            int[,] matrizDeAnalise = new int[dimensaoMatrizQuadrada, dimensaoMatrizQuadrada];

            for (int i = 0; i < dimensaoMatrizQuadrada; i++)
            {
                Console.WriteLine("Digite os valores da linha {0}", i + 1);
                string[] linhaDigitada = Console.ReadLine().Split(' ');

                for (int j = 0; j < dimensaoMatrizQuadrada; j++)
                {
                    matrizDeAnalise[i, j] = int.Parse(linhaDigitada[j]);

                }
            }

            Console.WriteLine("Diagonal");

            for (int i = 0; i < dimensaoMatrizQuadrada; i++)
            {


                Console.Write("{0} ", matrizDeAnalise[i, i]);


            }
            Console.WriteLine();

            int quantidadeNumerosNegativos = 0;

            for (int i = 0; i < dimensaoMatrizQuadrada; i++)
            {
                for (int j = 0; j < dimensaoMatrizQuadrada; j++)
                {
                    quantidadeNumerosNegativos += Convert.ToInt32((matrizDeAnalise[i, j] < 0));

                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de negativos {0}", quantidadeNumerosNegativos);
            Console.WriteLine();
            for (int i = 0; i < dimensaoMatrizQuadrada; i++)
            {
                for (int j = 0; j < dimensaoMatrizQuadrada; j++)
                {
                    Console.Write("\t{0}\t ", matrizDeAnalise[i, j]);

                }
                Console.WriteLine();
            }
        }

        private static void MatrixBasics()
        {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }

        private static void ListResources()
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Alex");
            list.Add("Marcos");
            list.Add("Medusa");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("=====================================");
            list.Insert(1, "Alvez");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine($"List Count: {list.Count}");
            Console.WriteLine();

            string s1 = list.Find(Test);
            Console.WriteLine($"First 'A': {s1}");

            Console.WriteLine("======================================");
            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s2}");

            Console.WriteLine("======================================");
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s3}");

            Console.WriteLine("======================================");
            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First Index 'A': {p1}");

            Console.WriteLine("======================================");
            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last Index 'A': {p2}");

            Console.WriteLine("======================================");
            List<string> list1 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list1)
            {
                Console.WriteLine("Filter List: " + obj);
            }


            Console.WriteLine("======================================");
            list.RemoveRange(2, 3);
            foreach (string obj in list)
            {
                Console.WriteLine("Remove Position 2 List: " + obj);
            }


            Console.WriteLine("======================================");
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine("Remove Position 2 List: " + obj);
            }

            Console.WriteLine("======================================");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine("Filter List: " + obj);
            }

            Console.WriteLine("======================================");
            int n = list.RemoveAll(x => x.StartsWith("M"));
            Console.WriteLine(n);
            foreach (string obj in list)
            {
                Console.WriteLine("Remove M List: " + obj);
            }
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }

        private static void InicializacaoList()
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string>()
            {
                "joao", "Maria","Marcos"
            };
        }

        private static void Foreach()
        {
            string[] vect = new string[] { "João", "Maria", "Alice" };

            foreach (string n in vect)
            {
                Console.WriteLine(n);
            }
        }

        private static void CalculatorRefOut()
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 8;
            int c;
            Calculator.Triple(8, out c);
            Console.WriteLine(c);
        }

        private static void CalculatorParams()
        {
            Console.WriteLine(Calculator.Sum(1, 2, 3, 6, 2, 4, 5));
        }

        private static void RentRoom()
        {
            Console.Write("How many rooms  will be rented?: ");
            int n = int.Parse(Console.ReadLine());
            Rent[] r = new Rent[10];

            string name;
            string email;
            int room;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                r[room] = new Rent
                {
                    Name = name,
                    Email = email,
                    Room = room
                };
            }

            Console.WriteLine("");
            Console.WriteLine("Busy rooms");

            for (int i = 0; i < 10; i++)
            {
                if (r[i] != null)
                    Console.WriteLine(r[i].ToString());
            }
        }

        private static void ClassVector()
        {
            Console.WriteLine("Quantos produtos?");
            int n = int.Parse(Console.ReadLine());

            Product[] p = new Product[n];

            string nome;
            double preco;

            for (int i = 0; i < n; i++)
            {
                nome = Console.ReadLine();
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p[i] = new Product(nome, preco);
            }

            double avg = 0;

            for (int i = 0; i < n; i++)
            {
                avg += p[i].Preco;
            }

            Console.WriteLine($"Average Price {avg / n:C}");
        }

        private static void VectoStruct()
        {
            Console.WriteLine("Quantas pessoas?");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            double avg = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                sum += vect[i];
            }

            avg = sum / vect.Length;
            Console.WriteLine($"AVARAGE HEIGHT {avg:F2}");
        }

        private static void CoalescenciaNula()
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //Operador de Coalescência Nula

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void StructPoint()
        {
            Point p;
            p.X = 20;
            p.Y = 10;
            Console.WriteLine(p);

            Point p1 = new Point();
            Console.WriteLine(p1);
        }
    }
}
