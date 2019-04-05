using System;
using System.Globalization;
using System.Threading;

namespace Aula0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);

        
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            System.Console.WriteLine("Insira informações do primeiro produto:");
            string[] productOne = Console.ReadLine().Split(' ');

            System.Console.WriteLine("Segundo Produto:");
            string[] productTwo = Console.ReadLine().Split(' ');

            double costProductOne = Double.Parse(productOne[2]);
            double costProductTwo = Double.Parse(productTwo[2]);

    
            double result = Convert.ToInt32(productOne[1]) * costProductOne
                                + Convert.ToInt32(productTwo[1]) * costProductTwo;

            System.Console.WriteLine($"Valor total: $ {result}");



        }


        static decimal Amount(int numberUnit, decimal costProduct)
        {

            return numberUnit * costProduct;
        }
    }
}
