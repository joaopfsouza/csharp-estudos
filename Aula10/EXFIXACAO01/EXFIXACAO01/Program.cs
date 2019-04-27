using EXFIXACAO01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXFIXACAO01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine("Product #{0} data:", i);
                Console.Write("Common, used or imported (c/u/i)? ");

                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double feeProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(nameProduct, priceProduct, feeProduct));

                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDateProduct = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InstalledUICulture);

                    products.Add(new UsedProduct(nameProduct, priceProduct, manufactureDateProduct));

                }
                else
                {
                    products.Add(new Product(nameProduct, priceProduct));

                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach (var item in products)
            {
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}
