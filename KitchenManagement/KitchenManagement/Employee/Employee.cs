using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    abstract class Employee
    {
        public string Name { get; private set; }
        public int SalaryInUSD { get; private set; }
        public DateTime BirthDate { get; private set; }

        public float TaxRate { get; } = 0.99F;

        public void CalculateTax()
        {
            Console.WriteLine($"My name is {Name}, my salary is {SalaryInUSD}, and my TAX is ${SalaryInUSD * TaxRate}");
        }

        public Employee(string name, int salary, DateTime birthDate)
        {
            Name = name;
            SalaryInUSD = salary;
            BirthDate = birthDate;
        }
    }
}
