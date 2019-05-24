using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id=1, Name="Computer", Price=1100.0,Category=c2},
                new Product(){Id=2, Name="Hammer", Price=90.0,Category=c1},
                new Product(){Id=3, Name="TV", Price=1700.0,Category=c3},
                new Product(){Id=4, Name="Notebook", Price=1300.0,Category=c2},
                new Product(){Id=5, Name="Saw", Price=80.0,Category=c1},
                new Product(){Id=6, Name="Tablet", Price=700.0,Category=c2},
                new Product(){Id=7, Name="Camera", Price=700.0,Category=c3},
                new Product(){Id=8, Name="Printer", Price=350.0,Category=c3},
                new Product(){Id=9, Name="MacBook", Price=1800.0,Category=c2},
                new Product(){Id=10, Name="Sound Bar", Price=700.0,Category=c3},
                new Product(){Id=11, Name="Level", Price=70.0,Category=c1}
            };

            var r1 = products.Where(p => p.Price < 900 && p.Category.Tier == 1);
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);


            var r3 = products
                .Where(p => p.Name[0] == 'C')
                .Select(p => new { PructName = p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOS OBJECT", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);


            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("FIRST Test 1: {0}", r6);

            var r7 = products.FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT 1: {0}", r7);

            var r8 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT 2: {0}", r8);


            var r9 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single Or Default 1: {0}", r9);


            var r10 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single Or Default 2: {0}", r10);

            var r11 = products.Max(p => p.Price);
            Console.WriteLine("Max price {0}", r11);

            var r12 = products.Min(p => p.Price);
            Console.WriteLine("Min price {0}", r12);

            var r13 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: {0}", r13);

            var r14 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Avarage prices: {0}", r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Avarage prices: {0}", r15);

            var r16 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate sum: {0}", r16);

            var r17 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate sum: {0}", r17);


            var r18 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category,Product> group in r18)
            {
                Console.WriteLine("Category "  + group.Key.Name + ":");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }

        private static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }

        private static void ExampleLambda()
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            result.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
