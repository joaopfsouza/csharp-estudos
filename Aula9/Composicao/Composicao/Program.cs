using Composicao.Entities;
using Composicao.Entities.Enum;
using System;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Alex", Enum.Parse<WorkerLevel>("MidLevel"),1200.00, new Departament("Design"));

            worker.AddContract(new HourContract(new DateTime(2018, 08, 20), 50.00, 20));
            worker.AddContract(new HourContract(new DateTime(2018, 06, 13), 30.00, 18));
            worker.AddContract(new HourContract(new DateTime(2018, 08, 25), 80.00, 10));


            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            DateTime dateConsult = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {dateConsult.ToString("MM/yyyy")}: {worker.Income(dateConsult.Year, dateConsult.Month):C}");

        }

        private static void Inputs()
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name:");
            string workerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine();


            Console.Write("Base salary:");
            double workerSalary = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            double workerNumberContracts = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Worker worker = new Worker(workerName, workerLevel, workerSalary, new Departament(deptName));


            for (int i = 1; i <= workerNumberContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data:", i);

                Console.Write("Date (DD/MM/YYYY):");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Value per hour:");
                double contractValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.Write("Duration (hours):");
                int contractHour = int.Parse(Console.ReadLine());
                Console.WriteLine();

                worker.AddContract(new HourContract(contractDate, contractValueHour, contractHour));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            DateTime dateConsult = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {dateConsult.ToString("MM/yyyy")}: {worker.Income(dateConsult.Year, dateConsult.Month)}");
        }
    }
}
