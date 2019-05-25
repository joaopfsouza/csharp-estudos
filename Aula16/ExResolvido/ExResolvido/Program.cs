using ExResolvido.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string sourceFile = Console.ReadLine();

            List<Product> products = new List<Product>();

            try
            {


                using (StreamReader stream = File.OpenText(sourceFile))
                {
                    while (!stream.EndOfStream)
                    {
                        string[] lineProduct = stream.ReadLine().Split(",");
                        products.Add(new Product() { Name = lineProduct[0], Price = Double.Parse(lineProduct[1], CultureInfo.InvariantCulture) });
                    }
                }

                var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price: {0:C2}", average);

                var filter = products
                    .Where(p => p.Price < average)
                    .OrderByDescending(p => p.Name)
                    .Select(p => p.Name);

                filter.ToList().ForEach(p => Console.WriteLine(p));


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
