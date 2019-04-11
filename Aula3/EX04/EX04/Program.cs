using System;
using System.Globalization;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Potencias();
        }

        private static void Potencias()
        {
            Console.WriteLine("N numero");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }

            private static void Divisores()
        {
            Console.WriteLine("N numero");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        private static void Fatorial()
        {
            Console.WriteLine("N numero");
            int n = int.Parse(Console.ReadLine());

            double product = 1;

            for (int i = n; i > 0; i--)
            {
                product *= i; 
            }

            Console.WriteLine($"Resultado:{product} ");


        }

        private static void Divisivel()
        {
            string[] v;
            double a, b;
            Console.WriteLine("N numero");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                v = Console.ReadLine().Split(' ');
                a = double.Parse(v[0], CultureInfo.InvariantCulture);
                b = double.Parse(v[1], CultureInfo.InvariantCulture);

                if (b == 0.0)
                {
                    Console.WriteLine("Não é possível dividir");
                }
                else
                {
                    Console.WriteLine($"{a / b:F1}");
                }

            }



        }

        private static void MediaPonderada()
        {
            int x = int.Parse(Console.ReadLine());
            string[] v;
            double a, b, c;
            double media = 0;

            for (int i = 1; i <= x; i++)
            {
                v = Console.ReadLine().Split(' ');
                a = double.Parse(v[0], CultureInfo.InvariantCulture);
                b = double.Parse(v[1], CultureInfo.InvariantCulture);
                c = double.Parse(v[2], CultureInfo.InvariantCulture);

                media = (a * 2 + b * 3 + c * 5) / (10);

                Console.WriteLine($"{media:F1}");

            }
        }

        private static void Impares()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);

            }
        }
    }
}
