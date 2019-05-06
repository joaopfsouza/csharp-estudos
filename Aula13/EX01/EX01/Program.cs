using EX01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13";
                string pathOut = Path.Combine(path, "EX01", "Files", "out");
                string fileToOpen = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\EX01\Files\summary.csv";
                string fileToSave = Path.Combine(pathOut,"summary.csv");

                Console.WriteLine(pathOut);

                if (!Directory.Exists(pathOut))
                {
                    Directory.CreateDirectory(pathOut);
                }

                if (File.Exists(fileToSave))
                {
                    File.Delete(fileToSave);
                }

                IEnumerable<string> fileCSV = Directory.EnumerateFiles(path, "*.csv", SearchOption.AllDirectories);

                //foreach (string fileToOpen in fileCSV)
                //{
                //    Console.WriteLine(fileToOpen);

                using (StreamReader sr = File.OpenText(fileToOpen))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] productInfo = sr.ReadLine().Split(',');

                        string name = productInfo[0];
                        double value = double.Parse(productInfo[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(productInfo[2]);


                        Console.WriteLine(new Product(name, value, qtd));
                        WriteInFile(pathOut, "summary", new Product(name, value, qtd));

                    }

                }
                //}


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }

        static public void WriteInFile(string path, string name, Product product)
        {
            string pathOut = Path.Combine(path, name + ".csv");

            using (StreamWriter sw = File.AppendText(pathOut))
            {
                sw.WriteLine(product.ExportCSVTotal());
            }
        }

    }
}
