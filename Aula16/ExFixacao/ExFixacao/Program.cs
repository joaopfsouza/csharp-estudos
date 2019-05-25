using ExFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourceFile = @"C:\temp\employees.txt";
                double salaryCut = 2000.00;
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(sourceFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] aux = sr.ReadLine().Split(",");
                        employees.Add(new Employee()
                        {
                            Name = aux[0],
                            Email = aux[1],
                            Salary = Double.Parse(aux[2], CultureInfo.InvariantCulture)
                        });
                    }
                }

                Console.WriteLine("Email salary is more than {0}", 2000.00);
                var filterSalary = employees.Where(e => e.Salary > salaryCut).Select(e => e.Email).OrderBy(e => e);
                filterSalary.ToList().ForEach(f => Console.WriteLine(f));

                var sumM = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Aggregate(0.0, (x, y) => y + x);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': {0:C2}", sumM);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
