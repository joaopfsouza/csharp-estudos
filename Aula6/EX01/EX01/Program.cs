using System;
using System.Collections.Generic;
using System.Globalization;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registrered? ");
            int recordAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < recordAmount; i++)
            {
               
                Console.WriteLine($"Employee #{i + 1}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have increase: ");
            int findId = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee emp = employees.Find(x => x.Id.Equals(findId));

            if (emp != null)
            {
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employess:");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
