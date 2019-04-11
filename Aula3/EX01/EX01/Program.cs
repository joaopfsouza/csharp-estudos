using System;
using System.Globalization;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }

        static void CalculaAreas()
        {
            string[] val = Console.ReadLine().Split(' ');
            double a = double.Parse(val[0],CultureInfo.InvariantCulture);
            double b = double.Parse(val[1],CultureInfo.InvariantCulture);
            double c = double.Parse(val[2],CultureInfo.InvariantCulture);

            Console.WriteLine($"Triangulo: {(a * c / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {(Math.PI * Math.Pow(c,2)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {((a+b)*c/2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {(Math.Pow(b,2)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {(a*b).ToString("F3", CultureInfo.InvariantCulture)}");
        }

        static void CalculaSalario()
        {
            Console.WriteLine("Código");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário hora");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{a} {(b*c).ToString("C")}");
        }

        static void DiferencaProduto()
        {
            Console.WriteLine("A");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("B");
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("C");
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("D");
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"Diferençã: {(a * b - c * d):F}");

        }
        static void CalculaRaio()
        {
            Console.WriteLine("Digite o raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"{area:F4}");
        }

        static void SomaDoisNumeros()
        {
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {n1 + n2}");
        }

    }
}
