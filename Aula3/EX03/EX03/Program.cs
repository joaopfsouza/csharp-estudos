using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesquisa();
        }

        private static void Pesquisa()
        {
            Console.WriteLine("Opção");
            int option = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(option != 4)
            {
                if (option == 1)
                    alcool++;
                else if (option == 2)
                    gasolina++;
                else if (option == 3)
                    diesel++;
                else
                    Console.WriteLine("");

                Console.WriteLine("Opção");
                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }

        private static void Quadrante()
        {
            Console.WriteLine("Coordenadas:");
            string[] v = Console.ReadLine().Split(" ");
            double x = double.Parse(v[0]);
            double y = double.Parse(v[1]);

            while (x != 0 && y != 0)
            {
                if(x>0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if(x<0 && y>0)
                    Console.WriteLine("Segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto");

                Console.WriteLine("Coordenadas:");
                v = Console.ReadLine().Split(" ");
                x = double.Parse(v[0]);
                y = double.Parse(v[1]);
            }

            Console.WriteLine("Nula");
        }
    }
}
