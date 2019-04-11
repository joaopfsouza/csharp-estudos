using System;
using System.Globalization;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void HoraAtual()
        {
            Console.WriteLine("Hora Atual:");
            int value = int.Parse(Console.ReadLine());

            if (value < 12)
                Console.WriteLine("Bom Dia!!!");
            else if (value < 18)
                Console.WriteLine("Boa Tarde!!!!");
            else if (value <= 24)
                Console.WriteLine("Boa Noite!!!!");
            else
                Console.WriteLine("Fora dos limites");



        }
        private static void ParImpar()
        {
            Console.WriteLine("Digita um Inteiro:");
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }

        private static void ExercioFixacaoEntrada()
        {
            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome, idade, Altura");
            string[] bios = Console.ReadLine().Split(' ');
            string nome2 = bios[0];
            int idade = int.Parse(bios[1]);
            float altura = float.Parse(bios[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {quartos} {preco.ToString("C")}");
            Console.WriteLine($"{nome2} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void EntradaInputDiferenteDeString()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] info = Console.ReadLine().Split(' ');
            string nome = info[0];
            char sexo = char.Parse(info[1]);
            int idade = int.Parse(info[2]);
            float altura = float.Parse(info[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");


            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void EntradaDeString()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] s = Console.ReadLine().Split(' ');
            string a = s[0], b = s[1], c = s[2];

            Console.WriteLine(frase);
            Console.WriteLine($"{x} {y} {z}");
            Console.WriteLine($"{a} {b} {c}");
        }

        private static void Baskara()
        {
            double a = 1.0, b = -3, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"x1: {x1} x2: {x2}");
        }

        private static void ExercicioDeAula()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produto:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:C}");
            Console.WriteLine("Mesa de escritório, cujo preço é {0:C}", preco2);

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"\nMedida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Medida com 3 casas decimais: {medida:F3}");
            Console.WriteLine("Invariant Culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        private static void VariableTypeAndShowVariables()
        {
            SByte x = 127;
            Console.WriteLine(++x);

            byte n1 = 255;
            Console.WriteLine(++n1);

            int n2 = int.MaxValue;
            Console.WriteLine(n2);

            long n3 = 2147483648L;
            Console.WriteLine(n3);

            bool complete = false;
            Console.WriteLine(complete);

            char genero = 'F';
            Console.WriteLine(genero);

            char word = '\u0041';
            Console.WriteLine(word);

            float n4 = 4.5f;
            Console.WriteLine(n4);

            double n5 = 4.5;
            Console.WriteLine(n5);

            string nome = "Maria Green";
            Console.WriteLine(nome);

            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());

            decimal n6 = decimal.MaxValue;
            Console.WriteLine(n6);

            Console.WriteLine("==========================================");
            char gender = 'F';
            int age = 32;
            double balancy = 10.35784;
            string name = "Maria";

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", gender, age, balancy.ToString("F2"), name);
            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}", gender, age, balancy, name);
            Console.WriteLine(balancy.ToString("F4"));
            Console.WriteLine(balancy.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("==========================================");
            Console.WriteLine($"{name} tem {age} anos e tem saldo de R$ {balancy.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{name} tem {age} anos e tem saldo de R$ {balancy:F2}");
        }
    }
}