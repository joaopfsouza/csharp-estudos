using EXRESOLVIDO01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXRESOLVIDO01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced: (y/n): ");
                char isOutsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Hours: ");
                int hoursEmployee = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHourEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (isOutsourced.ToString().ToUpper() == "Y")
                {

                    Console.Write("Additional Charge: ");
                    double additionalChargeOutsourcedEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(nameEmployee, hoursEmployee, valuePerHourEmployee, additionalChargeOutsourcedEmployee));

                }
                else
                {
                    employees.Add(new Employee(nameEmployee, hoursEmployee, valuePerHourEmployee));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.ToString()}");
            }

        }

    }
}
