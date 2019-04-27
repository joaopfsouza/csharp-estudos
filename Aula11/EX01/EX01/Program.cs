using EX01.Entities;
using EX01.Entities.Exception;
using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account bb = new Account(8021, "Bob Brown", 500.00, 300.00);

                //bb.Withdraw(100.00);
                //Console.WriteLine(bb);

                //bb.Withdraw(400.0);
                //Console.WriteLine(bb);

                // Console.WriteLine(bb);
                //bb.Withdraw(800.00);

                bb.Withdraw(300.00);
                bb.Withdraw(250);

            }
            catch (WithdrawException e)
            {

                Console.WriteLine("Withdraw error: {0}", e.Message);
            }
        }
    }
}
