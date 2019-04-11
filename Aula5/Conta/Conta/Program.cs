using System;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta p1 = new Conta(8532, "Alex Green", 500.00);

            Console.WriteLine(p1);

            p1.Deposito(200.00);
            Console.WriteLine(p1);

            p1.Saque(300.00);
            Console.WriteLine(p1);

            Conta p2 = new Conta(7801, "Maria Brown");

            Console.WriteLine(p2);

            p2.Deposito(200.00);
            Console.WriteLine(p2);

            p2.Saque(198.00);
            Console.WriteLine(p2);

        }
    }
}
