using System;
using System.Collections.Generic;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sandwich> menuSandwich = new List<Sandwich>(){
                new Sandwich(1,"Cachorro Quente",4.00),
                new Sandwich(2,"X-Salada", 4.50),
                new Sandwich(3,"X-Bacon",5.00),
                new Sandwich(4,"Torrada Simples",2.00),
                new Sandwich(5,"Rifregerante",1.50)
            };

            System.Console.WriteLine("Digite consumo");
            string[] inputConsumer = Console.ReadLine().Split(" ");

            int option = Convert.ToInt32(inputConsumer[0]);
            int qtd = Convert.ToInt32(inputConsumer[1]);

            double result = menuSandwich[option-1].Value * qtd;

            System.Console.WriteLine("Custo $ {0}", result);


        }
    }
}