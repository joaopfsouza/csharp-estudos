using System;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantidade de tentativas");
            int qtdTry = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int dataTry = 0;


            int inInterval = 0;
            int outInterval = 0;


            while (count < qtdTry)
            {

                System.Console.WriteLine("Número");
                dataTry = Convert.ToInt32(Console.ReadLine());

                if (dataTry >= 10 && dataTry <= 20)
                {
                    inInterval++;
                }
                else
                {
                    outInterval++;
                }

                count++;
            }
            System.Console.WriteLine("In: {0} \nOut: {1}", inInterval, outInterval);
        }

    }
}
