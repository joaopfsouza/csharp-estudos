using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EX01
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary *= (1+percentage/100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:C}";
        }
    }
}
