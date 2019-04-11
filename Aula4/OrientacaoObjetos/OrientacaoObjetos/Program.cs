using System;
using System.Globalization;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda.CotacaoDolar = 3.10;
            Console.WriteLine("{0:F2}", ConversorDeMoeda.ValorPagoReais(200.00));




        }

        private static void Aluno()
        {
            Aluno a = new Aluno()
            {
                Nome = "Alex Green",
                Nota = 0,
                Corte = 60
            };

            a.AdicionaNota(27.00);
            a.AdicionaNota(31.00);
            a.AdicionaNota(32.00);

            Console.WriteLine(a);


            Aluno b = new Aluno()
            {
                Nome = "Alex Green",
                Nota = 0,
                Corte = 60
            };

            b.AdicionaNota(17.00);
            b.AdicionaNota(20.00);
            b.AdicionaNota(15.00);

            Console.WriteLine(b);
        }

        private static void Funcionario()
        {
            Funcionario f = new Funcionario()
            {
                Nome = "joão Silva",
                SalarioBruto = 6000.00,
                Imposto = 1000.00
            };

            Console.WriteLine(f);
            f.AumentarSalario(10);
            Console.WriteLine(f);
        }

        private static void Retangulo()
        {
            Retangulo r = new Retangulo()
            {
                Altura = 3.00,
                Largura = 4.00
            };

            Console.WriteLine(r);
        }

        private static void Produto()
        {
            Produto p = new Produto()
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 10
            };

            Console.WriteLine(p);

            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            p.RemoverProdutos(3);
            Console.WriteLine(p);
        }

        private static void Triangulo()
        {
            Triangulo x, y;
            double a, b, c;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Triangulo X");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.A = a;
            x.B = b;
            x.C = c;

            Console.WriteLine("Triangulo Y");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.A = a;
            y.B = b;
            y.C = c;

            Console.WriteLine("Ax:{0:F4} {1:F4}", x.Area(), y.Area());

            if (x.Area() > y.Area())
                Console.WriteLine("x");
            else
                Console.WriteLine("y");
        }
    }


}
