using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas m = new Pessoas()
            {
                Nome = "Maria",
                Idade = 17
            };

            Pessoas j = new Pessoas()
            {
                Nome = "Joao",
                Idade = 16
            };

            if(m.Idade > j.Idade)
            {
                Console.WriteLine($"{m.Nome}");
              
            }
            else
            {
                Console.WriteLine($"{j.Nome}");
            }


            Funcionario c = new Funcionario()
            {
                Nome = "Carlos Silva",
                Salario = 6300.00
            };

            Funcionario a = new Funcionario()
            {
                Nome = "Ana MArques",
                Salario = 6700.00
            };


            if (c.Salario > a.Salario)
            {
                Console.WriteLine($"{c.Nome}");

            }
            else
            {
                Console.WriteLine($"{a.Nome}");
            }

            Console.WriteLine($"{(c.Salario+a.Salario)/2:C}");
        }
    }
}
