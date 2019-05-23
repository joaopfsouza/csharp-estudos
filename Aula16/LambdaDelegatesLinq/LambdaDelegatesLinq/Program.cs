using LambdaDelegatesLinq.Entities;
using LambdaDelegatesLinq.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }

        private static void FUNC()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD CASE", 80.90));

            //Func<Product, string> nameUpper = NameUpper;
            //List<string> result = list.Select(nameUpper).ToList();
            // Func<Product, string> func = p => p.Name.ToUpper();
            //Func<Product, string> func = p => { return p.Name.ToUpper(); };

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();



            result.ForEach(p => Console.WriteLine(p));
        }

        public static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }

        private static void Action()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD CASE", 80.90));

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price *= 1.10; };

            //list.ForEach(act);
            list.ForEach(p => { p.Price *= 1.10; });
            //list.ForEach(UpdatePrice);
            list.ForEach(p => Console.WriteLine(p));
        }

        private static List<Product> Predicate()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD CASE", 80.90));

            list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);
            list.ForEach(p => Console.WriteLine(p));
            return list;
        }

        public static void UpdatePrice(Product product)
        {
            product.Price *= 1.10;
        }

        public static bool ProductTest(Product product)
        {
            return product.Price >= 100;
        }

        private static void DelegateOperations()
        {
            double a = 10;
            double b = 12;

            CalculationService.BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a, b);
            Console.WriteLine(result);


            CalculationService.ShowSumDelegate ss = CalculationService.ShowSum;
            ss += CalculationService.ShowMax;
            ss.Invoke(a, b);
        }

        private static void CompareSort()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp1 = CompareProducts;
            Comparison<Product> comp2 = (p1, p2) => (p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            list.Sort((p1, p2) => (p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
