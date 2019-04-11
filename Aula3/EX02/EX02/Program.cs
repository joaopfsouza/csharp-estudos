using System;
using System.Globalization;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaImposto();
        }

        private static void CalculaImposto()
        {
            Console.WriteLine("Salário");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double normaliza = n - 2000.00;

            if (normaliza <= 0)
                Console.WriteLine("Insento");
            else if (normaliza <= 1000)
                Console.WriteLine(normaliza * 0.08);
            else if (normaliza <= 2500)
                Console.WriteLine(1000 * 0.08 + (normaliza - 1000) * 0.18);
            else if (normaliza > 2500)
                Console.WriteLine(1000 * 0.08 +  1500 * 0.18 + (normaliza - 2500) * 0.28);


        }

        private static void Quadrante()
        {
            Console.WriteLine("X&Y");
            string[] n = Console.ReadLine().Split(' ');
            double x = double.Parse(n[0]);
            double y = double.Parse(n[1]);

            if (x == 0.0 && y == 0.0)
                Console.WriteLine("Origem");
            else if (x > 0.0 && y > 0.0)
                Console.WriteLine("Q1");
            else if (x < 0.0 && y > 0.0)
                Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");
            else if (x > 0.0 && y < 0.0)
                Console.WriteLine("Q4");
            else if (x == 0.0)
                Console.WriteLine("Eixo X");
            else if (y == 0.0)
                Console.WriteLine("Eixo Y");


        }
        private static void EstaIntervalo()
        {
            Console.WriteLine("Número");
            double n = double.Parse(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("Fora");
            else if (n <= 25)
                Console.WriteLine("[0,25]");
            else if (n <= 50)
                Console.WriteLine("(25,50]");
            else if (n <= 75)
                Console.WriteLine("(50,75]");
            else if (n <= 100)
                Console.WriteLine("(75,100]");

        }


        private static void Duracao()
        {
            Console.WriteLine("Número");
            string[] n = Console.ReadLine().Split(' ');
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);

            if (a < b)
                Console.WriteLine($"Durou {b - a}");
            else if (a >= b)
                Console.WriteLine($"Durou {24 - a + b}");

        }


        private static void Multiplos()
        {

            Console.WriteLine("Número");
            string[] n = Console.ReadLine().Split(' ');
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Multiplo");
            else
                Console.WriteLine("Não Multiplo");


        }


        private static void PositivoOuNegativo()
        {
            Console.WriteLine("Número");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Positivo");
        }
    }
}
