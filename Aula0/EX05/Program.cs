using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2202;
            System.Console.WriteLine("Digite Senha:");
            int teste = Convert.ToInt32(Console.ReadLine());

            while (senha != (teste))
            {
                System.Console.WriteLine("Senha Errada");
                System.Console.WriteLine("Digite Senha:");
                teste = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Senha Correta");

        }
    }
}
