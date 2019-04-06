using System;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;
using Aula0.Model;

namespace Aula0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);

                Product productOne = new Product();
                Product productTwo = new Product();


                string pattern = @"\S+";
                Utils util = new Utils(pattern);


                System.Console.WriteLine("Produto Um:");
                string infoProductOne = Console.ReadLine();
                var listProd = util.StringToListDouble(infoProductOne);

                productOne.Id = (int)listProd[0];
                productOne.Unit = (int)listProd[1];
                productOne.Price = listProd[2];


                System.Console.WriteLine("Produto Dois:");
                listProd.Clear();
                string infoProductTwo = Console.ReadLine();
                listProd = util.StringToListDouble(infoProductTwo);

                productTwo.Id = (int)listProd[0];
                productTwo.Unit = (int)listProd[1];
                productTwo.Price = listProd[2];

                System.Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", productOne.Amount() + productTwo.Amount());


            }
            catch (System.Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }



        private static void AmountProcedural()
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
