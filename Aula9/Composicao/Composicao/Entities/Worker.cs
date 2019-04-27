using Composicao.Entities.Enum;
using System.Collections.Generic;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) : this(name, level, baseSalary)
        {
            Department = departament;
        }

        public void AddContract(HourContract contract)
        {

            Contracts.Add(contract);

        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            List<HourContract> filterContracts = Contracts.FindAll(x => x.Date.Month.Equals(month) && x.Date.Year.Equals(year));
            double incomeValue = BaseSalary;

            if (filterContracts.Count != 0)
            {
                foreach (var contract in filterContracts)
                {
                    incomeValue += contract.TotalValue();
                }
            }

            return incomeValue;
        }

        public override string ToString()
        {
            return $"Name {Name}\nDepartment {Department.Name}";
        }


    }
}
